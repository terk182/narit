using App.Common.Dtos;
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
        SecBaseResponse EditScheduleFisicalYear(string name, bool active);
        List<ScheduleFisicalYear> GetScheduleFisicalYear();
        List<ScheduleFisicalYear> GetScheduleFisicalYearbyYear(int year);
        SecBaseResponse ScheduleFisicalYearSetUp(ScheduleFisicalYear Request);
        List<BudgetType> GetByFiscalYear(int FiscalYear);
        PlanCrudpolicy GetPolicy(int year);
        SecBaseResponse AddUpdatePlanCrudpolicy(PlanCrudpolicy policy);
        List<DepartmentDto> DepartmentGetByFiscalYear(int FiscalYear);

        List<DepartmentDto> DepartmentGetByFiscalYearandDepartmentid(int FiscalYear, int id);
        List<ViewPlanForActivityByDepartmentTable> GetById(int departmentId, int FiscalYear);
        List<PlanTypeDto> PlanTypeGetAll(int FiscalYear);
        List<PlanTypeDto> PlanTypeGetByFiscalYear(int FiscalYear);
        List<PlanTypeDto> PlanTypeGetByFiscalYearandPlanTypeid(int FiscalYear, int id);


        SecBaseResponse StrategySetup(StrategySetupModel request);
        List<StrategySetupModel> StrategySetupByFiscalYear(int FiscalYear);
        List<StrategySetupModel> StrategySetupByFiscalYearandStrategyId(int FiscalYear, int id);
        SecBaseResponse StrategyBudgetSetup(StrategyBudgetDto request);
        List<StrategyBudgetDto> StrategyBudgetByFiscalYear(int FiscalYear);
        List<StrategyBudgetDto> StrategyBudgetByFiscalYearandStrategyId(int FiscalYear, int id);

        SecBaseResponse PlanTypeSetup(PlanTypeRequest request);

        SecBaseResponse DepartmentSetup(DepartmentRequest request);
        SecBaseResponse DepartmentBudgetLimitSetup(DepartmentBudgetLimitRequest request);
        List<DepartmentRespone> DepartmentListGetByFiscalYear(int FiscalYear);
        List<DepartmentBudgetLimitDto> DepartmentBudgetLimitGetByFiscalYear(int FiscalYear);
        //we are here
        SecBaseResponse FundTypeSetup(FundTypeRequest request);

        List<FundTypeRespone> FundTypeSetupByFiscalYear(int FiscalYear);

        List<FundSourceResponse> FundSourceSetupByFiscalYear(int FiscalYear);
        List<MissionResponse> MissionSetupByFiscalYear(int FiscalYear);
        SecBaseResponse MissionSetup(MissionRequest request);
        SecBaseResponse FundSourceSetup(FundSourceRequest request);
        List<GovExpenseList> GovExpenseType(string path);
        SecBaseResponse BudgetTypeSetup(BudgetTypeRequest request);

        SecBaseResponse StrategicIndicatorSetup(StrategicIndicatorRequest request);
        List<StrategicIndicatorResponse> StrategicIndicatorSetupByFiscalYear(int FiscalYear);
        List<StrategicIndicatorResponse> StrategicIndicatorGetbyStrategyId(int StrategyId);
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
        List<ViewPlanItemNameDto> SearchPlanItemNameByPlanActivityId(int PlanActivityId);
        List<ViewPlanForActivityByDepartmentTable> ReceivedReservedBudgetByPlanCreateTableData(int planTypeId, int fiscalYear, int depId = 0);
        List<ViewPlanForActivityByPlanTypeBudgetTypeTable> ViewPlanForActivityByPlanTypeBudgetTypeCreateTableData(int planTypeId, int fiscalYear, int depId = 0);
        ViewReceivedReservedBudgetByPlanActivityDto ViewReceivedReservedBudgetByPlanActivity(int PlanActivityId);

        ViewPlanActivityOperationPeriodByPlanCoreDto ViewPlanActivityOperationPeriodByPlanCore(int PlanCoreId);
        ViewPlanActivityOperationPeriodByPlanCoreDto EditPlanActivityOperationPeriodResult(int PlanActivityId);

        PerformanceIndicatorData ViewPerformanceIndicatorByPlanActivityList(int PlanCoreId);
        calBudgetDetail calbudget(ICollection<PlanActivity> planActivity);
        calBudgetDetail calbudget_by_Month(ICollection<PlanActivity> planActivity,int Month);

        List<Team> ResponsiblePeopleData(ICollection<ResponsiblePerson> ResponsiblePerson);
        List<PlanCoreApproveStatusReportResponse> PlanCoreApproveStatusReport(PlanCoreApproveStatusReportRequest request);

        List<aListModel> aList(int fiscalYear);
        PlanCoreListDto GetEditPlan(int PlanCoreId);
        SecBaseResponse PlanCoreSetUp(PlanCoreRequest request);
        SecBaseResponse ResponsiblePersonSetUp(ResponsiblePersonRequest request);
        SecBaseResponse PerformanceIndicatorSetUp(PerformanceIndicatorRequest request);
        List<PlanCoreGetAllDto> GetAllPlanCore(int fisicalYear);
        List<PlanCoreGetAllbyStaffIdDto> GetAllPlanCorebyStaffId(int fisicalYear, int staffId);
        List<PlanCoreGetAllDto> GetPlanCorefromParentPlanCore(int plancoreId);
        List<PlanCoreDetailDto> GetPlanCoreDetail(int plancoreId);
        List<PlanActivityGetAllDto> GetPlanActivityfromPlanCoreId(int plancoreId);
        List<StaffGetAllDto> GetAllStaff();
        List<PrinciplePlanTagDto> EditPlanPrinciplePlanTags();

        List<StrategyDto> EditPlanStrategicIndicatorServ(int fiscalYear);
        List<PlanTypeTreeDto> PlanTypeTree(int fiscalYear);
        //List<PerformanceIndicatorsDto> EditPerformanceIndicator(int fiscalYear);
        List<StrategicIndicatorResponse> EditPerformanceIndicator(int fiscalYear);
        List<DepartmentListDto> GetDepartments(int fiscalYear);
        List<StrategySetupDto> TryGetStrategy(int fiscalYear);
        List<ResponsiblePerson> getResponsiblePerson();
        SecBaseResponse PlanCoreAddUpdate(PlanCoreListDto request);
        SecBaseResponse PlanItemByBudgetTypeAndPlanTypeReport(int fiscalYear, int month, int planTypeId, int budgetTypeId);

        List<ViewPlanForActivityByPlanTypeBudgetTypeTable> PlanReportByPlanType(int fiscalYear);
        List<ViewPlanForActivityByPlanTypeBudgetTypeTable> PlanReportByDepartment(int fiscalYear);
        List<BudgetTypeCommonDto> PlanReportByBudgetType(int fiscalYear);
        planItemCal calPlanItem(int Id, int fiscalYear);
        List<BudgetTypeCommonDto> PlanReportByStrategy(int fiscalYear);

        List<BudgetTransferFormResponse> ViewPlanItemBudgetTransferListForApprove(BudgetTransferFormRequest request);
        ViewGeneralExpenseMemoFormResponse ViewGeneralExpenseMemoFormListForApproval(ViewGeneralExpenseMemoFormLisRequest request);
        ViewSettleReceiptFormListResponse ViewSettleReceiptFormListForApproval(ViewSettleReceiptFormListRequest request);
        ViewGeneralExpenseSettleFormListResponse ViewGeneralExpenseSettleFormListForApproval(ViewGeneralExpenseSettleFormListRequest request);
        List<GeneralExpenseMemoFormDto> ViewGeneralExpenseMemoFormList(ViewGeneralExpenseMemoFormListRequest request);
        List<BudgetTransferFormDto> ViewPlanItemBudgetTransferList(ViewPlanItemBudgetTransferListRespons request);
        SecBaseResponse DeleteStrategy(int StrategyId);
        SecBaseResponse DeleteStrategyBudget(int StrategyBudgetId);
        SecBaseResponse DeleteStrategicIndicator(int StrategicIndicatorId);
        SecBaseResponse DeletePlanType(int PlanTypeId);
        SecBaseResponse DeleteDepartment(int DepartmentId);
        SecBaseResponse DeleteFundType(int FundTypeId);
        SecBaseResponse DeleteBudgetType(int BudgetTypeId);
        SecBaseResponse DeletePlanCore(int PlanCoreId);
        SecBaseResponse DeleteResponsiblePerson(int ResponsiblePersonId);
        SecBaseResponse DeleteFundSource(int FundSourceId);
        SecBaseResponse DeleteMission(int MissionId);
        SecBaseResponse EditGeneralExpenseExtendForm(GeneralExpenseMemoFormRequest request);
        SecBaseResponse CostTypeSetup(CostTypeRequest request);
        SecBaseResponse PlanCRUDPolicySetup(PlanCrudpolicy request);
        SecBaseResponse PlanItemTypes(PlanItemTypeRequest request);
        SecBaseResponse PlanPerson(PlanPersonRequest request);
        List<GeneralExpenseSettleForm> ViewGeneralExpenseSettleAsBudgetFormList(ViewGeneralExpenseSettleAsBudgetFormListRequest request);
        List<GeneralExpenseSettleForm> viewGeneralExpenseSettleFormList(ViewGeneralExpenseSettleFormListRequest request);
        List<MonthlyForecastAdjustment> ViewMonthlyForecastAdjustmentList(ViewMonthlyForecastAdjustmentListRequest request );
        List<GeneralExpenseSettleForm> ViewOutsideDutyReportFormList(ViewOutsideDutyReportFormListRequest request);
        SecBaseResponse BudgetTransferForm(BudgetTransferFormDto request);
        SecBaseResponse EditChangedPlanItemRecord(RequestFormPlanViewRequest request);
        SecBaseResponse EditDirectExpenseMemoForm(DirectExpenseMemoFormRequest request);
        SecBaseResponse EditGeneralExpenseExtendForm(GeneralExpenseExtendFormRequest request);//แบบฟอร์มค่าใช้จ่ายทั่วไปขยาย
        SecBaseResponse EditGeneralExpensePersonalBorrowForm(List<GeneralExpensePersonalBorrowItemRequest> request); //แก้ไขค่าใช้จ่ายทั่วไปแบบฟอร์มการยืมส่วนบุคคล
        SecBaseResponse EditGeneralExpenseSettleForm(GeneralExpenseSettleFormRequest request);//แบบฟอร์มชำระค่าใช้จ่ายทั่วไป 
        SecBaseResponse EditMonthlyForecastAdjustment_t(MonthlyForecastAdjustment request);
        SecBaseResponse EditOutsideDutyReportForm(List<OutsideDutyReportStaff> request);
        SecBaseResponse EditPerformanceIndicatorResult(PerformanceIndicator request);
        SecBaseResponse EditPlanActivity(PlanActivityRequest request);
        SecBaseResponse EditPlanItem(PlanItemRequest request);
        SecBaseResponse EditPlanMonthlyOperation(PlanMonthlyOperation request);
        SecBaseResponse EditSettleReceiptForm(SettleReceiptForm request);
        List<PlanActivity> SearchPlanActivity(SearchPlanActivityRequest request);
        List<PlanItem> SearchPlanItem(SearchPlanItemRequest request);
        List<Supplier> SelectSupplierListForForm(SelectSupplierListForFormRequest request);
        List<GeneralExpenseMemoForm> ViewGeneralExpenseMemoFormListForExtend(ViewGeneralExpenseMemoFormListForExtendRequest request);
        List<RequestFormPlanView> ViewChangedPlanItemRecordList(ViewChangedPlanItemRecordListRequest request);
        List<DirectExpenseMemoForm> ViewDirectExpenseMemoFormList(ViewDirectExpenseMemoFormListRequest request);

        SecBaseResponse EditOutsideDutyGroup(List<OutsideDutyGroupRequest> request);
        List<OutsideDutyGroupRequest> GetditOutsideDutyGroup(int GeneralExpenseMemoFormsId);


    }
}
