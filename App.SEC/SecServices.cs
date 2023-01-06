using App.Common.Dtos;
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
using System.Net.WebSockets;
using System.Numerics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
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
            _database.Entry(policy).State = policy.Id == 0 ? EntityState.Added : EntityState.Modified;
            var result = _database.SaveChanges();
            var response = new SecBaseResponse();
            response.Success = result > 0 ? true : false;
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
            foreach (var item in result)
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

        public List<StrategySetupDto> TryGetStrategy(int FiscalYear)
        {
            var response = new List<StrategySetupDto>();
            var strategy = new List<StrategySetupDto>();
            var strategy_Parent = new List<StrategySetupDto>();
            var result = _database.Strategies.Where(x => x.FiscalYear == FiscalYear && x.Active).ToList();
            foreach (var item in result)
            {
                // department.Id = item.ParentDepartment;
                //if (item.ParentStrategyId != null)
                //{
                    foreach (var sub_strategy in item.InverseParentStrategy)
                    {


                        foreach (var sub1_strategy in sub_strategy.InverseParentStrategy)
                        {
                            strategy_Parent.Add(new StrategySetupDto
                            {
                                Id = sub1_strategy.Id,
                                Name = sub1_strategy.Name,
                                FiscalYear = sub1_strategy.FiscalYear,
                                Active = sub1_strategy.Active,
                                ParentStrategyId = sub1_strategy.ParentStrategyId
                            });
                        }


                        strategy.Add(new StrategySetupDto
                        {
                            Id = sub_strategy.Id,
                            Name = sub_strategy.Name,
                            FiscalYear = sub_strategy.FiscalYear,
                            Active = sub_strategy.Active,
                            ParentStrategyId = sub_strategy.ParentStrategyId,
                            Strategy = strategy_Parent,
                        }
                        );

                    }
                //}
                response.Add(new StrategySetupDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Active = item.Active,
                    ParentStrategyId = item.ParentStrategyId,
                    Strategy = strategy
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
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Active = item.Active,
                    ParentDepartmentId = item.ParentDepartmentId,
                });


            }
            return result;
        }

        public List<DepartmentBudgetLimitDto> DepartmentBudgetLimitGetByFiscalYear(int FiscalYear)
        {
            var data = _database.Departments.Where(x => x.FiscalYear == FiscalYear && x.Active);
            var result = new List<DepartmentBudgetLimitDto>();
            foreach (var item in data)
            {
                result.Add(new DepartmentBudgetLimitDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Active = item.Active,
                    ParentDepartmentId = item.ParentDepartmentId,
                    ReferenceOldId = item.ReferenceOldId,
                    BudgetLimit = item.BudgetLimit
                });


            }
            return result;
        }
        public List<PlanTypeDto> PlanTypeGetAll(int FiscalYear)
        {
            var data = _database.PlanTypes.Where(x => x.FiscalYear == FiscalYear && x.Active);
            var result = new List<PlanTypeDto>();
            foreach (var item in data)
            {
                result.Add(new PlanTypeDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Active = item.Active,
                    ParentPlanTypeId = item.ParentPlanTypeId,
                    ReferenceOldId = item.ReferenceOldId,
                    Weight = item.Weight,
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

            if (request.ParentDepartmentId != 0)
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
        public SecBaseResponse DepartmentBudgetLimitSetup(DepartmentBudgetLimitRequest request)
        {
            var response = new SecBaseResponse();
            var data = _database.Departments.Where(x => x.Id == request.Id).FirstOrDefault();
            if (data != null)
            {
                data.BudgetLimit = request.BudgetLimit;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Save Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

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
            return _database.BudgetTypes.Where(x => x.FiscalYear == FiscalYear).ToList();

        }

        public List<ViewPlanForActivityByDepartmentTable> GetById(int departmentId, int FiscalYear)
        {

            //decimal _NetBudget = 0;
            //decimal _InwardBudgetTransfers = 0;
            //decimal _InProcessBudget = 0;

            var loop1 = new List<PlanItem>();
            var _datalist = new List<ViewPlanForActivityByDepartmentTable>();
            var data = new List<Department>();
            if (departmentId != 0)
            {
                data = _database.Departments.Where(x => x.Id == departmentId && x.Active && x.FiscalYear == FiscalYear).Include(x => x.PlanActivities).Include(x => x.PlanCores).Include(x => x.InverseParentDepartment).ToList();
            }
            else
            {
                data = _database.Departments.Where(x => x.Active && x.FiscalYear == FiscalYear).Include(x => x.PlanActivities).Include(x => x.PlanCores).Include(x => x.InverseParentDepartment).ToList();
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
            var _PlanTypes = _database.PlanTypes.Where(x => x.FiscalYear == FiscalYear && x.Active).ToList();
            var _PlanTypes_start = _PlanTypes.Where(x => x.ParentPlanTypeId == null).ToList();
            var _PlanTypeDto_list = new List<PlanTypeDto>();

            foreach (var item in _PlanTypes_start)
            {
                var _PlanTypeDto_list_sub = new List<PlanTypeDto>();
                var _PlanTypesSub = _database.PlanTypes.Where(x => x.ParentPlanTypeId == item.Id && x.Active);



                foreach (var subPlanType in _PlanTypesSub)
                {
                    _PlanTypeDto_list_sub.Add(new PlanTypeDto
                    {
                        Id = subPlanType.Id,
                        Name = subPlanType.Name,
                        FiscalYear = subPlanType.FiscalYear,
                        Active = subPlanType.Active,
                        ParentPlanTypeId = subPlanType.ParentPlanTypeId,
                        ReferenceOldId = subPlanType.ReferenceOldId,
                        Weight = subPlanType.Weight,

                    });
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
                    planType = _PlanTypeDto_list_sub


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
            if (request.ParentPlanTypeId != 0)
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
            _Strategy.Name = request.Name;
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
            var data = _database.Strategies.Where(x => x.FiscalYear == FiscalYear & x.Active == true).ToList();
            foreach (var item in data)
            {
                result.Add(new StrategySetupModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Active = item.Active,
                    ParentStrategyId = item.ParentStrategyId,
                });
            }
            return result;
        }
        public List<StrategySetupModel> StrategySetupByFiscalYearandStrategyId(int FiscalYear, int id)
        {

            var result = new List<StrategySetupModel>();
            var data = _database.Strategies.Where(x => x.FiscalYear == FiscalYear &  x.ParentStrategyId == id).ToList();
                foreach (var item in data)
                {
                    result.Add(new StrategySetupModel
                    {
                        Id = item.Id,
                        Name = item.Name,
                        FiscalYear = item.FiscalYear,
                        Active = item.Active,
                        ParentStrategyId = item.ParentStrategyId,
                    });

                }
            return result;
        }
        public List<PlanTypeDto> PlanTypeGetByFiscalYearandPlanTypeid(int FiscalYear, int id)
        {

            var result = new List<PlanTypeDto>();
            var data = _database.PlanTypes.Where(x => x.FiscalYear == FiscalYear & x.ParentPlanTypeId == id).ToList();
            foreach (var item in data)
            {
                result.Add(new PlanTypeDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Active = item.Active,
                    ParentPlanTypeId = item.ParentPlanTypeId,
                    ReferenceOldId = item.ReferenceOldId,
                    Weight = item.Weight  
                });

            }
            return result;
        }
        public List<DepartmentDto> DepartmentGetByFiscalYearandDepartmentid(int FiscalYear, int id)
        {

            var result = new List<DepartmentDto>();
            var data = _database.Departments.Where(x => x.FiscalYear == FiscalYear & x.ParentDepartmentId == id).ToList();
            foreach (var item in data)
            {
                result.Add(new DepartmentDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Active = item.Active,
                    ReferenceOldId = item.ReferenceOldId,
                    ParentDepartmentId = item.ParentDepartmentId
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
            var data = _database.PrinciplePlanTags.Where(x => x.ParentPrinciplePlanTagId == null && x.Active).Include(x => x.InverseParentPrinciplePlanTag).ToList();

            foreach (var item in data)
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
            if (planTypeId != 0) objectList = _database.PlanTypes.Where(x => x.Id == planTypeId && x.Active).Include(x => x.PlanCores).Include(x => x.InverseParentPlanType).ToList();  // _PlanTService.GetAllChildHierarchy(planTypeId);
            else objectList = _database.PlanTypes.Where(x => x.FiscalYear == fiscalYear && x.Active).Include(x => x.InverseParentPlanType).ToList();

            var _list1 = new List<ViewPlanForActivityByDepartmentTable>();
            foreach (var PlanTypesItem in objectList)
            {
                var _list2 = new List<ViewPlanForActivityByDepartmentTable>();


                if (PlanTypesItem.InverseParentPlanType.Count > 0)
                {
                    foreach (var s1 in PlanTypesItem.InverseParentPlanType)
                    {
                        var _list2_d = new List<ViewPlanForActivityByDepartmentTable>();
                        var planCoreData = _database.PlanCores.Where(x => x.PlanTypeId == s1.Id && x.Active && depId != 0 ? x.DepartmentId == depId : true).ToList();
                        foreach (var loop1 in planCoreData)
                        {

                            var _list3 = new List<ViewPlanForActivityByDepartmentTable>();
                            foreach (var loop2 in loop1.PlanActivities)
                            {
                                decimal _TotalBudgetCache = 0;
                                decimal _TotalAmount = 0;
                                decimal _NetAmount = 0;
                                decimal _NetBudgetCache = 0;
                                decimal _UsedBudgetCache = 0;
                                decimal _RemainBudgetPlanView = 0;
                                decimal _TotalBudget = 0;
                                var _PlanItems = _database.PlanItems.Where(x => x.PlanActivityId == loop2.Id && x.Active).Include(x => x.MonthlyForecasts).Include(x => x.SummaryStatementCaches).ToList();
                                foreach (var _MonthlyForecasts in _PlanItems)
                                {
                                    _TotalBudget += _MonthlyForecasts.MonthlyForecasts.Count > 0 ? _MonthlyForecasts.MonthlyForecasts.Sum(x => x.Amount * x.BudgetPerPiece) : 0;
                                    _TotalAmount += _MonthlyForecasts.MonthlyForecasts.Count > 0 ? _MonthlyForecasts.MonthlyForecasts.Sum(x => x.Amount) : 0;
                                    _NetAmount += _MonthlyForecasts.MonthlyForecasts.Count > 0 ? _MonthlyForecasts.MonthlyForecasts.Sum(x => x.Amount) : 0;

                                    _NetBudgetCache += _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().NetBudgetPlanView;
                                    _UsedBudgetCache += _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().UsedBudgetPlanView;
                                    _RemainBudgetPlanView += _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().RemainBudgetPlanView;
                                    _TotalBudgetCache += _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().TotalBudgetPlanView;

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
                            _list2_d.Add(new ViewPlanForActivityByDepartmentTable
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
                        _list2.Add(new ViewPlanForActivityByDepartmentTable
                        {
                            Id = s1.Id,
                            Name = s1.Name,
                            FiscalYear = s1.FiscalYear,
                            TotalBudget = _list2_d.Sum(x => x.TotalBudget),
                            TotalBudgetCache = _list2_d.Sum(x => x.TotalBudgetCache),
                            NetBudgetCache = _list2_d.Sum(x => x.NetBudgetCache),
                            UsedBudgetCache = _list2_d.Sum(x => x.UsedBudgetCache),
                            RemainBudgetCache = _list2_d.Sum(x => x.RemainBudgetCache),
                            subdata = _list2_d
                        });
                    }



                }
                else
                {


                    var planCoreData = _database.PlanCores.Where(x => x.PlanTypeId == PlanTypesItem.Id && x.Active).Include(x => x.PlanActivities).ToList();
                    foreach (var loop1 in planCoreData)
                    {

                        var _list3 = new List<ViewPlanForActivityByDepartmentTable>();
                        foreach (var loop2 in loop1.PlanActivities)
                        {
                            decimal _TotalBudgetCache = 0;
                            decimal _TotalAmount = 0;
                            decimal _NetAmount = 0;
                            decimal _NetBudgetCache = 0;
                            decimal _UsedBudgetCache = 0;
                            decimal _RemainBudgetPlanView = 0;
                            decimal _TotalBudget = 0;
                            var _PlanItems = _database.PlanItems.Where(x => x.PlanActivityId == loop2.Id && x.Active).Include(x => x.MonthlyForecasts).Include(x => x.SummaryStatementCaches).ToList();
                            foreach (var _MonthlyForecasts in _PlanItems)
                            {
                                _TotalBudget += _MonthlyForecasts.MonthlyForecasts.Count > 0 ? _MonthlyForecasts.MonthlyForecasts.Sum(x => x.Amount * x.BudgetPerPiece) : 0;
                                _TotalAmount += _MonthlyForecasts.MonthlyForecasts.Count > 0 ? _MonthlyForecasts.MonthlyForecasts.Sum(x => x.Amount) : 0;
                                _NetAmount += _MonthlyForecasts.MonthlyForecasts.Count > 0 ? _MonthlyForecasts.MonthlyForecasts.Sum(x => x.Amount) : 0;

                                _NetBudgetCache += _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().NetBudgetPlanView;
                                _UsedBudgetCache += _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().UsedBudgetPlanView;
                                _RemainBudgetPlanView += _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().RemainBudgetPlanView;
                                _TotalBudgetCache += _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().TotalBudgetPlanView;

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
                    Position = index == 0 ? "ผู้รับผิดชอบโครงการ (Project Manager)" : "ผู้ร่วมโครงการ (Team)",
                    Name = team_item.Name,
                });
            }


            var _PlanItems = _database.PlanItems.Where(x => x.PlanActivityId == PlanActivityId && x.Active).Include(x => x.MonthlyForecasts).Include(x => x.SummaryStatementCaches).ToList();
            foreach (var item in _PlanItems)
            {


                _list.Add(new ViewPlanForActivityByDepartmentTable
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Amount = item.MonthlyForecasts.Count > 0 ? item.MonthlyForecasts.Where(x => x.Active).Sum(x => x.Amount) : 0,
                    BudgetPerPiece = item.MonthlyForecasts.Count > 0 ? item.MonthlyForecasts.Where(x => x.Active).Sum(x => x.BudgetPerPiece) / item.MonthlyForecasts.Where(x => x.Active).Sum(x => x.Amount) : 0,
                    Unit = item.Unit,
                    BudgetTypeId = item.BudgetTypeId,
                    TotalBudgetCache = item.SummaryStatementCaches.Count > 0 ? item.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().TotalBudgetPlanView : 0,
                    NetBudgetCache = item.SummaryStatementCaches.Count > 0 ? item.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().NetBudgetPlanView : 0,
                    UsedBudgetCache = item.SummaryStatementCaches.Count > 0 ? item.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().UsedBudgetPlanView : 0,
                    RemainBudgetCache = item.SummaryStatementCaches.Count > 0 ? item.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().RemainBudgetPlanView : 0,

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
            var BudgetTypeList = _list.GroupBy(x => x.BudgetTypeId).ToList();
            foreach (var value in BudgetTypeList)
            {

                var num = (int)value.Key;
                //var count_list = _list.Where(x => x.BudgetTypeId == num).ToList();
                //var ggg = _list.Where(x=>x.BudgetTypeId == num).Sum(x => x.TotalBudgetCache);
                Budgetmode.Add(new Budgetmode
                {
                    BudgetTypeId = num,
                    list = _database.BudgetTypes.Where(x => x.Id == num).FirstOrDefault().Name,
                    Budget = _list.Where(x => x.BudgetTypeId == num).Sum(x => x.TotalBudgetCache)
                });
            }
            _projectDetailDto.Budgetmode = Budgetmode;
            result.data = _total;
            result.projectDetail = _projectDetailDto;
            result.Persons = _Team;

            return result;
        }

        public List<ViewPlanForActivityByPlanTypeBudgetTypeTable> ViewPlanForActivityByPlanTypeBudgetTypeCreateTableData(int planTypeId, int fiscalYear, int depId = 0)
        {
            var startPlanType = new List<PlanType>();
            bool planTypeIdStatus = false;
            if (planTypeId != 0)
            {
                planTypeIdStatus = true;
                startPlanType = _database.PlanTypes.Where(x => x.Id == planTypeId && x.Active).Include(x => x.PlanCores).Include(x => x.InverseParentPlanType).ToList();
            }
            else
            {
                startPlanType = _database.PlanTypes.Where(x => x.FiscalYear == fiscalYear && x.Active).Include(x => x.PlanCores).Include(x => x.InverseParentPlanType).ToList();
            }


            var _list_m = new List<ViewPlanForActivityByPlanTypeBudgetTypeTable>();

            var count_InverseParentPlanType = startPlanType.SelectMany(x => x.InverseParentPlanType).Count();


            if (count_InverseParentPlanType > 0)
            {
                foreach (var s1 in startPlanType)
                {
                    var _list3 = new List<ViewPlanForActivityByPlanTypeBudgetTypeTable>();
                    foreach (var s2 in s1.InverseParentPlanType)
                    {
                        var _list2 = new List<ViewPlanForActivityByPlanTypeBudgetTypeTable>();
                        var PlanCoreDetail = new List<PlanCore>();
                        if (depId == 0)
                        {
                            PlanCoreDetail = _database.PlanCores.Where(x => x.PlanTypeId == s2.Id && x.Active).Include(x => x.PlanActivities).ToList();
                        }
                        else
                        {
                            PlanCoreDetail = _database.PlanCores.Where(x => x.PlanTypeId == s2.Id && x.DepartmentId == depId && x.Active).Include(x => x.PlanActivities).ToList();
                        }

                        foreach (var s3 in PlanCoreDetail)
                        {
                            var _list1 = new List<ViewPlanForActivityByPlanTypeBudgetTypeTable>();
                            foreach (var l2 in s3.PlanActivities)
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

                                    _NetBudgetCache += _MonthlyForecasts.SummaryStatementCaches.Count > 0 ? _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().NetBudgetPlanView : 0;
                                    _UsedBudgetCache += _MonthlyForecasts.SummaryStatementCaches.Count > 0 ? _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().UsedBudgetPlanView : 0;
                                    _RemainBudgetPlanView += _MonthlyForecasts.SummaryStatementCaches.Count > 0 ? _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().RemainBudgetPlanView : 0;
                                    _TotalBudgetCache += _MonthlyForecasts.SummaryStatementCaches.Count > 0 ? _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().TotalBudgetPlanView : 0;

                                }

                                _list1.Add(new ViewPlanForActivityByPlanTypeBudgetTypeTable
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
                            _list2.Add(new ViewPlanForActivityByPlanTypeBudgetTypeTable
                            {
                                Id = s3.Id,
                                Name = s3.Name,
                                FiscalYear = s3.FiscalYear,
                                TotalBudget = _list1.Sum(x => x.TotalBudget),
                                TotalBudgetCache = _list1.Sum(x => x.TotalBudgetCache),
                                NetBudgetCache = _list1.Sum(x => x.NetBudgetCache),
                                UsedBudgetCache = _list1.Sum(x => x.UsedBudgetCache),
                                RemainBudgetCache = _list1.Sum(x => x.RemainBudgetCache),
                                subdata = _list1
                            });
                        }
                        _list3.Add(new ViewPlanForActivityByPlanTypeBudgetTypeTable
                        {
                            Id = s2.Id,
                            Name = s2.Name,
                            FiscalYear = s2.FiscalYear,
                            TotalBudget = _list2.Sum(x => x.TotalBudget),
                            TotalBudgetCache = _list2.Sum(x => x.TotalBudgetCache),
                            NetBudgetCache = _list2.Sum(x => x.NetBudgetCache),
                            UsedBudgetCache = _list2.Sum(x => x.UsedBudgetCache),
                            RemainBudgetCache = _list2.Sum(x => x.RemainBudgetCache),
                            subdata = _list2
                        });
                    }
                    _list_m.Add(new ViewPlanForActivityByPlanTypeBudgetTypeTable
                    {
                        Id = s1.Id,
                        Name = s1.Name,
                        FiscalYear = s1.FiscalYear,
                        TotalBudget = _list3.Sum(x => x.TotalBudget),
                        TotalBudgetCache = _list3.Sum(x => x.TotalBudgetCache),
                        NetBudgetCache = _list3.Sum(x => x.NetBudgetCache),
                        UsedBudgetCache = _list3.Sum(x => x.UsedBudgetCache),
                        RemainBudgetCache = _list3.Sum(x => x.RemainBudgetCache),
                        subdata = _list3
                    });
                }
                return _list_m;
            }
            else
            {


                foreach (var PlanCores in startPlanType)
                {
                    var _list2 = new List<ViewPlanForActivityByPlanTypeBudgetTypeTable>();
                    foreach (var l1 in PlanCores.PlanCores)
                    {
                        var PlanActivities = _database.PlanActivities.Where(x => x.PlanCoreId == l1.Id && x.Active).Include(x => x.PlanItems).ToList();
                        var _list1 = new List<ViewPlanForActivityByPlanTypeBudgetTypeTable>();
                        foreach (var l2 in PlanActivities)
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

                            _list1.Add(new ViewPlanForActivityByPlanTypeBudgetTypeTable
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

                        _list2.Add(new ViewPlanForActivityByPlanTypeBudgetTypeTable
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
                    _list_m.Add(new ViewPlanForActivityByPlanTypeBudgetTypeTable
                    {
                        Id = PlanCores.Id,
                        Name = PlanCores.Name,
                        FiscalYear = PlanCores.FiscalYear,
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

        public ViewReceivedReservedBudgetByPlanActivityDto ViewReceivedReservedBudgetByPlanActivity(int PlanActivityId)
        {
            var result = new ViewReceivedReservedBudgetByPlanActivityDto();
            var projectDtail = new PlanActivityDetail();
            var _list_main = new List<ViewPlanForActivityByPlanTypeBudgetTypeTable>();
            var PlanCoreDetail = _database.PlanCores.Where(x => x.Id == PlanActivityId).Include(x => x.Strategies).Include(x => x.PlanActivities).ToList();
            var PlanTypeId = PlanCoreDetail.Select(x => x.PlanTypeId).FirstOrDefault();
            var PlanTypeDetail = _database.PlanTypes.Where(x => x.Id == PlanTypeId).FirstOrDefault();

            var PlanTypeDetailMain = _database.PlanTypes.Where(x => x.Id == PlanTypeDetail.ParentPlanTypeId).FirstOrDefault();
            projectDtail.FiscalYear = PlanCoreDetail.Select(x => x.FiscalYear).FirstOrDefault();
            var depId = PlanCoreDetail.Select(x => x.DepartmentId).FirstOrDefault();
            var departmaintdetail = _database.Departments.Where(x => x.Id == depId).FirstOrDefault();
            projectDtail.product = PlanTypeDetailMain.Name;
            projectDtail.PlanName = PlanTypeDetail.Name;
            projectDtail.Department = departmaintdetail.Name;
            projectDtail.ProjectName = PlanCoreDetail.Select(x => x.Name).FirstOrDefault();
            var StrategiesName = PlanCoreDetail.Select(x => x.Strategies).FirstOrDefault();
            projectDtail.StrategiesName = StrategiesName.Select(x => x.Name).FirstOrDefault();
            foreach (var s1 in PlanCoreDetail)
            {
                var _list1 = new List<ViewPlanForActivityByPlanTypeBudgetTypeTable>();
                foreach (var s2 in s1.PlanActivities)
                {
                    decimal _TotalBudgetCache = 0;
                    decimal _TotalAmount = 0;
                    decimal _NetAmount = 0;
                    decimal _NetBudgetCache = 0;
                    decimal _UsedBudgetCache = 0;
                    decimal _RemainBudgetPlanView = 0;
                    decimal _TotalBudget = 0;
                    var data_l = _database.PlanItems.Where(x => x.PlanActivityId == s2.Id && x.Active).Include(x => x.SummaryStatementCaches).ToList();
                    var _list_last = new List<ViewPlanForActivityByPlanTypeBudgetTypeTable>();
                    foreach (var _MonthlyForecasts in data_l)
                    {
                        //_NetBudgetCache = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().NetBudgetPlanView;
                        //_UsedBudgetCache = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().UsedBudgetPlanView;
                        //_RemainBudgetPlanView = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().RemainBudgetPlanView;
                        //_TotalBudgetCache = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().TotalBudgetPlanView;
                        _list_last.Add(new ViewPlanForActivityByPlanTypeBudgetTypeTable
                        {
                            Id = _MonthlyForecasts.Id,
                            Name = _MonthlyForecasts.Name,
                            FiscalYear = _MonthlyForecasts.FiscalYear,
                            TotalBudgetCache = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().TotalBudgetPlanView,
                            NetBudgetCache = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().NetBudgetPlanView,
                            UsedBudgetCache = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().UsedBudgetPlanView,
                            RemainBudgetCache = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().RemainBudgetPlanView,
                        });


                    }

                    _list1.Add(new ViewPlanForActivityByPlanTypeBudgetTypeTable
                    {
                        Id = s2.Id,
                        Name = s2.Name,
                        FiscalYear = s2.FiscalYear,
                        TotalBudget = _list_last.Sum(x => x.TotalBudget),
                        TotalBudgetCache = _list_last.Sum(x => x.TotalBudgetCache),
                        NetBudgetCache = _list_last.Sum(x => x.NetBudgetCache),
                        UsedBudgetCache = _list_last.Sum(x => x.UsedBudgetCache),
                        RemainBudgetCache = _list_last.Sum(x => x.RemainBudgetCache),
                        subdata = _list_last
                    });
                }

                _list_main.Add(new ViewPlanForActivityByPlanTypeBudgetTypeTable
                {
                    Id = s1.Id,
                    Name = s1.Name,
                    FiscalYear = s1.FiscalYear,
                    TotalBudget = _list1.Sum(x => x.TotalBudget),
                    TotalBudgetCache = _list1.Sum(x => x.TotalBudgetCache),
                    NetBudgetCache = _list1.Sum(x => x.NetBudgetCache),
                    UsedBudgetCache = _list1.Sum(x => x.UsedBudgetCache),
                    RemainBudgetCache = _list1.Sum(x => x.RemainBudgetCache),
                    subdata = _list1
                });
            }
            result.data = _list_main;
            result.detail = projectDtail;
            return result;
        }

        public ViewPlanActivityOperationPeriodByPlanCoreDto ViewPlanActivityOperationPeriodByPlanCore(int PlanCoreId)
        {
            var result = new ViewPlanActivityOperationPeriodByPlanCoreDto();
            var _List_PlanMonthlyOperation = new List<PlanMonthlyOperationDto>();
            var PlanActivities = _database.PlanActivities.Where(x => x.PlanCoreId == PlanCoreId && x.Active).Include(x => x.PlanMonthlyOperations).Include(x => x.PlanItems).Include(x => x.ResponsiblePeople).ToList();

            var _Team = new List<Team>();
            int index = 0;
            var _projectDetailDto = new projectDetailAddBugetDto();
            var _list_main = new List<ViewPlanForActivityByPlanTypeBudgetTypeTable>();
            var _list_result = new List<ViewPlanForActivityByPlanTypeBudgetTypeTable>();
            var b_num = new List<int>();
            var b_list = new List<butgetW>();
            int index_ = 0;
            foreach (var s1 in PlanActivities)
            {


                var PlanCoreDetail = _database.PlanCores.Where(x => x.Id == s1.PlanCoreId).Include(x => x.Strategies).Include(x => x.ResponsiblePeople).FirstOrDefault();


                _projectDetailDto.FiscalYear = PlanCoreDetail.FiscalYear;
                _projectDetailDto.StrategiesName = PlanCoreDetail.Strategies.Select(x => x.Name).FirstOrDefault();
                _projectDetailDto.PlanName = PlanCoreDetail.Name;
                _projectDetailDto.Department = _database.Departments.Where(x => x.Id == PlanCoreDetail.DepartmentId).FirstOrDefault().Name;
                _projectDetailDto.PlanName = PlanCoreDetail.Name;


                foreach (var team_item in s1.ResponsiblePeople)
                {

                    _Team.Add(new Team
                    {
                        HrdepartmentName = team_item.HrdepartmentName,
                        Position = index == 0 ? "ผู้รับผิดชอบโครงการ (Project Manager)" : "ผู้ร่วมโครงการ (Team)",
                        Name = team_item.Name,
                    });
                }


                decimal _TotalBudgetCache = 0;
                decimal _TotalAmount = 0;
                decimal _NetAmount = 0;
                decimal _NetBudgetCache = 0;
                decimal _UsedBudgetCache = 0;
                decimal _RemainBudgetPlanView = 0;
                decimal _TotalBudget = 0;
                var PlanItems = _database.PlanItems.Where(x => x.PlanActivityId == s1.Id && x.Active).Include(x => x.SummaryStatementCaches).ToList();
                var _list = new List<ViewPlanForActivityByPlanTypeBudgetTypeTable>();
                foreach (var item in PlanItems)
                {

                    //_NetBudgetCache = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().NetBudgetPlanView;
                    //_UsedBudgetCache = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().UsedBudgetPlanView;
                    //_RemainBudgetPlanView = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().RemainBudgetPlanView;
                    //_TotalBudgetCache = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().TotalBudgetPlanView;
                    _list.Add(new ViewPlanForActivityByPlanTypeBudgetTypeTable
                    {
                        Id = item.Id,
                        Name = item.Name,
                        FiscalYear = item.FiscalYear,
                        Unit = item.Unit,
                        BudgetTypeId = item.BudgetTypeId,
                        TotalBudgetCache = item.SummaryStatementCaches.Count > 0 ? item.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().TotalBudgetPlanView : 0,
                        NetBudgetCache = item.SummaryStatementCaches.Count > 0 ? item.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().NetBudgetPlanView : 0,
                        UsedBudgetCache = item.SummaryStatementCaches.Count > 0 ? item.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().UsedBudgetPlanView : 0,
                        RemainBudgetCache = item.SummaryStatementCaches.Count > 0 ? item.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().RemainBudgetPlanView : 0,
                    });
                    b_num.Add((int)item.BudgetTypeId);
                    b_list.Add(new butgetW
                    {
                        BudgetTypeId = (int)item.BudgetTypeId,
                        TotalBudgetCache = item.SummaryStatementCaches.Count > 0 ? item.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().TotalBudgetPlanView : 0

                    });


                }
                _list_main.Add(new ViewPlanForActivityByPlanTypeBudgetTypeTable
                {
                    Id = s1.Id,
                    Name = s1.Name,
                    FiscalYear = s1.FiscalYear,
                    TotalBudget = _list.Sum(x => x.TotalBudget),
                    TotalBudgetCache = _list.Sum(x => x.TotalBudgetCache),
                    NetBudgetCache = _list.Sum(x => x.NetBudgetCache),
                    UsedBudgetCache = _list.Sum(x => x.UsedBudgetCache),
                    RemainBudgetCache = _list.Sum(x => x.RemainBudgetCache),
                    subdata = _list
                });



                foreach (var s2 in s1.PlanMonthlyOperations)
                {
                    _List_PlanMonthlyOperation.Add(new PlanMonthlyOperationDto
                    {
                        Id = s2.Id,
                        Name = s2.Name,
                        Active = s2.Active,
                        FiscalYear = s2.FiscalYear,
                        January = s2.January,
                        February = s2.February,
                        March = s2.March,
                        April = s2.April,
                        May = s2.May,
                        June = s2.June,
                        July = s2.July,
                        August = s2.August,
                        September = s2.September,
                        October = s2.October,
                        November = s2.November,
                        December = s2.December,
                        Weight = s2.Weight,
                        PlanActivityId = s2.PlanActivityId,
                        ResultJanuary = s2.ResultJanuary,
                        ResultFebruary = s2.ResultFebruary,
                        ResultMarch = s2.ResultMarch,
                        ResultApril = s2.ResultApril,
                        ResultMay = s2.ResultMay,
                        ResultJune = s2.ResultJune,
                        ResultJuly = s2.ResultJuly,
                        ResultAugust = s2.ResultAugust,
                        ResultSeptember = s2.ResultSeptember,
                        ResultOctober = s2.ResultOctober,
                        ResultNovember = s2.ResultNovember,
                        ResultDecember = s2.ResultDecember,
                        DetailJanuary = s2.DetailJanuary,
                        DetailFebruary = s2.DetailFebruary,
                        DetailMarch = s2.DetailMarch,
                        DetailApril = s2.DetailApril,
                        DetailMay = s2.DetailMay,
                        DetailJune = s2.DetailJune,
                        DetailJuly = s2.DetailJuly,
                        DetailAugust = s2.DetailAugust,
                        DetailSeptember = s2.DetailSeptember,
                        DetailOctober = s2.DetailOctober,
                        DetailNovember = s2.DetailNovember,
                        DetailDecember = s2.DetailDecember,
                        ParentPlanMonthlyOperationId = s2.ParentPlanMonthlyOperationId
                    });
                }
            }
            _list_result.Add(new ViewPlanForActivityByPlanTypeBudgetTypeTable
            {

                TotalBudget = _list_main.Sum(x => x.TotalBudget),
                TotalBudgetCache = _list_main.Sum(x => x.TotalBudgetCache),
                NetBudgetCache = _list_main.Sum(x => x.NetBudgetCache),
                UsedBudgetCache = _list_main.Sum(x => x.UsedBudgetCache),
                RemainBudgetCache = _list_main.Sum(x => x.RemainBudgetCache),
                subdata = _list_main
            });


            var Budgetmode = new List<Budgetmode>();


            var bb = b_num.Distinct().ToArray();
            foreach (var num in bb)
            {

                var hh = b_list.Where(x => x.BudgetTypeId == num).ToList();
                Budgetmode.Add(new Budgetmode
                {
                    BudgetTypeId = num,
                    list = _database.BudgetTypes.Where(x => x.Id == num).FirstOrDefault().Name,
                    Budget = hh.Select(x => x.TotalBudgetCache).Sum()
                });
            }





            _projectDetailDto.BudgetDetail = _list_result;
            _projectDetailDto.Budgetmode = Budgetmode;
            result.data = _List_PlanMonthlyOperation;
            result.Persons = _Team;
            result.Detail = _projectDetailDto;
            return result;
        }

        public ViewPlanActivityOperationPeriodByPlanCoreDto EditPlanActivityOperationPeriodResult(int PlanActivityId)
        {
            var result = new ViewPlanActivityOperationPeriodByPlanCoreDto();
            var _List_PlanMonthlyOperation = new List<PlanMonthlyOperationDto>();

            var PlanMonthlyOperations = _database.PlanMonthlyOperations.Where(x => x.Id == PlanActivityId && x.Active).Include(x => x.PlanFiles).ToList();
            var PlanActivitiesId = PlanMonthlyOperations.Select(x => x.PlanActivityId).FirstOrDefault();
            var PlanActivities = _database.PlanActivities.Where(x => x.Id == PlanActivitiesId && x.Active).Include(x => x.PlanMonthlyOperations).Include(x => x.PlanItems).Include(x => x.ResponsiblePeople).ToList();
            var _Team = new List<Team>();

            var _projectDetailDto = new projectDetailAddBugetDto();
            var plancoreId = PlanActivities.Select(x => x.PlanCoreId).FirstOrDefault();
            var _PlanCores = _database.PlanCores.Where(x => x.Id == plancoreId).FirstOrDefault();
            _projectDetailDto.Name = PlanActivities.Select(x => x.Name).FirstOrDefault();
            _projectDetailDto.FiscalYear_main = PlanActivities.Select(x => x.FiscalYear).FirstOrDefault();
            _projectDetailDto.ProjectName = _PlanCores.Name;
            _projectDetailDto.step = PlanMonthlyOperations.Select(x => x.Name).FirstOrDefault();
            _projectDetailDto.Weight = PlanMonthlyOperations.Select(x => x.Weight).FirstOrDefault();
            _projectDetailDto.PlanName = _database.PlanTypes.Where(x => x.Id == _PlanCores.PlanTypeId).FirstOrDefault().Name;
            _projectDetailDto.Department = _database.Departments.Where(x => x.Id == _PlanCores.DepartmentId).FirstOrDefault().Name;
            var PlanA = PlanActivities.SelectMany(x => x.ResponsiblePeople).ToList();
            int index = 0;
            foreach (var team_item in PlanA)
            {

                _Team.Add(new Team
                {
                    HrdepartmentName = team_item.HrdepartmentName,
                    Position = index == 0 ? "ผู้รับผิดชอบโครงการ (Project Manager)" : "ผู้ร่วมโครงการ (Team)",
                    Name = team_item.Name,
                });
                index++;
            }

            foreach (var s2 in PlanMonthlyOperations)
            {
                _List_PlanMonthlyOperation.Add(new PlanMonthlyOperationDto
                {
                    Id = s2.Id,
                    Name = s2.Name,
                    Active = s2.Active,
                    FiscalYear = s2.FiscalYear,
                    January = s2.January,
                    February = s2.February,
                    March = s2.March,
                    April = s2.April,
                    May = s2.May,
                    June = s2.June,
                    July = s2.July,
                    August = s2.August,
                    September = s2.September,
                    October = s2.October,
                    November = s2.November,
                    December = s2.December,
                    Weight = s2.Weight,
                    PlanActivityId = s2.PlanActivityId,
                    ResultJanuary = s2.ResultJanuary,
                    ResultFebruary = s2.ResultFebruary,
                    ResultMarch = s2.ResultMarch,
                    ResultApril = s2.ResultApril,
                    ResultMay = s2.ResultMay,
                    ResultJune = s2.ResultJune,
                    ResultJuly = s2.ResultJuly,
                    ResultAugust = s2.ResultAugust,
                    ResultSeptember = s2.ResultSeptember,
                    ResultOctober = s2.ResultOctober,
                    ResultNovember = s2.ResultNovember,
                    ResultDecember = s2.ResultDecember,
                    DetailJanuary = s2.DetailJanuary,
                    DetailFebruary = s2.DetailFebruary,
                    DetailMarch = s2.DetailMarch,
                    DetailApril = s2.DetailApril,
                    DetailMay = s2.DetailMay,
                    DetailJune = s2.DetailJune,
                    DetailJuly = s2.DetailJuly,
                    DetailAugust = s2.DetailAugust,
                    DetailSeptember = s2.DetailSeptember,
                    DetailOctober = s2.DetailOctober,
                    DetailNovember = s2.DetailNovember,
                    DetailDecember = s2.DetailDecember,
                    ParentPlanMonthlyOperationId = s2.ParentPlanMonthlyOperationId
                });
            }
            result.data = _List_PlanMonthlyOperation;
            result.Detail = _projectDetailDto;
            result.Persons = _Team;
            return result;
        }

        public PerformanceIndicatorData ViewPerformanceIndicatorByPlanActivityList(int PlanCoreId)
        {
            var PerformanceIndicatorData = new PerformanceIndicatorData();
            var data_result = new List<PerformanceIndicatorDetail>();
            var planCore = _database.PlanCores.Where(x => x.Id == PlanCoreId && x.Active).Include(x => x.PerformanceIndicators).Include(x => x.ResponsiblePeople).Include(x => x.PlanActivities).ToList();

            foreach (var s2 in planCore)
            {


                foreach (var s1 in s2.PlanActivities)
                {

                    var result = new List<PerformanceIndicatorDto>();
                    var data = _database.PerformanceIndicators.Where(x => x.PlanActivityId == s1.Id).ToList();
                    foreach (var item in data)
                    {

                        result.Add(new PerformanceIndicatorDto
                        {
                            Id = item.Id,
                            Name = item.Name,
                            FiscalYear = item.FiscalYear,
                            Active = item.Active,
                            TargetValueQ1 = item.TargetValueQ1,
                            TargetUnit = item.TargetUnit,
                            Detail = item.Detail,
                            PlanActivityId = item.PlanActivityId,
                            TargetValueQ2 = item.TargetValueQ2,
                            TargetValueQ3 = item.TargetValueQ3,
                            TargetValueQ4 = item.TargetValueQ4,
                            PlanCoreId = item.PlanCoreId,
                            StrategicIndicatorId = item.StrategicIndicatorId,
                            ResultQ1 = item.ResultQ1,
                            ResultQ2 = item.ResultQ2,
                            ResultQ3 = item.ResultQ3,
                            ResultQ4 = item.ResultQ4,
                            DetailQ1 = item.DetailQ1,
                            DetailQ2 = item.DetailQ2,
                            DetailQ3 = item.DetailQ3,
                            DetailQ4 = item.DetailQ4,
                            SupportFactorQ1 = item.SupportFactorQ1,
                            SupportFactorQ2 = item.SupportFactorQ2,
                            SupportFactorQ3 = item.SupportFactorQ3,
                            SupportFactorQ4 = item.SupportFactorQ4,
                            ObstacleQ1 = item.ObstacleQ1,
                            ObstacleQ2 = item.ObstacleQ2,
                            ObstacleQ3 = item.ObstacleQ3,
                            ObstacleQ4 = item.ObstacleQ4,
                            ParentPerformanceIndicatorId = item.ParentPerformanceIndicatorId,
                            January = item.January,
                            February = item.February,
                            March = item.March,
                            April = item.April,
                            May = item.May,
                            June = item.June,
                            July = item.July,
                            August = item.August,
                            September = item.September,
                            October = item.October,
                            November = item.November,
                            December = item.December,
                            ResultJanuary = item.ResultJanuary,
                            ResultFebruary = item.ResultFebruary,
                            ResultMarch = item.ResultMarch,
                            ResultApril = item.ResultApril,
                            ResultMay = item.ResultMay,
                            ResultJune = item.ResultJune,
                            ResultJuly = item.ResultJuly,
                            ResultAugust = item.ResultAugust,
                            ResultSeptember = item.ResultSeptember,
                            ResultOctober = item.ResultOctober,
                            ResultNovember = item.ResultNovember,
                            ResultDecember = item.ResultDecember,
                            SupportFactorJanuary = item.SupportFactorJanuary,
                            SupportFactorFebruary = item.SupportFactorFebruary,
                            SupportFactorMarch = item.SupportFactorMarch,
                            SupportFactorApril = item.SupportFactorApril,
                            SupportFactorMay = item.SupportFactorMay,
                            SupportFactorJune = item.SupportFactorJune,
                            SupportFactorJuly = item.SupportFactorJuly,
                            SupportFactorAugust = item.SupportFactorAugust,
                            SupportFactorSeptember = item.SupportFactorSeptember,
                            SupportFactorOctober = item.SupportFactorOctober,
                            SupportFactorNovember = item.SupportFactorNovember,
                            SupportFactorDecember = item.SupportFactorDecember,
                            DetailJanuary = item.DetailJanuary,
                            DetailFebruary = item.DetailFebruary,
                            DetailMarch = item.DetailMarch,
                            DetailApril = item.DetailApril,
                            DetailMay = item.DetailMay,
                            DetailJune = item.DetailJune,
                            DetailJuly = item.DetailJuly,
                            DetailAugust = item.DetailAugust,
                            DetailSeptember = item.DetailSeptember,
                            DetailOctober = item.DetailOctober,
                            DetailNovember = item.DetailNovember,
                            DetailDecember = item.DetailDecember,
                            ObstacleJanuary = item.ObstacleJanuary,
                            ObstacleFebruary = item.ObstacleFebruary,
                            ObstacleMarch = item.ObstacleMarch,
                            ObstacleApril = item.ObstacleApril,
                            ObstacleMay = item.ObstacleMay,
                            ObstacleJune = item.ObstacleJune,
                            ObstacleJuly = item.ObstacleJuly,
                            ObstacleAugust = item.ObstacleAugust,
                            ObstacleSeptember = item.ObstacleSeptember,
                            ObstacleOctober = item.ObstacleOctober,
                            ObstacleNovember = item.ObstacleNovember,
                            ObstacleDecember = item.ObstacleDecember,
                        });


                    }
                    data_result.Add(new PerformanceIndicatorDetail
                    {
                        Name = s1.Name,
                        data = result
                    });

                }
            }
            var budget_list = calbudget(planCore.SelectMany(x => x.PlanActivities).ToList());
            PerformanceIndicatorData.BugetDetail = budget_list.Budget;
            PerformanceIndicatorData.PerformanceIndicatorDetail = data_result;
            PerformanceIndicatorData.ResponsiblePeople = ResponsiblePeopleData(planCore.SelectMany(x => x.ResponsiblePeople).ToList());
            PerformanceIndicatorData.budgetmodes = budget_list.budgetmodes;
            return PerformanceIndicatorData;
        }

        public calBudgetDetail calbudget(ICollection<PlanActivity> planActivity)
        {
            var calBudgetDetail = new calBudgetDetail();
            var _list_result = new ViewPlanForActivityByPlanTypeBudgetTypeTable();
            var _list_main = new List<ViewPlanForActivityByPlanTypeBudgetTypeTable>();
            var b_num = new List<int>();
            var b_list = new List<butgetW>();
            foreach (var s1 in planActivity)
            {


                decimal _TotalBudgetCache = 0;
                decimal _TotalAmount = 0;
                decimal _NetAmount = 0;
                decimal _NetBudgetCache = 0;
                decimal _UsedBudgetCache = 0;
                decimal _RemainBudgetPlanView = 0;
                decimal _TotalBudget = 0;
                var PlanItems = _database.PlanItems.Where(x => x.PlanActivityId == s1.Id && x.Active).Include(x => x.SummaryStatementCaches).ToList();
                var _list = new List<ViewPlanForActivityByPlanTypeBudgetTypeTable>();
                foreach (var item in PlanItems)
                {

                    //_NetBudgetCache = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().NetBudgetPlanView;
                    //_UsedBudgetCache = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().UsedBudgetPlanView;
                    //_RemainBudgetPlanView = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().RemainBudgetPlanView;
                    //_TotalBudgetCache = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().TotalBudgetPlanView;
                    _list.Add(new ViewPlanForActivityByPlanTypeBudgetTypeTable
                    {
                        Id = item.Id,
                        Name = item.Name,
                        FiscalYear = item.FiscalYear,
                        Unit = item.Unit,
                        BudgetTypeId = item.BudgetTypeId,
                        TotalBudgetCache = item.SummaryStatementCaches.Count > 0 ? item.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().TotalBudgetPlanView : 0,
                        NetBudgetCache = item.SummaryStatementCaches.Count > 0 ? item.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().NetBudgetPlanView : 0,
                        UsedBudgetCache = item.SummaryStatementCaches.Count > 0 ? item.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().UsedBudgetPlanView : 0,
                        RemainBudgetCache = item.SummaryStatementCaches.Count > 0 ? item.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().RemainBudgetPlanView : 0,
                    });
                    b_num.Add((int)item.BudgetTypeId);
                    b_list.Add(new butgetW
                    {
                        BudgetTypeId = (int)item.BudgetTypeId,
                        TotalBudgetCache = item.SummaryStatementCaches.Count > 0 ? item.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().TotalBudgetPlanView : 0

                    });

                }
                _list_main.Add(new ViewPlanForActivityByPlanTypeBudgetTypeTable
                {
                    Id = s1.Id,
                    Name = s1.Name,
                    FiscalYear = s1.FiscalYear,
                    TotalBudget = _list.Sum(x => x.TotalBudget),
                    TotalBudgetCache = _list.Sum(x => x.TotalBudgetCache),
                    NetBudgetCache = _list.Sum(x => x.NetBudgetCache),
                    UsedBudgetCache = _list.Sum(x => x.UsedBudgetCache),
                    RemainBudgetCache = _list.Sum(x => x.RemainBudgetCache),

                });




            }

            var Budgetmode = new List<Budgetmode>();


            var bb = b_num.Distinct().ToArray();
            foreach (var num in bb)
            {

                var hh = b_list.Where(x => x.BudgetTypeId == num).ToList();
                Budgetmode.Add(new Budgetmode
                {
                    BudgetTypeId = num,
                    list = _database.BudgetTypes.Where(x => x.Id == num).FirstOrDefault().Name,
                    Budget = hh.Select(x => x.TotalBudgetCache).Sum()
                });
            }



            _list_result.TotalBudget = _list_main.Sum(x => x.TotalBudget);
            _list_result.TotalBudgetCache = _list_main.Sum(x => x.TotalBudgetCache);
            _list_result.NetBudgetCache = _list_main.Sum(x => x.NetBudgetCache);
            _list_result.UsedBudgetCache = _list_main.Sum(x => x.UsedBudgetCache);
            _list_result.RemainBudgetCache = _list_main.Sum(x => x.RemainBudgetCache);

            calBudgetDetail.Budget = _list_result;
            calBudgetDetail.budgetmodes = Budgetmode;

            return calBudgetDetail;
        }


        public List<Team> ResponsiblePeopleData(ICollection<ResponsiblePerson> ResponsiblePerson)
        {
            var _Team = new List<Team>();
            int index = 0;
            foreach (var team_item in ResponsiblePerson)
            {

                _Team.Add(new Team
                {
                    HrdepartmentName = team_item.HrdepartmentName,
                    Position = index == 0 ? "ผู้รับผิดชอบโครงการ (Project Manager)" : "ผู้ร่วมโครงการ (Team)",
                    Name = team_item.Name,
                });
                index++;
            }
            return _Team;
        }

        public List<PlanCoreApproveStatusReportResponse> PlanCoreApproveStatusReport(PlanCoreApproveStatusReportRequest request)
        {
            decimal resTotalBudget = 0.00m;
            decimal total_tBudget = 0.00m;
            decimal total_pTypeB = 0.00m;
            decimal total_devB = 0.00m;
            int count = 1;
            var result = new List<PlanCoreApproveStatusReportResponse>();
            var data = _database.PlanCores.Where(x => x.Active && x.FiscalYear == request.fiscalYear && (request.depId != 0 ? x.DepartmentId == request.depId : true) && (request.planTypeId != 0 ? x.PlanTypeId == request.planTypeId : true) && (request.projectName != "" ? x.Name.Contains(request.projectName) : true) && (request.status != 0 ? (request.status == 1 ? x.IsApproved : !x.IsApproved) : true)).Include(x => x.PerformanceIndicators).Include(x => x.PlanActivities).Include(x => x.ResponsiblePeople).ToList();
            var aListNum = aList(request.fiscalYear);
            decimal pTypeB = 0.00m;
            var tBudget = aListNum.Select(x => x.TotalBudget).Sum();
            foreach (var pCore in data)
            {


                decimal pcBudget = calbudget(pCore.PlanActivities).Budget.TotalBudgetCache;
                resTotalBudget += pcBudget;
                decimal tb = tBudget != 0.00m ? pcBudget / tBudget : 0.00m;


                pTypeB = aListNum.Where(c => c.PlanTypeId == pCore.PlanTypeId).Sum(c => c.TotalBudget);
                decimal pt = pTypeB != 0.00m ? pcBudget / pTypeB : 0.00m;
                decimal devB = 0.00m;
                devB = aListNum.Where(c => c.DepartmentId == pCore.DepartmentId).Sum(c => c.TotalBudget);
                decimal db = devB != 0.00m ? pcBudget / devB : 0.00m;
                result.Add(new PlanCoreApproveStatusReportResponse
                {
                    Id = pCore.Id,
                    Approved = pCore.IsApproved,
                    Name = pCore.Name,
                    budget = pcBudget,
                    Weight_organization = decimal.Round(tb, 4),
                    Weight_plan = decimal.Round(pt, 4),
                    Weight_departmant = decimal.Round(db, 4),
                    PlanType = _database.PlanTypes.Where(x => x.Id == pCore.PlanTypeId).FirstOrDefault().Name,
                    departmant = _database.Departments.Where(x => x.Id == pCore.DepartmentId).FirstOrDefault().Name,
                    ResponsiblePerson = pCore.ResponsiblePeople.Count > 0 ? pCore.ResponsiblePeople.Select(x => x.Name).FirstOrDefault() : "",
                });
            }
            return result;
        }

        public List<aListModel> aList(int fiscalYear)
        {
            var result = new List<aListModel>();
            var PlanCores = _database.PlanCores.Where(x => x.Active && x.FiscalYear == fiscalYear).ToList();
            decimal total = 0;
            foreach (var s1 in PlanCores)
            {
                result.Add(new aListModel
                {
                    Id = s1.Id,
                    DepartmentId = s1.DepartmentId,
                    PlanTypeId = s1.PlanTypeId,
                    TotalBudget = calbudget(s1.PlanActivities).Budget.TotalBudgetCache

                });

            }
            return result;
        }

        public PlanCoreListDto GetEditPlan(int PlanCoreId)
        {
            var result = new PlanCoreListDto();
            var data = _database.PlanCores.Where(x => x.Id == PlanCoreId).Include(x => x.PerformanceIndicators).Include(x => x.Strategies).Include(x => x.ResponsiblePeople).ToList();
            foreach (var item in data)
            {
                result.Id = item.Id;
                result.Name = item.Name;
                result.FiscalYear = item.FiscalYear;
                result.Code = item.Code;
                result.Active = item.Active;
                result.DepartmentId = item.DepartmentId;
                result.PlanTypeId = item.PlanTypeId;
                result.ReferenceOldId = item.ReferenceOldId;
                result.Detail = item.Detail;
                result.Objective = item.Objective;
                result.Benefit = item.Benefit;
                result.PlanCategoryEnum = item.PlanCategoryEnum;
                result.ContinuousStatusEnum = item.ContinuousStatusEnum;
                result.FundTypeId = item.FundTypeId;
                result.CreateDate = item.CreateDate;
                result.CreateByStaffId = item.CreateByStaffId;
                result.PrinciplePlanTagId = item.PrinciplePlanTagId;
                result.Weight = item.Weight;
                result.IsApproved = item.IsApproved;
                result.CodeNumber = item.CodeNumber;
                result.ProjectDuration = item.ProjectDuration;
                result.MonthStart = item.MonthStart;
                result.MonthEnd = item.MonthEnd;
                result.TargetIdListValue = item.TargetIdListValue;
                result.OtherTarget = item.OtherTarget;
                result.ExpenseTypeEnum = item.ExpenseTypeEnum;
                result.Output = item.Output;
                result.Outcome = item.Outcome;
                result.FundSourceEnum = item.FundCategoryEnum;
                result.FundCategoryEnum = item.FundCategoryEnum;
                var ResponsiblePerson = new List<ResponsiblePerson>();
                var PerformanceIndicator = new List<PerformanceIndicator>();
                foreach (var s in item.ResponsiblePeople)
                {
                    ResponsiblePerson.Add(new narit_mis_api.Models.ResponsiblePerson
                    {
                        Id = s.Id,
                        Name = s.Name,
                        Active = s.Active,
                        FiscalYear = s.FiscalYear,
                        StaffId = s.StaffId,
                        PlanPersonResponsibilityEnum = s.PlanPersonResponsibilityEnum,
                        PlanCoreId = s.PlanCoreId,
                        PlanActivityId = s.PlanActivityId,
                        HrdepartmentId = s.HrdepartmentId,
                        HrdepartmentName = s.HrdepartmentName,
                    });
                }



                result.ResponsiblePeople = ResponsiblePerson;

                foreach (var s in item.PerformanceIndicators)
                {
                    if (s.Active == true)
                    {
                        PerformanceIndicator.Add(new narit_mis_api.Models.PerformanceIndicator
                        {
                            Id = s.Id,
                            Name = s.Name,
                            Active = s.Active,
                            FiscalYear = s.FiscalYear,

                        });
                    }
                }


                result.PerformanceIndicators = PerformanceIndicator;
                
            }
            return result;
        }

        public List<PrinciplePlanTagDto> EditPlanPrinciplePlanTags()
        {
            var list1 = new List<PrinciplePlanTagDto>();

            var PrinciplePlanTags = _database.PrinciplePlanTags.ToList();

            var data = PrinciplePlanTags.Where(x => x.ParentPrinciplePlanTagId == null).ToList();
            foreach (var item in data)
            {
                var list2 = new List<PrinciplePlanTagDto>();
                foreach (var s in PrinciplePlanTags)
                {
                    if (s.ParentPrinciplePlanTagId == item.Id)
                    {
                        var list3 = new List<PrinciplePlanTagDto>();
                        foreach (var s1 in PrinciplePlanTags)
                        {
                            if (s1.ParentPrinciplePlanTagId == s.Id)
                            {
                                list3.Add(new PrinciplePlanTagDto
                                {
                                    Id = s1.Id,
                                    Name = s1.Name,
                                    Active = s1.Active,
                                    Weight = s1.Weight,
                                    ParentPrinciplePlanTagId = s1.ParentPrinciplePlanTagId
                                    // PrinciplePlanTag { get; set; }
                                });
                            }

                        }
                        list2.Add(new PrinciplePlanTagDto
                        {
                            Id = s.Id,
                            Name = s.Name,
                            Active = s.Active,
                            Weight = s.Weight,
                            ParentPrinciplePlanTagId = s.ParentPrinciplePlanTagId,
                            PrinciplePlanTag = list3
                        });
                    }
                }
                list1.Add(new PrinciplePlanTagDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Active = item.Active,
                    Weight = item.Weight,
                    ParentPrinciplePlanTagId = item.ParentPrinciplePlanTagId,
                    PrinciplePlanTag = list2
                });



            }

            return list1;
        }

        public List<StrategyDto> EditPlanStrategicIndicatorServ(int fiscalYear)
        {
            var list1 = new List<StrategyDto>();
            var Strategies = _database.Strategies.Where(x => x.FiscalYear == fiscalYear && x.Active).ToList();
            var data = Strategies.Where(x => x.ParentStrategyId == null).ToList();
            foreach (var item in data)
            {
                var list2 = new List<StrategyDto>();
                foreach (var s in Strategies)
                {
                    if (s.ParentStrategyId == item.Id)
                    {
                        list2.Add(new StrategyDto
                        {
                            Id = s.Id,
                            Name = s.Name,
                            Active = s.Active,
                            ParentStrategyId = s.ParentStrategyId
                            // PrinciplePlanTag { get; set; }
                        });
                    }
                }
                list1.Add(new StrategyDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Active = item.Active,
                    ParentStrategyId = item.ParentStrategyId,
                    Strategy = list2
                });



            }

            return list1;
        }

        public List<PlanTypeTreeDto> PlanTypeTree(int fiscalYear)
        {
            var list1 = new List<PlanTypeTreeDto>();
            var PlanTypes = _database.PlanTypes.Where(x => x.FiscalYear == fiscalYear && x.Active).ToList();
            var data = PlanTypes.Where(x => x.ParentPlanTypeId == null).ToList();
            foreach (var item in data)
            {
                var list2 = new List<PlanTypeTreeDto>();
                foreach (var s in PlanTypes)
                {
                    if (s.ParentPlanTypeId == item.Id)
                    {
                        list2.Add(new PlanTypeTreeDto
                        {
                            Id = s.Id,
                            Name = s.Name,
                            Active = s.Active,
                            ParentPlanTypeId = s.ParentPlanTypeId
                            // PrinciplePlanTag { get; set; }
                        });
                    }
                }
                list1.Add(new PlanTypeTreeDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Active = item.Active,
                    ParentPlanTypeId = item.ParentPlanTypeId,
                    PlanType = list2
                });



            }

            return list1;
        }

        //public List<PerformanceIndicatorsDto> EditPerformanceIndicator(int fiscalYear)
        //{
        //    var list1 = new List<PerformanceIndicatorsDto>();
        //    var PerformanceIndicators = _database.PerformanceIndicators.Where(x => x.FiscalYear == fiscalYear && x.Active).ToList();
        //    var data = PerformanceIndicators.Where(x => x.ParentPerformanceIndicatorId == null).ToList();
        //    foreach (var item in data)
        //    {
        //        var list2 = new List<PerformanceIndicatorsDto>();
        //        foreach (var s in PerformanceIndicators)
        //        {
        //            if (s.ParentPerformanceIndicatorId == item.Id)
        //            {
        //                list2.Add(new PerformanceIndicatorsDto
        //                {
        //                    Id = s.Id,
        //                    Name = s.Name,
        //                    FiscalYear = s.FiscalYear,
        //                    Active = s.Active,
        //                    TargetValueQ1 = s.TargetValueQ1,
        //                    TargetUnit = s.TargetUnit,
        //                    Detail = s.Detail,
        //                    PlanActivityId = s.PlanActivityId,

        //                });
        //            }
        //        }
        //        list1.Add(new PerformanceIndicatorsDto
        //        {
        //            Id = item.Id,
        //            Name = item.Name,
        //            FiscalYear = item.FiscalYear,
        //            Active = item.Active,
        //            TargetValueQ1 = item.TargetValueQ1,
        //            TargetUnit = item.TargetUnit,
        //            Detail = item.Detail,
        //            PlanActivityId = item.PlanActivityId,
        //            PerformanceIndicators = list2
        //        });



        //    }

        //    return list1;
        //}

        public List<StrategicIndicatorResponse> EditPerformanceIndicator(int FiscalYear)
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
        //public List<StrategicIndicatorResponse> StrategicIndicatorSetupByFiscalYear(int FiscalYear)
        //{
        //    var result = new List<StrategicIndicatorResponse>();
        //    var data = _database.StrategicIndicators.Where(x => x.FiscalYear == FiscalYear).ToList();
        //    foreach (var item in data)
        //    {
        //        result.Add(new StrategicIndicatorResponse
        //        {
        //            Id = item.Id,
        //            Name = item.Name,
        //            FiscalYear = item.FiscalYear,
        //            Active = item.Active,
        //            ParentStrategicIndicatorId = item.ParentStrategicIndicatorId,
        //            Unit = item.Unit,
        //            Amount = item.Amount,
        //            Weight = item.Weight

        //        });
        //    }
        //    return result;
        //}

        public SecBaseResponse PlanCoreAddUpdate(PlanCoreListDto _PlanCore_request)
        {
            var _PlanCore = new PlanCore();

            _PlanCore.Id = _PlanCore_request.Id;
            _PlanCore.Name = _PlanCore_request.Name;
            _PlanCore.FiscalYear = _PlanCore_request.FiscalYear;
            _PlanCore.Active = _PlanCore_request.Active;

            _PlanCore.DepartmentId = _PlanCore_request.DepartmentId;
            _PlanCore.PlanTypeId = _PlanCore_request.PlanTypeId;
            _PlanCore.ReferenceOldId = _PlanCore_request.ReferenceOldId;
            _PlanCore.Detail = _PlanCore_request.Detail;
            _PlanCore.Objective = _PlanCore_request.Objective;
            _PlanCore.Benefit = _PlanCore_request.Benefit;
            _PlanCore.PlanCategoryEnum = _PlanCore_request.PlanCategoryEnum;
            _PlanCore.ContinuousStatusEnum = _PlanCore_request.ContinuousStatusEnum;
            _PlanCore.FundTypeId = _PlanCore_request.FundTypeId;
            _PlanCore.CreateDate = _PlanCore_request.CreateDate;
            _PlanCore.CreateByStaffId = _PlanCore_request.CreateByStaffId;
            _PlanCore.PrinciplePlanTagId = _PlanCore_request.PrinciplePlanTagId;
            _PlanCore.Weight = _PlanCore_request.Weight;
            _PlanCore.IsApproved = _PlanCore_request.IsApproved;
            _PlanCore.CodeNumber = _PlanCore_request.CodeNumber;
            _PlanCore.ProjectDuration = _PlanCore_request.ProjectDuration;
            _PlanCore.MonthStart = _PlanCore_request.MonthStart;
            _PlanCore.MonthEnd = _PlanCore_request.MonthEnd;
            _PlanCore.TargetIdListValue = _PlanCore_request.TargetIdListValue;
            _PlanCore.OtherTarget = _PlanCore_request.OtherTarget;
            _PlanCore.ExpenseTypeEnum = _PlanCore_request.ExpenseTypeEnum;
            _PlanCore.Output = _PlanCore_request.Output;
            _PlanCore.Outcome = _PlanCore_request.Outcome;
            _PlanCore.FundSourceEnum = _PlanCore_request.FundSourceEnum;
            _PlanCore.FundCategoryEnum = _PlanCore_request.FundCategoryEnum;


            _database.Entry(_PlanCore).State = _PlanCore.Id == 0 ?
                                      EntityState.Added :
                                      EntityState.Modified;


            var result = _database.SaveChanges();
            var response = new SecBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = _PlanCore.Id == 0 ? "update" : "insert";
            return response;
        }

        public List<DepartmentListDto> GetDepartments(int fiscalYear)
        {
            var list1 = new List<DepartmentListDto>();
            var Departments = _database.Departments.Where(x => x.FiscalYear == fiscalYear && x.Active).ToList();
            var data = Departments.Where(x => x.ParentDepartmentId == null).ToList();
            foreach (var item in data)
            {
                var list2 = new List<DepartmentListDto>();
                foreach (var s in Departments)
                {
                    if (s.ParentDepartmentId == item.Id)
                    {
                        list2.Add(new DepartmentListDto
                        {
                            Id = s.Id,
                            Name = s.Name,
                            FiscalYear = s.FiscalYear,
                            Active = s.Active,
                            ParentDepartmentId = s.ParentDepartmentId,
                            ReferenceOldId = s.ReferenceOldId,

                        });
                    }
                }
                list1.Add(new DepartmentListDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Active = item.Active,
                    ParentDepartmentId = item.ParentDepartmentId,
                    ReferenceOldId = item.ReferenceOldId,
                    ParentDepartment = list2
                });



            }

            return list1;
        }

        public List<ResponsiblePerson> getResponsiblePerson()
        {
            throw new NotImplementedException();
        }

        public SecBaseResponse PlanItemByBudgetTypeAndPlanTypeReport(int fiscalYear, int month, int planTypeId, int budgetTypeId)
        {

            decimal _NetBudgetCache = 0;

            var PlanTypes = _database.PlanTypes.Where(x => x.FiscalYear == fiscalYear && x.Active && x.Id == planTypeId).Include(x => x.PlanCores).Include(x => x.InverseParentPlanType).FirstOrDefault();
            foreach (var s in PlanTypes.InverseParentPlanType)
            {
                var planCore = _database.PlanCores.Where(x => x.PlanTypeId == s.Id && x.Active).Include(x => x.PlanActivities).ToList();
                _NetBudgetCache += calbudget(planCore.SelectMany(x => x.PlanActivities).ToList()).Budget.NetBudgetCache;

            }

            // var v1 = _TotalBudgetCache;

            return new SecBaseResponse();
        }

        public List<ViewPlanForActivityByPlanTypeBudgetTypeTable> PlanReportByPlanType(int fiscalYear)
        {
            var list1 = new List<ViewPlanForActivityByPlanTypeBudgetTypeTable>();
            var PlanTypes = _database.PlanTypes.Where(x => x.FiscalYear == fiscalYear && x.Active).ToList();
            var data = PlanTypes.Where(x => x.ParentPlanTypeId == null).ToList();
            foreach (var item in data)
            {
                var list2 = new List<ViewPlanForActivityByPlanTypeBudgetTypeTable>();
                foreach (var s in PlanTypes)
                {
                    if (s.ParentPlanTypeId == item.Id)
                    {
                        var planCore = _database.PlanCores.Where(x => x.PlanTypeId == s.Id).Include(x => x.PlanActivities);
                        var d = calbudget(planCore.SelectMany(x => x.PlanActivities).ToList());
                        list2.Add(new ViewPlanForActivityByPlanTypeBudgetTypeTable
                        {
                            Id = s.Id,
                            Name = s.Name,
                            FiscalYear = s.FiscalYear,
                            TotalBudgetCache = d.Budget.TotalBudgetCache,
                            NetBudgetCache = d.Budget.NetBudgetCache,
                            UsedBudgetCache = d.Budget.UsedBudgetCache,
                            RemainBudgetCache = d.Budget.RemainBudgetCache,
                            TotalBudget = d.Budget.TotalBudget,
                            NetBudget = d.Budget.NetBudget,

                        });
                    }
                }
                list1.Add(new ViewPlanForActivityByPlanTypeBudgetTypeTable
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    TotalBudgetCache = list2.Sum(x => x.TotalBudgetCache),
                    NetBudgetCache = list2.Sum(x => x.NetBudgetCache),
                    UsedBudgetCache = list2.Sum(x => x.UsedBudgetCache),
                    RemainBudgetCache = list2.Sum(x => x.RemainBudgetCache),
                    TotalBudget = list2.Sum(x => x.TotalBudget),
                    NetBudget = list2.Sum(x => x.NetBudget),
                    subdata = list2
                });



            }
            return list1;
        }

        public List<ViewPlanForActivityByPlanTypeBudgetTypeTable> PlanReportByDepartment(int fiscalYear)
        {
            bool one_check = true;
            var list1 = new List<ViewPlanForActivityByPlanTypeBudgetTypeTable>();
            var Departments = _database.Departments.Where(x => x.FiscalYear == fiscalYear && x.Active).ToList();
            var data = Departments.Where(x => x.ParentDepartmentId == null).ToList();
            foreach (var item in data)
            {

                var list2 = new List<ViewPlanForActivityByPlanTypeBudgetTypeTable>();
                foreach (var s in Departments)
                {
                    var planCore = _database.PlanCores.Where(x => x.DepartmentId == s.Id).Include(x => x.PlanActivities);
                    var d = calbudget(planCore.SelectMany(x => x.PlanActivities).ToList());
                    if (s.ParentDepartmentId == item.Id)
                    {
                        list2.Add(new ViewPlanForActivityByPlanTypeBudgetTypeTable
                        {
                            Id = s.Id,
                            Name = s.Name,
                            FiscalYear = s.FiscalYear,
                            TotalBudgetCache = d.Budget.TotalBudgetCache,
                            NetBudgetCache = d.Budget.NetBudgetCache,
                            UsedBudgetCache = d.Budget.UsedBudgetCache,
                            RemainBudgetCache = d.Budget.RemainBudgetCache,
                            TotalBudget = d.Budget.TotalBudget,
                            NetBudget = d.Budget.NetBudget,
                            PlanTypeId = planCore.Select(x => x.PlanTypeId).FirstOrDefault()
                        });
                    }
                }


                if (one_check == true)
                {
                    one_check = false;
                    var b = list2.Select(x => x.PlanTypeId).FirstOrDefault();

                    var h = _database.PlanTypes.Where(x => x.Id == b).FirstOrDefault().ParentPlanTypeId;

                    decimal _TotalBudgetCache = 0;
                    decimal _TotalAmount = 0;
                    decimal _NetAmount = 0;
                    decimal _NetBudgetCache = 0;
                    decimal _UsedBudgetCache = 0;
                    decimal _RemainBudgetPlanView = 0;
                    decimal _TotalBudget = 0;

                    var PlanTypes = _database.PlanTypes.Where(x => x.FiscalYear == fiscalYear && x.Active && x.Id == h).Include(x => x.PlanCores).Include(x => x.InverseParentPlanType).FirstOrDefault();
                    foreach (var s in PlanTypes.InverseParentPlanType)
                    {
                        var planCore = _database.PlanCores.Where(x => x.PlanTypeId == s.Id && x.Active).Include(x => x.PlanActivities).ToList();
                        _TotalBudgetCache += calbudget(planCore.SelectMany(x => x.PlanActivities).ToList()).Budget.TotalBudgetCache;
                        _NetBudgetCache += calbudget(planCore.SelectMany(x => x.PlanActivities).ToList()).Budget.NetBudgetCache;
                        _UsedBudgetCache += calbudget(planCore.SelectMany(x => x.PlanActivities).ToList()).Budget.UsedBudgetCache;
                        _RemainBudgetPlanView += calbudget(planCore.SelectMany(x => x.PlanActivities).ToList()).Budget.RemainBudgetCache;
                    }


                    list1.Add(new ViewPlanForActivityByPlanTypeBudgetTypeTable
                    {
                        Id = item.Id,
                        Name = item.Name,
                        FiscalYear = item.FiscalYear,
                        TotalBudgetCache = _TotalBudgetCache,
                        NetBudgetCache = _NetBudgetCache,
                        UsedBudgetCache = _UsedBudgetCache,
                        RemainBudgetCache = _RemainBudgetPlanView,
                        //TotalBudget = list2.Sum(x => x.TotalBudget),
                        //NetBudget = list2.Sum(x => x.NetBudget),
                        subdata = list2
                    });
                }
                else
                {
                    list1.Add(new ViewPlanForActivityByPlanTypeBudgetTypeTable
                    {
                        Id = item.Id,
                        Name = item.Name,
                        FiscalYear = item.FiscalYear,
                        TotalBudgetCache = list2.Sum(x => x.TotalBudgetCache),
                        NetBudgetCache = list2.Sum(x => x.NetBudgetCache),
                        UsedBudgetCache = list2.Sum(x => x.UsedBudgetCache),
                        RemainBudgetCache = list2.Sum(x => x.RemainBudgetCache),
                        TotalBudget = list2.Sum(x => x.TotalBudget),
                        NetBudget = list2.Sum(x => x.NetBudget),
                        subdata = list2
                    });
                }



            }
            return list1;
        }

        public List<BudgetTypeCommonDto> PlanReportByBudgetType(int fiscalYear)
        {

            var list1 = new List<BudgetTypeCommonDto>();
            var Departments = _database.BudgetTypes.Where(x => x.FiscalYear == fiscalYear && x.Active).ToList();
            var data = Departments.Where(x => x.ParentBudgetTypeId == null && x.Active).ToList();
            foreach (var item in data)
            {
                var list2 = new List<BudgetTypeCommonDto>();
                foreach (var s in Departments)
                {
                    if (s.ParentBudgetTypeId == item.Id && item.Active == true)
                    {
                        var list3 = new List<BudgetTypeCommonDto>();
                        foreach (var s1 in Departments)
                        {
                            if (s1.ParentBudgetTypeId == s.Id && s.Active == true)
                            {
                                var list4 = new List<BudgetTypeCommonDto>();
                                foreach (var s2 in Departments)
                                {
                                    if (s2.ParentBudgetTypeId == s1.Id && s1.Active == true)
                                    {

                                        var PlanItem_cal = calPlanItem(s2.Id, fiscalYear);
                                        list4.Add(new BudgetTypeCommonDto
                                        {
                                            Id = s2.Id,
                                            Name = s2.Name,
                                            Active = s2.Active,
                                            FiscalYear = s2.FiscalYear,
                                            ParentBudgetTypeId = s2.ParentBudgetTypeId,
                                            ReferenceOldId = s2.ReferenceOldId,
                                            ExpenseTypeEnum = s2.ExpenseTypeEnum,
                                            GovExpenseTypeEnum = s2.GovExpenseTypeEnum,
                                            TotalBudgetCache = PlanItem_cal.TotalBudgetCache,
                                            NetBudgetCache = PlanItem_cal.NetBudgetCache,
                                            UsedBudgetCache = PlanItem_cal.UsedBudgetCache,
                                            RemainBudgetCache = PlanItem_cal.RemainBudgetCache,
                                            TotalBudget = PlanItem_cal.TotalBudget



                                        }); ;
                                    }

                                }

                                list3.Add(new BudgetTypeCommonDto
                                {
                                    Id = s1.Id,
                                    Name = s1.Name,
                                    Active = s1.Active,
                                    FiscalYear = s1.FiscalYear,
                                    ParentBudgetTypeId = s1.ParentBudgetTypeId,
                                    ReferenceOldId = s1.ReferenceOldId,
                                    ExpenseTypeEnum = s1.ExpenseTypeEnum,
                                    GovExpenseTypeEnum = s1.GovExpenseTypeEnum,
                                    TotalBudgetCache = list4.Sum(x => x.TotalBudgetCache),
                                    NetBudgetCache = list4.Sum(x => x.NetBudgetCache),
                                    UsedBudgetCache = list4.Sum(x => x.UsedBudgetCache),
                                    RemainBudgetCache = list4.Sum(x => x.RemainBudgetCache),
                                    TotalBudget = list4.Sum(x => x.TotalBudget),
                                    ParentBudgetType = list4
                                });
                            }

                        }
                        list2.Add(new BudgetTypeCommonDto
                        {
                            Id = s.Id,
                            Name = s.Name,
                            Active = s.Active,
                            FiscalYear = s.FiscalYear,
                            ParentBudgetTypeId = s.ParentBudgetTypeId,
                            ReferenceOldId = s.ReferenceOldId,
                            ExpenseTypeEnum = s.ExpenseTypeEnum,
                            GovExpenseTypeEnum = s.GovExpenseTypeEnum,
                            TotalBudgetCache = list3.Sum(x => x.TotalBudgetCache),
                            NetBudgetCache = list3.Sum(x => x.NetBudgetCache),
                            UsedBudgetCache = list3.Sum(x => x.UsedBudgetCache),
                            RemainBudgetCache = list3.Sum(x => x.RemainBudgetCache),
                            TotalBudget = list3.Sum(x => x.TotalBudget),
                            ParentBudgetType = list3
                        });
                    }
                }
                list1.Add(new BudgetTypeCommonDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Active = item.Active,
                    FiscalYear = item.FiscalYear,
                    ParentBudgetTypeId = item.ParentBudgetTypeId,
                    ReferenceOldId = item.ReferenceOldId,
                    ExpenseTypeEnum = item.ExpenseTypeEnum,
                    GovExpenseTypeEnum = item.GovExpenseTypeEnum,
                    TotalBudgetCache = list2.Sum(x => x.TotalBudgetCache),
                    NetBudgetCache = list2.Sum(x => x.NetBudgetCache),
                    UsedBudgetCache = list2.Sum(x => x.UsedBudgetCache),
                    RemainBudgetCache = list2.Sum(x => x.RemainBudgetCache),
                    TotalBudget = list2.Sum(x => x.TotalBudget),
                    ParentBudgetType = list2
                });



            }

            return list1;


        }

        public planItemCal calPlanItem(int Id, int fiscalYear)
        {
            var result = new planItemCal();
            decimal _TotalBudgetCache = 0;
            decimal _TotalAmount = 0;
            decimal _NetAmount = 0;
            decimal _NetBudgetCache = 0;
            decimal _UsedBudgetCache = 0;
            decimal _RemainBudgetPlanView = 0;
            decimal _TotalBudget = 0;
            var _list = new List<ViewPlanForActivityByPlanTypeBudgetTypeTable>();
            var PlanItems = _database.PlanItems.Where(x => x.BudgetTypeId == Id && x.Active && x.FiscalYear == fiscalYear).Include(x => x.SummaryStatementCaches).Include(x => x.MonthlyForecasts).ToList();
            foreach (var item in PlanItems)
            {

                //_NetBudgetCache = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().NetBudgetPlanView;
                //_UsedBudgetCache = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().UsedBudgetPlanView;
                //_RemainBudgetPlanView = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().RemainBudgetPlanView;
                //_TotalBudgetCache = _MonthlyForecasts.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().TotalBudgetPlanView;
                _list.Add(new ViewPlanForActivityByPlanTypeBudgetTypeTable
                {
                    Id = item.Id,
                    Name = item.Name,
                    FiscalYear = item.FiscalYear,
                    Unit = item.Unit,
                    BudgetTypeId = item.BudgetTypeId,
                    TotalBudgetCache = item.SummaryStatementCaches.Count > 0 ? item.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().TotalBudgetPlanView : 0,
                    NetBudgetCache = item.SummaryStatementCaches.Count > 0 ? item.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().NetBudgetPlanView : 0,
                    UsedBudgetCache = item.SummaryStatementCaches.Count > 0 ? item.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().UsedBudgetPlanView : 0,
                    RemainBudgetCache = item.SummaryStatementCaches.Count > 0 ? item.SummaryStatementCaches.Where(x => x.Active && x.Month == 10).SingleOrDefault().RemainBudgetPlanView : 0,

                    TotalBudget = item.MonthlyForecasts.Sum(x => x.Amount * x.BudgetPerPiece),
                    TotalAmount = item.MonthlyForecasts.Sum(x => x.Amount),
                    NetAmount = item.MonthlyForecasts.Sum(x => x.Amount),
                });


            }


            result.TotalBudgetCache = _list.Sum(x => x.TotalBudgetCache);
            result.NetBudgetCache = _list.Sum(x => x.NetBudgetCache);
            result.UsedBudgetCache = _list.Sum(x => x.UsedBudgetCache);
            result.RemainBudgetCache = _list.Sum(x => x.RemainBudgetCache);
            result.TotalBudget = _list.Sum(x => x.TotalBudget);

            return result;

        }

        public List<BudgetTypeCommonDto> PlanReportByStrategy(int fiscalYear)
        {
            throw new NotImplementedException();
        }

        public List<BudgetTransferFormResponse> ViewPlanItemBudgetTransferListForApprove(BudgetTransferFormRequest request)
        {
            var result = new List<BudgetTransferFormResponse>();
            var data = _database.BudgetTransferForms.Where(c => c.Active && (request.fiscalYear > 0 ? c.FiscalYear == request.fiscalYear : true) && (request.documentnumber != "" ? c.DocumentNumber == request.documentnumber : true)).Include(x => x.BudgetTransfers).ToList();
            foreach (var item in data)
            {
                result.Add(new BudgetTransferFormResponse
                {
                    Id = item.Id,
                    Name = item.Name,
                    Active = item.Active,
                    FiscalYear = item.FiscalYear,
                    Remark = item.Remark,
                    ApprovalStatusEnum = item.ApprovalStatusEnum,
                    RequestDate = item.RequestDate,
                    ApprovedDate = item.ApprovedDate,
                    DocumentNumber = item.DocumentNumber,
                    CreateDate = item.CreateDate,
                    CreateByStaffId = item.CreateByStaffId,
                    StatementCalculationDate = item.StatementCalculationDate,
                    WriteDate = item.WriteDate,
                    Inform = item.Inform,
                    Enclosures = item.Enclosures,
                    Purpose = item.Purpose,
                    RequesterName = item.RequesterName,
                    RequesterSignDate = item.RequesterSignDate,
                    UnitChiefName = item.UnitChiefName,
                    UnitChiefSignDate = item.UnitChiefSignDate,
                    BudgetCheckerName = item.BudgetCheckerName,
                    BudgetCheckerSignDate = item.BudgetCheckerSignDate,
                    Approver = item.Approver,
                    ApproverSignDate = item.ApproverSignDate,
                    StatementName = item.StatementName,
                    SeniorUnitChiefName = item.SeniorUnitChiefName,
                    FinanceName = item.FinanceName,
                    SeniorUnitChiefSignDate = item.SeniorUnitChiefSignDate,
                    FinanceSignDate = item.FinanceSignDate,
                    RequestDepartmentId = item.RequestDepartmentId,
                    UnitChiefStaffId = item.UnitChiefStaffId,
                    ApproverStaffId = item.ApproverStaffId,
                    PlanFormApprovalStatusEnum = item.PlanFormApprovalStatusEnum,
                    BudgetTransferTypeEnum = item.BudgetTransferTypeEnum,
                    BudgetTransfer = item.BudgetTransfers.Select(x => x.TransferBudget).FirstOrDefault(),
                });
            }
            return result;
        }

        public ViewGeneralExpenseMemoFormResponse ViewGeneralExpenseMemoFormListForApproval(ViewGeneralExpenseMemoFormLisRequest request)
        {
            var result = new ViewGeneralExpenseMemoFormResponse();
            var respone = new List<GeneralExpenseMemoDto>();
            var data = new List<GeneralExpenseMemoForm>();
            if (request.objId != 0)
            {
                switch (request.type)
                {
                    case 1:
                        data = GetByPlanTypeId(request.objId, 10, request.documentNumber, request.budgetVal);
                        break;
                    case 2:
                        data = GetByDepartmentId(request.objId, 10, request.documentNumber, request.budgetVal);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                data = GetByFiscalYear(request.FiscalYear, 10, request.documentNumber, request.budgetVal);
            }

            foreach (var item in data)
            {
                respone.Add(new GeneralExpenseMemoDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Active = item.Active,
                    FiscalYear = item.FiscalYear,
                    WriteDate = item.WriteDate,
                    Inform = item.Inform,
                    Enclosures = item.Enclosures,
                    Purpose = item.Purpose,
                    RequesterName = item.RequesterName,
                    RequesterSignDate = item.RequesterSignDate,
                    UnitChiefName = item.UnitChiefName,
                    UnitChiefSignDate = item.UnitChiefSignDate,
                    BudgetCheckerName = item.BudgetCheckerName,
                    BudgetCheckerSignDate = item.BudgetCheckerSignDate,
                    Approver = item.Approver,
                    ApproverSignDate = item.ApproverSignDate,
                    ApprovalStatusEnum = item.ApprovalStatusEnum,
                    DepartmentName = item.DepartmentName,
                    DepartmentId = item.DepartmentId,
                    PlanTypeName = item.PlanTypeName,
                    PlanTypeId = item.PlanTypeId,
                    PlanCoreName = item.PlanCoreName,
                    PlanCoreId = item.PlanCoreId,
                    BudgetTypeName = item.BudgetTypeName,
                    BudgetTypeId = item.BudgetTypeId,
                    PlanCoreRemainBudget = item.PlanCoreRemainBudget,
                    PlanCoreCode = item.PlanCoreCode,
                    ApprovedDate = item.ApprovedDate,
                    DocumentNumber = item.DocumentNumber,
                    StatementPayStatusEnum = item.StatementPayStatusEnum,
                    NetPayValue = item.NetPayValue,
                    CreateDate = item.CreateDate,
                    CreateByStaffId = item.CreateByStaffId,
                    IsBorrow = item.IsBorrow,
                    IsTemporaryInvolve = item.IsTemporaryInvolve,
                    StatementCalculationDate = item.StatementCalculationDate,
                    PlanActivityIdOld = item.PlanActivityIdOld,
                    FundTypeName = item.FundTypeName,
                    FundTypeId = item.FundTypeId,
                    StatementName = item.StatementName,
                    RealInvolvePlanItemId = item.RealInvolvePlanItemId,
                    UsedToInvolvePlanItemId = item.UsedToInvolvePlanItemId,
                    ReserveByStaffName = item.ReserveByStaffName,
                    ReserveRemark = item.ReserveRemark,
                    ReserveForecastValue = item.ReserveForecastValue,
                    ReserveByStaffId = item.ReserveByStaffId,
                    ReserveDate = item.ReserveDate,
                    IsReserve = item.IsReserve,
                    DevelopmentRecordGroupId = item.DevelopmentRecordGroupId,
                    OutsideDutyGroupId = item.OutsideDutyGroupId,
                    ReserveDepartmentId = item.ReserveDepartmentId,
                    ReserveDepartmentName = item.ReserveDepartmentName,
                    SuppliesOfficerName = item.SuppliesOfficerName,
                    HrofficerName = item.HrofficerName,
                    SuppliesOfficerSignDate = item.SuppliesOfficerSignDate,
                    HrofficerSignDate = item.HrofficerSignDate,
                    RequesterDepartmentName = item.RequestDepartmentName,
                    RequesterPositionName = item.RequesterPositionName,
                    ProcureRequest = item.ProcureRequest,
                    FirstProcureComittee = item.FirstProcureComittee,
                    FirstCheckComittee = item.FirstCheckComittee,
                    OtherRequest = item.OtherRequest,
                    FirstBorrower = item.FirstBorrower,
                    SecondBorrower = item.SecondBorrower,
                    ThirdBorrower = item.ThirdBorrower,
                    FirstBorrowAmount = item.FirstBorrowAmount,
                    SecondBorrowAmount = item.SecondBorrowAmount,
                    ThirdBorrowAmount = item.ThirdBorrowAmount,
                    FirstBorrowerPosition = item.FirstBorrowerPosition,
                    ThirdBorrowerPosition = item.ThirdBorrowerPosition,
                    SecondBorrowerPosition = item.SecondBorrowerPosition,
                    FirstBorrowerDepartment = item.FirstBorrowerDepartment,
                    SecondBorrowerDepartment = item.SecondBorrowerDepartment,
                    ThirdBorrowerDepartment = item.ThirdBorrowerDepartment,
                    FourthBorrower = item.FourthBorrower,
                    FourthBorrowAmount = item.FourthBorrowAmount,
                    FourthBorrowerPosition = item.FourthBorrowerPosition,
                    FourthBorrowerDepartment = item.FourthBorrowerDepartment,
                    FifthBorrower = item.FirstBorrower,
                    FifthBorrowAmount = item.FifthBorrowAmount,
                    FifthBorrowerPosition = item.FirstBorrowerPosition,
                    FifthBorrowerDepartment = item.FirstBorrowerDepartment,
                    RequestDepartmentId = item.RequestDepartmentId,
                    RequestDepartmentName = item.RequestDepartmentName,
                    SettleDay = item.SettleDay,
                    DueDate = item.DueDate,
                    StartCountingDate = item.StartCountingDate,
                    UnitChiefStaffId = item.UnitChiefStaffId,
                    ApproverStaffId = item.ApproverStaffId,
                    PlanFormApprovalStatusEnum = item.PlanFormApprovalStatusEnum,
                    IsHidden = item.IsHidden,
                    ScheduleTitle = item.ScheduleTitle,
                    RelatedRegulation = item.RelatedRegulation,
                    ApproverSignatureId = item.ApproverSignatureId,
                    UnitChiefSignatureId = item.UnitChiefSignatureId,
                    SuppliesOfficerSignatureId = item.SuppliesOfficerSignatureId,
                    ProjectManagerSignatureId = item.ProjectManagerSignatureId,
                    BudgetCheckerSignatureId = item.BudgetCheckerSignatureId,
                    SuppliesOfficerStaffId = item.SuppliesOfficerSignatureId,
                    ProjectManagerStaffId = item.ProjectManager1StaffId,
                    RequesterStaffId = item.RequesterStaffId,
                    BudgetCheckerStaffId = item.BudgetCheckerStaffId,
                    RequesterSignatureId = item.RequesterSignatureId,
                    ProjectManager = item.ProjectManager,
                    ProjectManagerSignDate = item.ProjectManagerSignDate,
                    HrofficerStaffId = item.HrofficerStaffId,
                    HrofficerSignatureId = item.HrofficerStaffId,
                    ProjectManager1SignatureId = item.ProjectManager1SignatureId,
                    ProjectManager1 = item.ProjectManager1,
                    ProjectManager1SignDate = item.ProjectManager1SignDate,
                    ProjectManager1StaffId = item.ProjectManager1StaffId,
                    ProjectManager2SignatureId = item.ProjectManager2SignatureId,
                    ProjectManager2 = item.ProjectManager2,
                    ProjectManager2SignDate = item.ProjectManager2SignDate,
                    ProjectManager2StaffId = item.ProjectManager2StaffId,
                    ProjectManager3SignatureId = item.ProjectManager3SignatureId,
                    ProjectManager3 = item.ProjectManager3,
                    ProjectManager3SignDate = item.ProjectManager3SignDate,
                    ProjectManager3StaffId = item.ProjectManager3StaffId,
                    ProjectManager4SignatureId = item.ProjectManager4SignatureId,
                    ProjectManager4 = item.ProjectManager4,
                    ProjectManager4SignDate = item.ProjectManager4SignDate,
                    ProjectManager4StaffId = item.ProjectManager4StaffId,
                    UnitChiefPosition = item.UnitChiefPosition,
                    BudgetCheckerPosition = item.BudgetCheckerPosition,
                    ApproverPosition = item.ApproverPosition,
                    SuppliesOfficerPosition = item.SuppliesOfficerPosition,
                    HrofficerPosition = item.HrofficerPosition,
                    ProjectManager1Position = item.ProjectManager1Position,
                    ProjectManager2Position = item.ProjectManager2Position,
                    ProjectManager3Position = item.ProjectManager3Position,
                    ProjectManager4Position = item.ProjectManager4Position,
                    IsApproveInstead = item.IsApproveInstead,
                    DocCheckerName = item.DocCheckerName,
                    DocCheckerPosition = item.DocCheckerPosition,
                    DocCheckerSignDate = item.DocCheckerSignDate,
                    DocCheckerStaffId = item.DocCheckerStaffId,
                    DocCheckerSignatureId = item.DocCheckerSignatureId,
                    IsSent = item.IsSent,
                    FirstBorrowerPositionTypeName = item.FirstBorrowerPositionTypeName,
                    SecondBorrowerPositionTypeName = item.SecondBorrowerPositionTypeName,
                    ThirdBorrowerPositionTypeName = item.ThirdBorrowerPositionTypeName,
                    FourthBorrowerPositionTypeName = item.FourthBorrowerPositionTypeName,
                    FifthBorrowerPositionTypeName = item.FifthBorrowerPositionTypeName,
                });
            }
            result.Success = data != null? true: false;
            result.data = respone;
            return result;
        }






        public List<GeneralExpenseMemoForm> GetByPlanTypeId(int id, int approvalStatus, string documentNumber = "", decimal budgetValue = 0.00m)
        {
            if (approvalStatus != 0)
            {
                return _database.GeneralExpenseMemoForms.Where(c => c.Active && (c.PlanTypeId == id || c.GeneralExpenses.Where((GeneralExpense d) => d.Active).Any((GeneralExpense d) => d.PlanTypeId == id)) && (!(documentNumber != "") || c.DocumentNumber.Contains(documentNumber))).OrderByDescending(c => c.Id).ToList();

            }

            return _database.GeneralExpenseMemoForms.Where(c => c.Active && (c.PlanTypeId == id || c.GeneralExpenses.Where((GeneralExpense d) => d.Active).Any((GeneralExpense d) => d.PlanTypeId == id)) && c.ApprovalStatusEnum == approvalStatus && (!(documentNumber != "") || c.DocumentNumber.Contains(documentNumber))).OrderByDescending(c => c.Id).ToList();

        }

        public List<GeneralExpenseMemoForm> GetByDepartmentId(int id, int approvalStatus, string documentNumber = "", decimal budgetValue = 0.00m)
        {
            if (approvalStatus != 0)
            {
                return _database.GeneralExpenseMemoForms.Where(c => c.Active && (c.DepartmentId == id || c.GeneralExpenses.Where((GeneralExpense d) => d.Active).Any((GeneralExpense d) => d.DepartmentId == id)) && (!(documentNumber != "") || c.DocumentNumber.Contains(documentNumber))).OrderByDescending(c => c.Id).ToList();

            }

            return _database.GeneralExpenseMemoForms.Where(c => c.Active && (c.DepartmentId == id || c.GeneralExpenses.Where((GeneralExpense d) => d.Active).Any((GeneralExpense d) => d.DepartmentId == id)) && c.ApprovalStatusEnum == approvalStatus && (!(documentNumber != "") || c.DocumentNumber.Contains(documentNumber))).OrderByDescending(c => c.Id).ToList();

        }


        public List<GeneralExpenseMemoForm> GetByFiscalYear(int fiscalYear, int approvalStatus, string documentNumber = "", decimal budgetValue = 0.00m)
        {
            if (approvalStatus != 0)
            {
                return _database.GeneralExpenseMemoForms.Where(c => c.Active && c.FiscalYear == fiscalYear && (!(documentNumber != "") || c.DocumentNumber.Contains(documentNumber))).OrderByDescending(c => c.Id).Take(50).ToList();

            }

            return _database.GeneralExpenseMemoForms.Where(c => c.Active && c.FiscalYear == fiscalYear && c.ApprovalStatusEnum == approvalStatus && (!(documentNumber != "") || c.DocumentNumber.Contains(documentNumber))).OrderByDescending(c => c.Id).ToList();

        }

        public ViewSettleReceiptFormListResponse ViewSettleReceiptFormListForApproval(ViewSettleReceiptFormListRequest request)
        {
            var result = new ViewSettleReceiptFormListResponse();
            var data = new List<SettleReceiptForm>();
            var response = new List<SettleReceiptFormDto>();
            if (request.objId != 0)
            {
                switch (request.type)
                {
                    case 1:
                        data = GetByPlanTypeId_a(request.objId, 10, request.documentNumber, request.budgetVal, request.stateName);
                        break;
                    case 2:
                        data = GetByDepartmentId_a(request.objId, 10, request.documentNumber, request.budgetVal, request.stateName);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                data = GetByFiscalYear_a(request.FiscalYear, 10, request.documentNumber, request.budgetVal, request.stateName);
            }

            foreach (var item in data)
            {
                response.Add(new SettleReceiptFormDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Active = item.Active,
                    FiscalYear = item.FiscalYear,
                    GeneralExpenseMemoFormId = item.GeneralExpenseMemoFormId,
                    WriteDate = item.WriteDate,
                    Inform = item.Inform,
                    Purpose = item.Purpose,
                    DocumentNumber = item.DocumentNumber,
                    RequesterName = item.RequesterName,
                    RequesterSignDate = item.RequesterSignDate,
                    BudgetCheckerName = item.BudgetCheckerName,
                    BudgetCheckerSignDate = item.BudgetCheckerSignDate,
                    StatementPayMethodEnum = item.StatementPayMethodEnum,
                    StatementPayStatusEnum = item.StatementPayStatusEnum,
                    PayDate = item.PayDate,
                    NetPayValue = item.NetPayValue,
                    PaymentDocumentNumber = item.PaymentDocumentNumber,
                    CreateDate = item.CreateDate,
                    CreateByStaffId = item.CreateByStaffId,
                    StatementCalculationDate = item.StatementCalculationDate,
                    PaymentRemark = item.PaymentRemark,
                    StatementName = item.StatementName,
                    PlanFormApprovalStatusEnum = item.PlanFormApprovalStatusEnum,
                    ApprovalStatusEnum = item.ApprovalStatusEnum,
                    ApprovedDate = item.ApprovedDate,
                    UnitChiefSignDate = item.UnitChiefSignDate,
                    UnitChiefName = item.UnitChiefName,
                    IsSent = item.IsSent,
                    UnitChiefStaffId = item.UnitChiefStaffId,
                    BankAccountEnum = item.BankAccountEnum,
                    RequesterSignatureId = item.RequesterSignatureId,
                    RequesterStaffId = item.RequesterStaffId,
                    BudgetCheckerStaffId = item.BudgetCheckerStaffId,
                    BudgetCheckerSignatureId = item.BudgetCheckerSignatureId,
                    UnitChiefSignatureId = item.UnitChiefSignatureId,
                    AccountantName = item.AccountantName,
                    AccountantSignDate = item.AccountantSignDate,
                    AccountantStaffId = item.AccountantStaffId,
                    AccountantSignatureId = item.AccountantSignatureId,
                    SettleAmount = item.SettleReceiptItems.Where(c => c.Active).Sum(c => c.SettleAmount),
                    UsedBudget = item.SettleReceiptItems.Where(c => c.Active).Sum(c =>  c.UsedBudget),
                   
                 }); 
            }
            result.Success = data != null? true: false;
            result.data = response;
            return result;
        }

        public List<SettleReceiptForm> GetByPlanTypeId_a(int id, int approvalStatus, string documentNumber = "", decimal budgetValue = 0.00m, string statementName = "")
        {
            return  _database.SettleReceiptForms.Where( c => c.Active && c.SettleReceiptItems.Any( d => d.Active && d.GeneralExpense.PlanTypeId == id) && (c.ApprovalStatusEnum == approvalStatus) && (!(documentNumber != "") || c.DocumentNumber.Contains(documentNumber)) && (!(statementName != "") || c.GeneralExpenseMemoForm.StatementName.Contains(statementName))).Include(c => c.SettleReceiptItems).OrderByDescending(c => c.Id).ToList();

        }
        public List<SettleReceiptForm> GetByDepartmentId_a(int id,int approvalStatus, string documentNumber = "", decimal budgetValue = 0.00m, string statementName = "")
        {
            return _database.SettleReceiptForms.Where (c => c.Active && c.SettleReceiptItems.Any( d => d.Active && d.GeneralExpense.DepartmentId == id) && ( c.ApprovalStatusEnum == approvalStatus) && (!(documentNumber != "") || c.DocumentNumber.Contains(documentNumber)) && (!(statementName != "") || c.GeneralExpenseMemoForm.StatementName.Contains(statementName))).Include(c => c.SettleReceiptItems).OrderByDescending(c => c.Id).ToList();

        }
        public List<SettleReceiptForm> GetByFiscalYear_a(int fiscalYear, int approvalStatus , string documentNumber = "", decimal budgetValue = 0.00m, string statementName = "")
        {
            return _database.SettleReceiptForms.Where (c => c.Active && c.FiscalYear == fiscalYear && (c.ApprovalStatusEnum == approvalStatus) && (!(documentNumber != "") || c.DocumentNumber.Contains(documentNumber)) && (!(statementName != "") || c.GeneralExpenseMemoForm.StatementName.Contains(statementName))).Include(c => c.SettleReceiptItems).OrderByDescending(c => c.Id).Take(50).ToList();

        }

        public ViewGeneralExpenseSettleFormListResponse ViewGeneralExpenseSettleFormListForApproval(ViewGeneralExpenseSettleFormListRequest request)
        {
            var result = new ViewGeneralExpenseSettleFormListResponse();
            var response = new List<GeneralExpenseSettleFormDto>();
            var data = new List<GeneralExpenseSettleForm>();
            if (request.objId != 0)
            {
                switch (request.type)
                {
                    case 1:
                        data = GetByPlanTypeId_b(request.objId, 10, false, request.documentNumber, request.budgetVal);
                        break;
                    case 2:
                        data = GetByDepartmentId_b(request.objId, 10, false, request.documentNumber, request.budgetVal);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                data = GetByFiscalYear_b(request.FiscalYear, 10, false, request.documentNumber, request.budgetVal);
            }
            foreach (var item in data)
            {
                var GeneralExpense =_database.SettleDirectPaymentItems.Where(x => x.GeneralExpenseSettleFormId == item.Id && x.Active).Include(x => x.GeneralExpense).ToList();
                var AdditionalSettle = _database.AdditionalSettleItems.Where(x => x.GeneralExpenseSettleFormId == item.Id && x.Active).Include(x => x.GeneralExpense).ToList();
               // var SettleReceiptItem = _database.SettleReceiptItems.Where(x => x. == item.Id && x.Active).ToList();
                response.Add(new GeneralExpenseSettleFormDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Active = item.Active,
                    FiscalYear = item.FiscalYear,
                    WriteDate = item.WriteDate,
                    Inform = item.Inform,
                    Enclosures = item.Enclosures,
                    Purpose = item.Purpose,
                    RequesterName = item.RequesterName,
                    RequesterSignDate = item.RequesterSignDate,
                    UnitChiefName = item.UnitChiefName,
                    UnitChiefSignDate = item.UnitChiefSignDate,
                    BudgetCheckerName = item.BudgetCheckerName,
                    BudgetCheckerSignDate = item.BudgetCheckerSignDate,
                    Approver = item.Approver,
                    ApproverSignDate = item.ApproverSignDate,
                    ApprovalStatusEnum = item.ApprovalStatusEnum,
                    DepartmentNameOld = item.DepartmentNameOld,
                    DepartmentId = item.DepartmentId,
                    PlanTypeNameOld = item.PlanTypeNameOld,
                    PlanTypeId = item.PlanTypeId,
                    PlanCoreNameOld = item.PlanCoreNameOld,
                    PlanCoreId = item.PlanCoreId,
                    BudgetTypeName = item.BudgetTypeName,
                    BudgetTypeId = item.BudgetTypeId,
                    ApprovedDate = item.ApprovedDate,
                    DocumentNumber = item.DocumentNumber,
                    StatementPayMethodEnum = item.StatementPayMethodEnum,
                    StatementPayStatusEnum = item.StatementPayStatusEnum,
                    PayDate = item.PayDate,
                    NetPayValue = item.NetPayValue,
                    PaymentDocumentNumber  = item.PaymentDocumentNumber,
                    CreateDate = item.CreateDate,
                    CreateByStaffId  = item.CreateByStaffId,
                    PlanCoreCode = item.PlanCoreCode,
                    GeneralExpenseMemoFormId  = item.GeneralExpenseMemoFormId,
                    StatementCalculationDate = item.StatementCalculationDate,
                    PlanActivityIdOld  = item.PlanActivityIdOld,
                    FundTypeName = item.FundTypeName,
                    FundTypeId  = item.FundTypeId,
                    PaymentRemark = item.PaymentRemark,
                    StatementName  = item.StatementName,
                    StatementNameAsCash = item.StatementNameAsCash,
                    UnitChiefStaffId  = item.UnitChiefStaffId,
                    ApproverStaffId = item.ApproverStaffId,
                    PlanFormApprovalStatusEnum  = item.PlanFormApprovalStatusEnum,
                    RelatedRegulation = item.RelatedRegulation,
                    OperationSummary  = item.OperationSummary,
                    SuppliesOfficerName = item.SuppliesOfficerName,
                    SuppliesOfficerPosition  = item.SuppliesOfficerPosition,
                    SuppliesOfficerSignDate = item.SuppliesOfficerSignDate,
                    RefWithdrawalFormText  = item.RefWithdrawalFormText,
                    OtherRequest = item.OtherRequest,
                    PlanItemDetailListByBorrowerValue  = item.PlanItemDetailListByBorrowerValue,
                    IsSent = item.IsSent,
                    RequesterStaffId  = item.RequesterStaffId,
                    OtherReqDocNumber = item.OtherReqDocNumber,
                    OtherReqWriteDate  = item.OtherReqWriteDate,
                    SettleAmount = item.SettlementItems.Where(c => c.Active).Sum(c => c.SettleAmount),
                    UsedBudget = item.SettlementItems.Where(c => c.Active).Sum(c => c.UsedBudget),
                    TotalSettleDirectPaymentUsedBudget = item.SettleDirectPaymentItems.Where( c => c.Active).Sum(c => c.UsedBudget),
                    TotalSettleDirectPaymentBudget = GeneralExpense.Select(x => x.GeneralExpense).Sum(x=>x.TotalBudget),
                    TotalSettleDirectPaymentReturnBudget = GeneralExpense.Select(x => x.GeneralExpense).Sum(x => x.TotalBudget),
                    TotalAdditionalSettleItemUsedBudget = AdditionalSettle.Sum(x => x.UsedBudget),
                    TotalAdditionalSettleItemBudget = AdditionalSettle.Sum(x => x.GeRemainBudget),
                    TotalAdditionalSettleItemReturnBudget = AdditionalSettle.Select( c => c.GeneralExpense).Sum( c => c.TotalBudget),
                    //TotalWithdrawnBudget = item.SettlementItems.Any( c => c.Active) ? item.SettlementItems.Where( c => c.Active).Sum( c => c.SettleReceiptItem.SettleAmount):0,
                    SettleAmountAfterReceipt = item.SettlementItems.Any(c => c.Active) ? item.SettlementItems.Where( c => c.Active).Sum( c => c.SettleAmount) :0
            });
            }

            
            result.Success = data != null ? true : false;
            result.data = response;
            return result;  
        }

        public List<GeneralExpenseSettleForm> GetByPlanTypeId_b(int id, int approvalStatus, bool onlyHasSettleAsBudget = false, string documentNumber = "", decimal budgetValue = 0.00m, string statementName = "")
        {
            return _database.GeneralExpenseSettleForms.Where( c => c.Active && c.PlanTypeId == id && ( c.ApprovalStatusEnum == approvalStatus) && (!(documentNumber != "") || c.DocumentNumber.Contains(documentNumber)) && (!(statementName != "") || c.GeneralExpenseMemoForm.StatementName.Contains(statementName))).Include(c => c.SettlementItems).Include(c => c.SettleDirectPaymentItems).Include(c => c.AdditionalSettleItems).OrderByDescending(c => c.Id).ToList();

        }
        public List<GeneralExpenseSettleForm> GetByDepartmentId_b(int id, int approvalStatus, bool onlyHasSettleAsBudget = false, string documentNumber = "", decimal budgetValue = 0.00m, string statementName = "")
        {
            return _database.GeneralExpenseSettleForms.Where (c => c.Active && c.DepartmentId == id && ( c.ApprovalStatusEnum == approvalStatus) && (!(documentNumber != "") || c.DocumentNumber.Contains(documentNumber)) && (!(statementName != "") || c.GeneralExpenseMemoForm.StatementName.Contains(statementName))).Include(c => c.SettlementItems).Include(c => c.SettleDirectPaymentItems).Include(c => c.AdditionalSettleItems).OrderByDescending(c => c.Id).ToList();

        }
        public List<GeneralExpenseSettleForm> GetByFiscalYear_b(int fiscalYear,int approvalStatus, bool onlyHasSettleAsBudget = false, string documentNumber = "", decimal budgetValue = 0.00m, string statementName = "")
        {
            return _database.GeneralExpenseSettleForms.Where (c => c.Active && c.FiscalYear == fiscalYear && ( c.ApprovalStatusEnum == approvalStatus) && (!(documentNumber != "") || c.DocumentNumber.Contains(documentNumber)) && (!(statementName != "") || c.GeneralExpenseMemoForm.StatementName.Contains(statementName))).Include(c => c.SettlementItems).Include(c => c.SettleDirectPaymentItems).Include(c => c.AdditionalSettleItems).OrderByDescending(c => c.Id).ToList();

        }

        public List<GeneralExpenseMemoFormDto> ViewGeneralExpenseMemoFormList(ViewGeneralExpenseMemoFormListRequest request)
        {
            var result = new List<GeneralExpenseMemoFormDto>();
            var query = _database.GeneralExpenseMemoForms.Where(c => c.Active && c.FiscalYear == request.FiscalYear && ((request.documentNumber != "") ? c.DocumentNumber.Contains(request.documentNumber) : true)  && (request.reqdepId != 0 ? c.RequestDepartmentId == request.reqdepId : true)
         && (request.stateName != "" ? c.StatementName.Contains(request.stateName) : true) && ((request.objId != 0) ? (request.PlanObjectTypeRadioButtonList == "PlanType" ? (c.PlanTypeId == request.objId || c.GeneralExpenses.Where(d => d.Active).Any(d => d.PlanTypeId == request.objId)) : (c.DepartmentId == request.objId || c.GeneralExpenses.Where(d => d.Active).Any(d => d.DepartmentId == request.objId))) : true)
         && (request.appState != 0 ? c.ApprovalStatusEnum == request.appState : true) && (request.isBorrow != 0 ? (c.IsBorrow == (request.isBorrow == 10)) : true) && (request.staffId != 0 ? c.CreateByStaffId == request.staffId : true)).Include(c => c.GeneralExpenses).OrderByDescending(c => c.Id).Take(50).ToList();
            foreach (var item in query)
            {
                result.Add(new GeneralExpenseMemoFormDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Active = item.Active,
                    FiscalYear = item.FiscalYear,
                    WriteDate = item.WriteDate,
                    Inform = item.Inform,
                    Enclosures = item.Enclosures,
                    Purpose = item.Purpose,
                    RequesterName = item.RequesterName,
                    RequesterSignDate = item.RequesterSignDate,
                    UnitChiefName = item.UnitChiefName,
                    UnitChiefSignDate = item.UnitChiefSignDate,
                    BudgetCheckerName = item.BudgetCheckerName,
                    BudgetCheckerSignDate = item.BudgetCheckerSignDate,
                    Approver = item.Approver,
                    ApproverSignDate = item.ApproverSignDate,
                    ApprovalStatusEnum = item.ApprovalStatusEnum,
                    DepartmentName = item.DepartmentName,
                    DepartmentId = item.DepartmentId,
                    PlanTypeName = item.PlanTypeName,
                    PlanTypeId = item.PlanTypeId,
                    PlanCoreName = item.PlanCoreName,
                    PlanCoreId = item.PlanCoreId,
                    BudgetTypeName = item.BudgetTypeName,
                    BudgetTypeId = item.BudgetTypeId,
                    PlanCoreRemainBudget = item.PlanCoreRemainBudget,
                    PlanCoreCode = item.PlanCoreCode,
                    ApprovedDate = item.ApprovedDate,
                    DocumentNumber = item.DocumentNumber,
                    StatementPayStatusEnum = item.StatementPayStatusEnum,
                    NetPayValue = item.NetPayValue,
                    CreateDate = item.CreateDate,
                    CreateByStaffId = item.CreateByStaffId,
                    IsBorrow = item.IsBorrow,
                    IsTemporaryInvolve = item.IsTemporaryInvolve,
                    StatementCalculationDate = item.StatementCalculationDate,
                    PlanActivityIdOld = item.PlanActivityIdOld,
                    FundTypeName = item.FundTypeName,
                    FundTypeId = item.FundTypeId,
                    StatementName = item.StatementName,
                    RealInvolvePlanItemId = item.RealInvolvePlanItemId,
                    UsedToInvolvePlanItemId = item.UsedToInvolvePlanItemId,
                    ReserveByStaffName = item.ReserveByStaffName,
                    ReserveRemark = item.ReserveRemark,
                    ReserveForecastValue = item.ReserveForecastValue,
                    ReserveByStaffId = item.ReserveByStaffId,
                    ReserveDate = item.ReserveDate,
                    IsReserve = item.IsReserve,
                    DevelopmentRecordGroupId = item.DevelopmentRecordGroupId,
                    OutsideDutyGroupId = item.OutsideDutyGroupId,
                    ReserveDepartmentId = item.ReserveDepartmentId,
                    ReserveDepartmentName = item.ReserveDepartmentName,
                    SuppliesOfficerName = item.SuppliesOfficerName,
                    HrofficerName = item.HrofficerName,
                    SuppliesOfficerSignDate = item.SuppliesOfficerSignDate,
                    HrofficerSignDate = item.HrofficerSignDate,
                    RequesterDepartmentName = item.RequestDepartmentName,
                    RequesterPositionName = item.RequesterPositionName,
                    ProcureRequest = item.ProcureRequest,
                    FirstProcureComittee = item.FirstProcureComittee,
                    FirstCheckComittee = item.FirstCheckComittee,
                    OtherRequest = item.OtherRequest,
                    FirstBorrower = item.FirstBorrower,
                    SecondBorrower = item.SecondBorrower,
                    ThirdBorrower = item.ThirdBorrower,
                    FirstBorrowAmount = item.FirstBorrowAmount,
                    SecondBorrowAmount = item.SecondBorrowAmount,
                    ThirdBorrowAmount = item.ThirdBorrowAmount,
                    FirstBorrowerPosition = item.FirstBorrowerPosition,
                    ThirdBorrowerPosition = item.ThirdBorrowerPosition,
                    SecondBorrowerPosition = item.SecondBorrowerPosition,
                    FirstBorrowerDepartment = item.FirstBorrowerDepartment,
                    SecondBorrowerDepartment = item.SecondBorrowerDepartment,
                    ThirdBorrowerDepartment = item.ThirdBorrowerDepartment,
                    FourthBorrower = item.FourthBorrower,
                    FourthBorrowAmount = item.FourthBorrowAmount,
                    FourthBorrowerPosition = item.FourthBorrowerPosition,
                    FourthBorrowerDepartment = item.FourthBorrowerDepartment,
                    FifthBorrower = item.FifthBorrower,
                    FifthBorrowAmount = item.FifthBorrowAmount,
                    FifthBorrowerPosition = item.FifthBorrowerPosition,
                    FifthBorrowerDepartment = item.FifthBorrowerDepartment,
                    RequestDepartmentId = item.RequestDepartmentId,
                    RequestDepartmentName = item.RequestDepartmentName,
                    SettleDay = item.SettleDay,
                    DueDate = item.DueDate,
                    StartCountingDate = item.StartCountingDate,
                    UnitChiefStaffId = item.UnitChiefStaffId,
                    ApproverStaffId = item.ApproverStaffId,
                    PlanFormApprovalStatusEnum = item.PlanFormApprovalStatusEnum,
                    IsHidden = item.IsHidden,
                    ScheduleTitle = item.ScheduleTitle,
                    RelatedRegulation = item.RelatedRegulation,
                    ApproverSignatureId = item.ApproverSignatureId,
                    UnitChiefSignatureId = item.UnitChiefSignatureId,
                    SuppliesOfficerSignatureId = item.SuppliesOfficerSignatureId,
                    ProjectManagerSignatureId = item.ProjectManagerSignatureId,
                    BudgetCheckerSignatureId = item.BudgetCheckerSignatureId,
                    SuppliesOfficerStaffId = item.SuppliesOfficerStaffId,
                    ProjectManagerStaffId = item.ProjectManagerStaffId,
                    RequesterStaffId = item.RequesterStaffId,
                    BudgetCheckerStaffId = item.BudgetCheckerStaffId,
                    RequesterSignatureId = item.RequesterSignatureId,
                    ProjectManager = item.ProjectManager,
                    ProjectManagerSignDate = item.ProjectManagerSignDate,
                    HrofficerStaffId = item.HrofficerStaffId,
                    HrofficerSignatureId = item.HrofficerSignatureId,
                    ProjectManager1SignatureId = item.ProjectManager1SignatureId,
                    ProjectManager1 = item.ProjectManager1,
                    ProjectManager1SignDate = item.ProjectManager1SignDate,
                    ProjectManager1StaffId = item.ProjectManager1StaffId,
                    ProjectManager2SignatureId = item.ProjectManager2SignatureId,
                    ProjectManager2 = item.ProjectManager2,
                    ProjectManager2SignDate = item.ProjectManager2SignDate,
                    ProjectManager2StaffId = item.ProjectManager2StaffId,
                    ProjectManager3SignatureId = item.ProjectManager3SignatureId,
                    ProjectManager3 = item.ProjectManager3,
                    ProjectManager3SignDate = item.ProjectManager3SignDate,
                    ProjectManager3StaffId = item.ProjectManager3StaffId,
                    ProjectManager4SignatureId = item.ProjectManager4SignatureId,
                    ProjectManager4 = item.ProjectManager4,
                    ProjectManager4SignDate = item.ProjectManager4SignDate,
                    ProjectManager4StaffId = item.ProjectManager4StaffId,
                    UnitChiefPosition = item.UnitChiefPosition,
                    BudgetCheckerPosition = item.BudgetCheckerPosition,
                    ApproverPosition = item.ApproverPosition,
                    SuppliesOfficerPosition = item.SuppliesOfficerPosition,
                    HrofficerPosition = item.HrofficerPosition,
                    ProjectManager1Position = item.ProjectManager1Position,
                    ProjectManager2Position = item.ProjectManager2Position,
                    ProjectManager3Position = item.ProjectManager3Position,
                    ProjectManager4Position = item.ProjectManager3Position,
                    IsApproveInstead = item.IsApproveInstead,
                    DocCheckerName = item.DocCheckerName,
                    DocCheckerPosition = item.DocCheckerPosition,
                    DocCheckerSignDate = item.DocCheckerSignDate,
                    DocCheckerStaffId = item.DocCheckerStaffId,
                    DocCheckerSignatureId = item.DocCheckerSignatureId,
                    IsSent = item.IsSent,
                    FirstBorrowerPositionTypeName = item.FirstBorrowerPositionTypeName,
                    SecondBorrowerPositionTypeName = item.SecondBorrowerPositionTypeName,
                    ThirdBorrowerPositionTypeName = item.ThirdBorrowerPositionTypeName,
                    FourthBorrowerPositionTypeName = item.FourthBorrowerPositionTypeName,
                    FifthBorrowerPositionTypeName = item.FifthBorrowerPositionTypeName,
                    TotalBudget = item.GeneralExpenses.Sum( x => x.TotalBudget)
                }); ;
            }
            return result;
        }

        public List<BudgetTransferFormDto> ViewPlanItemBudgetTransferList(ViewPlanItemBudgetTransferListRespons request)
        {
            var data = new List<BudgetTransferForm>();
            var result = new List<BudgetTransferFormDto>();
            switch (request.DirectionRadioButtonList)
            {
                case "Inward":
                    data = _database.BudgetTransferForms.Where(c => c.Active && c.FiscalYear == request.FiscalYear && (request.pTypeId != 0 ? c.BudgetTransfers.Any(d => d.Active && d.InwardPlanTypeId == request.pTypeId) : true)
                    && (request.depId != 0 ? c.BudgetTransfers.Any(d => d.Active && d.InwardDepartmentId == request.depId) : true) && (request.documentNumber != "" ? c.DocumentNumber.Contains(request.documentNumber) : true)).OrderByDescending(c => c.Id).Include(c => c.BudgetTransfers).ToList();
                    break;
                case "Outward":
                    data = _database.BudgetTransferForms.Where(c => c.Active && c.FiscalYear == request.FiscalYear && (request.pTypeId != 0 ? c.BudgetTransfers.Any(d => d.Active && d.OutwardPlanTypeId == request.pTypeId) : true)
                     && (request.depId != 0 ? c.BudgetTransfers.Any(d => d.Active && d.OutwardDepartmentId == request.depId) : true) && (request.documentNumber != "" ? c.DocumentNumber.Contains(request.documentNumber) : true)).OrderByDescending(c => c.Id).Include(c => c.BudgetTransfers).ToList();
                    break;
                default:
                    break;
            }
            foreach (var item in data)
            {
                result.Add(new BudgetTransferFormDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Active = item.Active,
                    FiscalYear = item.FiscalYear,
                    Remark = item.Remark,
                    ApprovalStatusEnum = item.ApprovalStatusEnum,
                    RequestDate = item.RequestDate,
                    ApprovedDate = item.ApprovedDate,
                    DocumentNumber = item.DocumentNumber,
                    CreateDate = item.CreateDate,
                    CreateByStaffId = item.CreateByStaffId,
                    StatementCalculationDate = item.StatementCalculationDate,
                    WriteDate = item.WriteDate,
                    Inform = item.Inform,
                    Enclosures = item.Enclosures,
                    Purpose = item.Purpose,
                    RequesterName = item.RequesterName,
                    RequesterSignDate = item.RequesterSignDate,
                    UnitChiefName = item.UnitChiefName,
                    UnitChiefSignDate = item.UnitChiefSignDate,
                    BudgetCheckerName = item.BudgetCheckerName,
                    BudgetCheckerSignDate = item.BudgetCheckerSignDate,
                    Approver = item.Approver,
                    ApproverSignDate = item.ApproverSignDate,
                    StatementName = item.StatementName,
                    SeniorUnitChiefName = item.SeniorUnitChiefName,
                    FinanceName = item.FinanceName,
                    SeniorUnitChiefSignDate = item.SeniorUnitChiefSignDate,
                    FinanceSignDate = item.FinanceSignDate,
                    RequestDepartmentId = item.RequestDepartmentId,
                    UnitChiefStaffId = item.UnitChiefStaffId,
                    ApproverStaffId = item.ApproverStaffId,
                    PlanFormApprovalStatusEnum = item.PlanFormApprovalStatusEnum,
                    BudgetTransferTypeEnum = item.BudgetTransferTypeEnum,
                    TransferBudget = item.BudgetTransfers.Where(x => x.Active).Sum(c => c.TransferBudget)
                }); 
            }

            return result;
        }

        public SecBaseResponse DeleteStrategy(int StrategyId)
        {
            var response = new SecBaseResponse();
            var data = _database.Strategies.Where(x => x.Id == StrategyId).FirstOrDefault();
            if (data != null)
            {
                //_database.Remove(data);
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delect Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        public SecBaseResponse DeleteStrategicIndicator(int StrategicIndicatorId)
        {
            var response = new SecBaseResponse();
            var data = _database.StrategicIndicators.Where(x => x.Id == StrategicIndicatorId).FirstOrDefault();
            if (data != null)
            {
                //_database.Remove(data);
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delect Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        public SecBaseResponse DeletePlanType(int PlanTypeId)
        {
            var response = new SecBaseResponse();
            var data = _database.PlanTypes.Where(x => x.Id == PlanTypeId).FirstOrDefault();
            if (data != null)
            {
                //_database.Remove(data);
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delect Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        public SecBaseResponse DeleteDepartment(int DepartmentId)
        {
            var response = new SecBaseResponse();
            var data = _database.Departments.Where(x => x.Id == DepartmentId).FirstOrDefault();
            if (data != null)
            {
                //_database.Remove(data);
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delect Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        public SecBaseResponse DeleteFundType(int FundTypeId)
        {
            var response = new SecBaseResponse();
            var data = _database.FundTypes.Where(x => x.Id == FundTypeId).FirstOrDefault();
            if (data != null)
            {
                //_database.Remove(data);
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delect Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
        public SecBaseResponse DeleteBudgetType(int BudgetTypeId)
        {
            var response = new SecBaseResponse();
            var data = _database.BudgetTypes.Where(x => x.Id == BudgetTypeId).FirstOrDefault();
            if (data != null)
            {
                //_database.Remove(data);
                data.Active = false;
                _database.Entry(data).State = EntityState.Modified;
                var result = _database.SaveChanges();
                response.Success = result > 0 ? true : false;
                response.Messsage = "Delect Complete";
            }
            else
            {
                response.Success = false;
                response.Messsage = "not have data";
            }

            return response;
        }
    }
}
