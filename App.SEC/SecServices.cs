using App.SEC.Dtos;
using App.SEC.enums;
using App.SEC.helper;
using App.SEC.Models;
using App.SEC.Models.Requests;
using App.SEC.Models.Responses;
using App.SEC.Responses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using narit_mis_api.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC
{
    public class SecServices : ISecServices
    {
        private readonly NARIT_MIS_LINKContext _database;

        public SecServices(NARIT_MIS_LINKContext context)
        {
            _database = context;
        }

        public SecBaseResponse AddPlanCrudpolicy(PlanCrudpolicy policy)
        {
            _database.Entry(policy).State = policy.Id == 0 ? EntityState.Added :EntityState.Modified;
            var result = _database.SaveChanges();
            var response = new SecBaseResponse();
            response.Success = result > 0 ? true: false;
            response.Messsage = result > 0 ? "success" : "error";
            return response;
        }

        public SecBaseResponse AddUpdatePlanCrudpolicy(PlanCrudpolicy policy)
        {
            throw new NotImplementedException();
        }

        public List<DepartmentDto> DepartmentGetByFiscalYear(int FiscalYear)
        {
            var response = new List<DepartmentDto>();
            var department = new List<DepartmentDto>();
            var department_Parent = new List<DepartmentDto>();
            var result = _database.Departments.Where(x => x.FiscalYear == FiscalYear && x.Active).OrderBy(x => x.Name).ToList();
            foreach(var item in result)
            {
                // department.Id = item.ParentDepartment;
                
                foreach (var sub_department in item.InverseParentDepartment)
                {
                    
                    
                            foreach (var sub1_department in sub_department.InverseParentDepartment)
                            {
                                department_Parent.Add(new DepartmentDto
                                {
                                    Id = sub1_department.Id,
                                    Name = sub1_department.Name,
                                    FiscalYear = sub1_department.FiscalYear,
                                    Active = sub1_department.Active,
                                    ReferenceOldId = sub1_department.ReferenceOldId,
                                    ParentDepartmentId = sub1_department.ParentDepartmentId,
                                });
                            }


                        department.Add(new DepartmentDto
                        {
                                Id = sub_department.Id,
                                Name = sub_department.Name,
                                FiscalYear = sub_department.FiscalYear,
                                Active = sub_department.Active,
                                ReferenceOldId = sub_department.ReferenceOldId,
                                ParentDepartmentId = sub_department.ParentDepartmentId,
                                Department = department_Parent,
                                }
                        );
                    
                }
                response.Add(new DepartmentDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Active = item.Active,
                    ReferenceOldId = item.ReferenceOldId,
                    ParentDepartmentId = item.ParentDepartmentId,
                    Department = department
                });
       
            }
             return response;
        }

        public List<DepartmentRespone> DepartmentListGetByFiscalYear(int FiscalYear)
        {
            var data = _database.Departments.Where(x => x.FiscalYear == FiscalYear && x.Active);
            var result = new List<DepartmentRespone>();
            foreach (var item in data)
            {
                result.Add(new DepartmentRespone
                {
                    Id=item.Id,
                    Name=item.Name,
                    FiscalYear=item.FiscalYear,
                    Active=item.Active,
                    ParentDepartmentId =item.ParentDepartmentId,
                });

                
            }
            return result;
        }

        public SecBaseResponse DepartmentSetup(DepartmentRequest request)
        {
            var _Department = new Department();
            _Department.Id = request.Id;
            _Department.Name = request.Name;
            _Department.FiscalYear = request.FiscalYear;
            _Department.Active = request.Active;
           
            if(request.ParentDepartmentId != 0)
            {
                _Department.ParentDepartmentId = request.ParentDepartmentId;
            }
            _database.Entry(_Department).State = _Department.Id == 0 ?
                                      EntityState.Added :
                                      EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new SecBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = _Department.Id == 0 ? "update" : "insert";
            return response;
     
        }

        public SecBaseResponse FundTypeSetup(FundTypeRequest request)
        {
            var _FundType = new FundType();
            _FundType.Id = request.Id;
            _FundType.Name = request.Name;
            _FundType.FiscalYear = request.FiscalYear;
            _FundType.Active = request.Active;

            if (request.ParentFundTypeId != 0)
            {
                _FundType.ParentFundTypeId = request.ParentFundTypeId;
            }
            _database.Entry(_FundType).State = _FundType.Id == 0 ?
                                      EntityState.Added :
                                      EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new SecBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = _FundType.Id == 0 ? "update" : "insert";
            return response;
        }

        public List<FundTypeRespone> FundTypeSetupByFiscalYear(int FiscalYear)
        { 
            var _result = new List<FundTypeRespone>();
            var data = _database.FundTypes.Where(x => x.FiscalYear == FiscalYear).ToList();
            foreach (var item in data)
            {
                _result.Add(new FundTypeRespone
                {
                    Id = item.Id,
                    Name = item.Name,
                    Active = item.Active,
                    ParentFundTypeId = item.ParentFundTypeId,
                    ReferenceOldId = item.ReferenceOldId,
                });
            }
            return _result;
        }

        public List<BudgetType> GetByFiscalYear(int FiscalYear)
        {
            return _database.BudgetTypes.Where(x => x.FiscalYear == FiscalYear ).ToList();

        }

        public List<ViewPlanForActivityByDepartmentTable> GetById(int departmentId, int FiscalYear)
        {
            decimal _TotalBudgetCache = 0;
            decimal _TotalAmount = 0;
            decimal _NetAmount = 0;
            decimal _NetBudgetCache = 0;
            decimal _UsedBudgetCache = 0;
            decimal _RemainBudgetPlanView = 0;
            decimal _TotalBudget = 0;
            //decimal _NetBudget = 0;
            //decimal _InwardBudgetTransfers = 0;
            //decimal _InProcessBudget = 0;
           
            var loop1 = new List<PlanItem>();
            var _datalist = new List<ViewPlanForActivityByDepartmentTable>();
            var data  = new List<Department>();
            if (departmentId != 0)
            {
                 data = _database.Departments.Where(x => x.Id == departmentId && x.Active && x.FiscalYear==FiscalYear).Include(x => x.PlanActivities).Include(x => x.PlanCores).Include(x => x.InverseParentDepartment).ToList();  
            }
            else
            {
                 data = _database.Departments.Where(x =>  x.Active && x.FiscalYear == FiscalYear).Include(x => x.PlanActivities).Include(x => x.PlanCores).ToList();
            }

            var _datalist_main = new List<ViewPlanForActivityByDepartmentTable>();

        

            foreach (var item in data)
            {
                if (item.InverseParentDepartment.Count > 0)
                {
                    foreach (var item_l1 in item.InverseParentDepartment)
                    {
                        var _datalist_sub = new List<ViewPlanForActivityByDepartmentTable>();
                        var planCore = _database.PlanCores.Where(x => x.DepartmentId == item_l1.Id).Include(x => x.PlanActivities).ToList();
                        foreach (var item_l2 in planCore)
                        {
                            var _datalist_sub2 = new List<ViewPlanForActivityByDepartmentTable>();

                             _TotalBudgetCache = 0;
                             _TotalAmount = 0;
                             _NetAmount = 0;
                             _NetBudgetCache = 0;
                             _UsedBudgetCache = 0;
                             _RemainBudgetPlanView = 0;
                             _TotalBudget = 0;

                            foreach (var l3 in item_l2.PlanActivities)
                            {
                                var _PlanItems = _database.PlanItems.Where(x => x.PlanActivityId == l3.Id).Include(x => x.MonthlyForecasts).Include(x => x.SummaryStatementCaches).ToList();
                                foreach (var _MonthlyForecasts in _PlanItems)
                                {
                                    _TotalBudget += _MonthlyForecasts.MonthlyForecasts.Sum(x => x.Amount * x.BudgetPerPiece);
                                    _TotalAmount += _MonthlyForecasts.MonthlyForecasts.Sum(x => x.Amount);
                                    _NetAmount += _MonthlyForecasts.MonthlyForecasts.Sum(x => x.Amount);
                                    _NetBudgetCache = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().NetBudgetPlanView;
                                    _UsedBudgetCache = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().UsedBudgetPlanView;
                                    _RemainBudgetPlanView = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().RemainBudgetPlanView;
                                    _TotalBudgetCache = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().TotalBudgetPlanView;

                                }
                                _datalist_sub2.Add(new ViewPlanForActivityByDepartmentTable
                                {
                                    Id = l3.Id,
                                    Name = l3.Name,
                                    FiscalYear = l3.FiscalYear,
                                    TotalBudget = _TotalBudget,
                                    TotalBudgetCache = _TotalBudgetCache,
                                    NetBudgetCache = _NetBudgetCache,
                                    UsedBudgetCache = _UsedBudgetCache,
                                    RemainBudgetCache = _RemainBudgetPlanView,

                                });
                            }
                            _datalist_sub.Add(new ViewPlanForActivityByDepartmentTable
                            {
                                Id = item_l2.Id,
                                Name = item_l2.Name,
                                FiscalYear = item_l2.FiscalYear,
                                TotalBudget = _datalist_sub2.Sum(x => x.TotalBudget),
                                TotalBudgetCache = _datalist_sub2.Sum(x => x.TotalBudgetCache),
                                NetBudgetCache = _datalist_sub2.Sum(x => x.NetBudgetCache),
                                UsedBudgetCache = _datalist_sub2.Sum(x => x.UsedBudgetCache),
                                RemainBudgetCache = _datalist_sub2.Sum(x => x.RemainBudgetCache),
                                subdata = _datalist_sub2
                            });
                        }
                        _datalist.Add(new ViewPlanForActivityByDepartmentTable
                        {
                            Id = item_l1.Id,
                            Name = item_l1.Name,
                            FiscalYear = item_l1.FiscalYear,
                            TotalBudget = _datalist_sub.Sum(x => x.TotalBudget),
                            TotalBudgetCache = _datalist_sub.Sum(x => x.TotalBudgetCache),
                            NetBudgetCache = _datalist_sub.Sum(x => x.NetBudgetCache),
                            UsedBudgetCache = _datalist_sub.Sum(x => x.UsedBudgetCache),
                            RemainBudgetCache = _datalist_sub.Sum(x => x.RemainBudgetCache),
                            subdata = _datalist_sub
                        });
                    }
                    


                }
                else
                {
                    var _datalist_sub = new List<ViewPlanForActivityByDepartmentTable>();
                    foreach (var item_l1 in item.PlanCores)
                    {
                        var _datalist_sub2 = new List<ViewPlanForActivityByDepartmentTable>();
                        foreach (var l1 in item_l1.PlanActivities)
                        {
                            _TotalBudgetCache = 0;
                            _TotalAmount = 0;
                            _NetAmount = 0;
                            _NetBudgetCache = 0;
                            _UsedBudgetCache = 0;
                            _RemainBudgetPlanView = 0;
                            _TotalBudget = 0;
                            var _PlanItems = _database.PlanItems.Where(x => x.PlanActivityId == l1.Id).Include(x => x.MonthlyForecasts).Include(x => x.SummaryStatementCaches).ToList();
                            foreach (var _MonthlyForecasts in _PlanItems)
                            {
                                _TotalBudget += _MonthlyForecasts.MonthlyForecasts.Sum(x => x.Amount * x.BudgetPerPiece);
                                _TotalAmount += _MonthlyForecasts.MonthlyForecasts.Sum(x => x.Amount);
                                _NetAmount += _MonthlyForecasts.MonthlyForecasts.Sum(x => x.Amount);
                                _NetBudgetCache = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().NetBudgetPlanView;
                                _UsedBudgetCache = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().UsedBudgetPlanView;
                                _RemainBudgetPlanView = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().RemainBudgetPlanView;
                                _TotalBudgetCache = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().TotalBudgetPlanView;

                            }
                            _datalist_sub2.Add(new ViewPlanForActivityByDepartmentTable
                            {
                                Id = l1.Id,
                                Name = l1.Name,
                                FiscalYear = l1.FiscalYear,
                                TotalBudget = _TotalBudget,
                                TotalBudgetCache = _TotalBudgetCache,
                                NetBudgetCache = _NetBudgetCache,
                                UsedBudgetCache = _UsedBudgetCache,
                                RemainBudgetCache = _RemainBudgetPlanView,

                            });
                        }
                        _datalist.Add(new ViewPlanForActivityByDepartmentTable
                        {
                            Id = item_l1.Id,
                            Name = item_l1.Name,
                            FiscalYear = item_l1.FiscalYear,
                            TotalBudget = _datalist_sub2.Sum(x => x.TotalBudget),
                            TotalBudgetCache = _datalist_sub2.Sum(x => x.TotalBudgetCache),
                            NetBudgetCache = _datalist_sub2.Sum(x => x.NetBudgetCache),
                            UsedBudgetCache = _datalist_sub2.Sum(x => x.UsedBudgetCache),
                            RemainBudgetCache = _datalist_sub2.Sum(x => x.RemainBudgetCache),
                            subdata = _datalist_sub2
                        });
                    }
                }

                _datalist_main.Add(new ViewPlanForActivityByDepartmentTable
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    TotalBudget = _datalist.Sum(x => x.TotalBudget),
                    TotalBudgetCache = _datalist.Sum(x => x.TotalBudgetCache),
                    NetBudgetCache = _datalist.Sum(x => x.NetBudgetCache),
                    UsedBudgetCache = _datalist.Sum(x => x.UsedBudgetCache),
                    RemainBudgetCache = _datalist.Sum(x => x.RemainBudgetCache),
                    subdata = _datalist
                });











            }
            return _datalist_main;
        }

        public PlanCrudpolicy GetPolicy(int year)
        {
            return _database.PlanCrudpolicies.Where(x => x.FiscalYear == year && x.Active).OrderBy(x => x.Name).FirstOrDefault();
          
        }

        public List<GovExpenseList> GovExpenseType(string path)
        {
           
                var json = new enumconvent<GovExpenseList>(path);

                return json.JsonNetResult()!;
            
        }

        public List<PlanTypeDto> PlanTypeGetByFiscalYear(int FiscalYear)
        {
            var _PlanTypes =  _database.PlanTypes.Where(x => x.FiscalYear == FiscalYear).Include(x => x.InverseParentPlanType).Include(x => x.PlanCores).ToList();
            var _PlanTypeDto_list = new List<PlanTypeDto>();
            
            string n = "";
            foreach (var item in _PlanTypes)
            {
                if (item.ParentPlanType != null)
                {
                    
                    n = item.ParentPlanType.Name;
                }
                
                
                _PlanTypeDto_list.Add(new PlanTypeDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Active = item.Active,
                    ParentPlanTypeId = item.ParentPlanTypeId,
                    ReferenceOldId = item.ReferenceOldId,
                    Weight = item.Weight,
                    ParentPlanType = n
                  

                }); 
            }
            return _PlanTypeDto_list;
        }

        public SecBaseResponse PlanTypeSetup(PlanTypeRequest request)
        {
            var _PlanType = new PlanType();
            _PlanType.Id = request.Id;
            _PlanType.Name = request.Name;
            _PlanType.FiscalYear = request.FiscalYear;
            _PlanType.Active = request.Active;
            if(request.ParentPlanTypeId != 0)
            {
                _PlanType.ParentPlanTypeId = request.ParentPlanTypeId;
            }
            _database.Entry(_PlanType).State = _PlanType.Id == 0 ?
                                      EntityState.Added :
                                      EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new SecBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = _PlanType.Id == 0 ? "update" : "insert";
            return response;
        }

        public SecBaseResponse StrategySetup(StrategySetupModel request)
        {

            var _Strategy = new Strategy();
            _Strategy.Id = (int)request.Id;
            _Strategy.Name = request.mame;
            _Strategy.Active = request.Active;
            _Strategy.FiscalYear = (int)request.FiscalYear;
            if (request.ParentStrategyId != 0)
            {
                _Strategy.ParentStrategyId = request.ParentStrategyId;
            }
            


            _database.Entry(_Strategy).State = _Strategy.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new SecBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = _Strategy.Id == 0 ? "update" : "insert";
            return response;
        }

        public List<StrategySetupModel> StrategySetupByFiscalYear(int FiscalYear)
        {

            var result = new List<StrategySetupModel>();
            var data =   _database.Strategies.Where(x => x.FiscalYear == FiscalYear).ToList();
            foreach (var item in data)
            {
                result.Add(new StrategySetupModel
                {
                    Id = item.Id,
                    mame = item.Name,
                    FiscalYear = item.FiscalYear,
                    Active = item.Active,
                    ParentStrategyId = item.ParentStrategyId,
                });
            }
            return result;
        }

        public SecBaseResponse BudgetTypeSetup(BudgetTypeRequest request)
        {
            var _BudgetType = new BudgetType();
            _BudgetType.Id = request.Id;
            _BudgetType.Name = request.Name;
            _BudgetType.Active = request.Active;
            _BudgetType.FiscalYear = (int)request.FiscalYear;
            _BudgetType.GovExpenseTypeEnum = request.GovExpenseTypeEnum;
            _BudgetType.ExpenseTypeEnum = request.ExpenseTypeEnum;
            if (request.ParentBudgetTypeId != 0)
            {
                _BudgetType.ParentBudgetTypeId = request.ParentBudgetTypeId;
            }



            _database.Entry(_BudgetType).State = _BudgetType.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new SecBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = _BudgetType.Id == 0 ? "update" : "insert";
            return response;
           
        }

        public SecBaseResponse StrategicIndicatorSetup(StrategicIndicatorRequest request)
        {
            var _StrategicIndicator = new StrategicIndicator();
            _StrategicIndicator.Id = request.Id;
            _StrategicIndicator.Name = request.Name;
            _StrategicIndicator.Active = request.Active;
            _StrategicIndicator.FiscalYear = request.FiscalYear;
            _StrategicIndicator.ParentStrategicIndicatorId = request.ParentStrategicIndicatorId;
            _StrategicIndicator.Unit = request.Unit;
            _StrategicIndicator.Amount = request.Amount;
            _StrategicIndicator.Weight = request.Weight;
            if (request.ParentStrategicIndicatorId != 0)
            {
                _StrategicIndicator.ParentStrategicIndicatorId = request.ParentStrategicIndicatorId;
            }



            _database.Entry(_StrategicIndicator).State = _StrategicIndicator.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new SecBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = _StrategicIndicator.Id == 0 ? "update" : "insert";
            return response;
         
        }

        public List<StrategicIndicatorResponse> StrategicIndicatorSetupByFiscalYear(int FiscalYear)
        {
            var result = new List<StrategicIndicatorResponse>();
            var data = _database.StrategicIndicators.Where(x => x.FiscalYear == FiscalYear).ToList();
            foreach (var item in data)
            {
                result.Add(new StrategicIndicatorResponse
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Active = item.Active,
                    ParentStrategicIndicatorId = item.ParentStrategicIndicatorId,
                    Unit = item.Unit,
                    Amount = item.Amount,
                    Weight = item.Weight

                });
            }
            return result;
        }

        public List<PrinciplePlanTagsResponse> PrinciplePlanTagSetup()
        {
            var loop1 = new List<PrinciplePlanTagsResponse>();
            var data = _database.PrinciplePlanTags.Where(x=> x.ParentPrinciplePlanTagId == null && x.Active).Include(x => x.InverseParentPrinciplePlanTag).ToList();

            foreach(var item in data)
            {

                        var loop2 = new List<PrinciplePlanTagsResponse>();
            
            
                        foreach (var item_1 in item.InverseParentPrinciplePlanTag)
                        {
                            loop2.Add(new PrinciplePlanTagsResponse
                            {
                                Id = item_1.Id,
                                Name = item_1.Name,
                                Active = item_1.Active,
                                Weight = item_1.Weight,
                                ParentPrinciplePlanTagId = item_1.ParentPrinciplePlanTagId
                            });
                        }
                loop1.Add(new PrinciplePlanTagsResponse
                {
                    Id = item.Id,
                    Name = item.Name,
                    Active = item.Active,
                    Weight = item.Weight,
                    ParentPrinciplePlanTagId = item.ParentPrinciplePlanTagId,
                    ParentPrinciplePlanTag = loop2
                });

            }
            return loop1;
        }

        public SecBaseResponse PrinciplePlanTagSetupData(PrinciplePlanTagsRequest request)
        {
            var _PrinciplePlanTag = new PrinciplePlanTag();
            _PrinciplePlanTag.Id = request.Id;
            _PrinciplePlanTag.Name = request.Name;
            _PrinciplePlanTag.Active = request.Active;
            
            if (request.ParentPrinciplePlanTagId != 0)
            {
                _PrinciplePlanTag.ParentPrinciplePlanTagId = request.ParentPrinciplePlanTagId;
            }



            _database.Entry(_PrinciplePlanTag).State = _PrinciplePlanTag.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new SecBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = _PrinciplePlanTag.Id == 0 ? "update" : "insert";
            return response;

        }

        public SecBaseResponse GovernmentDisbursementGoalSetup(GovernmentDisbursementGoal request)
        {
            _database.Entry(request).State = request.Id == 0 ?
                           EntityState.Added :
                           EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new SecBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = request.Id == 0 ? "update" : "insert";
            return response;
        }

        public List<GovernmentDisbursementGoal> GovernmentDisbursementGoalByFiscalYear(int FiscalYear)
        {
            return _database.GovernmentDisbursementGoals.Where(x => x.FiscalYear == FiscalYear && x.Active).ToList();
            
        }
        public List<FundTypeRespone> SearchPlanForActivityFundTypeSetupByFiscalYear(int FiscalYear)
        {
            var _result = new List<FundTypeRespone>();
            var data = _database.FundTypes.Where(x => x.FiscalYear == FiscalYear).ToList();
            foreach (var item in data)
            {
                _result.Add(new FundTypeRespone
                {
                    Id = item.Id,
                    Name = item.Name,
                    Active = item.Active,
                    ParentFundTypeId = item.ParentFundTypeId,
                    ReferenceOldId = item.ReferenceOldId,
                });
            }
            return _result;
        }

        public List<DepartmentRespone> SearchPlanForActivityDepartmentListGetByFiscalYear(int FiscalYear)
        {
            var data = _database.Departments.Where(x => x.FiscalYear == FiscalYear && x.Active);
            var result = new List<DepartmentRespone>();
            foreach (var item in data)
            {
                result.Add(new DepartmentRespone
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Active = item.Active,
                    ParentDepartmentId = item.ParentDepartmentId,
                });


            }
            return result;
        }

        public List<PlanTypeDto> SearchPlanForActivityPlanTypeGetByFiscalYear(int FiscalYear)
        {
            var _PlanTypes = _database.PlanTypes.Where(x => x.FiscalYear == FiscalYear).Include(x => x.InverseParentPlanType).Include(x => x.PlanCores).ToList();
            var _PlanTypeDto_list = new List<PlanTypeDto>();

            string n = "";
            foreach (var item in _PlanTypes)
            {
                if (item.ParentPlanType != null)
                {

                    n = item.ParentPlanType.Name;
                }


                _PlanTypeDto_list.Add(new PlanTypeDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Active = item.Active,
                    ParentPlanTypeId = item.ParentPlanTypeId,
                    ReferenceOldId = item.ReferenceOldId,
                    Weight = item.Weight,
                    ParentPlanType = n


                });
            }
            return _PlanTypeDto_list;
        }

        public List<FundTypeRespone> SearchPlanActivityFundTypeSetupByFiscalYear(int FiscalYear)
        {
            var _result = new List<FundTypeRespone>();
            var data = _database.FundTypes.Where(x => x.FiscalYear == FiscalYear).ToList();
            foreach (var item in data)
            {
                _result.Add(new FundTypeRespone
                {
                    Id = item.Id,
                    Name = item.Name,
                    Active = item.Active,
                    ParentFundTypeId = item.ParentFundTypeId,
                    ReferenceOldId = item.ReferenceOldId,
                });
            }
            return _result;
        }

        public List<DepartmentRespone> SearchPlanActivityDepartmentListGetByFiscalYear(int FiscalYear)
        {
            var data = _database.Departments.Where(x => x.FiscalYear == FiscalYear && x.Active);
            var result = new List<DepartmentRespone>();
            foreach (var item in data)
            {
                result.Add(new DepartmentRespone
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Active = item.Active,
                    ParentDepartmentId = item.ParentDepartmentId,
                });


            }
            return result;
        }

        public List<PlanTypeDto> SearchPlanActivityPlanTypeGetByFiscalYear(int FiscalYear)
        {
            var _PlanTypes = _database.PlanTypes.Where(x => x.FiscalYear == FiscalYear).Include(x => x.InverseParentPlanType).Include(x => x.PlanCores).ToList();
            var _PlanTypeDto_list = new List<PlanTypeDto>();

            string n = "";
            foreach (var item in _PlanTypes)
            {
                if (item.ParentPlanType != null)
                {

                    n = item.ParentPlanType.Name;
                }


                _PlanTypeDto_list.Add(new PlanTypeDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Active = item.Active,
                    ParentPlanTypeId = item.ParentPlanTypeId,
                    ReferenceOldId = item.ReferenceOldId,
                    Weight = item.Weight,
                    ParentPlanType = n


                });
            }
            return _PlanTypeDto_list;
        }

        public List<FundTypeRespone> SearchPlanItemFundTypeSetupByFiscalYear(int FiscalYear)
        {
            var _result = new List<FundTypeRespone>();
            var data = _database.FundTypes.Where(x => x.FiscalYear == FiscalYear).ToList();
            foreach (var item in data)
            {
                _result.Add(new FundTypeRespone
                {
                    Id = item.Id,
                    Name = item.Name,
                    Active = item.Active,
                    ParentFundTypeId = item.ParentFundTypeId,
                    ReferenceOldId = item.ReferenceOldId,
                });
            }
            return _result;
        }

        public List<DepartmentRespone> SearchPlanItemDepartmentListGetByFiscalYear(int FiscalYear)
        {
            var data = _database.Departments.Where(x => x.FiscalYear == FiscalYear && x.Active);
            var result = new List<DepartmentRespone>();
            foreach (var item in data)
            {
                result.Add(new DepartmentRespone
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Active = item.Active,
                    ParentDepartmentId = item.ParentDepartmentId,
                });


            }
            return result;
        }

        public List<PlanTypeDto> SearchPlanItemPlanTypeGetByFiscalYear(int FiscalYear)
        {
            var _PlanTypes = _database.PlanTypes.Where(x => x.FiscalYear == FiscalYear).Include(x => x.InverseParentPlanType).Include(x => x.PlanCores).ToList();
            var _PlanTypeDto_list = new List<PlanTypeDto>();

            string n = "";
            foreach (var item in _PlanTypes)
            {
                if (item.ParentPlanType != null)
                {

                    n = item.ParentPlanType.Name;
                }


                _PlanTypeDto_list.Add(new PlanTypeDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Active = item.Active,
                    ParentPlanTypeId = item.ParentPlanTypeId,
                    ReferenceOldId = item.ReferenceOldId,
                    Weight = item.Weight,
                    ParentPlanType = n


                });
            }
            return _PlanTypeDto_list;
        }

        public List<PlanCore> SearchPlanCoreById(int PlanCoreId)
        {


            var plancoredata = _database.PlanCores.Where(x => x.Id == PlanCoreId && x.Active).Include(x => x.PlanActivities).Include(x => x.Strategies).Include(x => x.ResponsiblePeople).SingleOrDefault();


            foreach (var item in plancoredata.PlanActivities)
            {
                var _PlanItems = _database.PlanItems.Where(x => x.PlanActivityId == item.Id).Include(x => x.MonthlyForecasts).Include(x => x.SummaryStatementCaches).ToList();
            }

            

            throw new NotImplementedException();
        }

        public List<PlanType> ReceivedReservedBudgetByPlanCreateTableData(int planTypeId, int fiscalYear, int depId = 0)
        {
            var objectList = new List<PlanType>();
            if (planTypeId != 0) objectList = _database.PlanTypes.Where(x => x.Id == planTypeId && x.Active).Include(x => x.PlanCores).ToList();  // _PlanTService.GetAllChildHierarchy(planTypeId);
            else objectList = _database.PlanTypes.Where(x => x.FiscalYear == fiscalYear && x.Active).ToList();

            var gg = 0;
            
            throw new NotImplementedException();
        }
    }
}
