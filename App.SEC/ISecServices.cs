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
        //งานนโยบายและแผน/ค้นหา

        //ค้นหาโครงการ(รายการหลัก)
        List<FundTypeRespone> SearchPlanForActivityFundTypeSetupByFiscalYear(int FiscalYear);
        List<DepartmentRespone> SearchPlanForActivityDepartmentListGetByFiscalYear(int FiscalYear);
        List<PlanTypeDto> SearchPlanForActivityPlanTypeGetByFiscalYear(int FiscalYear);
        //ค้นหากิจกรรม
        List<FundTypeRespone> SearchPlanActivityFundTypeSetupByFiscalYear(int FiscalYear);
        List<DepartmentRespone> SearchPlanActivityDepartmentListGetByFiscalYear(int FiscalYear);
        List<PlanTypeDto> SearchPlanActivityPlanTypeGetByFiscalYear(int FiscalYear);
        //ค้นหารายการย่อย
        List<FundTypeRespone> SearchPlanItemFundTypeSetupByFiscalYear(int FiscalYear);
        List<DepartmentRespone> SearchPlanItemDepartmentListGetByFiscalYear(int FiscalYear);
        List<PlanTypeDto> SearchPlanItemPlanTypeGetByFiscalYear(int FiscalYear);

        ViewPlanActivityListDataDto SearchPlanItemById(int PlanActivityId);
        List<ViewPlanForActivityByDepartmentTable> ReceivedReservedBudgetByPlanCreateTableData(int planTypeId, int fiscalYear, int depId = 0);
        List<ViewPlanForActivityByPlanTypeBudgetTypeTable> ViewPlanForActivityByPlanTypeBudgetTypeCreateTableData(int planTypeId, int fiscalYear, int depId = 0);
        ViewReceivedReservedBudgetByPlanActivityDto ViewReceivedReservedBudgetByPlanActivity(int PlanActivityId);

        ViewPlanActivityOperationPeriodByPlanCoreDto ViewPlanActivityOperationPeriodByPlanCore(int PlanCoreId);
        ViewPlanActivityOperationPeriodByPlanCoreDto EditPlanActivityOperationPeriodResult(int PlanActivityId);

        PerformanceIndicatorData ViewPerformanceIndicatorByPlanActivityList(int PlanCoreId);
        calBudgetDetail calbudget(ICollection<PlanActivity> planActivity);

        List<Team> ResponsiblePeopleData(ICollection<ResponsiblePerson> ResponsiblePerson);
        List<PlanCoreApproveStatusReportResponse> PlanCoreApproveStatusReport(PlanCoreApproveStatusReportRequest request);

        List<aListModel> aList(int fiscalYear);
        PlanCoreListDto GetEditPlan(int PlanCoreId);

        List<PrinciplePlanTagDto> EditPlanPrinciplePlanTags();

        List<StrategyDto> EditPlanStrategicIndicatorServ(int fiscalYear);
        List<PlanTypeTreeDto> PlanTypeTree(int fiscalYear);
        List<PerformanceIndicatorsDto> EditPerformanceIndicator(int fiscalYear);

    }
}
