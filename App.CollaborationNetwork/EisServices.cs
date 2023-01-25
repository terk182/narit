using App.EIS.Models;
using App.EIS.Dtos;
using Microsoft.EntityFrameworkCore;
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using App.EIS.Models.Responses;
using App.EIS.Models.Requests;
using App.Common;
using App.SEC;
using App.SEC.Dtos;

namespace App.EIS
{
    public class EisServices : IEisServices
    {
        private readonly NARIT_MIS_LINKContext _database;
        private readonly  ICommonServices _CommonServices;
        private readonly ISecServices _SecServices;
        public EisServices(NARIT_MIS_LINKContext context, ICommonServices CommonServices, ISecServices secServices)
        {
            _database = context;
            _CommonServices = CommonServices;
            _SecServices = secServices;
        }

        public EisBaseResponse BillingLocationSetup(BillingLocationRequest request)
        {
            var _BillingLocationSetup = new BillingLocation();
            _BillingLocationSetup.Id = request.Id;
            _BillingLocationSetup.Name = request.Name;
            _BillingLocationSetup.Active = request.Active;
            _BillingLocationSetup.Detail = request.Detail;
            _BillingLocationSetup.BillingLocationTypeEnum = request.BillingLocationTypeEnum;
            _BillingLocationSetup.MeterId = request.MeterId;
            _BillingLocationSetup.MeterSize = request.MeterSize;
            _BillingLocationSetup.UserCode = request.UserCode;
            _BillingLocationSetup.Multiplier = request.Multiplier;
            _BillingLocationSetup.Location = request.Location;
            _BillingLocationSetup.ServiceProviderCode = request.ServiceProviderCode;
            _BillingLocationSetup.UserType = request.UserType;

            if (request.ParentBillingLocationId != 0)
            {
                _BillingLocationSetup.ParentBillingLocationId = request.ParentBillingLocationId;
            }
            _database.Entry(_BillingLocationSetup).State = _BillingLocationSetup.Id == 0 ?
                                               EntityState.Added :
                                               EntityState.Modified;

            var result = _database.SaveChanges();
            var response = new EisBaseResponse();
            response.Success = result > 0 ? true : false;
            response.Messsage = _BillingLocationSetup.Id == 0 ? "update" : "insert";
            return response;
        }

