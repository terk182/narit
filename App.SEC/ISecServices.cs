using App.SEC.Dtos;
using App.SEC.Models;
using App.SEC.Models.Requests;
using App.SEC.Models.Responses;
using App.SEC.Responses;
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC
{
    public interface ISecServices
    {
        List<BudgetType> GetByFiscalYear(int FiscalYear);
        PlanCrudpolicy GetPolicy(int year);
        SecBaseResponse AddUpdatePlanCrudpolicy(PlanCrudpolicy policy);
        List<DepartmentDto> DepartmentGetByFiscalYear(int FiscalYear);
        List<ViewPlanForActivityByDepartmentTable> GetById(int departmentId, int FiscalYear);
        List<PlanTypeDto> PlanTypeGetByFiscalYear(int FiscalYear);

        SecBaseResponse StrategySetup(StrategySetupModel request);
        List<StrategySetupModel> StrategySetupByFiscalYear(int FiscalYear);

        SecBaseResponse PlanTypeSetup(PlanTypeRequest request);

        SecBaseResponse DepartmentSetup(DepartmentRequest request);
        List<DepartmentRespone> DepartmentListGetByFiscalYear(int FiscalYear);
        SecBaseResponse FundTypeSetup(FundTypeRequest request);

        List<FundTypeRespone> FundTypeSetupByFiscalYear(int FiscalYear);

        List<GovExpenseList> GovExpenseType(string path);
        SecBaseResponse BudgetTypeSetup(BudgetTypeRequest request);

        SecBaseResponse StrategicIndicatorSetup(StrategicIndicatorRequest request);
        List<StrategicIndicatorResponse> StrategicIndicatorSetupByFiscalYear(int FiscalYear);

        List<PrinciplePlanTagsResponse> PrinciplePlanTagSetup();

        SecBaseResponse PrinciplePlanTagSetupData(PrinciplePlanTagsRequest request);

        SecBaseResponse GovernmentDisbursementGoalSetup(GovernmentDisbursementGoal request);
        List<GovernmentDisbursementGoal> GovernmentDisbursementGoalByFiscalYear(int FiscalYear);

    }
}
