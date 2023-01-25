using App.EIS.Dtos;
using App.EIS.Models.Requests;
using App.EIS.Models.Responses;
using App.SEC.Dtos;
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.EIS
{
    public interface IEisServices
    {
        List<PlanCore> getPlanCore();
        List<GovernmentDisbursementGoal> getGovernmentDisbursementGoal();
        List<PlanCore> planCoreList(int year);
        List<BillingLocationDto> getAllBillingLocation();

        List<ProcureStoreLocationDto> getAllBuildingPlan();

        EisBaseResponse BillingLocationSetup(BillingLocationRequest request);
        List<calBudgetDetail> CalculatePlanTypeData(int fYear, int month);
        void CreateAreaChart();
        void CreateMOPAreaChart();
        void CreatePieChart();
        void CreateMOPPieChart(int month);
        //CreateStackColumnChart();
        void CreateGroupColumnChart();
        void CreateMOPGroupColumnChart(int fYear, int month);
        void CreateTableData(int fYear, int month);

    }
}