        public List<calBudgetDetail> CalculatePlanTypeData(int fYear, int month)
        {
            var result_list = new List<calBudgetDetail>();
            decimal netBudgetByFiscalYear = 0.00m;
            decimal netBudgetByMonth = 0.00m;
            decimal netUsedBudget = 0.00m;
            List<int> _MonthList;
            int _MonthIndex = 11;
            var _PlanTypeList = _CommonServices.GetPlanType(fYear);
            _MonthList = new List<int>() { 10, 11, 12, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            _MonthIndex = _MonthList.FindIndex(c => c == month);

            var _MonthListSum = new MonthListSum();
            decimal netBudgetByFYear = 0.00m;
            decimal netBudget = 0.00m;
            decimal paidBudgetAcc = 0.00m;
            decimal paidBudget = 0.00m;
            decimal inProcessBudgetAcc = 0.00m;
            decimal TotalBudgetCache = 0.00m;
            decimal UsedBudgetCache = 0.00m;
            decimal TotalBudget = 0.00m;
            decimal NetAmount = 0.00m;
            decimal InProcessBudget = 0.00m;
            decimal UsedBudget = 0.00m;
            decimal NetBudget = 0.00m;
            decimal BudgetPerPiece = 0.00m;
            decimal NetBudgetCache = 0.00m;
            decimal RemainBudgetCache = 0.00m;
            decimal TotalAmount = 0.00m;
            decimal EntireTotalBudget = 0.00m;
            decimal EntireNetBudget = 0.00m;
            decimal CheckViewUsedBudget = 0.00m;
            decimal Amount = 0.00m;
            foreach (var item in _PlanTypeList)
            {
                foreach(var l in item.ParentPlanType)
                {
                    var PlanCores = _database.PlanCores.Where(x => x.Active ==true && x.PlanTypeId == l.Id).Include(x => x.PlanActivities).ToList();
                    foreach (var l1 in PlanCores)
                    {



                       // foreach (var m in _MonthList) // วน Loop เพื่อแสดงกราฟรายเดือน
                       // {

                            var result = _SecServices.calbudget(l1.PlanActivities);
                            netBudgetByFYear += result.Budget.NetBudgetCache;
                        paidBudget += result.Budget.UsedBudgetCache;
                        TotalBudgetCache += result.Budget.TotalBudgetCache;

                        NetBudgetCache += result.Budget.NetBudgetCache;

                        UsedBudgetCache += result.Budget.UsedBudgetCache;

                        RemainBudgetCache += result.Budget.RemainBudgetCache;

                        TotalBudget += result.Budget.TotalBudget;
                        TotalAmount += result.Budget.TotalAmount;
                        NetAmount += result.Budget.NetAmount;
                        EntireTotalBudget += result.Budget.EntireTotalBudget;

                        NetBudget += result.Budget.NetBudget;

                        EntireNetBudget += result.Budget.EntireNetBudget;

                        InProcessBudget += result.Budget.InProcessBudget;
                        CheckViewUsedBudget += result.Budget.CheckViewUsedBudget;
                        UsedBudget += result.Budget.UsedBudget;
                        Amount += result.Budget.Amount;
                        BudgetPerPiece += result.Budget.BudgetPerPiece;
                        //  }
                    }
                }
            }
            var fff = netBudget;
            return result_list;
        }
        public Tuple<decimal, decimal, decimal, decimal, decimal, decimal> GetSummaryStatementCacheByMonth(int month, int? budgetTypeId = null)
        {
            if (! _database.PlanItems.Any((PlanItem c) => c.Active))
            {
                return null;
            }

            List<Tuple<decimal, decimal, decimal, decimal, decimal, decimal>> list = new List<Tuple<decimal, decimal, decimal, decimal, decimal, decimal>>();
            foreach (PlanItem item in _database.PlanItems.Where((PlanItem c) => c.Active && (!budgetTypeId.HasValue || (c.BudgetTypeId.HasValue && c.BudgetTypeId.Value == budgetTypeId.Value))).ToList())
            {
                list.Add(item.GetSummaryStatementCacheByMonth(month));
            }

            list.RemoveAll((Tuple<decimal, decimal, decimal, decimal, decimal, decimal> c) => c == null);
            return (list.Count > 0) ? new Tuple<decimal, decimal, decimal, decimal, decimal, decimal>(list.Sum((Tuple<decimal, decimal, decimal, decimal, decimal, decimal> c) => c.Item1), list.Sum((Tuple<decimal, decimal, decimal, decimal, decimal, decimal> c) => c.Item2), list.Sum((Tuple<decimal, decimal, decimal, decimal, decimal, decimal> c) => c.Item3), list.Sum((Tuple<decimal, decimal, decimal, decimal, decimal, decimal> c) => c.Item4), list.Sum((Tuple<decimal, decimal, decimal, decimal, decimal, decimal> c) => c.Item5), list.Sum((Tuple<decimal, decimal, decimal, decimal, decimal, decimal> c) => c.Item6)) : null;
        }
        public void CreateAreaChart()
        {
            throw new NotImplementedException();
        }

        public void CreateGroupColumnChart()
        {
            throw new NotImplementedException();
        }

        public void CreateMOPAreaChart()
        {
            throw new NotImplementedException();
        }

        public void CreateMOPGroupColumnChart(int fYear, int month)
        {
            throw new NotImplementedException();
        }

        public void CreateMOPPieChart(int month)
        {
            throw new NotImplementedException();
        }

        public void CreatePieChart()
        {
            throw new NotImplementedException();
        }

        public void CreateTableData(int fYear, int month)
        {
            throw new NotImplementedException();
        }

        public List<BillingLocationDto> getAllBillingLocation()
        {
            var result = new List<BillingLocationDto>();
            var data = _database.BillingLocations.ToList();
            foreach (var item in data)
            {
                result.Add(new BillingLocationDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Active = item.Active,
                    Detail = item.Detail,
                    BillingLocationTypeEnum = item.BillingLocationTypeEnum,
                    MeterId = item.MeterId,
                    MeterSize = item.MeterSize,
                    UserCode = item.UserCode,
                    Multiplier = item.Multiplier,
                    Location = item.Location,
                    ServiceProviderCode = item.ServiceProviderCode,
                    UserType = item.UserType,
                    ParentBillingLocationId = item.ParentBillingLocationId

                });
            }
            return result;
        }

        public List<ProcureStoreLocationDto> getAllBuildingPlan()
        {
            var result = new List<ProcureStoreLocationDto>();
            var data = _database.ProcureStoreLocations.ToList();
            foreach (var item in data)
            {
                result.Add(new ProcureStoreLocationDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Active = item.Active,
                    ParentProcureStoreLocationId = item.ParentProcureStoreLocationId,
                    ProcureStoreLocationTypeEnum = item.ProcureStoreLocationTypeEnum,
                    Detail = item.Detail,
                    Code = item.Code,
                    Area = item.Area,
                    CanvasPosition = item.CanvasPosition,
                    HrdepartmentId = item.HrdepartmentId,
                    ImagePath = item.ImagePath,
                    //ParentProcureStoreLocation = item.ParentProcureStoreLocation

                });
            }
            return result;
        }

        public List<GovernmentDisbursementGoal> getGovernmentDisbursementGoal()
        {
            throw new NotImplementedException();
        }

        public List<PlanCore> getPlanCore()
        {
            throw new NotImplementedException();
        }

        public List<PlanCore> planCoreList(int year)
        {
            var planCore = _database.PlanCores.Where(x => x.FiscalYear == year && x.Active).OrderBy(x => x.Name).ToList();   
            return planCore;
        }

 
    }
}
