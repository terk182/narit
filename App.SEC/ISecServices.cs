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
        List<DepartmentDto> DepartmentNameGetByDepartmentid(int id);
        List<ViewPlanForActivityByDepartmentTable> GetById(int departmentId, int FiscalYear);
        List<PlanTypeDto> PlanTypeGetAll(int FiscalYear);
        List<PlanTypeDto> PlanTypeGetByFiscalYear(int FiscalYear);
        List<PlanTypeDto> PlanTypeGetByFiscalYearandPlanTypeid(int FiscalYear, int id);
        List<PlanTypeDto> PlanTypeNameGetByPlanTypeid(int id);


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

        ////////////////////////////NEW NEW NEW by ardin///////////////////////////////
        //MainGovtStatement
        List<MainGovtStatement> GetAllMainGovtStatement();
        List<MainGovtStatement> GetMainGovtStatementbyId(int MainGovtStatementId);
        SecBaseResponse MainGovtStatementSetup(MainGovtStatement request);
        SecBaseResponse DeleteMainGovtStatement(int MainGovtStatementId);
        //GovtStrategic
        List<GovtStrategic> GetAllGovtStrategic();
        List<GovtStrategic> GetGovtStrategicbyId(int GovtStrategicId);
        SecBaseResponse GovtStrategicSetup(GovtStrategic request);
        SecBaseResponse DeleteGovtStrategic(int GovtStrategicId);
        //GovtPlan
        List<GovtPlan> GetAllGovtPlan();
        List<GovtPlan> GetGovtPlanbyId(int GovtPlanId);
        SecBaseResponse GovtPlanSetup(GovtPlan request);
        SecBaseResponse DeleteGovtPlan(int GovtPlanId);
        //MainProject
        List<MainProject> GetAllMainProject();
        List<MainProject> GetMainProjectbyId(int MainProjectId);
        SecBaseResponse MainProjectSetup(MainProject request);
        SecBaseResponse DeleteMainProject(int MainProjectId);
        //MainActivity
        List<MainActivity> GetAllMainActivity();
        List<MainActivity> GetMainActivitybyId(int MainActivityId);
        SecBaseResponse MainActivitySetup(MainActivity request);
        SecBaseResponse DeleteMainActivity(int MainActivityId);
        //StrategicIssue
        List<StrategicIssue> GetAllStrategicIssue();
        List<StrategicIssue> GetStrategicIssuebyId(int StrategicIssueId);
        SecBaseResponse StrategicIssueSetup(StrategicIssue request);
        SecBaseResponse DeleteStrategicIssue(int StrategicIssueId);
        //Strategy1
        List<Strategy1> GetAllStrategy1();
        List<Strategy1> GetStrategy1byId(int Strategy1Id);
        SecBaseResponse Strategy1Setup(Strategy1 request);
        SecBaseResponse DeleteStrategy1(int Strategy1Id);
        //Measure
        List<Measure> GetAllMeasure();
        List<Measure> GetMeasurebyId(int MeasureId);
        SecBaseResponse MeasureSetup(Measure request);
        SecBaseResponse DeleteMeasure(int MeasureId);
        //AnnualBudget
        List<AnnualBudget> GetAllAnnualBudget();
        List<AnnualBudget> GetAnnualBudgetbyId(int AnnualBudgetId);
        SecBaseResponse AnnualBudgetSetup(AnnualBudget request);
        SecBaseResponse DeleteAnnualBudget(int AnnualBudgetId);
        //SubAnnualBudget
        List<SubAnnualBudget> GetAllSubAnnualBudget();
        List<SubAnnualBudget> GetSubAnnualBudgetbyId(int SubAnnualBudgetId);
        SecBaseResponse SubAnnualBudgetSetup(SubAnnualBudget request);
        SecBaseResponse DeleteSubAnnualBudget(int SubAnnualBudgetId);
        //CapticalType
        List<CapticalType> GetAllCapticalType();
        List<CapticalType> GetCapticalTypebyId(int CapticalTypeId);
        SecBaseResponse CapticalTypeSetup(CapticalType request);
        SecBaseResponse DeleteCapticalType(int CapticalTypeId);
        //Project
        List<Project> GetAllProject();
        List<Project> GetProjectbyFisicalYear(int FisicalYear);
        List<Project> GetProjectbyId(int ProjectId);
        SecBaseResponse GetsubProjectorProjectActivitybyProjectId(int ProjectId);
        SecBaseResponse ProjectSetup(Project request);
        SecBaseResponse DeleteProject(int ProjectId);
        //ProjectCaptical
        List<ProjectCaptical> GetAllProjectCaptical();
        List<ProjectCaptical> GetProjectCapticalbyId(int ProjectCapticalId);
        SecBaseResponse ProjectCapticalSetup(ProjectCaptical request);
        SecBaseResponse DeleteProjectCaptical(int ProjectCapticalId);
        //ProjectResponsiblePerson
        List<ProjectResponsiblePerson> GetAllProjectResponsiblePersons();
        List<ProjectResponsiblePerson> GetProjectResponsiblePersonsbyId(int ProjectResponsiblePersonsId);
        List<ProjectResponsiblePerson> GetProjectResponsiblePersonsbyProjectId(int ProjectId);
        SecBaseResponse ProjectResponsiblePersonsSetup(ProjectResponsiblePerson request);
        SecBaseResponse DeleteProjectResponsiblePersons(int ProjectResponsiblePersonsId);
        //IndicatorsStrategyForProject
        List<IndicatorsStrategyForProject> GetAllIndicatorsStrategyForProject();
        List<IndicatorsStrategyForProject> GetIndicatorsStrategyForProjectbyId(int IndicatorsStrategyForProjectId);
        SecBaseResponse IndicatorsStrategyForProjectSetup(IndicatorsStrategyForProject request);
        SecBaseResponse DeleteIndicatorsStrategyForProject(int IndicatorsStrategyForProjectId);
        //ExternalBudgetStrategy
        List<ExternalBudgetStrategy> GetAllExternalBudgetStrategy();
        List<ExternalBudgetStrategy> GetExternalBudgetStrategybyId(int ExternalBudgetStrategyId);
        SecBaseResponse ExternalBudgetStrategySetup(ExternalBudgetStrategy request);
        SecBaseResponse DeleteExternalBudgetStrategy(int ExternalBudgetStrategyId);
        //InternalStrategy
        List<InternalStrategy> GetAllInternalStrategy();
        List<InternalStrategy> GetInternalStrategybyId(int InternalStrategyId);
        SecBaseResponse InternalStrategySetup(InternalStrategy request);
        SecBaseResponse DeleteInternalStrategy(int InternalStrategyId);
        //ProjectActivity
        List<ProjectActivity> GetAllProjectActivity();
        List<ProjectActivity> GetProjectActivitybyId(int ProjectActivityId);
        List<ProjectActivity> GetProjectActivityforProjectbyId(int ProjectId);
        List<ProjectActivity> GetProjectActivityfromSubProjectId(int SubProjectId);
        SecBaseResponse ProjectActivitySetup(ProjectActivity request);
        SecBaseResponse DeleteProjectActivity(int ProjectActivityId);
        //SubProject
        List<SubProject> GetAllSubProject();
        List<SubProject> GetSubProjectbyId(int SubProjectId);
        List<SubProject> GetSubProjectforProjectbyId(int ProjectId);
        SecBaseResponse SubProjectSetup(SubProject request);
        SecBaseResponse DeleteSubProject(int SubProjectId);
        //ProjectActivityResponsiblePerson
        List<ProjectActivityResponsiblePerson> GetAllProjectActivityResponsiblePerson();
        List<ProjectActivityResponsiblePerson> GetProjectActivityResponsiblePersonbyId(int ProjectActivityResponsiblePersonId);
        List<ProjectActivityResponsiblePerson> GetProjectActivityResponsiblePersonsbyProjectId(int ProjectActivityId);
        SecBaseResponse ProjectActivityResponsiblePersonSetup(ProjectActivityResponsiblePerson request);
        SecBaseResponse DeleteProjectActivityResponsiblePerson(int ProjectActivityResponsiblePersonId);
        //SubProjectResponsiblePerson
        List<SubProjectResponsiblePerson> GetAllSubProjectResponsiblePerson();
        List<SubProjectResponsiblePerson> GetSubProjectResponsiblePersonbyId(int SubProjectResponsiblePersonId);
        List<SubProjectResponsiblePerson> GetSubProjectResponsiblePersonsbyProjectId(int SubProjectId);
        SecBaseResponse SubProjectResponsiblePersonSetup(SubProjectResponsiblePerson request);
        SecBaseResponse DeleteSubProjectResponsiblePerson(int SubProjectResponsiblePersonId);
    }
}
