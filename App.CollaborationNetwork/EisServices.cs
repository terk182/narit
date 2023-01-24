﻿using App.EIS.Models;
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

namespace App.EIS
{
    public class EisServices : IEisServices
    {
        private readonly NARIT_MIS_LINKContext _database;
        private readonly  ICommonServices _CommonServices;
        public EisServices(NARIT_MIS_LINKContext context, ICommonServices CommonServices)
        {
            _database = context;
            _CommonServices = CommonServices;
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

        public EisBaseResponse CalculatePlanTypeData(int fYear, int month)
        {

            decimal netBudgetByFiscalYear = 0.00m;
            decimal netBudgetByMonth = 0.00m;
            decimal netUsedBudget = 0.00m;
            List<int> _MonthList;
            int _MonthIndex = 11;
            var _PlanTypeList = _CommonServices.GetPlanType(fYear);
            _MonthList = new List<int>() { 10, 11, 12, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            _MonthIndex = _MonthList.FindIndex(c => c == month);



            foreach (var item in _PlanTypeList)
            {
                foreach(var l in item.ParentPlanType)
                {
                    var PlanCores = _database.PlanCores.Where(x => x.Active ==true && x.PlanTypeId == l.Id).Include(x => x.PlanActivities).ToList();
                    foreach (var l1 in PlanCores)
                    {
                        foreach (var l2 in l1.PlanActivities)
                        {
                              var PlanA = _database.PlanItems.Where(x => x.Active == true && x.PlanActivityId == l2.Id).Include(x=> x.SummaryStatementCaches).Include(x => x.SummaryStatementCaches);
                        }
                    }
                }
            }
            throw new NotImplementedException();
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
