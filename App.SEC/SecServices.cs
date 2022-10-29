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
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
                 data = _database.Departments.Where(x =>  x.Active && x.FiscalYear == FiscalYear).Include(x => x.PlanActivities).Include(x => x.PlanCores).Include(x => x.InverseParentDepartment).ToList();
            }

            var _datalist_main = new List<ViewPlanForActivityByDepartmentTable>();

        
           
                var _list_m = new List<ViewPlanForActivityByDepartmentTable>();
            foreach (var plancoreList in data)
            {

                if (plancoreList.InverseParentDepartment.Count > 0)
                {
                    foreach (var loop_l in plancoreList.InverseParentDepartment)
                    {
                        var plancore = _database.PlanCores.Where(x => x.DepartmentId == loop_l.Id && x.Active).Include(x => x.PlanActivities).ToList();
                        var _list2 = new List<ViewPlanForActivityByDepartmentTable>();
                        foreach (var loop_l2 in plancore)
                        {
                            var _list1 = new List<ViewPlanForActivityByDepartmentTable>();

                            foreach (var loop_3 in loop_l2.PlanActivities)
                            {
                                decimal _TotalBudgetCache = 0;
                                decimal _TotalAmount = 0;
                                decimal _NetAmount = 0;
                                decimal _NetBudgetCache = 0;
                                decimal _UsedBudgetCache = 0;
                                decimal _RemainBudgetPlanView = 0;
                                decimal _TotalBudget = 0;
                                var data_l = _database.PlanItems.Where(x => x.PlanActivityId == loop_3.Id && x.Active).Include(x => x.SummaryStatementCaches).ToList();
                                foreach (var _MonthlyForecasts in data_l)
                                {

                                    _NetBudgetCache += _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().NetBudgetPlanView;
                                    _UsedBudgetCache += _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().UsedBudgetPlanView;
                                    _RemainBudgetPlanView += _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().RemainBudgetPlanView;
                                    _TotalBudgetCache += _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().TotalBudgetPlanView;

                                }
                                _list1.Add(new ViewPlanForActivityByDepartmentTable
                                {
                                    Id = loop_3.Id,
                                    Name = loop_3.Name,
                                    FiscalYear = loop_3.FiscalYear,
                                    TotalBudgetCache = _TotalBudgetCache,
                                    NetBudgetCache = _NetBudgetCache,
                                    UsedBudgetCache = _UsedBudgetCache,
                                    RemainBudgetCache = _RemainBudgetPlanView,

                                });
                            }
                            _list2.Add(new ViewPlanForActivityByDepartmentTable
                            {
                                Id = loop_l2.Id,
                                Name = loop_l2.Name,
                                FiscalYear = loop_l2.FiscalYear,
                                TotalBudget = _list1.Sum(x => x.TotalBudget),
                                TotalBudgetCache = _list1.Sum(x => x.TotalBudgetCache),
                                NetBudgetCache = _list1.Sum(x => x.NetBudgetCache),
                                UsedBudgetCache = _list1.Sum(x => x.UsedBudgetCache),
                                RemainBudgetCache = _list1.Sum(x => x.RemainBudgetCache),
                                subdata = _list1
                            });
                        }
                        _list_m.Add(new ViewPlanForActivityByDepartmentTable
                        {
                            Id = loop_l.Id,
                            Name = loop_l.Name,
                            FiscalYear = loop_l.FiscalYear,
                            TotalBudget = _list2.Sum(x => x.TotalBudget),
                            TotalBudgetCache = _list2.Sum(x => x.TotalBudgetCache),
                            NetBudgetCache = _list2.Sum(x => x.NetBudgetCache),
                            UsedBudgetCache = _list2.Sum(x => x.UsedBudgetCache),
                            RemainBudgetCache = _list2.Sum(x => x.RemainBudgetCache),
                            subdata = _list2
                        });
                    }
                    _datalist_main.Add(new ViewPlanForActivityByDepartmentTable
                    {
                        Id = plancoreList.Id,
                        Name = plancoreList.Name,
                        FiscalYear = plancoreList.FiscalYear,
                        TotalBudget = _list_m.Sum(x => x.TotalBudget),
                        TotalBudgetCache = _list_m.Sum(x => x.TotalBudgetCache),
                        NetBudgetCache = _list_m.Sum(x => x.NetBudgetCache),
                        UsedBudgetCache = _list_m.Sum(x => x.UsedBudgetCache),
                        RemainBudgetCache = _list_m.Sum(x => x.RemainBudgetCache),
                        subdata = _list_m
                    });
                    return _datalist_main;

                }
                else
                {


                    var _list2 = new List<ViewPlanForActivityByDepartmentTable>();
                    foreach (var l1 in plancoreList.PlanCores)
                    {
                        var _list1 = new List<ViewPlanForActivityByDepartmentTable>();
                        foreach (var l2 in l1.PlanActivities)
                        {
                            decimal _TotalBudgetCache = 0;
                            decimal _TotalAmount = 0;
                            decimal _NetAmount = 0;
                            decimal _NetBudgetCache = 0;
                            decimal _UsedBudgetCache = 0;
                            decimal _RemainBudgetPlanView = 0;
                            decimal _TotalBudget = 0;
                            var data_l = _database.PlanItems.Where(x => x.PlanActivityId == l2.Id && x.Active).Include(x => x.SummaryStatementCaches).ToList();
                            foreach (var _MonthlyForecasts in data_l)
                            {

                                _NetBudgetCache += _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().NetBudgetPlanView;
                                _UsedBudgetCache += _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().UsedBudgetPlanView;
                                _RemainBudgetPlanView += _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().RemainBudgetPlanView;
                                _TotalBudgetCache += _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().TotalBudgetPlanView;

                            }

                            _list1.Add(new ViewPlanForActivityByDepartmentTable
                            {
                                Id = l2.Id,
                                Name = l2.Name,
                                FiscalYear = l2.FiscalYear,
                                TotalBudgetCache = _TotalBudgetCache,
                                NetBudgetCache = _NetBudgetCache,
                                UsedBudgetCache = _UsedBudgetCache,
                                RemainBudgetCache = _RemainBudgetPlanView,

                            });
                        }

                        _list2.Add(new ViewPlanForActivityByDepartmentTable
                        {
                            Id = l1.Id,
                            Name = l1.Name,
                            FiscalYear = l1.FiscalYear,
                            TotalBudget = _list1.Sum(x => x.TotalBudget),
                            TotalBudgetCache = _list1.Sum(x => x.TotalBudgetCache),
                            NetBudgetCache = _list1.Sum(x => x.NetBudgetCache),
                            UsedBudgetCache = _list1.Sum(x => x.UsedBudgetCache),
                            RemainBudgetCache = _list1.Sum(x => x.RemainBudgetCache),
                            subdata = _list1
                        });
                    }
                    _list_m.Add(new ViewPlanForActivityByDepartmentTable
                    {
                        Id = plancoreList.Id,
                        Name = plancoreList.Name,
                        FiscalYear = plancoreList.FiscalYear,
                        TotalBudget = _list2.Sum(x => x.TotalBudget),
                        TotalBudgetCache = _list2.Sum(x => x.TotalBudgetCache),
                        NetBudgetCache = _list2.Sum(x => x.NetBudgetCache),
                        UsedBudgetCache = _list2.Sum(x => x.UsedBudgetCache),
                        RemainBudgetCache = _list2.Sum(x => x.RemainBudgetCache),
                        subdata = _list2
                    });

                }
               
            }


            return _list_m;


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

       
        public List<ViewPlanForActivityByDepartmentTable> ReceivedReservedBudgetByPlanCreateTableData(int planTypeId, int fiscalYear, int depId = 0)
        {
            var objectList = new List<PlanType>();
            if (planTypeId != 0) objectList = _database.PlanTypes.Where(x => x.Id == planTypeId && x.Active).Include(x => x.PlanCores).ToList();  // _PlanTService.GetAllChildHierarchy(planTypeId);
            else objectList = _database.PlanTypes.Where(x => x.FiscalYear == fiscalYear && x.Active).ToList();

            var _list1 = new List<ViewPlanForActivityByDepartmentTable>();
            foreach (var PlanTypesItem in objectList)
            {
                var _list2 = new List<ViewPlanForActivityByDepartmentTable>();
                var planCoreData = _database.PlanCores.Where(x => x.PlanTypeId == PlanTypesItem.Id && x.Active).Include(x => x.PlanActivities).ToList();
                foreach (var loop1 in planCoreData)
                {
                    decimal _TotalBudgetCache = 0;
                    decimal _TotalAmount = 0;
                    decimal _NetAmount = 0;
                    decimal _NetBudgetCache = 0;
                    decimal _UsedBudgetCache = 0;
                    decimal _RemainBudgetPlanView = 0;
                    decimal _TotalBudget = 0;
                    var _list3 = new List<ViewPlanForActivityByDepartmentTable>();
                    foreach (var loop2 in loop1.PlanActivities)
                    {
                        var _PlanItems = _database.PlanItems.Where(x => x.PlanActivityId == loop2.Id && x.Active).Include(x => x.MonthlyForecasts).Include(x => x.SummaryStatementCaches).ToList();
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
                        _list3.Add(new ViewPlanForActivityByDepartmentTable
                        {
                            Id = loop2.Id,
                            Name = loop2.Name,
                            FiscalYear = loop2.FiscalYear,
                            TotalBudget = _TotalBudget,
                            TotalBudgetCache = _TotalBudgetCache,
                            NetBudgetCache = _NetBudgetCache,
                            UsedBudgetCache = _UsedBudgetCache,
                            RemainBudgetCache = _RemainBudgetPlanView,

                        });



                    }
                    _list2.Add(new ViewPlanForActivityByDepartmentTable
                    {
                        Id = loop1.Id,
                        Name = loop1.Name,
                        FiscalYear = loop1.FiscalYear,
                        TotalBudget = _list3.Sum(x => x.TotalBudget),
                        TotalBudgetCache = _list3.Sum(x => x.TotalBudgetCache),
                        NetBudgetCache = _list3.Sum(x => x.NetBudgetCache),
                        UsedBudgetCache = _list3.Sum(x => x.UsedBudgetCache),
                        RemainBudgetCache = _list3.Sum(x => x.RemainBudgetCache),
                        subdata = _list3
                    });

                }
                _list1.Add(new ViewPlanForActivityByDepartmentTable
                {
                    Id = PlanTypesItem.Id,
                    Name = PlanTypesItem.Name,
                    FiscalYear = PlanTypesItem.FiscalYear,
                    TotalBudget = _list2.Sum(x => x.TotalBudget),
                    TotalBudgetCache = _list2.Sum(x => x.TotalBudgetCache),
                    NetBudgetCache = _list2.Sum(x => x.NetBudgetCache),
                    UsedBudgetCache = _list2.Sum(x => x.UsedBudgetCache),
                    RemainBudgetCache = _list2.Sum(x => x.RemainBudgetCache),
                    subdata = _list2
                });
            }
            
            return _list1;
        }

        public ViewPlanActivityListDataDto SearchPlanItemById(int PlanActivityId)
        {
            var result = new ViewPlanActivityListDataDto();
            var _list = new List<ViewPlanForActivityByDepartmentTable>();
            var _total = new List<ViewPlanForActivityByDepartmentTable>();
            var PlanActivitiesDetail = _database.PlanActivities.Where(x => x.Id == PlanActivityId).FirstOrDefault();
            var PlanCoreDetail = _database.PlanCores.Where(x => x.Id == PlanActivitiesDetail.PlanCoreId).Include(x => x.Strategies).Include(x => x.ResponsiblePeople).FirstOrDefault();

            var _projectDetailDto = new projectDetailDto();
            _projectDetailDto.FiscalYear = PlanCoreDetail.FiscalYear;
            _projectDetailDto.StrategiesName = PlanCoreDetail.Strategies.Select(x => x.Name).FirstOrDefault();
            _projectDetailDto.PlanName = PlanCoreDetail.Name;
            _projectDetailDto.Department = _database.Departments.Where(x => x.Id == PlanCoreDetail.DepartmentId).FirstOrDefault().Name;
            _projectDetailDto.PlanName = PlanCoreDetail.Name;


            var _Team = new List<Team>();
            int index = 0;
            foreach (var team_item in PlanCoreDetail.ResponsiblePeople)
            {

                _Team.Add(new Team
                {
                    HrdepartmentName = team_item.HrdepartmentName,
                    Position = index == 0? "ผู้รับผิดชอบโครงการ (Project Manager)" : "ผู้ร่วมโครงการ (Team)",
                    Name = team_item.Name,
                }) ;
            }


            var _PlanItems = _database.PlanItems.Where(x => x.PlanActivityId == PlanActivityId && x.Active).Include(x => x.MonthlyForecasts).Include(x => x.SummaryStatementCaches).ToList();
            foreach (var item in _PlanItems)
            {


                _list.Add(new ViewPlanForActivityByDepartmentTable
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Amount = item.MonthlyForecasts.Where(x => x.Active).Sum(x => x.Amount),
                    BudgetPerPiece = item.MonthlyForecasts.Where(x => x.Active).FirstOrDefault().BudgetPerPiece,
                    Unit = item.Unit,
                    BudgetTypeId = item.BudgetTypeId,
                    TotalBudgetCache = item.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().TotalBudgetPlanView,
                    NetBudgetCache = item.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().NetBudgetPlanView,
                    UsedBudgetCache = item.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().UsedBudgetPlanView,
                    RemainBudgetCache = item.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().RemainBudgetPlanView,
            
                });

               
                //_TotalBudget += _MonthlyForecasts.MonthlyForecasts.Sum(x => x.Amount * x.BudgetPerPiece);
                //_TotalAmount += _MonthlyForecasts.MonthlyForecasts.Sum(x => x.Amount);
                //_NetAmount += _MonthlyForecasts.MonthlyForecasts.Sum(x => x.Amount);
                //_NetBudgetCache = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().NetBudgetPlanView;
                //_UsedBudgetCache = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().UsedBudgetPlanView;
                //_RemainBudgetPlanView = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().RemainBudgetPlanView;
                //_TotalBudgetCache = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().TotalBudgetPlanView;

            }
           
            _total.Add(new ViewPlanForActivityByDepartmentTable
            {
                Id = PlanActivitiesDetail.Id,
                Name = PlanActivitiesDetail.Name,
                FiscalYear = PlanActivitiesDetail.FiscalYear,
                TotalBudget = _list.Sum(x => x.TotalBudget),
                TotalBudgetCache = _list.Sum(x => x.TotalBudgetCache),
                NetBudgetCache = _list.Sum(x => x.NetBudgetCache),
                UsedBudgetCache = _list.Sum(x => x.UsedBudgetCache),
                RemainBudgetCache = _list.Sum(x => x.RemainBudgetCache),
                subdata = _list
            });
            var Budgetmode = new List<Budgetmode>();
            var BudgetTypeList =  _list.GroupBy(x => x.BudgetTypeId).ToList();
            foreach(var value in BudgetTypeList)
            {

                var num = (int)value.Key;
                //var count_list = _list.Where(x => x.BudgetTypeId == num).ToList();
                //var ggg = _list.Where(x=>x.BudgetTypeId == num).Sum(x => x.TotalBudgetCache);
                Budgetmode.Add(new Budgetmode
                {

                    list = _database.BudgetTypes.Where(x => x.Id == num).FirstOrDefault().Name,
                    Budget = _list.Where(x => x.BudgetTypeId == num).Sum(x => x.TotalBudgetCache)
                }) ; 
            }
            _projectDetailDto.Budgetmode = Budgetmode;
            result.data = _total;
            result.projectDetail = _projectDetailDto;
            result.Persons = _Team;
            
            return result;
        }
    }
}
