using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace narit_mis_api.Models
{
    public partial class NARIT_MIS_LINKContext : DbContext
    {
        public NARIT_MIS_LINKContext()
        {
        }

        public NARIT_MIS_LINKContext(DbContextOptions<NARIT_MIS_LINKContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accommodation> Accommodations { get; set; } = null!;
        public virtual DbSet<AccommodationVisiting> AccommodationVisitings { get; set; } = null!;
        public virtual DbSet<AdditionalSettleItem> AdditionalSettleItems { get; set; } = null!;
        public virtual DbSet<Address> Addresses { get; set; } = null!;
        public virtual DbSet<AddressStyle> AddressStyles { get; set; } = null!;
        public virtual DbSet<AddressType> AddressTypes { get; set; } = null!;
        public virtual DbSet<Agreement> Agreements { get; set; } = null!;
        public virtual DbSet<AgreementApproveItemTransform> AgreementApproveItemTransforms { get; set; } = null!;
        public virtual DbSet<AgreementForm> AgreementForms { get; set; } = null!;
        public virtual DbSet<AgreementItem> AgreementItems { get; set; } = null!;
        public virtual DbSet<AgreementItemPlanReferenceItem> AgreementItemPlanReferenceItems { get; set; } = null!;
        public virtual DbSet<AgreementMemorandum> AgreementMemorandums { get; set; } = null!;
        public virtual DbSet<AgreementVisiting> AgreementVisitings { get; set; } = null!;
        public virtual DbSet<AppFormActionLog> AppFormActionLogs { get; set; } = null!;
        public virtual DbSet<Application> Applications { get; set; } = null!;
        public virtual DbSet<ApproveForm> ApproveForms { get; set; } = null!;
        public virtual DbSet<ApproveItem> ApproveItems { get; set; } = null!;
        public virtual DbSet<ApproveItemPlanReferenceItem> ApproveItemPlanReferenceItems { get; set; } = null!;
        public virtual DbSet<ApproveMemorandum> ApproveMemorandums { get; set; } = null!;
        public virtual DbSet<ApproveOrderItemTransform> ApproveOrderItemTransforms { get; set; } = null!;
        public virtual DbSet<AspnetApplication> AspnetApplications { get; set; } = null!;
        public virtual DbSet<AspnetMembership> AspnetMemberships { get; set; } = null!;
        public virtual DbSet<AspnetPath> AspnetPaths { get; set; } = null!;
        public virtual DbSet<AspnetPersonalizationAllUser> AspnetPersonalizationAllUsers { get; set; } = null!;
        public virtual DbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; } = null!;
        public virtual DbSet<AspnetProfile> AspnetProfiles { get; set; } = null!;
        public virtual DbSet<AspnetRole> AspnetRoles { get; set; } = null!;
        public virtual DbSet<AspnetSchemaVersion> AspnetSchemaVersions { get; set; } = null!;
        public virtual DbSet<AspnetUser> AspnetUsers { get; set; } = null!;
        public virtual DbSet<AspnetWebEventEvent> AspnetWebEventEvents { get; set; } = null!;
        public virtual DbSet<AuFormActionLog> AuFormActionLogs { get; set; } = null!;
        public virtual DbSet<AuthorizeForm> AuthorizeForms { get; set; } = null!;
        public virtual DbSet<BillingFile> BillingFiles { get; set; } = null!;
        public virtual DbSet<BillingLocation> BillingLocations { get; set; } = null!;
        public virtual DbSet<BtFormActionLog> BtFormActionLogs { get; set; } = null!;
        public virtual DbSet<BudgetTransfer> BudgetTransfers { get; set; } = null!;
        public virtual DbSet<BudgetTransferForm> BudgetTransferForms { get; set; } = null!;
        public virtual DbSet<BudgetType> BudgetTypes { get; set; } = null!;
        public virtual DbSet<CertifyOfMedicalRightForm> CertifyOfMedicalRightForms { get; set; } = null!;
        public virtual DbSet<CheckForm> CheckForms { get; set; } = null!;
        public virtual DbSet<CheckFormActionLog> CheckFormActionLogs { get; set; } = null!;
        public virtual DbSet<CheckFormPlanView> CheckFormPlanViews { get; set; } = null!;
        public virtual DbSet<CheckItem> CheckItems { get; set; } = null!;
        public virtual DbSet<CheckItemPlanReferenceItem> CheckItemPlanReferenceItems { get; set; } = null!;
        public virtual DbSet<CheckRequisitionItemTransform> CheckRequisitionItemTransforms { get; set; } = null!;
        public virtual DbSet<CheckViewUsedPlanItem> CheckViewUsedPlanItems { get; set; } = null!;
        public virtual DbSet<ChildTuitionFeeRequestForm> ChildTuitionFeeRequestForms { get; set; } = null!;
        public virtual DbSet<CoReportRefFilingDocument> CoReportRefFilingDocuments { get; set; } = null!;
        public virtual DbSet<CoReportRefGeMomoForm> CoReportRefGeMomoForms { get; set; } = null!;
        public virtual DbSet<CollaborateReport> CollaborateReports { get; set; } = null!;
        public virtual DbSet<CollaborateStaff> CollaborateStaffs { get; set; } = null!;
        public virtual DbSet<CollaborationNetworkFile> CollaborationNetworkFiles { get; set; } = null!;
        public virtual DbSet<CompetencyEvaluationForm> CompetencyEvaluationForms { get; set; } = null!;
        public virtual DbSet<CompetencyEvaluationItem> CompetencyEvaluationItems { get; set; } = null!;
        public virtual DbSet<CompetencyTopicExpectScore> CompetencyTopicExpectScores { get; set; } = null!;
        public virtual DbSet<CompetencyTopicItem> CompetencyTopicItems { get; set; } = null!;
        public virtual DbSet<ContactPerson> ContactPersons { get; set; } = null!;
        public virtual DbSet<ContactPersonHistory> ContactPersonHistories { get; set; } = null!;
        public virtual DbSet<ContactPersonVisiting> ContactPersonVisitings { get; set; } = null!;
        public virtual DbSet<ContractEndEvaluationForm> ContractEndEvaluationForms { get; set; } = null!;
        public virtual DbSet<CostType> CostTypes { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<DailyAttendance> DailyAttendances { get; set; } = null!;
        public virtual DbSet<DailyAttendanceRequestForm> DailyAttendanceRequestForms { get; set; } = null!;
        public virtual DbSet<DeFormActionLog> DeFormActionLogs { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<DepartmentInternalFilingNumber> DepartmentInternalFilingNumbers { get; set; } = null!;
        public virtual DbSet<DevelopmentRecord> DevelopmentRecords { get; set; } = null!;
        public virtual DbSet<DevelopmentRecordCancellation> DevelopmentRecordCancellations { get; set; } = null!;
        public virtual DbSet<DevelopmentRecordFollowUpForm> DevelopmentRecordFollowUpForms { get; set; } = null!;
        public virtual DbSet<DevelopmentRecordGroup> DevelopmentRecordGroups { get; set; } = null!;
        public virtual DbSet<DevelopmentRecordGroupCancellation> DevelopmentRecordGroupCancellations { get; set; } = null!;
        public virtual DbSet<DirectExpense> DirectExpenses { get; set; } = null!;
        public virtual DbSet<DirectExpenseMemoForm> DirectExpenseMemoForms { get; set; } = null!;
        public virtual DbSet<DocumentWarehouse> DocumentWarehouses { get; set; } = null!;
        public virtual DbSet<DrinkingWaterBill> DrinkingWaterBills { get; set; } = null!;
        public virtual DbSet<EducationLevel> EducationLevels { get; set; } = null!;
        public virtual DbSet<EducationRecord> EducationRecords { get; set; } = null!;
        public virtual DbSet<EfilingDepartmentPermission> EfilingDepartmentPermissions { get; set; } = null!;
        public virtual DbSet<ElectricityBill> ElectricityBills { get; set; } = null!;
        public virtual DbSet<EmploymentContract> EmploymentContracts { get; set; } = null!;
        public virtual DbSet<FamilialRelationship> FamilialRelationships { get; set; } = null!;
        public virtual DbSet<FilingDocMessageReferrer> FilingDocMessageReferrers { get; set; } = null!;
        public virtual DbSet<FilingDocProjectRelation> FilingDocProjectRelations { get; set; } = null!;
        public virtual DbSet<FilingDocTagRelation> FilingDocTagRelations { get; set; } = null!;
        public virtual DbSet<FilingDocWarehouseRelation> FilingDocWarehouseRelations { get; set; } = null!;
        public virtual DbSet<FilingDocument> FilingDocuments { get; set; } = null!;
        public virtual DbSet<FilingDocumentAccessLog> FilingDocumentAccessLogs { get; set; } = null!;
        public virtual DbSet<FilingDocumentHistory> FilingDocumentHistories { get; set; } = null!;
        public virtual DbSet<FilingDocumentReferrer> FilingDocumentReferrers { get; set; } = null!;
        public virtual DbSet<FilingFile> FilingFiles { get; set; } = null!;
        public virtual DbSet<FilingFileAccessLog> FilingFileAccessLogs { get; set; } = null!;
        public virtual DbSet<FilingGeneralOrder> FilingGeneralOrders { get; set; } = null!;
        public virtual DbSet<FilingHrdepartmentPermission> FilingHrdepartmentPermissions { get; set; } = null!;
        public virtual DbSet<FilingHrdepartmentStaffPermission> FilingHrdepartmentStaffPermissions { get; set; } = null!;
        public virtual DbSet<FilingOpinion> FilingOpinions { get; set; } = null!;
        public virtual DbSet<FilingPersonalMarkup> FilingPersonalMarkups { get; set; } = null!;
        public virtual DbSet<FilingPostscript> FilingPostscripts { get; set; } = null!;
        public virtual DbSet<FilingProject> FilingProjects { get; set; } = null!;
        public virtual DbSet<FilingRegisterBook> FilingRegisterBooks { get; set; } = null!;
        public virtual DbSet<FilingRegisterNumber> FilingRegisterNumbers { get; set; } = null!;
        public virtual DbSet<FilingRegisterNumberLog> FilingRegisterNumberLogs { get; set; } = null!;
        public virtual DbSet<FilingSecretary> FilingSecretaries { get; set; } = null!;
        public virtual DbSet<FilingSendForm> FilingSendForms { get; set; } = null!;
        public virtual DbSet<FilingTag> FilingTags { get; set; } = null!;
        public virtual DbSet<FinancialReimbursementForm> FinancialReimbursementForms { get; set; } = null!;
        public virtual DbSet<FinancialReimbursementItem> FinancialReimbursementItems { get; set; } = null!;
        public virtual DbSet<FingerPrintDbconnector> FingerPrintDbconnectors { get; set; } = null!;
        public virtual DbSet<FingerPrintDbrawData> FingerPrintDbrawDatas { get; set; } = null!;
        public virtual DbSet<FingerPrintReaderSensor> FingerPrintReaderSensors { get; set; } = null!;
        public virtual DbSet<FormRequest> FormRequests { get; set; } = null!;
        public virtual DbSet<FrFormActionLog> FrFormActionLogs { get; set; } = null!;
        public virtual DbSet<FundSource> FundSources { get; set; } = null!;
        public virtual DbSet<FundType> FundTypes { get; set; } = null!;
        public virtual DbSet<GarbageBill> GarbageBills { get; set; } = null!;
        public virtual DbSet<GeBorrowFormActionLog> GeBorrowFormActionLogs { get; set; } = null!;
        public virtual DbSet<GeExtendFormActionLog> GeExtendFormActionLogs { get; set; } = null!;
        public virtual DbSet<GeFormActionLog> GeFormActionLogs { get; set; } = null!;
        public virtual DbSet<GedataGroup> GedataGroups { get; set; } = null!;
        public virtual DbSet<GememoFormSchedule> GememoFormSchedules { get; set; } = null!;
        public virtual DbSet<GeneralExpense> GeneralExpenses { get; set; } = null!;
        public virtual DbSet<GeneralExpenseCancelForm> GeneralExpenseCancelForms { get; set; } = null!;
        public virtual DbSet<GeneralExpenseCancelItem> GeneralExpenseCancelItems { get; set; } = null!;
        public virtual DbSet<GeneralExpenseExtendForm> GeneralExpenseExtendForms { get; set; } = null!;
        public virtual DbSet<GeneralExpenseMemoForm> GeneralExpenseMemoForms { get; set; } = null!;
        public virtual DbSet<GeneralExpensePersonalBorrowForm> GeneralExpensePersonalBorrowForms { get; set; } = null!;
        public virtual DbSet<GeneralExpensePersonalBorrowItem> GeneralExpensePersonalBorrowItems { get; set; } = null!;
        public virtual DbSet<GeneralExpenseReturnForm> GeneralExpenseReturnForms { get; set; } = null!;
        public virtual DbSet<GeneralExpenseReturnItem> GeneralExpenseReturnItems { get; set; } = null!;
        public virtual DbSet<GeneralExpenseSettleForm> GeneralExpenseSettleForms { get; set; } = null!;
        public virtual DbSet<GovernmentDisbursementGoal> GovernmentDisbursementGoals { get; set; } = null!;
        public virtual DbSet<GprocurementRss> GprocurementRsses { get; set; } = null!;
        public virtual DbSet<Holiday> Holidays { get; set; } = null!;
        public virtual DbSet<HrcertifiedDocumentRequestForm> HrcertifiedDocumentRequestForms { get; set; } = null!;
        public virtual DbSet<Hrdepartment> Hrdepartments { get; set; } = null!;
        public virtual DbSet<HrdepartmentStaffPermissionForHr> HrdepartmentStaffPermissionForHrs { get; set; } = null!;
        public virtual DbSet<HrdevelopmentType> HrdevelopmentTypes { get; set; } = null!;
        public virtual DbSet<Hrfile> Hrfiles { get; set; } = null!;
        public virtual DbSet<Insignia> Insignias { get; set; } = null!;
        public virtual DbSet<InsigniaRank> InsigniaRanks { get; set; } = null!;
        public virtual DbSet<Itinerary> Itineraries { get; set; } = null!;
        public virtual DbSet<JobDescription> JobDescriptions { get; set; } = null!;
        public virtual DbSet<JobFunctionalPosition> JobFunctionalPositions { get; set; } = null!;
        public virtual DbSet<JobPosition> JobPositions { get; set; } = null!;
        public virtual DbSet<JobPositionGroup> JobPositionGroups { get; set; } = null!;
        public virtual DbSet<JobPositionKeyCompetencyDetail> JobPositionKeyCompetencyDetails { get; set; } = null!;
        public virtual DbSet<JobPositionLevel> JobPositionLevels { get; set; } = null!;
        public virtual DbSet<JobPositionType> JobPositionTypes { get; set; } = null!;
        public virtual DbSet<JobQualification> JobQualifications { get; set; } = null!;
        public virtual DbSet<JobResponsibility> JobResponsibilities { get; set; } = null!;
        public virtual DbSet<JobResponsibilityEvaluationForm> JobResponsibilityEvaluationForms { get; set; } = null!;
        public virtual DbSet<JobResponsibilityEvaluationItem> JobResponsibilityEvaluationItems { get; set; } = null!;
        public virtual DbSet<JobResponsibilityExpectScore> JobResponsibilityExpectScores { get; set; } = null!;
        public virtual DbSet<JobResponsibilityGroup> JobResponsibilityGroups { get; set; } = null!;
        public virtual DbSet<KeyCompetency> KeyCompetencies { get; set; } = null!;
        public virtual DbSet<Leaf> Leaves { get; set; } = null!;
        public virtual DbSet<LeaveArchievedRecord> LeaveArchievedRecords { get; set; } = null!;
        public virtual DbSet<LeaveCancellationForm> LeaveCancellationForms { get; set; } = null!;
        public virtual DbSet<LeaveType> LeaveTypes { get; set; } = null!;
        public virtual DbSet<LeaveTypeLimit> LeaveTypeLimits { get; set; } = null!;
        public virtual DbSet<MedicalReimbursement> MedicalReimbursements { get; set; } = null!;
        public virtual DbSet<MedicalRightRequestForm> MedicalRightRequestForms { get; set; } = null!;
        public virtual DbSet<Message> Messages { get; set; } = null!;
        public virtual DbSet<MessageHistory> MessageHistories { get; set; } = null!;
        public virtual DbSet<MisGeneralExpenseMemoFormsSignList> MisGeneralExpenseMemoFormsSignLists { get; set; } = null!;
        public virtual DbSet<MisSsoMatching> MisSsoMatchings { get; set; } = null!;
        public virtual DbSet<Mission> Missions { get; set; } = null!;
        public virtual DbSet<MonthlyForecast> MonthlyForecasts { get; set; } = null!;
        public virtual DbSet<MonthlyForecastAdjustment> MonthlyForecastAdjustments { get; set; } = null!;
        public virtual DbSet<NameTitle> NameTitles { get; set; } = null!;
        public virtual DbSet<Nationality> Nationalities { get; set; } = null!;
        public virtual DbSet<OperationFile> OperationFiles { get; set; } = null!;
        public virtual DbSet<OrFormActionLog> OrFormActionLogs { get; set; } = null!;
        public virtual DbSet<OrderCheckItemTransform> OrderCheckItemTransforms { get; set; } = null!;
        public virtual DbSet<OrderContract> OrderContracts { get; set; } = null!;
        public virtual DbSet<OrderForm> OrderForms { get; set; } = null!;
        public virtual DbSet<OrderItem> OrderItems { get; set; } = null!;
        public virtual DbSet<OrderItemPlanReferenceItem> OrderItemPlanReferenceItems { get; set; } = null!;
        public virtual DbSet<Organization> Organizations { get; set; } = null!;
        public virtual DbSet<OrganizationVisiting> OrganizationVisitings { get; set; } = null!;
        public virtual DbSet<OutsideDuty> OutsideDuties { get; set; } = null!;
        public virtual DbSet<OutsideDutyCancellation> OutsideDutyCancellations { get; set; } = null!;
        public virtual DbSet<OutsideDutyGroup> OutsideDutyGroups { get; set; } = null!;
        public virtual DbSet<OutsideDutyGroupCancellation> OutsideDutyGroupCancellations { get; set; } = null!;
        public virtual DbSet<OutsideDutyReportActionLog> OutsideDutyReportActionLogs { get; set; } = null!;
        public virtual DbSet<OutsideDutyReportForm> OutsideDutyReportForms { get; set; } = null!;
        public virtual DbSet<OutsideDutyReportReceipt> OutsideDutyReportReceipts { get; set; } = null!;
        public virtual DbSet<OutsideDutyReportStaff> OutsideDutyReportStaffs { get; set; } = null!;
        public virtual DbSet<OverTimeMultiplyRate> OverTimeMultiplyRates { get; set; } = null!;
        public virtual DbSet<OverTimeRatePerHour> OverTimeRatePerHours { get; set; } = null!;
        public virtual DbSet<OverTimeRequestForm> OverTimeRequestForms { get; set; } = null!;
        public virtual DbSet<OverTimeRequestFormGroup> OverTimeRequestFormGroups { get; set; } = null!;
        public virtual DbSet<OverTimeRequestResultFormGroup> OverTimeRequestResultFormGroups { get; set; } = null!;
        public virtual DbSet<PastDevelopmentRecord> PastDevelopmentRecords { get; set; } = null!;
        public virtual DbSet<PerfYearlyEvalFormActionLog> PerfYearlyEvalFormActionLogs { get; set; } = null!;
        public virtual DbSet<PerformanceIndicator> PerformanceIndicators { get; set; } = null!;
        public virtual DbSet<PerformanceIndicatorFile> PerformanceIndicatorFiles { get; set; } = null!;
        public virtual DbSet<PerformanceYearlyEvaluationForm> PerformanceYearlyEvaluationForms { get; set; } = null!;
        public virtual DbSet<PerformanceYearlyEvaluationWeight> PerformanceYearlyEvaluationWeights { get; set; } = null!;
        public virtual DbSet<PersonalAbility> PersonalAbilities { get; set; } = null!;
        public virtual DbSet<PlanActivity> PlanActivities { get; set; } = null!;
        public virtual DbSet<PlanActivityActionLog> PlanActivityActionLogs { get; set; } = null!;
        public virtual DbSet<PlanCore> PlanCores { get; set; } = null!;
        public virtual DbSet<PlanCoreActionLog> PlanCoreActionLogs { get; set; } = null!;
        public virtual DbSet<PlanCoreStaffPermission> PlanCoreStaffPermissions { get; set; } = null!;
        public virtual DbSet<PlanCrudpolicy> PlanCrudpolicies { get; set; } = null!;
        public virtual DbSet<PlanDepartmentStaffPermission> PlanDepartmentStaffPermissions { get; set; } = null!;
        public virtual DbSet<PlanFile> PlanFiles { get; set; } = null!;
        public virtual DbSet<PlanFundSource> PlanFundSources { get; set; } = null!;
        public virtual DbSet<PlanItem> PlanItems { get; set; } = null!;
        public virtual DbSet<PlanItemActionLog> PlanItemActionLogs { get; set; } = null!;
        public virtual DbSet<PlanItemType> PlanItemTypes { get; set; } = null!;
        public virtual DbSet<PlanMonthlyOperation> PlanMonthlyOperations { get; set; } = null!;
        public virtual DbSet<PlanMonthlyOperationChangeLog> PlanMonthlyOperationChangeLogs { get; set; } = null!;
        public virtual DbSet<PlanPerson> PlanPersons { get; set; } = null!;
        public virtual DbSet<PlanType> PlanTypes { get; set; } = null!;
        public virtual DbSet<PostDevelopmentRecordEvaluationForm> PostDevelopmentRecordEvaluationForms { get; set; } = null!;
        public virtual DbSet<PrinciplePlanTag> PrinciplePlanTags { get; set; } = null!;
        public virtual DbSet<ProbationEvaluationForm> ProbationEvaluationForms { get; set; } = null!;
        public virtual DbSet<ProcureComitteeGroup> ProcureComitteeGroups { get; set; } = null!;
        public virtual DbSet<ProcureComitteePerson> ProcureComitteePersons { get; set; } = null!;
        public virtual DbSet<ProcureContract> ProcureContracts { get; set; } = null!;
        public virtual DbSet<ProcureContractInstallment> ProcureContractInstallments { get; set; } = null!;
        public virtual DbSet<ProcureDepartmentPermission> ProcureDepartmentPermissions { get; set; } = null!;
        public virtual DbSet<ProcureFile> ProcureFiles { get; set; } = null!;
        public virtual DbSet<ProcureLoaningCancelForm> ProcureLoaningCancelForms { get; set; } = null!;
        public virtual DbSet<ProcureLoaningFormActionLog> ProcureLoaningFormActionLogs { get; set; } = null!;
        public virtual DbSet<ProcureLoaningItem> ProcureLoaningItems { get; set; } = null!;
        public virtual DbSet<ProcureLoaningItemPlanReferenceItem> ProcureLoaningItemPlanReferenceItems { get; set; } = null!;
        public virtual DbSet<ProcureLoaningMemoForm> ProcureLoaningMemoForms { get; set; } = null!;
        public virtual DbSet<ProcureLoaningReturnForm> ProcureLoaningReturnForms { get; set; } = null!;
        public virtual DbSet<ProcureLoaningSettleItem> ProcureLoaningSettleItems { get; set; } = null!;
        public virtual DbSet<ProcureLoaningWithdrawalForm> ProcureLoaningWithdrawalForms { get; set; } = null!;
        public virtual DbSet<ProcureLoaningWithdrawalFormPlanView> ProcureLoaningWithdrawalFormPlanViews { get; set; } = null!;
        public virtual DbSet<ProcureLoaningWithdrawalItem> ProcureLoaningWithdrawalItems { get; set; } = null!;
        public virtual DbSet<ProcureRepairForm> ProcureRepairForms { get; set; } = null!;
        public virtual DbSet<ProcureRepairFormActionLog> ProcureRepairFormActionLogs { get; set; } = null!;
        public virtual DbSet<ProcureSeFormActionLog> ProcureSeFormActionLogs { get; set; } = null!;
        public virtual DbSet<ProcureSettleMemoForm> ProcureSettleMemoForms { get; set; } = null!;
        public virtual DbSet<ProcureSettleReceiptForm> ProcureSettleReceiptForms { get; set; } = null!;
        public virtual DbSet<ProcureSettleReceiptFormPlanView> ProcureSettleReceiptFormPlanViews { get; set; } = null!;
        public virtual DbSet<ProcureSettleReceiptItem> ProcureSettleReceiptItems { get; set; } = null!;
        public virtual DbSet<ProcureSettleReceiptItemPlanView> ProcureSettleReceiptItemPlanViews { get; set; } = null!;
        public virtual DbSet<ProcureStoreLocation> ProcureStoreLocations { get; set; } = null!;
        public virtual DbSet<ProcureTrackingAction> ProcureTrackingActions { get; set; } = null!;
        public virtual DbSet<ProcureTrackingBaseItem> ProcureTrackingBaseItems { get; set; } = null!;
        public virtual DbSet<ProcureTrackingGroup> ProcureTrackingGroups { get; set; } = null!;
        public virtual DbSet<ProcureTrackingItem> ProcureTrackingItems { get; set; } = null!;
        public virtual DbSet<ProcureTrackingRefForm> ProcureTrackingRefForms { get; set; } = null!;
        public virtual DbSet<ProcureTrackingRefItem> ProcureTrackingRefItems { get; set; } = null!;
        public virtual DbSet<Quotation> Quotations { get; set; } = null!;
        public virtual DbSet<Race> Races { get; set; } = null!;
        public virtual DbSet<Receiver> Receivers { get; set; } = null!;
        public virtual DbSet<RegDurableItemActionLog> RegDurableItemActionLogs { get; set; } = null!;
        public virtual DbSet<RegItemTransferFormActionLog> RegItemTransferFormActionLogs { get; set; } = null!;
        public virtual DbSet<RegisterDurableItem> RegisterDurableItems { get; set; } = null!;
        public virtual DbSet<RegisterItemCheckForm> RegisterItemCheckForms { get; set; } = null!;
        public virtual DbSet<RegisterItemCheckRecord> RegisterItemCheckRecords { get; set; } = null!;
        public virtual DbSet<RegisterItemDisposedForm> RegisterItemDisposedForms { get; set; } = null!;
        public virtual DbSet<RegisterItemTransferForm> RegisterItemTransferForms { get; set; } = null!;
        public virtual DbSet<RegisterItemTransferRecord> RegisterItemTransferRecords { get; set; } = null!;
        public virtual DbSet<RegisterProcureItem> RegisterProcureItems { get; set; } = null!;
        public virtual DbSet<RegisterProcureItemType> RegisterProcureItemTypes { get; set; } = null!;
        public virtual DbSet<RelativePerson> RelativePersons { get; set; } = null!;
        public virtual DbSet<Religion> Religions { get; set; } = null!;
        public virtual DbSet<RequestAgreementItemTransform> RequestAgreementItemTransforms { get; set; } = null!;
        public virtual DbSet<RequestApproveItemTransform> RequestApproveItemTransforms { get; set; } = null!;
        public virtual DbSet<RequestForm> RequestForms { get; set; } = null!;
        public virtual DbSet<RequestFormPlanView> RequestFormPlanViews { get; set; } = null!;
        public virtual DbSet<RequestItem> RequestItems { get; set; } = null!;
        public virtual DbSet<RequestItemPlanReferenceItem> RequestItemPlanReferenceItems { get; set; } = null!;
        public virtual DbSet<RequestViewUsedPlanItem> RequestViewUsedPlanItems { get; set; } = null!;
        public virtual DbSet<RequisitionForm> RequisitionForms { get; set; } = null!;
        public virtual DbSet<RequisitionItem> RequisitionItems { get; set; } = null!;
        public virtual DbSet<RequisitionItemPlanReferenceItem> RequisitionItemPlanReferenceItems { get; set; } = null!;
        public virtual DbSet<ReserveBudgetMonthlyReason> ReserveBudgetMonthlyReasons { get; set; } = null!;
        public virtual DbSet<ResponsiblePerson> ResponsiblePersons { get; set; } = null!;
        public virtual DbSet<RolesGroup> RolesGroups { get; set; } = null!;
        public virtual DbSet<RqFormActionLog> RqFormActionLogs { get; set; } = null!;
        public virtual DbSet<ScheduleFisicalYear> ScheduleFisicalYears { get; set; } = null!;
        public virtual DbSet<SeFormActionLog> SeFormActionLogs { get; set; } = null!;
        public virtual DbSet<SeReceiptFormActionLog> SeReceiptFormActionLogs { get; set; } = null!;
        public virtual DbSet<Secondment> Secondments { get; set; } = null!;
        public virtual DbSet<SettleDirectPaymentItem> SettleDirectPaymentItems { get; set; } = null!;
        public virtual DbSet<SettleReceiptForm> SettleReceiptForms { get; set; } = null!;
        public virtual DbSet<SettleReceiptItem> SettleReceiptItems { get; set; } = null!;
        public virtual DbSet<SettlementItem> SettlementItems { get; set; } = null!;
        public virtual DbSet<Staff> Staffs { get; set; } = null!;
        public virtual DbSet<StaffCipherKeyPair> StaffCipherKeyPairs { get; set; } = null!;
        public virtual DbSet<StaffPositionInHrdepartment> StaffPositionInHrdepartments { get; set; } = null!;
        public virtual DbSet<StaffSecurity> StaffSecurities { get; set; } = null!;
        public virtual DbSet<StaffSignature> StaffSignatures { get; set; } = null!;
        public virtual DbSet<StaffSignature1> StaffSignatures1 { get; set; } = null!;
        public virtual DbSet<StaffWorkShift> StaffWorkShifts { get; set; } = null!;
        public virtual DbSet<StaffWorkShiftSpecificDayOff> StaffWorkShiftSpecificDayOffs { get; set; } = null!;
        public virtual DbSet<StaffWorkShiftSpecificHoliday> StaffWorkShiftSpecificHolidays { get; set; } = null!;
        public virtual DbSet<StrategicIndicator> StrategicIndicators { get; set; } = null!;
        public virtual DbSet<StrategiesBudget> StrategiesBudgets { get; set; } = null!;
        public virtual DbSet<Strategy> Strategies { get; set; } = null!;
        public virtual DbSet<SummaryStatementCache> SummaryStatementCaches { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<SupplierType> SupplierTypes { get; set; } = null!;
        public virtual DbSet<Syllabuse> Syllabuses { get; set; } = null!;
        public virtual DbSet<TelephoneBill> TelephoneBills { get; set; } = null!;
        public virtual DbSet<TempYearlyEvaluation5859Score> TempYearlyEvaluation5859Scores { get; set; } = null!;
        public virtual DbSet<TemporaryEmployeeRequestForm> TemporaryEmployeeRequestForms { get; set; } = null!;
        public virtual DbSet<ViewFormRequestAndPlanCoresDetail> ViewFormRequestAndPlanCoresDetails { get; set; } = null!;
        public virtual DbSet<ViewRequestFormDetail> ViewRequestFormDetails { get; set; } = null!;
        public virtual DbSet<VwAspnetApplication> VwAspnetApplications { get; set; } = null!;
        public virtual DbSet<VwAspnetMembershipUser> VwAspnetMembershipUsers { get; set; } = null!;
        public virtual DbSet<VwAspnetProfile> VwAspnetProfiles { get; set; } = null!;
        public virtual DbSet<VwAspnetRole> VwAspnetRoles { get; set; } = null!;
        public virtual DbSet<VwAspnetUser> VwAspnetUsers { get; set; } = null!;
        public virtual DbSet<VwAspnetUsersInRole> VwAspnetUsersInRoles { get; set; } = null!;
        public virtual DbSet<VwAspnetWebPartStatePath> VwAspnetWebPartStatePaths { get; set; } = null!;
        public virtual DbSet<VwAspnetWebPartStateShared> VwAspnetWebPartStateShareds { get; set; } = null!;
        public virtual DbSet<VwAspnetWebPartStateUser> VwAspnetWebPartStateUsers { get; set; } = null!;
        public virtual DbSet<WaterBill> WaterBills { get; set; } = null!;
        public virtual DbSet<WdFormActionLog> WdFormActionLogs { get; set; } = null!;
        public virtual DbSet<WithdrawalForm> WithdrawalForms { get; set; } = null!;
        public virtual DbSet<WithdrawalItem> WithdrawalItems { get; set; } = null!;
        public virtual DbSet<WorkHistory> WorkHistories { get; set; } = null!;
        public virtual DbSet<WorkShiftData> WorkShiftDatas { get; set; } = null!;
        public virtual DbSet<WorkShiftExtraAllowance> WorkShiftExtraAllowances { get; set; } = null!;
        public virtual DbSet<WorkShiftSwitchForm> WorkShiftSwitchForms { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=192.168.2.176,49176;Database=NARIT_MIS_LINK;User ID=admin;Password=Aa!12345;Trusted_Connection=false ;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accommodation>(entity =>
            {
                entity.ToTable("Accommodations", "CollaborationNetwork");

                entity.HasIndex(e => e.OrganizationId, "IX_FK_OrganizationAccommodation");

                entity.Property(e => e.LatestUpdate).HasColumnType("datetime");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Accommodations)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("FK_OrganizationAccommodation");
            });

            modelBuilder.Entity<AccommodationVisiting>(entity =>
            {
                entity.ToTable("AccommodationVisitings", "CollaborationNetwork");

                entity.HasIndex(e => e.AccommodationId, "IX_FK_AccommodationAccommodationVisiting");

                entity.HasIndex(e => e.CollaborateReportId, "IX_FK_CollaborateReportAccommodationVisiting");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.Accommodation)
                    .WithMany(p => p.AccommodationVisitings)
                    .HasForeignKey(d => d.AccommodationId)
                    .HasConstraintName("FK_AccommodationAccommodationVisiting");

                entity.HasOne(d => d.CollaborateReport)
                    .WithMany(p => p.AccommodationVisitings)
                    .HasForeignKey(d => d.CollaborateReportId)
                    .HasConstraintName("FK_CollaborateReportAccommodationVisiting");
            });

            modelBuilder.Entity<AdditionalSettleItem>(entity =>
            {
                entity.ToTable("AdditionalSettleItems", "Plan");

                entity.HasIndex(e => e.GeneralExpenseId, "IX_FK_GeneralExpenseAdditionalSettleItem");

                entity.HasIndex(e => e.GeneralExpenseSettleFormId, "IX_FK_GeneralExpenseSettleFormAdditionalSettleItem");

                entity.Property(e => e.GeRemainBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.UsedBudget).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.GeneralExpense)
                    .WithMany(p => p.AdditionalSettleItems)
                    .HasForeignKey(d => d.GeneralExpenseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpenseAdditionalSettleItem");

                entity.HasOne(d => d.GeneralExpenseSettleForm)
                    .WithMany(p => p.AdditionalSettleItems)
                    .HasForeignKey(d => d.GeneralExpenseSettleFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpenseSettleFormAdditionalSettleItem");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Addresses", "HR");

                entity.HasIndex(e => e.AddressStyleId, "IX_FK_AddressStyleAddress");

                entity.HasIndex(e => e.AddressTypeId, "IX_FK_AddressTypeAddress");

                entity.HasIndex(e => e.RelativePersonId, "IX_FK_RelativePersonAddress");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffAddress");

                entity.HasOne(d => d.AddressStyle)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.AddressStyleId)
                    .HasConstraintName("FK_AddressStyleAddress");

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.AddressTypeId)
                    .HasConstraintName("FK_AddressTypeAddress");

                entity.HasOne(d => d.RelativePerson)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.RelativePersonId)
                    .HasConstraintName("FK_RelativePersonAddress");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK_StaffAddress");
            });

            modelBuilder.Entity<AddressStyle>(entity =>
            {
                entity.ToTable("AddressStyles", "HR");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<AddressType>(entity =>
            {
                entity.ToTable("AddressTypes", "HR");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Agreement>(entity =>
            {
                entity.ToTable("Agreements", "CollaborationNetwork");

                entity.HasIndex(e => e.CollaborateReportId, "IX_FK_CollaborateReportAgreement");

                entity.HasIndex(e => e.OrganizationId, "IX_FK_OrganizationAgreement");

                entity.Property(e => e.CloseIssueDate).HasColumnType("datetime");

                entity.Property(e => e.FirstRegisterNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.OpenIssueDate).HasColumnType("datetime");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.SigningDate).HasColumnType("datetime");

                entity.HasOne(d => d.CollaborateReport)
                    .WithMany(p => p.Agreements)
                    .HasForeignKey(d => d.CollaborateReportId)
                    .HasConstraintName("FK_CollaborateReportAgreement");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Agreements)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("FK_OrganizationAgreement");
            });

            modelBuilder.Entity<AgreementApproveItemTransform>(entity =>
            {
                entity.ToTable("AgreementApproveItemTransforms", "Procure");

                entity.HasIndex(e => e.AgreementItemId, "IX_FK_AgreementItemAgreementApproveItemTransform");

                entity.HasIndex(e => e.ApproveItemId, "IX_FK_ApproveItemAgreementApproveItemTransform");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 5)");

                entity.HasOne(d => d.AgreementItem)
                    .WithMany(p => p.AgreementApproveItemTransforms)
                    .HasForeignKey(d => d.AgreementItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AgreementItemAgreementApproveItemTransform");

                entity.HasOne(d => d.ApproveItem)
                    .WithMany(p => p.AgreementApproveItemTransforms)
                    .HasForeignKey(d => d.ApproveItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApproveItemAgreementApproveItemTransform");
            });

            modelBuilder.Entity<AgreementForm>(entity =>
            {
                entity.ToTable("AgreementForms", "Procure");

                entity.Property(e => e.ApproverSignDate).HasColumnType("datetime");

                entity.Property(e => e.CheckEighthComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckNinthComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckSecretaryAndComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckSeventhComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckSixthComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckViceChairman).HasDefaultValueSql("('')");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ProcureSecretaryAndComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.ProcureViceChairman).HasDefaultValueSql("('')");

                entity.Property(e => e.RequestFormDate).HasColumnType("datetime");

                entity.Property(e => e.SuppliesOfficerSignDate).HasColumnType("datetime");

                entity.Property(e => e.SuppliesUnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AgreementItem>(entity =>
            {
                entity.ToTable("AgreementItems", "Procure");

                entity.HasIndex(e => e.AgreementFormId, "IX_FK_AgreementFormAgreementItem");

                entity.HasIndex(e => e.AgreementMemorandumId, "IX_FK_AgreementMemorandumAgreementItem");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.PricePerPiece).HasColumnType("decimal(15, 5)");

                entity.HasOne(d => d.AgreementForm)
                    .WithMany(p => p.AgreementItems)
                    .HasForeignKey(d => d.AgreementFormId)
                    .HasConstraintName("FK_AgreementFormAgreementItem");

                entity.HasOne(d => d.AgreementMemorandum)
                    .WithMany(p => p.AgreementItems)
                    .HasForeignKey(d => d.AgreementMemorandumId)
                    .HasConstraintName("FK_AgreementMemorandumAgreementItem");
            });

            modelBuilder.Entity<AgreementItemPlanReferenceItem>(entity =>
            {
                entity.ToTable("AgreementItemPlanReferenceItems", "Procure");

                entity.HasIndex(e => e.AgreementFormId, "IX_FK_AgreementFormAgreementItemPlanReferenceItem");

                entity.HasIndex(e => e.AgreementItemId, "IX_FK_AgreementItemAgreementItemPlanReferenceItem");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 5)");

                entity.HasOne(d => d.AgreementForm)
                    .WithMany(p => p.AgreementItemPlanReferenceItems)
                    .HasForeignKey(d => d.AgreementFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AgreementFormAgreementItemPlanReferenceItem");

                entity.HasOne(d => d.AgreementItem)
                    .WithMany(p => p.AgreementItemPlanReferenceItems)
                    .HasForeignKey(d => d.AgreementItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AgreementItemAgreementItemPlanReferenceItem");
            });

            modelBuilder.Entity<AgreementMemorandum>(entity =>
            {
                entity.ToTable("AgreementMemorandums", "Procure");

                entity.Property(e => e.RequestFormDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AgreementVisiting>(entity =>
            {
                entity.ToTable("AgreementVisitings", "CollaborationNetwork");

                entity.HasIndex(e => e.AgreementId, "IX_FK_AgreementAgreementVisiting");

                entity.HasIndex(e => e.CollaborateReportId, "IX_FK_CollaborateReportAgreementVisiting");

                entity.HasOne(d => d.Agreement)
                    .WithMany(p => p.AgreementVisitings)
                    .HasForeignKey(d => d.AgreementId)
                    .HasConstraintName("FK_AgreementAgreementVisiting");

                entity.HasOne(d => d.CollaborateReport)
                    .WithMany(p => p.AgreementVisitings)
                    .HasForeignKey(d => d.CollaborateReportId)
                    .HasConstraintName("FK_CollaborateReportAgreementVisiting");
            });

            modelBuilder.Entity<AppFormActionLog>(entity =>
            {
                entity.ToTable("AppFormActionLogs", "Procure");

                entity.HasIndex(e => e.ApproveFormId, "IX_FK_ApproveFormAppFormActionLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.Ip).HasColumnName("IP");

                entity.HasOne(d => d.ApproveForm)
                    .WithMany(p => p.AppFormActionLogs)
                    .HasForeignKey(d => d.ApproveFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApproveFormAppFormActionLog");
            });

            modelBuilder.Entity<Application>(entity =>
            {
                entity.ToTable("Application");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Detail)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ImageURL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Link)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Shortform)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ApproveForm>(entity =>
            {
                entity.ToTable("ApproveForms", "Procure");

                entity.Property(e => e.AgreementFormDate).HasColumnType("datetime");

                entity.Property(e => e.AnnouncementDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverSignDate).HasColumnType("datetime");

                entity.Property(e => e.AuthorizeFormDocumentNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeFormWriteDate).HasColumnType("datetime");

                entity.Property(e => e.BorrowReason).HasDefaultValueSql("('')");

                entity.Property(e => e.Borrower).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckEighthComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckEighthComitteePosition).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckFifthComitteePosition).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckFourthComitteePosition).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckNinthComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckNinthComitteePosition).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckOfficer).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckOfficerPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckSecretaryAndComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckSecretaryAndComitteePosition).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckSecretaryComitteePosition).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckSeventhComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckSeventhComitteePosition).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckSixthComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckSixthComitteePosition).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckThirdComitteePosition).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckViceChairman).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckViceChairmanPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.MemoAnnouncementTitle).HasDefaultValueSql("('')");

                entity.Property(e => e.MemoDocumentNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.MemoPurpose).HasDefaultValueSql("('')");

                entity.Property(e => e.MemoTitle).HasDefaultValueSql("('')");

                entity.Property(e => e.MemoWriteDate).HasColumnType("datetime");

                entity.Property(e => e.PlanActivityName).HasDefaultValueSql("('')");

                entity.Property(e => e.PlanItemName).HasDefaultValueSql("('')");

                entity.Property(e => e.ProcureSecretaryAndComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.ProcureViceChairman).HasDefaultValueSql("('')");

                entity.Property(e => e.RequestFormDate).HasColumnType("datetime");

                entity.Property(e => e.StatementName).HasDefaultValueSql("('')");

                entity.Property(e => e.SuppliesOfficerSignDate).HasColumnType("datetime");

                entity.Property(e => e.SuppliesUnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ApproveItem>(entity =>
            {
                entity.ToTable("ApproveItems", "Procure");

                entity.HasIndex(e => e.ApproveFormId, "IX_FK_ApproveFormApproveItem");

                entity.HasIndex(e => e.ApproveMemorandumId, "IX_FK_ApproveMemorandumApproveItem");

                entity.HasIndex(e => e.SupplierId, "IX_FK_SupplierApproveItem");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.PricePerPiece).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.QuotationDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasDefaultValueSql("('')");

                entity.Property(e => e.RequestPricePerPiece).HasColumnType("decimal(15, 5)");

                entity.HasOne(d => d.ApproveForm)
                    .WithMany(p => p.ApproveItems)
                    .HasForeignKey(d => d.ApproveFormId)
                    .HasConstraintName("FK_ApproveFormApproveItem");

                entity.HasOne(d => d.ApproveMemorandum)
                    .WithMany(p => p.ApproveItems)
                    .HasForeignKey(d => d.ApproveMemorandumId)
                    .HasConstraintName("FK_ApproveMemorandumApproveItem");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.ApproveItems)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_SupplierApproveItem");
            });

            modelBuilder.Entity<ApproveItemPlanReferenceItem>(entity =>
            {
                entity.ToTable("ApproveItemPlanReferenceItems", "Procure");

                entity.HasIndex(e => e.ApproveFormId, "IX_FK_ApproveFormApproveItemPlanReferenceItem");

                entity.HasIndex(e => e.ApproveItemId, "IX_FK_ApproveItemApproveItemPlanReferenceItem");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 5)");

                entity.HasOne(d => d.ApproveForm)
                    .WithMany(p => p.ApproveItemPlanReferenceItems)
                    .HasForeignKey(d => d.ApproveFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApproveFormApproveItemPlanReferenceItem");

                entity.HasOne(d => d.ApproveItem)
                    .WithMany(p => p.ApproveItemPlanReferenceItems)
                    .HasForeignKey(d => d.ApproveItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApproveItemApproveItemPlanReferenceItem");
            });

            modelBuilder.Entity<ApproveMemorandum>(entity =>
            {
                entity.ToTable("ApproveMemorandums", "Procure");

                entity.Property(e => e.CheckEighthComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckNinthComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckOfficer).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckSecretaryAndComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckSeventhComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckSixthComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckViceChairman).HasDefaultValueSql("('')");

                entity.Property(e => e.ProcureViceChairman).HasDefaultValueSql("('')");

                entity.Property(e => e.RequestFormDate).HasColumnType("datetime");

                entity.Property(e => e.SuppliesOfficer).HasDefaultValueSql("('')");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ApproveOrderItemTransform>(entity =>
            {
                entity.ToTable("ApproveOrderItemTransforms", "Procure");

                entity.HasIndex(e => e.ApproveItemId, "IX_FK_ApproveItemApproveOrderItemTransform");

                entity.HasIndex(e => e.OrderItemId, "IX_FK_OrderItemApproveOrderItemTransform");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 5)");

                entity.HasOne(d => d.ApproveItem)
                    .WithMany(p => p.ApproveOrderItemTransforms)
                    .HasForeignKey(d => d.ApproveItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApproveItemApproveOrderItemTransform");

                entity.HasOne(d => d.OrderItem)
                    .WithMany(p => p.ApproveOrderItemTransforms)
                    .HasForeignKey(d => d.OrderItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderItemApproveOrderItemTransform");
            });

            modelBuilder.Entity<AspnetApplication>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK__aspnet_A__C93A4C98014935CB")
                    .IsClustered(false);

                entity.ToTable("aspnet_Applications");

                entity.HasIndex(e => e.LoweredApplicationName, "UQ__aspnet_A__17477DE40425A276")
                    .IsUnique();

                entity.HasIndex(e => e.ApplicationName, "UQ__aspnet_A__3091033107020F21")
                    .IsUnique();

                entity.HasIndex(e => e.LoweredApplicationName, "aspnet_Applications_Index")
                    .IsClustered();

                entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationName).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspnetMembership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_M__1788CC4D1FCDBCEB")
                    .IsClustered(false);

                entity.ToTable("aspnet_Membership");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredEmail }, "aspnet_Membership_index")
                    .IsClustered();

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobilePin)
                    .HasMaxLength(16)
                    .HasColumnName("MobilePIN");

                entity.Property(e => e.Password).HasMaxLength(128);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.PasswordSalt).HasMaxLength(128);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetMemberships)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__Appli__21B6055D");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetMembership)
                    .HasForeignKey<AspnetMembership>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__UserI__22AA2996");
            });

            modelBuilder.Entity<AspnetPath>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_P__CD67DC5859063A47")
                    .IsClustered(false);

                entity.ToTable("aspnet_Paths");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredPath }, "aspnet_Paths_index")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.PathId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LoweredPath).HasMaxLength(256);

                entity.Property(e => e.Path).HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetPaths)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pa__Appli__5AEE82B9");
            });

            modelBuilder.Entity<AspnetPersonalizationAllUser>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_P__CD67DC5960A75C0F");

                entity.ToTable("aspnet_PersonalizationAllUsers");

                entity.Property(e => e.PathId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings).HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithOne(p => p.AspnetPersonalizationAllUser)
                    .HasForeignKey<AspnetPersonalizationAllUser>(d => d.PathId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pe__PathI__628FA481");
            });

            modelBuilder.Entity<AspnetPersonalizationPerUser>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__aspnet_P__3214EC06656C112C")
                    .IsClustered(false);

                entity.ToTable("aspnet_PersonalizationPerUser");

                entity.HasIndex(e => new { e.PathId, e.UserId }, "aspnet_PersonalizationPerUser_index1")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.UserId, e.PathId }, "aspnet_PersonalizationPerUser_ncindex2")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings).HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithMany(p => p.AspnetPersonalizationPerUsers)
                    .HasForeignKey(d => d.PathId)
                    .HasConstraintName("FK__aspnet_Pe__PathI__68487DD7");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetPersonalizationPerUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__aspnet_Pe__UserI__693CA210");
            });

            modelBuilder.Entity<AspnetProfile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_P__1788CC4C36B12243");

                entity.ToTable("aspnet_Profile");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PropertyNames).HasColumnType("ntext");

                entity.Property(e => e.PropertyValuesBinary).HasColumnType("image");

                entity.Property(e => e.PropertyValuesString).HasColumnType("ntext");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetProfile)
                    .HasForeignKey<AspnetProfile>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pr__UserI__38996AB5");
            });

            modelBuilder.Entity<AspnetRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__aspnet_R__8AFACE1B4222D4EF")
                    .IsClustered(false);

                entity.ToTable("aspnet_Roles");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredRoleName }, "aspnet_Roles_index1")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName).HasMaxLength(256);

                entity.Property(e => e.RoleName).HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetRoles)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Ro__Appli__440B1D61");
            });

            modelBuilder.Entity<AspnetSchemaVersion>(entity =>
            {
                entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion })
                    .HasName("PK__aspnet_S__5A1E6BC11367E606");

                entity.ToTable("aspnet_SchemaVersions");

                entity.Property(e => e.Feature).HasMaxLength(128);

                entity.Property(e => e.CompatibleSchemaVersion).HasMaxLength(128);
            });

            modelBuilder.Entity<AspnetUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_U__1788CC4D0BC6C43E")
                    .IsClustered(false);

                entity.ToTable("aspnet_Users");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName }, "aspnet_Users_Index")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.ApplicationId, e.LastActivityDate }, "aspnet_Users_Index2");

                entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName).HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetUsers)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__Appli__0DAF0CB0");

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "AspnetUsersInRole",
                        l => l.HasOne<AspnetRole>().WithMany().HasForeignKey("RoleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__aspnet_Us__RoleI__4AB81AF0"),
                        r => r.HasOne<AspnetUser>().WithMany().HasForeignKey("UserId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__aspnet_Us__UserI__49C3F6B7"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId").HasName("PK__aspnet_U__AF2760AD47DBAE45");

                            j.ToTable("aspnet_UsersInRoles");

                            j.HasIndex(new[] { "RoleId" }, "aspnet_UsersInRoles_index");
                        });
            });

            modelBuilder.Entity<AspnetWebEventEvent>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK__aspnet_W__7944C810797309D9");

                entity.ToTable("aspnet_WebEvent_Events");

                entity.Property(e => e.EventId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ApplicationPath).HasMaxLength(256);

                entity.Property(e => e.ApplicationVirtualPath).HasMaxLength(256);

                entity.Property(e => e.Details).HasColumnType("ntext");

                entity.Property(e => e.EventOccurrence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventSequence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.EventTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.EventType).HasMaxLength(256);

                entity.Property(e => e.ExceptionType).HasMaxLength(256);

                entity.Property(e => e.MachineName).HasMaxLength(256);

                entity.Property(e => e.Message).HasMaxLength(1024);

                entity.Property(e => e.RequestUrl).HasMaxLength(1024);
            });

            modelBuilder.Entity<AuFormActionLog>(entity =>
            {
                entity.ToTable("AuFormActionLogs", "Procure");

                entity.HasIndex(e => e.AuthorizeFormId, "IX_FK_AuthorizeFormAuFormActionLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.Ip).HasColumnName("IP");

                entity.HasOne(d => d.AuthorizeForm)
                    .WithMany(p => p.AuFormActionLogs)
                    .HasForeignKey(d => d.AuthorizeFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuthorizeFormAuFormActionLog");
            });

            modelBuilder.Entity<AuthorizeForm>(entity =>
            {
                entity.ToTable("AuthorizeForms", "Procure");

                entity.HasIndex(e => e.RequestFormId, "IX_FK_RequestFormAuthorizeForm");

                entity.Property(e => e.BorrowAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.BorrowReason).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckEighthComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckEighthComitteePosition).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckFifthComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckFifthComitteePosition).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckFourthComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckFourthComitteePosition).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckNinthComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckNinthComitteePosition).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckSeventhComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckSeventhComitteePosition).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckSixthComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckSixthComitteePosition).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckThirdComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckThirdComitteePosition).HasDefaultValueSql("('')");

                entity.Property(e => e.ContractControlNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.MedianPrice).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ProcureFifthComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.ProcureFifthComitteePosition).HasDefaultValueSql("('')");

                entity.Property(e => e.ProcureFourthComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.ProcureFourthComitteePosition).HasDefaultValueSql("('')");

                entity.Property(e => e.RequestFormWriteDate).HasColumnType("datetime");

                entity.Property(e => e.SuppliesOfficerSignDate).HasColumnType("datetime");

                entity.Property(e => e.SuppliesUnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.TotalBill).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.RequestForm)
                    .WithMany(p => p.AuthorizeForms)
                    .HasForeignKey(d => d.RequestFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestFormAuthorizeForm");
            });

            modelBuilder.Entity<BillingFile>(entity =>
            {
                entity.ToTable("BillingFiles", "Operation");

                entity.HasIndex(e => e.DrinkingWaterBillId, "IX_FK_DrinkingWaterBillBillingFile");

                entity.HasIndex(e => e.ElectricityBillId, "IX_FK_ElectricityBillBillingFile");

                entity.HasIndex(e => e.GarbageBillId, "IX_FK_GarbageBillBillingFile");

                entity.HasIndex(e => e.TelephoneBillId, "IX_FK_TelephoneBillBillingFile");

                entity.HasIndex(e => e.WaterBillId, "IX_FK_WaterBillBillingFile");

                entity.Property(e => e.UploadDate).HasColumnType("datetime");

                entity.HasOne(d => d.DrinkingWaterBill)
                    .WithMany(p => p.BillingFiles)
                    .HasForeignKey(d => d.DrinkingWaterBillId)
                    .HasConstraintName("FK_DrinkingWaterBillBillingFile");

                entity.HasOne(d => d.ElectricityBill)
                    .WithMany(p => p.BillingFiles)
                    .HasForeignKey(d => d.ElectricityBillId)
                    .HasConstraintName("FK_ElectricityBillBillingFile");

                entity.HasOne(d => d.GarbageBill)
                    .WithMany(p => p.BillingFiles)
                    .HasForeignKey(d => d.GarbageBillId)
                    .HasConstraintName("FK_GarbageBillBillingFile");

                entity.HasOne(d => d.TelephoneBill)
                    .WithMany(p => p.BillingFiles)
                    .HasForeignKey(d => d.TelephoneBillId)
                    .HasConstraintName("FK_TelephoneBillBillingFile");

                entity.HasOne(d => d.WaterBill)
                    .WithMany(p => p.BillingFiles)
                    .HasForeignKey(d => d.WaterBillId)
                    .HasConstraintName("FK_WaterBillBillingFile");
            });

            modelBuilder.Entity<BillingLocation>(entity =>
            {
                entity.ToTable("BillingLocations", "Operation");

                entity.HasIndex(e => e.ParentBillingLocationId, "IX_FK_BillingLocationParentBillingLocation");

                entity.Property(e => e.Multiplier).HasColumnType("decimal(12, 4)");

                entity.HasOne(d => d.ParentBillingLocation)
                    .WithMany(p => p.InverseParentBillingLocation)
                    .HasForeignKey(d => d.ParentBillingLocationId)
                    .HasConstraintName("FK_BillingLocationParentBillingLocation");
            });

            modelBuilder.Entity<BtFormActionLog>(entity =>
            {
                entity.ToTable("BtFormActionLogs", "Plan");

                entity.HasIndex(e => e.BudgetTransferFormId, "IX_FK_BudgetTransferFormBtFormActionLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.Ip).HasColumnName("IP");

                entity.HasOne(d => d.BudgetTransferForm)
                    .WithMany(p => p.BtFormActionLogs)
                    .HasForeignKey(d => d.BudgetTransferFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BudgetTransferFormBtFormActionLog");
            });

            modelBuilder.Entity<BudgetTransfer>(entity =>
            {
                entity.ToTable("BudgetTransfers", "Plan");

                entity.HasIndex(e => e.BudgetTransferFormId, "IX_FK_BudgetTransferFormBudgetTransfer");

                entity.HasIndex(e => e.InwardPlanItemId, "IX_FK_PlanItemInwardBudgetTransfer");

                entity.HasIndex(e => e.OutwardPlanItemId, "IX_FK_PlanItemOutwardBudgetTransfer");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverSignDate).HasColumnType("datetime");

                entity.Property(e => e.BudgetCheckerSignDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.InwardAmount)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.InwardMonthlyForecastChangedValue).HasDefaultValueSql("('')");

                entity.Property(e => e.InwardMonthlyForecastValue).HasDefaultValueSql("('')");

                entity.Property(e => e.InwardPlanCoreNetBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.InwardPlanCoreRemainBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.InwardPlanItemNetBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.InwardPlanItemRemainBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.OutwardAmount)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.OutwardMonthlyForecastChangedValue).HasDefaultValueSql("('')");

                entity.Property(e => e.OutwardMonthlyForecastValue).HasDefaultValueSql("('')");

                entity.Property(e => e.OutwardPlanCoreNetBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.OutwardPlanCoreRemainBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.OutwardPlanItemNetBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.OutwardPlanItemRemainBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.RequesterSignDate).HasColumnType("datetime");

                entity.Property(e => e.StatementCalculationDate).HasColumnType("datetime");

                entity.Property(e => e.TransferBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.UnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.BudgetTransferForm)
                    .WithMany(p => p.BudgetTransfers)
                    .HasForeignKey(d => d.BudgetTransferFormId)
                    .HasConstraintName("FK_BudgetTransferFormBudgetTransfer");

                entity.HasOne(d => d.InwardPlanItem)
                    .WithMany(p => p.BudgetTransferInwardPlanItems)
                    .HasForeignKey(d => d.InwardPlanItemId)
                    .HasConstraintName("FK_PlanItemInwardBudgetTransfer");

                entity.HasOne(d => d.OutwardPlanItem)
                    .WithMany(p => p.BudgetTransferOutwardPlanItems)
                    .HasForeignKey(d => d.OutwardPlanItemId)
                    .HasConstraintName("FK_PlanItemOutwardBudgetTransfer");
            });

            modelBuilder.Entity<BudgetTransferForm>(entity =>
            {
                entity.ToTable("BudgetTransferForms", "Plan");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverSignDate).HasColumnType("datetime");

                entity.Property(e => e.BudgetCheckerSignDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.FinanceName).HasDefaultValueSql("('')");

                entity.Property(e => e.FinanceSignDate).HasColumnType("datetime");

                entity.Property(e => e.PlanFormApprovalStatusEnum).HasDefaultValueSql("((10))");

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.RequesterSignDate).HasColumnType("datetime");

                entity.Property(e => e.SeniorUnitChiefName).HasDefaultValueSql("('')");

                entity.Property(e => e.SeniorUnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.StatementCalculationDate).HasColumnType("datetime");

                entity.Property(e => e.UnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<BudgetType>(entity =>
            {
                entity.ToTable("BudgetTypes", "Plan");

                entity.HasIndex(e => e.ParentBudgetTypeId, "IX_FK_BudgetTypeSubBudgetTypes");

                entity.HasOne(d => d.ParentBudgetType)
                    .WithMany(p => p.InverseParentBudgetType)
                    .HasForeignKey(d => d.ParentBudgetTypeId)
                    .HasConstraintName("FK_BudgetTypeSubBudgetTypes");
            });

            modelBuilder.Entity<CertifyOfMedicalRightForm>(entity =>
            {
                entity.ToTable("CertifyOfMedicalRightForms", "HR");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.IdcardNumber).HasColumnName("IDCardNumber");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CheckForm>(entity =>
            {
                entity.ToTable("CheckForms", "Procure");

                entity.HasIndex(e => e.SupplierId, "IX_FK_SupplierCheckForm");

                entity.Property(e => e.BudgetCheckerSignDate).HasColumnType("datetime");

                entity.Property(e => e.CheckEighthComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckNinthComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckOfficer).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckReportLateDeliveryFineValue).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CheckReportPlanCoreName).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckReportProcureTypeMethodName).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckReportSupplierName).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckReportTotalBill).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CheckReportWriteDate).HasColumnType("datetime");

                entity.Property(e => e.CheckSecretaryAndComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckSeventhComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckSixthComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckViceChairman).HasDefaultValueSql("('')");

                entity.Property(e => e.ComitteeCheckDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryFormDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryFormManualText).HasDefaultValueSql("('')");

                entity.Property(e => e.DeliveryRequestFormDate).HasColumnType("datetime");

                entity.Property(e => e.IsResultCheckedCorrect)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowCountTimeOnPrint)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ItemName).HasDefaultValueSql("('')");

                entity.Property(e => e.LateDeliveryFineRate).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.LateDeliveryFineValue).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.PlanActivityName).HasDefaultValueSql("('')");

                entity.Property(e => e.PlanItemName).HasDefaultValueSql("('')");

                entity.Property(e => e.RefDocumentDate).HasColumnType("datetime");

                entity.Property(e => e.RefDocumentNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.RequestFormDate).HasColumnType("datetime");

                entity.Property(e => e.SuppliesOfficer).HasDefaultValueSql("('')");

                entity.Property(e => e.SuppliesOfficerSignDate).HasColumnType("datetime");

                entity.Property(e => e.SuppliesUnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.CheckForms)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_SupplierCheckForm");
            });

            modelBuilder.Entity<CheckFormActionLog>(entity =>
            {
                entity.ToTable("CheckFormActionLogs", "Procure");

                entity.HasIndex(e => e.CheckFormId, "IX_FK_CheckFormCheckFormActionLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.Ip).HasColumnName("IP");

                entity.HasOne(d => d.CheckForm)
                    .WithMany(p => p.CheckFormActionLogs)
                    .HasForeignKey(d => d.CheckFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CheckFormCheckFormActionLog");
            });

            modelBuilder.Entity<CheckFormPlanView>(entity =>
            {
                entity.ToTable("CheckFormPlanViews", "Plan");

                entity.HasIndex(e => e.ProcureLoaningWithdrawalFormPlanViewId, "IX_FK_ProcureLoaningWithdrawalFormPlanViewCheckFormPlanView");

                entity.HasIndex(e => e.RequestFormPlanViewId, "IX_FK_RequestFormPlanViewCheckFormPlanView");

                entity.Property(e => e.BudgetCheckerSignDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.NetPayValue).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.PlanActivityIdOld).HasColumnName("PlanActivityId_Old");

                entity.Property(e => e.StatementCalculationDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.ProcureLoaningWithdrawalFormPlanView)
                    .WithMany(p => p.CheckFormPlanViews)
                    .HasForeignKey(d => d.ProcureLoaningWithdrawalFormPlanViewId)
                    .HasConstraintName("FK_ProcureLoaningWithdrawalFormPlanViewCheckFormPlanView");

                entity.HasOne(d => d.RequestFormPlanView)
                    .WithMany(p => p.CheckFormPlanViews)
                    .HasForeignKey(d => d.RequestFormPlanViewId)
                    .HasConstraintName("FK_RequestFormPlanViewCheckFormPlanView");
            });

            modelBuilder.Entity<CheckItem>(entity =>
            {
                entity.ToTable("CheckItems", "Procure");

                entity.HasIndex(e => e.CheckFormId, "IX_FK_CheckFormCheckItem");

                entity.HasIndex(e => e.SupplierId, "IX_FK_SupplierCheckItem");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DeliveryAmount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Discount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.OrderAmount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.PricePerPiece).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.RemainOrderAmount).HasColumnType("decimal(15, 5)");

                entity.HasOne(d => d.CheckForm)
                    .WithMany(p => p.CheckItems)
                    .HasForeignKey(d => d.CheckFormId)
                    .HasConstraintName("FK_CheckFormCheckItem");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.CheckItems)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_SupplierCheckItem");
            });

            modelBuilder.Entity<CheckItemPlanReferenceItem>(entity =>
            {
                entity.ToTable("CheckItemPlanReferenceItems", "Procure");

                entity.HasIndex(e => e.CheckFormId, "IX_FK_CheckFormCheckItemPlanReferenceItem");

                entity.HasIndex(e => e.CheckItemId, "IX_FK_CheckItemCheckItemPlanReferenceItem");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 5)");

                entity.HasOne(d => d.CheckForm)
                    .WithMany(p => p.CheckItemPlanReferenceItems)
                    .HasForeignKey(d => d.CheckFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CheckFormCheckItemPlanReferenceItem");

                entity.HasOne(d => d.CheckItem)
                    .WithMany(p => p.CheckItemPlanReferenceItems)
                    .HasForeignKey(d => d.CheckItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CheckItemCheckItemPlanReferenceItem");
            });

            modelBuilder.Entity<CheckRequisitionItemTransform>(entity =>
            {
                entity.ToTable("CheckRequisitionItemTransforms", "Procure");

                entity.HasIndex(e => e.CheckItemId, "IX_FK_CheckItemCheckRequisitionItemTransform");

                entity.HasIndex(e => e.RequisitionItemId, "IX_FK_RequisitionItemCheckRequisitionItemTransform");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 5)");

                entity.HasOne(d => d.CheckItem)
                    .WithMany(p => p.CheckRequisitionItemTransforms)
                    .HasForeignKey(d => d.CheckItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CheckItemCheckRequisitionItemTransform");

                entity.HasOne(d => d.RequisitionItem)
                    .WithMany(p => p.CheckRequisitionItemTransforms)
                    .HasForeignKey(d => d.RequisitionItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequisitionItemCheckRequisitionItemTransform");
            });

            modelBuilder.Entity<CheckViewUsedPlanItem>(entity =>
            {
                entity.ToTable("CheckViewUsedPlanItems", "Plan");

                entity.HasIndex(e => e.CheckFormPlanViewId, "IX_FK_CheckFormPlanViewCheckViewUsedPlanItem");

                entity.HasIndex(e => e.PlanItemId, "IX_FK_PlanItemCheckViewUsedPlanItem");

                entity.HasIndex(e => e.PlanItemTypeId, "IX_FK_PlanItemTypeCheckViewUsedPlanItem");

                entity.HasIndex(e => e.ProcureSettleReceiptItemPlanViewId, "IX_FK_ProcureSettleReceiptItemPlanViewCheckViewUsedPlanItem");

                entity.HasIndex(e => e.RequestViewUsedPlanItemId, "IX_FK_RequestViewUsedPlanItemCheckViewUsedPlanItem");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.ChangedAmount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.CheckDate).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MutiplyAmount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.NetPayValue).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.PricePerPiece).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.ProcureLoaningWithdrawnMoney).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CheckFormPlanView)
                    .WithMany(p => p.CheckViewUsedPlanItems)
                    .HasForeignKey(d => d.CheckFormPlanViewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CheckFormPlanViewCheckViewUsedPlanItem");

                entity.HasOne(d => d.PlanItem)
                    .WithMany(p => p.CheckViewUsedPlanItems)
                    .HasForeignKey(d => d.PlanItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanItemCheckViewUsedPlanItem");

                entity.HasOne(d => d.PlanItemType)
                    .WithMany(p => p.CheckViewUsedPlanItems)
                    .HasForeignKey(d => d.PlanItemTypeId)
                    .HasConstraintName("FK_PlanItemTypeCheckViewUsedPlanItem");

                entity.HasOne(d => d.ProcureSettleReceiptItemPlanView)
                    .WithMany(p => p.CheckViewUsedPlanItems)
                    .HasForeignKey(d => d.ProcureSettleReceiptItemPlanViewId)
                    .HasConstraintName("FK_ProcureSettleReceiptItemPlanViewCheckViewUsedPlanItem");

                entity.HasOne(d => d.RequestViewUsedPlanItem)
                    .WithMany(p => p.CheckViewUsedPlanItems)
                    .HasForeignKey(d => d.RequestViewUsedPlanItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestViewUsedPlanItemCheckViewUsedPlanItem");
            });

            modelBuilder.Entity<ChildTuitionFeeRequestForm>(entity =>
            {
                entity.ToTable("ChildTuitionFeeRequestForms", "HR");

                entity.Property(e => e.ApproverSignDate).HasColumnType("datetime");

                entity.Property(e => e.ChildDateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.RequestBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.TotalBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CoReportRefFilingDocument>(entity =>
            {
                entity.ToTable("CoReportRefFilingDocuments", "CollaborationNetwork");

                entity.HasIndex(e => e.CollaborateReportId, "IX_FK_CollaborateReportCoReportRefFilingDocument");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.HasOne(d => d.CollaborateReport)
                    .WithMany(p => p.CoReportRefFilingDocuments)
                    .HasForeignKey(d => d.CollaborateReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CollaborateReportCoReportRefFilingDocument");
            });

            modelBuilder.Entity<CoReportRefGeMomoForm>(entity =>
            {
                entity.ToTable("CoReportRefGeMomoForms", "CollaborationNetwork");

                entity.HasIndex(e => e.CollaborateReportId, "IX_FK_CollaborateReportCoReportRefGeMomoForm");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.CollaborateReport)
                    .WithMany(p => p.CoReportRefGeMomoForms)
                    .HasForeignKey(d => d.CollaborateReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CollaborateReportCoReportRefGeMomoForm");
            });

            modelBuilder.Entity<CollaborateReport>(entity =>
            {
                entity.ToTable("CollaborateReports", "CollaborationNetwork");

                entity.HasIndex(e => e.OrganizationId, "IX_FK_OrganizationCollaborateReport");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.Expectation).HasDefaultValueSql("('')");

                entity.Property(e => e.Objective).HasDefaultValueSql("('')");

                entity.Property(e => e.Other).HasDefaultValueSql("('')");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.CollaborateReports)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("FK_OrganizationCollaborateReport");
            });

            modelBuilder.Entity<CollaborateStaff>(entity =>
            {
                entity.ToTable("CollaborateStaffs", "CollaborationNetwork");

                entity.HasIndex(e => e.CollaborateReportId, "IX_FK_CollaborateReportCollaborateStaff");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.HrdepartmentName).HasColumnName("HRDepartmentName");

                entity.HasOne(d => d.CollaborateReport)
                    .WithMany(p => p.CollaborateStaffs)
                    .HasForeignKey(d => d.CollaborateReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CollaborateReportCollaborateStaff");
            });

            modelBuilder.Entity<CollaborationNetworkFile>(entity =>
            {
                entity.ToTable("CollaborationNetworkFiles", "CollaborationNetwork");

                entity.HasIndex(e => e.CollaborateReportId, "IX_FK_CollaborateReportCollaborationNetworkFile");

                entity.HasIndex(e => e.OrganizationId, "IX_FK_OrganizationCollaborationNetworkFile");

                entity.Property(e => e.UploadDate).HasColumnType("datetime");

                entity.HasOne(d => d.CollaborateReport)
                    .WithMany(p => p.CollaborationNetworkFiles)
                    .HasForeignKey(d => d.CollaborateReportId)
                    .HasConstraintName("FK_CollaborateReportCollaborationNetworkFile");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.CollaborationNetworkFiles)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("FK_OrganizationCollaborationNetworkFile");
            });

            modelBuilder.Entity<CompetencyEvaluationForm>(entity =>
            {
                entity.ToTable("CompetencyEvaluationForms", "HR");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffCompetencyEvaluationForm");

                entity.Property(e => e.FirstEvaluator).HasDefaultValueSql("('')");

                entity.Property(e => e.FirstEvaluatorOpinion).HasDefaultValueSql("('')");

                entity.Property(e => e.FirstEvaluatorPositionName).HasDefaultValueSql("('')");

                entity.Property(e => e.Opinion).HasDefaultValueSql("('')");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.Property(e => e.SecondEvaluator).HasDefaultValueSql("('')");

                entity.Property(e => e.SecondEvaluatorOpinion).HasDefaultValueSql("('')");

                entity.Property(e => e.SecondEvaluatorPositionName).HasDefaultValueSql("('')");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.CompetencyEvaluationForms)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffCompetencyEvaluationForm");
            });

            modelBuilder.Entity<CompetencyEvaluationItem>(entity =>
            {
                entity.ToTable("CompetencyEvaluationItems", "HR");

                entity.HasIndex(e => e.CompetencyEvaluationFormId, "IX_FK_CompetencyEvaluationFormCompetencyEvaluationItem");

                entity.HasIndex(e => e.CompetencyTopicItemId, "IX_FK_CompetencyTopicItemCompetencyEvaluationItem");

                entity.HasOne(d => d.CompetencyEvaluationForm)
                    .WithMany(p => p.CompetencyEvaluationItems)
                    .HasForeignKey(d => d.CompetencyEvaluationFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencyEvaluationFormCompetencyEvaluationItem");

                entity.HasOne(d => d.CompetencyTopicItem)
                    .WithMany(p => p.CompetencyEvaluationItems)
                    .HasForeignKey(d => d.CompetencyTopicItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencyTopicItemCompetencyEvaluationItem");
            });

            modelBuilder.Entity<CompetencyTopicExpectScore>(entity =>
            {
                entity.ToTable("CompetencyTopicExpectScores", "HR");

                entity.HasIndex(e => e.CompetencyTopicItemId, "IX_FK_CompetencyTopicItemCompetencyTopicExpectScore");

                entity.HasIndex(e => e.JobPositionId, "IX_FK_JobPositionCompetencyTopicExpectScore");

                entity.HasIndex(e => e.JobPositionLevelId, "IX_FK_JobPositionLevelCompetencyTopicExpectScore");

                entity.HasOne(d => d.CompetencyTopicItem)
                    .WithMany(p => p.CompetencyTopicExpectScores)
                    .HasForeignKey(d => d.CompetencyTopicItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencyTopicItemCompetencyTopicExpectScore");

                entity.HasOne(d => d.JobPosition)
                    .WithMany(p => p.CompetencyTopicExpectScores)
                    .HasForeignKey(d => d.JobPositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobPositionCompetencyTopicExpectScore");

                entity.HasOne(d => d.JobPositionLevel)
                    .WithMany(p => p.CompetencyTopicExpectScores)
                    .HasForeignKey(d => d.JobPositionLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobPositionLevelCompetencyTopicExpectScore");
            });

            modelBuilder.Entity<CompetencyTopicItem>(entity =>
            {
                entity.ToTable("CompetencyTopicItems", "HR");

                entity.Property(e => e.Level0Definitinition).HasDefaultValueSql("('')");

                entity.Property(e => e.Level1Definitinition).HasDefaultValueSql("('')");

                entity.Property(e => e.Level2Definitinition).HasDefaultValueSql("('')");

                entity.Property(e => e.Level3Definitinition).HasDefaultValueSql("('')");

                entity.Property(e => e.Level4Definitinition).HasDefaultValueSql("('')");

                entity.Property(e => e.Level5Definitinition).HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ContactPerson>(entity =>
            {
                entity.ToTable("ContactPersons", "CollaborationNetwork");

                entity.HasIndex(e => e.OrganizationId, "IX_FK_OrganizationContactPerson");

                entity.Property(e => e.ImageUrl).HasColumnName("ImageURL");

                entity.Property(e => e.LatestUpdate).HasColumnType("datetime");

                entity.Property(e => e.Nickname).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.ContactPeople)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("FK_OrganizationContactPerson");
            });

            modelBuilder.Entity<ContactPersonHistory>(entity =>
            {
                entity.ToTable("ContactPersonHistories", "CollaborationNetwork");

                entity.HasIndex(e => e.ContactPersonId, "IX_FK_ContactPersonContactPersonHistory");

                entity.Property(e => e.ImageUrl).HasColumnName("ImageURL");

                entity.Property(e => e.LatestUpdate).HasColumnType("datetime");

                entity.Property(e => e.Nickname).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.HasOne(d => d.ContactPerson)
                    .WithMany(p => p.ContactPersonHistories)
                    .HasForeignKey(d => d.ContactPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContactPersonContactPersonHistory");
            });

            modelBuilder.Entity<ContactPersonVisiting>(entity =>
            {
                entity.ToTable("ContactPersonVisitings", "CollaborationNetwork");

                entity.HasIndex(e => e.CollaborateReportId, "IX_FK_CollaborateReportContactPersonVisiting");

                entity.HasIndex(e => e.ContactPersonId, "IX_FK_ContactPersonContactPersonVisiting");

                entity.HasOne(d => d.CollaborateReport)
                    .WithMany(p => p.ContactPersonVisitings)
                    .HasForeignKey(d => d.CollaborateReportId)
                    .HasConstraintName("FK_CollaborateReportContactPersonVisiting");

                entity.HasOne(d => d.ContactPerson)
                    .WithMany(p => p.ContactPersonVisitings)
                    .HasForeignKey(d => d.ContactPersonId)
                    .HasConstraintName("FK_ContactPersonContactPersonVisiting");
            });

            modelBuilder.Entity<ContractEndEvaluationForm>(entity =>
            {
                entity.ToTable("ContractEndEvaluationForms", "HR");

                entity.HasIndex(e => e.EmploymentContractId, "IX_FK_EmploymentContractContractEndEvaluationForm");

                entity.Property(e => e.FirstContractEndDate).HasColumnType("datetime");

                entity.Property(e => e.FirstContractStartDate).HasColumnType("datetime");

                entity.Property(e => e.FirstEvaluator).HasDefaultValueSql("('')");

                entity.Property(e => e.FirstEvaluatorIsPass)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FirstEvaluatorOpinion).HasDefaultValueSql("('')");

                entity.Property(e => e.FirstEvaluatorPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.FirstEvaluatorSignDate).HasColumnType("datetime");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.Issue11).HasColumnName("Issue1_1");

                entity.Property(e => e.Issue11Opinion).HasColumnName("Issue1_1_Opinion");

                entity.Property(e => e.Issue11Score).HasColumnName("Issue1_1_Score");

                entity.Property(e => e.Issue11Weight).HasColumnName("Issue1_1_Weight");

                entity.Property(e => e.Issue12).HasColumnName("Issue1_2");

                entity.Property(e => e.Issue12Opinion).HasColumnName("Issue1_2_Opinion");

                entity.Property(e => e.Issue12Score).HasColumnName("Issue1_2_Score");

                entity.Property(e => e.Issue12Weight).HasColumnName("Issue1_2_Weight");

                entity.Property(e => e.Issue13).HasColumnName("Issue1_3");

                entity.Property(e => e.Issue13Opinion).HasColumnName("Issue1_3_Opinion");

                entity.Property(e => e.Issue13Score).HasColumnName("Issue1_3_Score");

                entity.Property(e => e.Issue13Weight).HasColumnName("Issue1_3_Weight");

                entity.Property(e => e.Issue21).HasColumnName("Issue2_1");

                entity.Property(e => e.Issue21Opinion).HasColumnName("Issue2_1_Opinion");

                entity.Property(e => e.Issue21Score).HasColumnName("Issue2_1_Score");

                entity.Property(e => e.Issue21Weight).HasColumnName("Issue2_1_Weight");

                entity.Property(e => e.Issue22).HasColumnName("Issue2_2");

                entity.Property(e => e.Issue22Opinion).HasColumnName("Issue2_2_Opinion");

                entity.Property(e => e.Issue22Score).HasColumnName("Issue2_2_Score");

                entity.Property(e => e.Issue22Weight).HasColumnName("Issue2_2_Weight");

                entity.Property(e => e.Issue31).HasColumnName("Issue3_1");

                entity.Property(e => e.Issue31Opinion).HasColumnName("Issue3_1_Opinion");

                entity.Property(e => e.Issue31Score).HasColumnName("Issue3_1_Score");

                entity.Property(e => e.Issue31Weight).HasColumnName("Issue3_1_Weight");

                entity.Property(e => e.Issue41).HasColumnName("Issue4_1");

                entity.Property(e => e.Issue41Opinion).HasColumnName("Issue4_1_Opinion");

                entity.Property(e => e.Issue41Score).HasColumnName("Issue4_1_Score");

                entity.Property(e => e.Issue41Weight).HasColumnName("Issue4_1_Weight");

                entity.Property(e => e.Issue51).HasColumnName("Issue5_1");

                entity.Property(e => e.Issue51Opinion).HasColumnName("Issue5_1_Opinion");

                entity.Property(e => e.Issue51Score).HasColumnName("Issue5_1_Score");

                entity.Property(e => e.Issue51Weight).HasColumnName("Issue5_1_Weight");

                entity.Property(e => e.Issue61).HasColumnName("Issue6_1");

                entity.Property(e => e.Issue61Opinion).HasColumnName("Issue6_1_Opinion");

                entity.Property(e => e.Issue61Score).HasColumnName("Issue6_1_Score");

                entity.Property(e => e.Issue61Weight).HasColumnName("Issue6_1_Weight");

                entity.Property(e => e.Issue71).HasColumnName("Issue7_1");

                entity.Property(e => e.Issue71Opinion).HasColumnName("Issue7_1_Opinion");

                entity.Property(e => e.Issue71Score).HasColumnName("Issue7_1_Score");

                entity.Property(e => e.Issue71Weight).HasColumnName("Issue7_1_Weight");

                entity.Property(e => e.Issue81).HasColumnName("Issue8_1");

                entity.Property(e => e.Issue81Opinion).HasColumnName("Issue8_1_Opinion");

                entity.Property(e => e.Issue81Score).HasColumnName("Issue8_1_Score");

                entity.Property(e => e.Issue81Weight).HasColumnName("Issue8_1_Weight");

                entity.Property(e => e.Issue91).HasColumnName("Issue9_1");

                entity.Property(e => e.Issue91Opinion).HasColumnName("Issue9_1_Opinion");

                entity.Property(e => e.Issue91Score).HasColumnName("Issue9_1_Score");

                entity.Property(e => e.Issue91Weight).HasColumnName("Issue9_1_Weight");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.Property(e => e.RecorderPositionName).HasDefaultValueSql("('')");

                entity.Property(e => e.RecorderSignDate).HasColumnType("datetime");

                entity.Property(e => e.SecondContractEndDate).HasColumnType("datetime");

                entity.Property(e => e.SecondContractStartDate).HasColumnType("datetime");

                entity.Property(e => e.SecondEvaluator).HasDefaultValueSql("('')");

                entity.Property(e => e.SecondEvaluatorIsPass)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SecondEvaluatorOpinion).HasDefaultValueSql("('')");

                entity.Property(e => e.SecondEvaluatorPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.SecondEvaluatorSignDate).HasColumnType("datetime");

                entity.Property(e => e.StaffBirthday).HasColumnType("datetime");

                entity.Property(e => e.StaffStartWorkingDate).HasColumnType("datetime");

                entity.Property(e => e.ThirdContractEndDate).HasColumnType("datetime");

                entity.Property(e => e.ThirdContractStartDate).HasColumnType("datetime");

                entity.HasOne(d => d.EmploymentContract)
                    .WithMany(p => p.ContractEndEvaluationForms)
                    .HasForeignKey(d => d.EmploymentContractId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmploymentContractContractEndEvaluationForm");
            });

            modelBuilder.Entity<CostType>(entity =>
            {
                entity.ToTable("CostTypes", "Plan");

                entity.HasIndex(e => e.ParentCostTypeId, "IX_FK_CostTypeCostType");

                entity.HasOne(d => d.ParentCostType)
                    .WithMany(p => p.InverseParentCostType)
                    .HasForeignKey(d => d.ParentCostTypeId)
                    .HasConstraintName("FK_CostTypeCostType");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Countries", "CollaborationNetwork");
            });

            modelBuilder.Entity<DailyAttendance>(entity =>
            {
                entity.ToTable("DailyAttendances", "HR");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffDailyAttendance");

                entity.HasIndex(e => e.StaffWorkShiftId, "IX_FK_StaffWorkShiftDailyAttendance");

                entity.Property(e => e.ClockIn).HasColumnType("datetime");

                entity.Property(e => e.ClockOut).HasColumnType("datetime");

                entity.Property(e => e.ForDate).HasColumnType("datetime");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.HrdepartmentName).HasColumnName("HRDepartmentName");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.DailyAttendances)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffDailyAttendance");

                entity.HasOne(d => d.StaffWorkShift)
                    .WithMany(p => p.DailyAttendances)
                    .HasForeignKey(d => d.StaffWorkShiftId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffWorkShiftDailyAttendance");
            });

            modelBuilder.Entity<DailyAttendanceRequestForm>(entity =>
            {
                entity.ToTable("DailyAttendanceRequestForms", "HR");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffDailyAttendanceRequestForm");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverSignDate).HasColumnType("datetime");

                entity.Property(e => e.ClockIn).HasColumnType("datetime");

                entity.Property(e => e.ClockOut).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ForDate).HasColumnType("datetime");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.HrdepartmentName).HasColumnName("HRDepartmentName");

                entity.Property(e => e.StaffWorkShiftClockIn).HasColumnType("datetime");

                entity.Property(e => e.StaffWorkShiftClockOut).HasColumnType("datetime");

                entity.Property(e => e.UnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.DailyAttendanceRequestForms)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffDailyAttendanceRequestForm");
            });

            modelBuilder.Entity<DeFormActionLog>(entity =>
            {
                entity.ToTable("DeFormActionLogs", "Plan");

                entity.HasIndex(e => e.DirectExpenseMemoFormId, "IX_FK_DirectExpenseMemoFormDeFormActionLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.Ip).HasColumnName("IP");

                entity.HasOne(d => d.DirectExpenseMemoForm)
                    .WithMany(p => p.DeFormActionLogs)
                    .HasForeignKey(d => d.DirectExpenseMemoFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DirectExpenseMemoFormDeFormActionLog");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Departments", "Plan");

                entity.HasIndex(e => e.ParentDepartmentId, "IX_FK_DepartmentSubDepartments");

                entity.HasOne(d => d.ParentDepartment)
                    .WithMany(p => p.InverseParentDepartment)
                    .HasForeignKey(d => d.ParentDepartmentId)
                    .HasConstraintName("FK_DepartmentSubDepartments");
            });

            modelBuilder.Entity<DepartmentInternalFilingNumber>(entity =>
            {
                entity.ToTable("DepartmentInternalFilingNumbers", "Filing");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.HrdepartmentName).HasColumnName("HRDepartmentName");
            });

            modelBuilder.Entity<DevelopmentRecord>(entity =>
            {
                entity.ToTable("DevelopmentRecords", "HR");

                entity.HasIndex(e => e.DevelopmentRecordGroupId, "IX_FK_DevelopmentRecordGroupDevelopmentRecord");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffDevelopmentRecord");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.Cost).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.HrdepartmentName).HasColumnName("HRDepartmentName");

                entity.HasOne(d => d.DevelopmentRecordGroup)
                    .WithMany(p => p.DevelopmentRecords)
                    .HasForeignKey(d => d.DevelopmentRecordGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DevelopmentRecordGroupDevelopmentRecord");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.DevelopmentRecords)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffDevelopmentRecord");
            });

            modelBuilder.Entity<DevelopmentRecordCancellation>(entity =>
            {
                entity.ToTable("DevelopmentRecordCancellations", "HR");

                entity.HasIndex(e => e.DevelopmentRecordId, "IX_FK_DevelopmentRecordDevelopmentRecordCancellation");

                entity.HasIndex(e => e.DevelopmentRecordGroupCancellationId, "IX_FK_DevelopmentRecordGroupCancellationDevelopmentRecordCancellation");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffDevelopmentRecordCancellation");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.HrdepartmentName).HasColumnName("HRDepartmentName");

                entity.HasOne(d => d.DevelopmentRecordGroupCancellation)
                    .WithMany(p => p.DevelopmentRecordCancellations)
                    .HasForeignKey(d => d.DevelopmentRecordGroupCancellationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DevelopmentRecordGroupCancellationDevelopmentRecordCancellation");

                entity.HasOne(d => d.DevelopmentRecord)
                    .WithMany(p => p.DevelopmentRecordCancellations)
                    .HasForeignKey(d => d.DevelopmentRecordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DevelopmentRecordDevelopmentRecordCancellation");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.DevelopmentRecordCancellations)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffDevelopmentRecordCancellation");
            });

            modelBuilder.Entity<DevelopmentRecordFollowUpForm>(entity =>
            {
                entity.ToTable("DevelopmentRecordFollowUpForms", "HR");

                entity.HasIndex(e => e.DevelopmentRecordId, "IX_FK_DevelopmentRecordDevelopmentRecordFollowUpForm");

                entity.Property(e => e.ApprovalStatusEnum).HasDefaultValueSql("((10))");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.Issue1Score).HasColumnName("Issue1_Score");

                entity.Property(e => e.Issue2Score).HasColumnName("Issue2_Score");

                entity.Property(e => e.Issue3Score).HasColumnName("Issue3_Score");

                entity.Property(e => e.Issue4Score).HasColumnName("Issue4_Score");

                entity.Property(e => e.Issue5Score).HasColumnName("Issue5_Score");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.HasOne(d => d.DevelopmentRecord)
                    .WithMany(p => p.DevelopmentRecordFollowUpForms)
                    .HasForeignKey(d => d.DevelopmentRecordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DevelopmentRecordDevelopmentRecordFollowUpForm");
            });

            modelBuilder.Entity<DevelopmentRecordGroup>(entity =>
            {
                entity.ToTable("DevelopmentRecordGroups", "HR");

                entity.HasIndex(e => e.HrdevelopmentTypeId, "IX_FK_HRDevelopmentTypeDevelopmentRecordGroup");

                entity.HasIndex(e => e.SyllabusId, "IX_FK_SyllabusDevelopmentRecordGroup");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverSignDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.DepartmentName).HasDefaultValueSql("('')");

                entity.Property(e => e.FundTypeName).HasDefaultValueSql("('')");

                entity.Property(e => e.HrdevelopmentTypeId).HasColumnName("HRDevelopmentTypeId");

                entity.Property(e => e.Location).HasDefaultValueSql("('')");

                entity.Property(e => e.OperationDate).HasDefaultValueSql("('')");

                entity.Property(e => e.OperationTime).HasDefaultValueSql("('')");

                entity.Property(e => e.OtherPeopleAttachText).HasDefaultValueSql("('')");

                entity.Property(e => e.OtherPeopleText).HasDefaultValueSql("('')");

                entity.Property(e => e.PlanActivityName).HasDefaultValueSql("('')");

                entity.Property(e => e.PlanCoreName).HasDefaultValueSql("('')");

                entity.Property(e => e.PlanCoreRemainBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.PlanTypeName).HasDefaultValueSql("('')");

                entity.Property(e => e.Purpose).HasDefaultValueSql("('')");

                entity.Property(e => e.RangeNumber).HasDefaultValueSql("((1))");

                entity.Property(e => e.Title).HasDefaultValueSql("('')");

                entity.Property(e => e.UnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.HrdevelopmentType)
                    .WithMany(p => p.DevelopmentRecordGroups)
                    .HasForeignKey(d => d.HrdevelopmentTypeId)
                    .HasConstraintName("FK_HRDevelopmentTypeDevelopmentRecordGroup");

                entity.HasOne(d => d.Syllabus)
                    .WithMany(p => p.DevelopmentRecordGroups)
                    .HasForeignKey(d => d.SyllabusId)
                    .HasConstraintName("FK_SyllabusDevelopmentRecordGroup");
            });

            modelBuilder.Entity<DevelopmentRecordGroupCancellation>(entity =>
            {
                entity.ToTable("DevelopmentRecordGroupCancellations", "HR");

                entity.HasIndex(e => e.DevelopmentRecordGroupId, "IX_FK_DevelopmentRecordGroupDevelopmentRecordGroupCancellation");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverSignDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.UnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.DevelopmentRecordGroup)
                    .WithMany(p => p.DevelopmentRecordGroupCancellations)
                    .HasForeignKey(d => d.DevelopmentRecordGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DevelopmentRecordGroupDevelopmentRecordGroupCancellation");
            });

            modelBuilder.Entity<DirectExpense>(entity =>
            {
                entity.ToTable("DirectExpenses", "Plan");

                entity.HasIndex(e => e.DirectExpenseMemoFormId, "IX_FK_DirectExpenseMemoFormDirectExpense");

                entity.HasIndex(e => e.PlanItemId, "IX_FK_PlanItemDirectExpense");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.TotalBudget).HasColumnType("decimal(15, 5)");

                entity.HasOne(d => d.DirectExpenseMemoForm)
                    .WithMany(p => p.DirectExpenses)
                    .HasForeignKey(d => d.DirectExpenseMemoFormId)
                    .HasConstraintName("FK_DirectExpenseMemoFormDirectExpense");

                entity.HasOne(d => d.PlanItem)
                    .WithMany(p => p.DirectExpenses)
                    .HasForeignKey(d => d.PlanItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanItemDirectExpense");
            });

            modelBuilder.Entity<DirectExpenseMemoForm>(entity =>
            {
                entity.ToTable("DirectExpenseMemoForms", "Plan");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.PlanActivityIdOld).HasColumnName("PlanActivityId_Old");

                entity.Property(e => e.PlanCoreNetBudget).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.PlanCoreRemainBudget).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.StatementCalculationDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DocumentWarehouse>(entity =>
            {
                entity.ToTable("DocumentWarehouses", "Filing");

                entity.HasIndex(e => e.ParentDocumentWarehouseId, "IX_FK_ParentDocumentWarehouseSubDocumentWarehouse");

                entity.HasOne(d => d.ParentDocumentWarehouse)
                    .WithMany(p => p.InverseParentDocumentWarehouse)
                    .HasForeignKey(d => d.ParentDocumentWarehouseId)
                    .HasConstraintName("FK_ParentDocumentWarehouseSubDocumentWarehouse");
            });

            modelBuilder.Entity<DrinkingWaterBill>(entity =>
            {
                entity.ToTable("DrinkingWaterBills", "Operation");

                entity.HasIndex(e => e.BillingLocationId, "IX_FK_BillingLocationDrinkingWaterBill");

                entity.Property(e => e.BillingDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasDefaultValueSql("('')");

                entity.Property(e => e.TotalBill).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.BillingLocation)
                    .WithMany(p => p.DrinkingWaterBills)
                    .HasForeignKey(d => d.BillingLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillingLocationDrinkingWaterBill");
            });

            modelBuilder.Entity<EducationLevel>(entity =>
            {
                entity.ToTable("EducationLevels", "HR");
            });

            modelBuilder.Entity<EducationRecord>(entity =>
            {
                entity.ToTable("EducationRecords", "HR");

                entity.HasIndex(e => e.EducationLevelId, "IX_FK_EducationLevelEducationRecord");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffEducationRecord");

                entity.HasOne(d => d.EducationLevel)
                    .WithMany(p => p.EducationRecords)
                    .HasForeignKey(d => d.EducationLevelId)
                    .HasConstraintName("FK_EducationLevelEducationRecord");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.EducationRecords)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffEducationRecord");
            });

            modelBuilder.Entity<EfilingDepartmentPermission>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.AspnetUsersUserId });

                entity.ToTable("EFiling_DepartmentPermissions");

                entity.HasIndex(e => e.AspnetUsersUserId, "IX_FK_aspnet_UsersEFiling_DepartmentPermission");

                entity.Property(e => e.AspnetUsersUserId).HasColumnName("aspnet_UsersUserId");

                entity.HasOne(d => d.AspnetUsersUser)
                    .WithMany(p => p.EfilingDepartmentPermissions)
                    .HasForeignKey(d => d.AspnetUsersUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aspnet_UsersEFiling_DepartmentPermission");
            });

            modelBuilder.Entity<ElectricityBill>(entity =>
            {
                entity.ToTable("ElectricityBills", "Operation");

                entity.HasIndex(e => e.BillingLocationId, "IX_FK_BillingLocationElectricityBill");

                entity.Property(e => e.BilingNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.BillingDate).HasColumnType("datetime");

                entity.Property(e => e.Ft)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("FT");

                entity.Property(e => e.HolidayKwunit)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("HolidayKWUnit");

                entity.Property(e => e.HolidayUnit).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.KwpeakBill)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("KWPeakBill");

                entity.Property(e => e.MeterReadDate).HasColumnType("datetime");

                entity.Property(e => e.OffPeakBill).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.OffPeakKwunit)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("OffPeakKWUnit");

                entity.Property(e => e.OffPeakUnit).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.PeakBill).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.PeakKwunit)
                    .HasColumnType("decimal(12, 4)")
                    .HasColumnName("PeakKWUnit");

                entity.Property(e => e.PeakUnit).HasColumnType("decimal(12, 4)");

                entity.Property(e => e.Remark).HasDefaultValueSql("('')");

                entity.Property(e => e.ServiceBill).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.TotalBill).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.BillingLocation)
                    .WithMany(p => p.ElectricityBills)
                    .HasForeignKey(d => d.BillingLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillingLocationElectricityBill");
            });

            modelBuilder.Entity<EmploymentContract>(entity =>
            {
                entity.ToTable("EmploymentContracts", "HR");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffEmploymentContract");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.SentMailDate).HasColumnType("datetime");

                entity.Property(e => e.SentMailToHrdate)
                    .HasColumnType("datetime")
                    .HasColumnName("SentMailToHRDate");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.EmploymentContracts)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffEmploymentContract");
            });

            modelBuilder.Entity<FamilialRelationship>(entity =>
            {
                entity.ToTable("FamilialRelationships", "HR");

                entity.Property(e => e.FamilyRelationTypeEnum).HasDefaultValueSql("((10))");
            });

            modelBuilder.Entity<FilingDocMessageReferrer>(entity =>
            {
                entity.ToTable("FilingDocMessageReferrers", "Filing");

                entity.HasIndex(e => e.FilingDocumentId, "IX_FK_FilingDocumentFilingDocMessageReferrer");

                entity.HasIndex(e => e.MessageId, "IX_FK_MessageFilingDocMessageReferrer");

                entity.HasOne(d => d.FilingDocument)
                    .WithMany(p => p.FilingDocMessageReferrers)
                    .HasForeignKey(d => d.FilingDocumentId)
                    .HasConstraintName("FK_FilingDocumentFilingDocMessageReferrer");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.FilingDocMessageReferrers)
                    .HasForeignKey(d => d.MessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MessageFilingDocMessageReferrer");
            });

            modelBuilder.Entity<FilingDocProjectRelation>(entity =>
            {
                entity.ToTable("FilingDocProjectRelations", "Filing");

                entity.HasIndex(e => e.FilingDocumentId, "IX_FK_FilingDocumentFilingDocProjectRelation");

                entity.HasIndex(e => e.FilingProjectId, "IX_FK_FilingProjectFilingDocProjectRelation");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.TagDate).HasColumnType("datetime");

                entity.HasOne(d => d.FilingDocument)
                    .WithMany(p => p.FilingDocProjectRelations)
                    .HasForeignKey(d => d.FilingDocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FilingDocumentFilingDocProjectRelation");

                entity.HasOne(d => d.FilingProject)
                    .WithMany(p => p.FilingDocProjectRelations)
                    .HasForeignKey(d => d.FilingProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FilingProjectFilingDocProjectRelation");
            });

            modelBuilder.Entity<FilingDocTagRelation>(entity =>
            {
                entity.ToTable("FilingDocTagRelations", "Filing");

                entity.HasIndex(e => e.FilingDocumentId, "IX_FK_FilingDocumentFilingDocTagRelation");

                entity.HasIndex(e => e.FilingTagId, "IX_FK_FilingTagFilingDocTagRelation");

                entity.HasOne(d => d.FilingDocument)
                    .WithMany(p => p.FilingDocTagRelations)
                    .HasForeignKey(d => d.FilingDocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FilingDocumentFilingDocTagRelation");

                entity.HasOne(d => d.FilingTag)
                    .WithMany(p => p.FilingDocTagRelations)
                    .HasForeignKey(d => d.FilingTagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FilingTagFilingDocTagRelation");
            });

            modelBuilder.Entity<FilingDocWarehouseRelation>(entity =>
            {
                entity.ToTable("FilingDocWarehouseRelations", "Filing");

                entity.HasIndex(e => e.DocumentWarehouseId, "IX_FK_DocumentWarehouseFilingDocWarehouseRelation");

                entity.HasIndex(e => e.FilingDocumentId, "IX_FK_FilingDocumentFilingDocWarehouseRelation");

                entity.HasOne(d => d.DocumentWarehouse)
                    .WithMany(p => p.FilingDocWarehouseRelations)
                    .HasForeignKey(d => d.DocumentWarehouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentWarehouseFilingDocWarehouseRelation");

                entity.HasOne(d => d.FilingDocument)
                    .WithMany(p => p.FilingDocWarehouseRelations)
                    .HasForeignKey(d => d.FilingDocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FilingDocumentFilingDocWarehouseRelation");
            });

            modelBuilder.Entity<FilingDocument>(entity =>
            {
                entity.ToTable("FilingDocuments", "Filing");

                entity.HasIndex(e => e.FilingGeneralOrderId, "IX_FK_FilingGeneralOrderFilingDocument");

                entity.Property(e => e.CloseIssueDate).HasColumnType("datetime");

                entity.Property(e => e.CoordinateHrdepId).HasColumnName("CoordinateHRDepId");

                entity.Property(e => e.CoordinateHrdepName)
                    .HasColumnName("CoordinateHRDepName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatorIp).HasColumnName("CreatorIP");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.FilingDate).HasColumnType("datetime");

                entity.Property(e => e.FirstResponsibleStaff).HasDefaultValueSql("('')");

                entity.Property(e => e.FirstResponsibleStaffPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.HrdepartmentName).HasColumnName("HRDepartmentName");

                entity.Property(e => e.LastSaveDate).HasColumnType("datetime");

                entity.Property(e => e.LastSaveIp).HasColumnName("LastSaveIP");

                entity.Property(e => e.Moucountry)
                    .HasColumnName("MOUCountry")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OpenIssueDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.RespondsibleHrdepId).HasColumnName("RespondsibleHRDepId");

                entity.Property(e => e.RespondsibleHrdepName)
                    .HasColumnName("RespondsibleHRDepName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ResponsibleStaff).HasDefaultValueSql("('')");

                entity.Property(e => e.ResponsibleStaffPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.SecondResponsibleStaff).HasDefaultValueSql("('')");

                entity.Property(e => e.SecondResponsibleStaffPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.ThirdResponsibleStaff).HasDefaultValueSql("('')");

                entity.Property(e => e.ThirdResponsibleStaffPosition).HasDefaultValueSql("('')");

                entity.HasOne(d => d.FilingGeneralOrder)
                    .WithMany(p => p.FilingDocuments)
                    .HasForeignKey(d => d.FilingGeneralOrderId)
                    .HasConstraintName("FK_FilingGeneralOrderFilingDocument");
            });

            modelBuilder.Entity<FilingDocumentAccessLog>(entity =>
            {
                entity.ToTable("FilingDocumentAccessLogs", "Filing");

                entity.HasIndex(e => e.FilingDocumentId, "IX_FK_FilingDocumentFilingDocumentAccessLog");

                entity.Property(e => e.AccessDate).HasColumnType("datetime");

                entity.Property(e => e.AccessIp).HasColumnName("AccessIP");

                entity.Property(e => e.LeaveDate).HasColumnType("datetime");

                entity.HasOne(d => d.FilingDocument)
                    .WithMany(p => p.FilingDocumentAccessLogs)
                    .HasForeignKey(d => d.FilingDocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FilingDocumentFilingDocumentAccessLog");
            });

            modelBuilder.Entity<FilingDocumentHistory>(entity =>
            {
                entity.ToTable("FilingDocumentHistories", "Filing");

                entity.HasIndex(e => e.FilingDocumentId, "IX_FK_FilingDocumentFilingDocumentHistory");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.EditDate).HasColumnType("datetime");

                entity.Property(e => e.EditorIp).HasColumnName("EditorIP");

                entity.Property(e => e.FilingDate).HasColumnType("datetime");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.HrdepartmentName).HasColumnName("HRDepartmentName");

                entity.HasOne(d => d.FilingDocument)
                    .WithMany(p => p.FilingDocumentHistories)
                    .HasForeignKey(d => d.FilingDocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FilingDocumentFilingDocumentHistory");
            });

            modelBuilder.Entity<FilingDocumentReferrer>(entity =>
            {
                entity.ToTable("FilingDocumentReferrers", "Filing");

                entity.HasIndex(e => e.FilingDocumentId, "IX_FK_FilingDocumentFilingDocumentReferrer");

                entity.HasIndex(e => e.ReferFilingDocumentId, "IX_FK_ReferFilingDocumentFilingDocumentRefered");

                entity.HasOne(d => d.FilingDocument)
                    .WithMany(p => p.FilingDocumentReferrerFilingDocuments)
                    .HasForeignKey(d => d.FilingDocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FilingDocumentFilingDocumentReferrer");

                entity.HasOne(d => d.ReferFilingDocument)
                    .WithMany(p => p.FilingDocumentReferrerReferFilingDocuments)
                    .HasForeignKey(d => d.ReferFilingDocumentId)
                    .HasConstraintName("FK_ReferFilingDocumentFilingDocumentRefered");
            });

            modelBuilder.Entity<FilingFile>(entity =>
            {
                entity.ToTable("FilingFiles", "Filing");

                entity.HasIndex(e => e.FilingDocumentId, "IX_FK_FilingDocumentFilingFile");

                entity.HasIndex(e => e.MainFilingDocumentId, "IX_FK_FilingDocumentMainFilingFile");

                entity.HasIndex(e => e.MessageId, "IX_FK_MessageFilingFile");

                entity.Property(e => e.UploadDate).HasColumnType("datetime");

                entity.HasOne(d => d.FilingDocument)
                    .WithMany(p => p.FilingFileFilingDocuments)
                    .HasForeignKey(d => d.FilingDocumentId)
                    .HasConstraintName("FK_FilingDocumentFilingFile");

                entity.HasOne(d => d.MainFilingDocument)
                    .WithMany(p => p.FilingFileMainFilingDocuments)
                    .HasForeignKey(d => d.MainFilingDocumentId)
                    .HasConstraintName("FK_FilingDocumentMainFilingFile");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.FilingFiles)
                    .HasForeignKey(d => d.MessageId)
                    .HasConstraintName("FK_MessageFilingFile");
            });

            modelBuilder.Entity<FilingFileAccessLog>(entity =>
            {
                entity.ToTable("FilingFileAccessLogs", "Filing");

                entity.HasIndex(e => e.FilingFileId, "IX_FK_FilingFileFilingFileAccessLog");

                entity.Property(e => e.AccessDate).HasColumnType("datetime");

                entity.Property(e => e.AccessIp).HasColumnName("AccessIP");

                entity.HasOne(d => d.FilingFile)
                    .WithMany(p => p.FilingFileAccessLogs)
                    .HasForeignKey(d => d.FilingFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FilingFileFilingFileAccessLog");
            });

            modelBuilder.Entity<FilingGeneralOrder>(entity =>
            {
                entity.ToTable("FilingGeneralOrders", "Filing");
            });

            modelBuilder.Entity<FilingHrdepartmentPermission>(entity =>
            {
                entity.ToTable("FilingHRDepartmentPermissions", "Filing");

                entity.HasIndex(e => e.FilingRegisterBookId, "IX_FK_FilingRegisterBookFilingHRDepartmentPermission");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.HasOne(d => d.FilingRegisterBook)
                    .WithMany(p => p.FilingHrdepartmentPermissions)
                    .HasForeignKey(d => d.FilingRegisterBookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FilingRegisterBookFilingHRDepartmentPermission");
            });

            modelBuilder.Entity<FilingHrdepartmentStaffPermission>(entity =>
            {
                entity.ToTable("FilingHRDepartmentStaffPermissions", "Filing");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.HrdepartmentName).HasColumnName("HRDepartmentName");
            });

            modelBuilder.Entity<FilingOpinion>(entity =>
            {
                entity.ToTable("FilingOpinions", "Filing");

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<FilingPersonalMarkup>(entity =>
            {
                entity.ToTable("FilingPersonalMarkups", "Filing");

                entity.HasIndex(e => e.FilingDocumentId, "IX_FK_FilingDocumentFilingPersonalMarkup");

                entity.HasOne(d => d.FilingDocument)
                    .WithMany(p => p.FilingPersonalMarkups)
                    .HasForeignKey(d => d.FilingDocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FilingDocumentFilingPersonalMarkup");
            });

            modelBuilder.Entity<FilingPostscript>(entity =>
            {
                entity.ToTable("FilingPostscripts", "Filing");

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<FilingProject>(entity =>
            {
                entity.ToTable("FilingProjects", "Filing");

                entity.HasIndex(e => e.ParentFilingProjectId, "IX_FK_ParentFilingProjectSubFilingProject");

                entity.HasOne(d => d.ParentFilingProject)
                    .WithMany(p => p.InverseParentFilingProject)
                    .HasForeignKey(d => d.ParentFilingProjectId)
                    .HasConstraintName("FK_ParentFilingProjectSubFilingProject");
            });

            modelBuilder.Entity<FilingRegisterBook>(entity =>
            {
                entity.ToTable("FilingRegisterBooks", "Filing");

                entity.HasIndex(e => e.ParentFilingRegisterBookId, "IX_FK_ParentFilingRegisterBookSubFilingRegisterBook");

                entity.HasOne(d => d.ParentFilingRegisterBook)
                    .WithMany(p => p.InverseParentFilingRegisterBook)
                    .HasForeignKey(d => d.ParentFilingRegisterBookId)
                    .HasConstraintName("FK_ParentFilingRegisterBookSubFilingRegisterBook");
            });

            modelBuilder.Entity<FilingRegisterNumber>(entity =>
            {
                entity.ToTable("FilingRegisterNumbers", "Filing");

                entity.HasIndex(e => e.FilingDocumentId, "IX_FK_FilingDocumentFilingRegisterNumber");

                entity.HasIndex(e => e.FilingRegisterBookId, "IX_FK_FilingRegisterBookFilingRegisterNumber");

                entity.Property(e => e.CancelReason).HasDefaultValueSql("('')");

                entity.Property(e => e.CreatorIp).HasColumnName("CreatorIP");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUsed).HasColumnType("datetime");

                entity.Property(e => e.RegisterDate).HasColumnType("datetime");

                entity.Property(e => e.ReservedByDepartment).HasDefaultValueSql("('')");

                entity.Property(e => e.ReservedByStaff).HasDefaultValueSql("('')");

                entity.Property(e => e.ReservedReason).HasDefaultValueSql("('')");

                entity.HasOne(d => d.FilingDocument)
                    .WithMany(p => p.FilingRegisterNumbers)
                    .HasForeignKey(d => d.FilingDocumentId)
                    .HasConstraintName("FK_FilingDocumentFilingRegisterNumber");

                entity.HasOne(d => d.FilingRegisterBook)
                    .WithMany(p => p.FilingRegisterNumbers)
                    .HasForeignKey(d => d.FilingRegisterBookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FilingRegisterBookFilingRegisterNumber");
            });

            modelBuilder.Entity<FilingRegisterNumberLog>(entity =>
            {
                entity.ToTable("FilingRegisterNumberLogs", "Filing");

                entity.Property(e => e.DateOfChanged).HasColumnType("datetime");
            });

            modelBuilder.Entity<FilingSecretary>(entity =>
            {
                entity.ToTable("FilingSecretaries", "Filing");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<FilingSendForm>(entity =>
            {
                entity.ToTable("FilingSendForms", "Filing");

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<FilingTag>(entity =>
            {
                entity.ToTable("FilingTags", "Filing");

                entity.HasIndex(e => e.ParentFilingTagId, "IX_FK_ParentFilingTagSubFilingTag");

                entity.HasOne(d => d.ParentFilingTag)
                    .WithMany(p => p.InverseParentFilingTag)
                    .HasForeignKey(d => d.ParentFilingTagId)
                    .HasConstraintName("FK_ParentFilingTagSubFilingTag");
            });

            modelBuilder.Entity<FinancialReimbursementForm>(entity =>
            {
                entity.ToTable("FinancialReimbursementForms", "Plan");

                entity.HasIndex(e => e.GeneralExpenseMemoFormId, "IX_FK_GeneralExpenseMemoFormFinancialReimbursementForm");

                entity.Property(e => e.ApproverSignDate).HasColumnType("datetime");

                entity.Property(e => e.BudgetCheckerSignDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.OperationSummary).HasDefaultValueSql("('')");

                entity.Property(e => e.PayeeSignDate).HasColumnType("datetime");

                entity.Property(e => e.PayerSignDate).HasColumnType("datetime");

                entity.Property(e => e.PlanFormApprovalStatusEnum).HasDefaultValueSql("((10))");

                entity.Property(e => e.RefDocumentDate).HasColumnType("datetime");

                entity.Property(e => e.RefStatementName).HasDefaultValueSql("('')");

                entity.Property(e => e.RefTotalBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.RelatedRegulation).HasDefaultValueSql("('')");

                entity.Property(e => e.RequesterSignDate).HasColumnType("datetime");

                entity.Property(e => e.SuppliesOfficerSignDate).HasColumnType("datetime");

                entity.Property(e => e.UnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.GeneralExpenseMemoForm)
                    .WithMany(p => p.FinancialReimbursementForms)
                    .HasForeignKey(d => d.GeneralExpenseMemoFormId)
                    .HasConstraintName("FK_GeneralExpenseMemoFormFinancialReimbursementForm");
            });

            modelBuilder.Entity<FinancialReimbursementItem>(entity =>
            {
                entity.ToTable("FinancialReimbursementItems", "Plan");

                entity.HasIndex(e => e.FinancialReimbursementFormId, "IX_FK_FinancialReimbursementFormFinancialReimbursementItem");

                entity.HasIndex(e => e.GeneralExpenseId, "IX_FK_GeneralExpenseFinancialReimbursementItem");

                entity.Property(e => e.BudgetTypeName).HasDefaultValueSql("('')");

                entity.Property(e => e.GedataGroupId).HasColumnName("GEDataGroupId");

                entity.Property(e => e.GedocumentNumber)
                    .HasColumnName("GEDocumentNumber")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsHrpayment).HasColumnName("IsHRPayment");

                entity.Property(e => e.PlanActivityCode).HasDefaultValueSql("('')");

                entity.Property(e => e.PlanCoreCode).HasDefaultValueSql("('')");

                entity.Property(e => e.PlanCoreRemainBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.PlanItemRemainBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.PlanTypeCode).HasDefaultValueSql("('')");

                entity.Property(e => e.RangeNumber).HasDefaultValueSql("((1))");

                entity.Property(e => e.RequestBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.TotalBudget).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.FinancialReimbursementForm)
                    .WithMany(p => p.FinancialReimbursementItems)
                    .HasForeignKey(d => d.FinancialReimbursementFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FinancialReimbursementFormFinancialReimbursementItem");
            });

            modelBuilder.Entity<FingerPrintDbconnector>(entity =>
            {
                entity.ToTable("FingerPrintDBConnectors", "HR");

                entity.Property(e => e.LastReadDate).HasColumnType("datetime");

                entity.Property(e => e.LastSourceCheckTimeRead).HasColumnType("datetime");

                entity.Property(e => e.PreviousReadDate).HasColumnType("datetime");

                entity.Property(e => e.PreviousSourceCheckTimeRead).HasColumnType("datetime");
            });

            modelBuilder.Entity<FingerPrintDbrawData>(entity =>
            {
                entity.ToTable("FingerPrintDBRawDatas", "HR");

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.FingerPrintDbconnectorId).HasColumnName("FingerPrintDBConnectorId");

                entity.Property(e => e.ForDate).HasColumnType("datetime");

                entity.Property(e => e.RawDbid).HasColumnName("RawDBId");

                entity.Property(e => e.ReadDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FingerPrintReaderSensor>(entity =>
            {
                entity.ToTable("FingerPrintReaderSensors", "HR");

                entity.Property(e => e.LastSourceCheckTimeRead)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<FormRequest>(entity =>
            {
                entity.ToTable("FormRequest", "Procure");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FrFormActionLog>(entity =>
            {
                entity.ToTable("FrFormActionLogs", "Plan");

                entity.HasIndex(e => e.FinancialReimbursementFormId, "IX_FK_FinancialReimbursementFormFrFormActionLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.Ip).HasColumnName("IP");

                entity.Property(e => e.ReturnDeadline).HasColumnType("datetime");

                entity.Property(e => e.ReturnReasonValue).HasDefaultValueSql("('')");

                entity.HasOne(d => d.FinancialReimbursementForm)
                    .WithMany(p => p.FrFormActionLogs)
                    .HasForeignKey(d => d.FinancialReimbursementFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FinancialReimbursementFormFrFormActionLog");
            });

            modelBuilder.Entity<FundSource>(entity =>
            {
                entity.ToTable("FundSource", "Plan");
            });

            modelBuilder.Entity<FundType>(entity =>
            {
                entity.ToTable("FundTypes", "Plan");

                entity.HasIndex(e => e.ParentFundTypeId, "IX_FK_FundTypeFundType");

                entity.HasOne(d => d.ParentFundType)
                    .WithMany(p => p.InverseParentFundType)
                    .HasForeignKey(d => d.ParentFundTypeId)
                    .HasConstraintName("FK_FundTypeFundType");
            });

            modelBuilder.Entity<GarbageBill>(entity =>
            {
                entity.ToTable("GarbageBills", "Operation");

                entity.HasIndex(e => e.BillingLocationId, "IX_FK_BillingLocationGarbageBill");

                entity.Property(e => e.BillingDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasDefaultValueSql("('')");

                entity.Property(e => e.TotalBill).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.BillingLocation)
                    .WithMany(p => p.GarbageBills)
                    .HasForeignKey(d => d.BillingLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillingLocationGarbageBill");
            });

            modelBuilder.Entity<GeBorrowFormActionLog>(entity =>
            {
                entity.ToTable("GeBorrowFormActionLogs", "Plan");

                entity.HasIndex(e => e.GeneralExpensePersonalBorrowFormId, "IX_FK_GeneralExpensePersonalBorrowFormGeBorrowFormActionLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.CipherKeyPairId).HasDefaultValueSql("('')");

                entity.Property(e => e.Detail).HasDefaultValueSql("('')");

                entity.Property(e => e.Ip).HasColumnName("IP");

                entity.Property(e => e.Jwtpayload)
                    .HasColumnName("JWTPayload")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SignedHashText).HasDefaultValueSql("('')");

                entity.Property(e => e.SignedHashValue).HasDefaultValueSql("('')");

                entity.Property(e => e.VerifyData).HasDefaultValueSql("('')");

                entity.HasOne(d => d.GeneralExpensePersonalBorrowForm)
                    .WithMany(p => p.GeBorrowFormActionLogs)
                    .HasForeignKey(d => d.GeneralExpensePersonalBorrowFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpensePersonalBorrowFormGeBorrowFormActionLog");
            });

            modelBuilder.Entity<GeExtendFormActionLog>(entity =>
            {
                entity.ToTable("GeExtendFormActionLogs", "Plan");

                entity.HasIndex(e => e.GeneralExpenseExtendFormId, "IX_FK_GeneralExpenseExtendFormGeExtendFormActionLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.Ip).HasColumnName("IP");

                entity.HasOne(d => d.GeneralExpenseExtendForm)
                    .WithMany(p => p.GeExtendFormActionLogs)
                    .HasForeignKey(d => d.GeneralExpenseExtendFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpenseExtendFormGeExtendFormActionLog");
            });

            modelBuilder.Entity<GeFormActionLog>(entity =>
            {
                entity.ToTable("GeFormActionLogs", "Plan");

                entity.HasIndex(e => e.GeneralExpenseMemoFormId, "IX_FK_GeneralExpenseMemoFormGeFormActionLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.Detail).HasDefaultValueSql("('')");

                entity.Property(e => e.Ip).HasColumnName("IP");

                entity.Property(e => e.Jwtpayload)
                    .HasColumnName("JWTPayload")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SignedHashText).HasDefaultValueSql("('')");

                entity.Property(e => e.SignedHashValue).HasDefaultValueSql("('')");

                entity.Property(e => e.VerifyData).HasDefaultValueSql("('')");

                entity.HasOne(d => d.GeneralExpenseMemoForm)
                    .WithMany(p => p.GeFormActionLogs)
                    .HasForeignKey(d => d.GeneralExpenseMemoFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpenseMemoFormGeFormActionLog");
            });

            modelBuilder.Entity<GedataGroup>(entity =>
            {
                entity.ToTable("GEDataGroups", "Plan");

                entity.Property(e => e.PlanCoreRemainBudget).HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<GememoFormSchedule>(entity =>
            {
                entity.ToTable("GEMemoFormSchedules", "Plan");

                entity.HasIndex(e => e.GeneralExpenseMemoFormId, "IX_FK_GeneralExpenseMemoFormGEMemoFormSchedule");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.HasOne(d => d.GeneralExpenseMemoForm)
                    .WithMany(p => p.GememoFormSchedules)
                    .HasForeignKey(d => d.GeneralExpenseMemoFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpenseMemoFormGEMemoFormSchedule");
            });

            modelBuilder.Entity<GeneralExpense>(entity =>
            {
                entity.ToTable("GeneralExpenses", "Plan");

                entity.HasIndex(e => e.GedataGroupId, "IX_FK_GEDataGroupGeneralExpense");

                entity.HasIndex(e => e.GeneralExpenseCancelFormId, "IX_FK_GeneralExpenseCancelFormGeneralExpense");

                entity.HasIndex(e => e.GeneralExpenseMemoFormId, "IX_FK_GeneralExpenseMemoFormGeneralExpense");

                entity.HasIndex(e => e.GeneralExpenseReturnFormId, "IX_FK_GeneralExpenseReturnFormGeneralExpense");

                entity.HasIndex(e => e.PlanItemId, "IX_FK_PlanItemGeneralExpense");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.CancelBudgetOld)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("CancelBudget_Old");

                entity.Property(e => e.FinishSettleFormWriteDate).HasColumnType("datetime");

                entity.Property(e => e.FinishTransformDate).HasColumnType("datetime");

                entity.Property(e => e.GedataGroupId).HasColumnName("GEDataGroupId");

                entity.Property(e => e.IsHrpayment).HasColumnName("IsHRPayment");

                entity.Property(e => e.PlanActivityName).HasDefaultValueSql("('')");

                entity.Property(e => e.PlanCoreName).HasDefaultValueSql("('')");

                entity.Property(e => e.PlanCoreRemainBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.PlanItemFinRemainBudget)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.RequestReserveBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ReturnBudgetOld)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("ReturnBudget_Old");

                entity.Property(e => e.ReturnBudgetYearEndRequest)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalBudget).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.GedataGroup)
                    .WithMany(p => p.GeneralExpenses)
                    .HasForeignKey(d => d.GedataGroupId)
                    .HasConstraintName("FK_GEDataGroupGeneralExpense");

                entity.HasOne(d => d.GeneralExpenseCancelForm)
                    .WithMany(p => p.GeneralExpenses)
                    .HasForeignKey(d => d.GeneralExpenseCancelFormId)
                    .HasConstraintName("FK_GeneralExpenseCancelFormGeneralExpense");

                entity.HasOne(d => d.GeneralExpenseMemoForm)
                    .WithMany(p => p.GeneralExpenses)
                    .HasForeignKey(d => d.GeneralExpenseMemoFormId)
                    .HasConstraintName("FK_GeneralExpenseMemoFormGeneralExpense");

                entity.HasOne(d => d.GeneralExpenseReturnForm)
                    .WithMany(p => p.GeneralExpenses)
                    .HasForeignKey(d => d.GeneralExpenseReturnFormId)
                    .HasConstraintName("FK_GeneralExpenseReturnFormGeneralExpense");

                entity.HasOne(d => d.PlanItem)
                    .WithMany(p => p.GeneralExpenses)
                    .HasForeignKey(d => d.PlanItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanItemGeneralExpense");
            });

            modelBuilder.Entity<GeneralExpenseCancelForm>(entity =>
            {
                entity.ToTable("GeneralExpenseCancelForms", "Plan");

                entity.HasIndex(e => e.GeneralExpenseMemoFormId, "IX_FK_GeneralExpenseMemoFormGeneralExpenseCancelForm");

                entity.Property(e => e.CancelDate).HasColumnType("datetime");

                entity.Property(e => e.StatementCalculationDate).HasColumnType("datetime");

                entity.HasOne(d => d.GeneralExpenseMemoForm)
                    .WithMany(p => p.GeneralExpenseCancelForms)
                    .HasForeignKey(d => d.GeneralExpenseMemoFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpenseMemoFormGeneralExpenseCancelForm");
            });

            modelBuilder.Entity<GeneralExpenseCancelItem>(entity =>
            {
                entity.ToTable("GeneralExpenseCancelItems", "Plan");

                entity.HasIndex(e => e.GeneralExpenseCancelFormId, "IX_FK_GeneralExpenseCancelFormGeneralExpenseCancelItem");

                entity.HasIndex(e => e.GeneralExpenseId, "IX_FK_GeneralExpenseGeneralExpenseCancelItem");

                entity.Property(e => e.CancelBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.RemainWithdrawableBudgetAtDate).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.GeneralExpenseCancelForm)
                    .WithMany(p => p.GeneralExpenseCancelItems)
                    .HasForeignKey(d => d.GeneralExpenseCancelFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpenseCancelFormGeneralExpenseCancelItem");

                entity.HasOne(d => d.GeneralExpense)
                    .WithMany(p => p.GeneralExpenseCancelItems)
                    .HasForeignKey(d => d.GeneralExpenseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpenseGeneralExpenseCancelItem");
            });

            modelBuilder.Entity<GeneralExpenseExtendForm>(entity =>
            {
                entity.ToTable("GeneralExpenseExtendForms", "Plan");

                entity.HasIndex(e => e.GeneralExpenseMemoFormId, "IX_FK_GeneralExpenseMemoFormGeneralExpenseExtendForm");

                entity.Property(e => e.RefDocumentWriteDate).HasColumnType("datetime");

                entity.Property(e => e.TotalBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.GeneralExpenseMemoForm)
                    .WithMany(p => p.GeneralExpenseExtendForms)
                    .HasForeignKey(d => d.GeneralExpenseMemoFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpenseMemoFormGeneralExpenseExtendForm");
            });

            modelBuilder.Entity<GeneralExpenseMemoForm>(entity =>
            {
                entity.ToTable("GeneralExpenseMemoForms", "Plan");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.ApproverSignDate).HasColumnType("datetime");

                entity.Property(e => e.BudgetCheckerPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.BudgetCheckerSignDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DocCheckerName).HasDefaultValueSql("('')");

                entity.Property(e => e.DocCheckerPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.DocCheckerSignDate).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.FifthBorrowAmount)
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.FifthBorrower).HasDefaultValueSql("('')");

                entity.Property(e => e.FifthBorrowerDepartment).HasDefaultValueSql("('')");

                entity.Property(e => e.FifthBorrowerPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.FifthBorrowerPositionTypeName).HasDefaultValueSql("('')");

                entity.Property(e => e.FirstBorrowAmount)
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.FirstBorrower).HasDefaultValueSql("('')");

                entity.Property(e => e.FirstBorrowerDepartment).HasDefaultValueSql("('')");

                entity.Property(e => e.FirstBorrowerPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.FirstBorrowerPositionTypeName).HasDefaultValueSql("('')");

                entity.Property(e => e.FirstCheckComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.FirstProcureComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.FourthBorrowAmount)
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.FourthBorrower).HasDefaultValueSql("('')");

                entity.Property(e => e.FourthBorrowerDepartment).HasDefaultValueSql("('')");

                entity.Property(e => e.FourthBorrowerPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.FourthBorrowerPositionTypeName).HasDefaultValueSql("('')");

                entity.Property(e => e.HrofficerName)
                    .HasColumnName("HROfficerName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HrofficerPosition)
                    .HasColumnName("HROfficerPosition")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HrofficerSignDate)
                    .HasColumnType("datetime")
                    .HasColumnName("HROfficerSignDate");

                entity.Property(e => e.HrofficerSignatureId).HasColumnName("HROfficerSignatureId");

                entity.Property(e => e.HrofficerStaffId).HasColumnName("HROfficerStaffId");

                entity.Property(e => e.NetPayValue).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.OtherRequest).HasDefaultValueSql("('')");

                entity.Property(e => e.PlanActivityIdOld).HasColumnName("PlanActivityId_Old");

                entity.Property(e => e.PlanCoreRemainBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.PlanFormApprovalStatusEnum).HasDefaultValueSql("((10))");

                entity.Property(e => e.ProcureRequest).HasDefaultValueSql("('')");

                entity.Property(e => e.ProjectManager).HasDefaultValueSql("('')");

                entity.Property(e => e.ProjectManager1).HasDefaultValueSql("('')");

                entity.Property(e => e.ProjectManager1Position).HasDefaultValueSql("('')");

                entity.Property(e => e.ProjectManager1SignDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectManager2).HasDefaultValueSql("('')");

                entity.Property(e => e.ProjectManager2Position).HasDefaultValueSql("('')");

                entity.Property(e => e.ProjectManager2SignDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectManager3).HasDefaultValueSql("('')");

                entity.Property(e => e.ProjectManager3Position).HasDefaultValueSql("('')");

                entity.Property(e => e.ProjectManager3SignDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectManager4).HasDefaultValueSql("('')");

                entity.Property(e => e.ProjectManager4Position).HasDefaultValueSql("('')");

                entity.Property(e => e.ProjectManager4SignDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectManagerSignDate).HasColumnType("datetime");

                entity.Property(e => e.RelatedRegulation).HasDefaultValueSql("('')");

                entity.Property(e => e.RequestDepartmentName).HasDefaultValueSql("('')");

                entity.Property(e => e.RequesterDepartmentName).HasDefaultValueSql("('')");

                entity.Property(e => e.RequesterPositionName).HasDefaultValueSql("('')");

                entity.Property(e => e.RequesterSignDate).HasColumnType("datetime");

                entity.Property(e => e.ReserveByStaffName).HasDefaultValueSql("('')");

                entity.Property(e => e.ReserveDate).HasColumnType("datetime");

                entity.Property(e => e.ReserveDepartmentName).HasDefaultValueSql("('')");

                entity.Property(e => e.ReserveForecastValue).HasDefaultValueSql("('')");

                entity.Property(e => e.ReserveRemark).HasDefaultValueSql("('')");

                entity.Property(e => e.ScheduleTitle).HasDefaultValueSql("('')");

                entity.Property(e => e.SecondBorrowAmount)
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.SecondBorrower).HasDefaultValueSql("('')");

                entity.Property(e => e.SecondBorrowerDepartment).HasDefaultValueSql("('')");

                entity.Property(e => e.SecondBorrowerPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.SecondBorrowerPositionTypeName).HasDefaultValueSql("('')");

                entity.Property(e => e.SettleDay).HasDefaultValueSql("((15))");

                entity.Property(e => e.StartCountingDate).HasColumnType("datetime");

                entity.Property(e => e.StatementCalculationDate).HasColumnType("datetime");

                entity.Property(e => e.SuppliesOfficerName).HasDefaultValueSql("('')");

                entity.Property(e => e.SuppliesOfficerPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.SuppliesOfficerSignDate).HasColumnType("datetime");

                entity.Property(e => e.ThirdBorrowAmount)
                    .HasColumnType("decimal(9, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ThirdBorrower).HasDefaultValueSql("('')");

                entity.Property(e => e.ThirdBorrowerDepartment).HasDefaultValueSql("('')");

                entity.Property(e => e.ThirdBorrowerPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.ThirdBorrowerPositionTypeName).HasDefaultValueSql("('')");

                entity.Property(e => e.UnitChiefPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.UnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasMany(d => d.FinancialReimbursementFormsNavigation)
                    .WithMany(p => p.GeneralExpenseMemoForms)
                    .UsingEntity<Dictionary<string, object>>(
                        "GeneralExpenseMemoFormFinancialReimbursementForm",
                        l => l.HasOne<FinancialReimbursementForm>().WithMany().HasForeignKey("FinancialReimbursementFormsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_GeneralExpenseMemoFormFinancialReimbursementForm_FinancialReimbursementForm"),
                        r => r.HasOne<GeneralExpenseMemoForm>().WithMany().HasForeignKey("GeneralExpenseMemoFormsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_GeneralExpenseMemoFormFinancialReimbursementForm_GeneralExpenseMemoForm"),
                        j =>
                        {
                            j.HasKey("GeneralExpenseMemoFormsId", "FinancialReimbursementFormsId");

                            j.ToTable("GeneralExpenseMemoFormFinancialReimbursementForm", "Plan");

                            j.HasIndex(new[] { "FinancialReimbursementFormsId" }, "IX_FK_GeneralExpenseMemoFormFinancialReimbursementForm_FinancialReimbursementForm");

                            j.IndexerProperty<int>("GeneralExpenseMemoFormsId").HasColumnName("GeneralExpenseMemoForms_Id");

                            j.IndexerProperty<int>("FinancialReimbursementFormsId").HasColumnName("FinancialReimbursementForms_Id");
                        });

                entity.HasMany(d => d.OutsideDutyReportForms)
                    .WithMany(p => p.GeneralExpenseMemoForms)
                    .UsingEntity<Dictionary<string, object>>(
                        "GeneralExpenseMemoFormOutsideDutyReportForm",
                        l => l.HasOne<OutsideDutyReportForm>().WithMany().HasForeignKey("OutsideDutyReportFormsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_GeneralExpenseMemoFormOutsideDutyReportForm_OutsideDutyReportForm"),
                        r => r.HasOne<GeneralExpenseMemoForm>().WithMany().HasForeignKey("GeneralExpenseMemoFormsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_GeneralExpenseMemoFormOutsideDutyReportForm_GeneralExpenseMemoForm"),
                        j =>
                        {
                            j.HasKey("GeneralExpenseMemoFormsId", "OutsideDutyReportFormsId");

                            j.ToTable("GeneralExpenseMemoFormOutsideDutyReportForm", "Plan");

                            j.HasIndex(new[] { "OutsideDutyReportFormsId" }, "IX_FK_GeneralExpenseMemoFormOutsideDutyReportForm_OutsideDutyReportForm");

                            j.IndexerProperty<int>("GeneralExpenseMemoFormsId").HasColumnName("GeneralExpenseMemoForms_Id");

                            j.IndexerProperty<int>("OutsideDutyReportFormsId").HasColumnName("OutsideDutyReportForms_Id");
                        });
            });

            modelBuilder.Entity<GeneralExpensePersonalBorrowForm>(entity =>
            {
                entity.ToTable("GeneralExpensePersonalBorrowForms", "Plan");

                entity.HasIndex(e => e.GeneralExpenseMemoFormId, "IX_FK_GeneralExpenseMemoFormGeneralExpensePersonalBorrowForm");

                entity.Property(e => e.ApprovalStatusEnum).HasDefaultValueSql("((10))");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverSignDate).HasColumnType("datetime");

                entity.Property(e => e.AttorneySignDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.FinanceCheckerName).HasDefaultValueSql("('')");

                entity.Property(e => e.FinanceCheckerSignDate).HasColumnType("datetime");

                entity.Property(e => e.PlanFormApprovalStatusEnum).HasDefaultValueSql("((10))");

                entity.Property(e => e.RefDocumentDate).HasColumnType("datetime");

                entity.Property(e => e.RequesterSignDate).HasColumnType("datetime");

                entity.Property(e => e.SettleDate).HasColumnType("datetime");

                entity.Property(e => e.StaffPositionType).HasDefaultValueSql("('')");

                entity.Property(e => e.TotalBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.UnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.GeneralExpenseMemoForm)
                    .WithMany(p => p.GeneralExpensePersonalBorrowForms)
                    .HasForeignKey(d => d.GeneralExpenseMemoFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpenseMemoFormGeneralExpensePersonalBorrowForm");

                entity.HasMany(d => d.GeneralExpenseExtendForms)
                    .WithMany(p => p.GeneralExpensePersonalBorrowForms)
                    .UsingEntity<Dictionary<string, object>>(
                        "GeneralExpensePersonalBorrowFormGeneralExpenseExtendForm",
                        l => l.HasOne<GeneralExpenseExtendForm>().WithMany().HasForeignKey("GeneralExpenseExtendFormsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_GeneralExpensePersonalBorrowFormGeneralExpenseExtendForm_GeneralExpenseExtendForm"),
                        r => r.HasOne<GeneralExpensePersonalBorrowForm>().WithMany().HasForeignKey("GeneralExpensePersonalBorrowFormsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_GeneralExpensePersonalBorrowFormGeneralExpenseExtendForm_GeneralExpensePersonalBorrowForm"),
                        j =>
                        {
                            j.HasKey("GeneralExpensePersonalBorrowFormsId", "GeneralExpenseExtendFormsId");

                            j.ToTable("GeneralExpensePersonalBorrowFormGeneralExpenseExtendForm", "Plan");

                            j.HasIndex(new[] { "GeneralExpenseExtendFormsId" }, "IX_FK_GeneralExpensePersonalBorrowFormGeneralExpenseExtendForm_GeneralExpenseExtendForm");

                            j.IndexerProperty<int>("GeneralExpensePersonalBorrowFormsId").HasColumnName("GeneralExpensePersonalBorrowForms_Id");

                            j.IndexerProperty<int>("GeneralExpenseExtendFormsId").HasColumnName("GeneralExpenseExtendForms_Id");
                        });
            });

            modelBuilder.Entity<GeneralExpensePersonalBorrowItem>(entity =>
            {
                entity.ToTable("GeneralExpensePersonalBorrowItems", "Plan");

                entity.HasIndex(e => e.GeneralExpenseId, "IX_FK_GeneralExpenseGeneralExpensePersonalBorrowItem");

                entity.HasIndex(e => e.GeneralExpensePersonalBorrowFormId, "IX_FK_GeneralExpensePersonalBorrowFormGeneralExpensePersonalBorrowItem");

                entity.Property(e => e.BorrowBudget).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.GeneralExpense)
                    .WithMany(p => p.GeneralExpensePersonalBorrowItems)
                    .HasForeignKey(d => d.GeneralExpenseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpenseGeneralExpensePersonalBorrowItem");

                entity.HasOne(d => d.GeneralExpensePersonalBorrowForm)
                    .WithMany(p => p.GeneralExpensePersonalBorrowItems)
                    .HasForeignKey(d => d.GeneralExpensePersonalBorrowFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpensePersonalBorrowFormGeneralExpensePersonalBorrowItem");
            });

            modelBuilder.Entity<GeneralExpenseReturnForm>(entity =>
            {
                entity.ToTable("GeneralExpenseReturnForms", "Plan");

                entity.HasIndex(e => e.GeneralExpenseMemoFormId, "IX_FK_GeneralExpenseMemoFormGeneralExpenseReturnForm");

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");

                entity.Property(e => e.StatementCalculationDate).HasColumnType("datetime");

                entity.HasOne(d => d.GeneralExpenseMemoForm)
                    .WithMany(p => p.GeneralExpenseReturnForms)
                    .HasForeignKey(d => d.GeneralExpenseMemoFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpenseMemoFormGeneralExpenseReturnForm");
            });

            modelBuilder.Entity<GeneralExpenseReturnItem>(entity =>
            {
                entity.ToTable("GeneralExpenseReturnItems", "Plan");

                entity.HasIndex(e => e.GeneralExpenseId, "IX_FK_GeneralExpenseGeneralExpenseReturnItem");

                entity.HasIndex(e => e.GeneralExpenseReturnFormId, "IX_FK_GeneralExpenseReturnFormGeneralExpenseReturnItem");

                entity.Property(e => e.RemainWithdrawableBudgetAtDate).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ReturnBudget).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.GeneralExpense)
                    .WithMany(p => p.GeneralExpenseReturnItems)
                    .HasForeignKey(d => d.GeneralExpenseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpenseGeneralExpenseReturnItem");

                entity.HasOne(d => d.GeneralExpenseReturnForm)
                    .WithMany(p => p.GeneralExpenseReturnItems)
                    .HasForeignKey(d => d.GeneralExpenseReturnFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpenseReturnFormGeneralExpenseReturnItem");
            });

            modelBuilder.Entity<GeneralExpenseSettleForm>(entity =>
            {
                entity.ToTable("GeneralExpenseSettleForms", "Plan");

                entity.HasIndex(e => e.GeneralExpenseMemoFormId, "IX_FK_GeneralExpenseMemoFormGeneralExpenseSettleForm");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverSignDate).HasColumnType("datetime");

                entity.Property(e => e.BudgetCheckerSignDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentNameOld).HasColumnName("DepartmentName_Old");

                entity.Property(e => e.NetPayValue).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.OperationSummary).HasDefaultValueSql("('')");

                entity.Property(e => e.OtherReqDocNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.OtherReqWriteDate).HasColumnType("datetime");

                entity.Property(e => e.OtherRequest).HasDefaultValueSql("('')");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.PlanActivityIdOld).HasColumnName("PlanActivityId_Old");

                entity.Property(e => e.PlanCoreNameOld).HasColumnName("PlanCoreName_Old");

                entity.Property(e => e.PlanFormApprovalStatusEnum).HasDefaultValueSql("((10))");

                entity.Property(e => e.PlanItemDetailListByBorrowerValue).HasDefaultValueSql("('')");

                entity.Property(e => e.PlanTypeNameOld).HasColumnName("PlanTypeName_Old");

                entity.Property(e => e.RefWithdrawalFormText).HasDefaultValueSql("('')");

                entity.Property(e => e.RelatedRegulation).HasDefaultValueSql("('')");

                entity.Property(e => e.RequesterSignDate).HasColumnType("datetime");

                entity.Property(e => e.StatementCalculationDate).HasColumnType("datetime");

                entity.Property(e => e.SuppliesOfficerName).HasDefaultValueSql("('')");

                entity.Property(e => e.SuppliesOfficerPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.SuppliesOfficerSignDate).HasColumnType("datetime");

                entity.Property(e => e.UnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.GeneralExpenseMemoForm)
                    .WithMany(p => p.GeneralExpenseSettleForms)
                    .HasForeignKey(d => d.GeneralExpenseMemoFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpenseMemoFormGeneralExpenseSettleForm");
            });

            modelBuilder.Entity<GovernmentDisbursementGoal>(entity =>
            {
                entity.ToTable("GovernmentDisbursementGoals", "Plan");

                entity.Property(e => e.TargetValueAccQ1).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.TargetValueAccQ2).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.TargetValueAccQ3).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.TargetValueAccQ4).HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<GprocurementRss>(entity =>
            {
                entity.ToTable("GProcurementRSSes", "Procure");

                entity.Property(e => e.PubDate).HasColumnType("datetime");

                entity.Property(e => e.ReadDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.ToTable("Holidays", "HR");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");
            });

            modelBuilder.Entity<HrcertifiedDocumentRequestForm>(entity =>
            {
                entity.ToTable("HRCertifiedDocumentRequestForms", "HR");

                entity.Property(e => e.ApproverSignDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.HrcertifiedDocTypeEnumListValue).HasColumnName("HRCertifiedDocTypeEnumListValue");

                entity.Property(e => e.TakenDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Hrdepartment>(entity =>
            {
                entity.ToTable("HRDepartments", "HR");

                entity.HasIndex(e => e.ParentHrdepartmentId, "IX_FK_HRDepartmentHRDepartment");

                entity.Property(e => e.ParentHrdepartmentId).HasColumnName("ParentHRDepartmentId");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ParentHrdepartment)
                    .WithMany(p => p.InverseParentHrdepartment)
                    .HasForeignKey(d => d.ParentHrdepartmentId)
                    .HasConstraintName("FK_HRDepartmentHRDepartment");
            });

            modelBuilder.Entity<HrdepartmentStaffPermissionForHr>(entity =>
            {
                entity.ToTable("HRDepartmentStaffPermissionForHRs", "HR");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.HrdepartmentName).HasColumnName("HRDepartmentName");
            });

            modelBuilder.Entity<HrdevelopmentType>(entity =>
            {
                entity.ToTable("HRDevelopmentTypes", "HR");
            });

            modelBuilder.Entity<Hrfile>(entity =>
            {
                entity.ToTable("HRFiles", "HR");

                entity.HasIndex(e => e.DevelopmentRecordGroupId, "IX_FK_DevelopmentRecordGroupHRFile");

                entity.HasIndex(e => e.EmploymentContractId, "IX_FK_EmploymentContractHRFile");

                entity.HasIndex(e => e.LeaveId, "IX_FK_LeaveHRFile");

                entity.HasIndex(e => e.MedicalReimbursementId, "IX_FK_MedicalReimbursementHRFile");

                entity.HasIndex(e => e.OutsideDutyGroupId, "IX_FK_OutsideDutyGroupHRFile");

                entity.Property(e => e.UploadDate).HasColumnType("datetime");

                entity.HasOne(d => d.DevelopmentRecordGroup)
                    .WithMany(p => p.Hrfiles)
                    .HasForeignKey(d => d.DevelopmentRecordGroupId)
                    .HasConstraintName("FK_DevelopmentRecordGroupHRFile");

                entity.HasOne(d => d.EmploymentContract)
                    .WithMany(p => p.Hrfiles)
                    .HasForeignKey(d => d.EmploymentContractId)
                    .HasConstraintName("FK_EmploymentContractHRFile");

                entity.HasOne(d => d.Leave)
                    .WithMany(p => p.Hrfiles)
                    .HasForeignKey(d => d.LeaveId)
                    .HasConstraintName("FK_LeaveHRFile");

                entity.HasOne(d => d.MedicalReimbursement)
                    .WithMany(p => p.Hrfiles)
                    .HasForeignKey(d => d.MedicalReimbursementId)
                    .HasConstraintName("FK_MedicalReimbursementHRFile");

                entity.HasOne(d => d.OutsideDutyGroup)
                    .WithMany(p => p.Hrfiles)
                    .HasForeignKey(d => d.OutsideDutyGroupId)
                    .HasConstraintName("FK_OutsideDutyGroupHRFile");
            });

            modelBuilder.Entity<Insignia>(entity =>
            {
                entity.ToTable("Insignias", "HR");

                entity.HasIndex(e => e.InsigniaRankId, "IX_FK_InsigniaRankInsignia");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffInsignia");

                entity.HasOne(d => d.InsigniaRank)
                    .WithMany(p => p.Insignia)
                    .HasForeignKey(d => d.InsigniaRankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InsigniaRankInsignia");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Insignia)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffInsignia");
            });

            modelBuilder.Entity<InsigniaRank>(entity =>
            {
                entity.ToTable("InsigniaRanks", "HR");
            });

            modelBuilder.Entity<Itinerary>(entity =>
            {
                entity.ToTable("Itineraries", "CollaborationNetwork");

                entity.HasIndex(e => e.CollaborateReportId, "IX_FK_CollaborateReportItinerary");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasDefaultValueSql("('')");

                entity.HasOne(d => d.CollaborateReport)
                    .WithMany(p => p.Itineraries)
                    .HasForeignKey(d => d.CollaborateReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CollaborateReportItinerary");
            });

            modelBuilder.Entity<JobDescription>(entity =>
            {
                entity.ToTable("JobDescriptions", "HR");

                entity.HasIndex(e => e.JobPositionId, "IX_FK_JobPositionJobDescription");

                entity.HasIndex(e => e.JobPositionLevelId, "IX_FK_JobPositionLevelJobDescription");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffJobDescription");

                entity.HasOne(d => d.JobPosition)
                    .WithMany(p => p.JobDescriptions)
                    .HasForeignKey(d => d.JobPositionId)
                    .HasConstraintName("FK_JobPositionJobDescription");

                entity.HasOne(d => d.JobPositionLevel)
                    .WithMany(p => p.JobDescriptions)
                    .HasForeignKey(d => d.JobPositionLevelId)
                    .HasConstraintName("FK_JobPositionLevelJobDescription");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.JobDescriptions)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK_StaffJobDescription");
            });

            modelBuilder.Entity<JobFunctionalPosition>(entity =>
            {
                entity.ToTable("JobFunctionalPositions", "HR");
            });

            modelBuilder.Entity<JobPosition>(entity =>
            {
                entity.ToTable("JobPositions", "HR");

                entity.HasIndex(e => e.EducationLevelId, "IX_FK_EducationLevelJobPosition");

                entity.HasIndex(e => e.HrdepartmentId, "IX_FK_HRDepartmentJobPosition");

                entity.HasIndex(e => e.JobPositionGroupId, "IX_FK_JobPositionGroupJobPosition");

                entity.HasIndex(e => e.ParentJobPositionId, "IX_FK_JobPositionParentJobPosition");

                entity.HasIndex(e => e.JobPositionTypeId, "IX_FK_JobPositionTypeJobPosition");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.HasOne(d => d.EducationLevel)
                    .WithMany(p => p.JobPositions)
                    .HasForeignKey(d => d.EducationLevelId)
                    .HasConstraintName("FK_EducationLevelJobPosition");

                entity.HasOne(d => d.Hrdepartment)
                    .WithMany(p => p.JobPositions)
                    .HasForeignKey(d => d.HrdepartmentId)
                    .HasConstraintName("FK_HRDepartmentJobPosition");

                entity.HasOne(d => d.JobPositionGroup)
                    .WithMany(p => p.JobPositions)
                    .HasForeignKey(d => d.JobPositionGroupId)
                    .HasConstraintName("FK_JobPositionGroupJobPosition");

                entity.HasOne(d => d.JobPositionType)
                    .WithMany(p => p.JobPositions)
                    .HasForeignKey(d => d.JobPositionTypeId)
                    .HasConstraintName("FK_JobPositionTypeJobPosition");

                entity.HasOne(d => d.ParentJobPosition)
                    .WithMany(p => p.InverseParentJobPosition)
                    .HasForeignKey(d => d.ParentJobPositionId)
                    .HasConstraintName("FK_JobPositionParentJobPosition");
            });

            modelBuilder.Entity<JobPositionGroup>(entity =>
            {
                entity.ToTable("JobPositionGroups", "HR");
            });

            modelBuilder.Entity<JobPositionKeyCompetencyDetail>(entity =>
            {
                entity.ToTable("JobPositionKeyCompetencyDetails", "HR");

                entity.HasIndex(e => e.JobPositionId, "IX_FK_JobPositionJobPositionKeyCompetencyDetail");

                entity.HasIndex(e => e.JobPositionLevelId, "IX_FK_JobPositionLevelJobPositionKeyCompetencyDetail");

                entity.HasIndex(e => e.KeyCompetencyId, "IX_FK_KeyCompetencyJobPositionKeyCompetencyDetail");

                entity.HasOne(d => d.JobPosition)
                    .WithMany(p => p.JobPositionKeyCompetencyDetails)
                    .HasForeignKey(d => d.JobPositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobPositionJobPositionKeyCompetencyDetail");

                entity.HasOne(d => d.JobPositionLevel)
                    .WithMany(p => p.JobPositionKeyCompetencyDetails)
                    .HasForeignKey(d => d.JobPositionLevelId)
                    .HasConstraintName("FK_JobPositionLevelJobPositionKeyCompetencyDetail");

                entity.HasOne(d => d.KeyCompetency)
                    .WithMany(p => p.JobPositionKeyCompetencyDetails)
                    .HasForeignKey(d => d.KeyCompetencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KeyCompetencyJobPositionKeyCompetencyDetail");
            });

            modelBuilder.Entity<JobPositionLevel>(entity =>
            {
                entity.ToTable("JobPositionLevels", "HR");
            });

            modelBuilder.Entity<JobPositionType>(entity =>
            {
                entity.ToTable("JobPositionTypes", "HR");

                entity.Property(e => e.JobPositionWageTypeEnum).HasDefaultValueSql("((30))");
            });

            modelBuilder.Entity<JobQualification>(entity =>
            {
                entity.ToTable("JobQualifications", "HR");

                entity.HasIndex(e => e.EducationLevelId, "IX_FK_EducationLevelJobQualification");

                entity.HasIndex(e => e.JobPositionId, "IX_FK_JobPositionJobQualification");

                entity.HasIndex(e => e.JobPositionLevelId, "IX_FK_JobPositionLevelJobQualification");

                entity.HasOne(d => d.EducationLevel)
                    .WithMany(p => p.JobQualifications)
                    .HasForeignKey(d => d.EducationLevelId)
                    .HasConstraintName("FK_EducationLevelJobQualification");

                entity.HasOne(d => d.JobPosition)
                    .WithMany(p => p.JobQualifications)
                    .HasForeignKey(d => d.JobPositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobPositionJobQualification");

                entity.HasOne(d => d.JobPositionLevel)
                    .WithMany(p => p.JobQualifications)
                    .HasForeignKey(d => d.JobPositionLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobPositionLevelJobQualification");
            });

            modelBuilder.Entity<JobResponsibility>(entity =>
            {
                entity.ToTable("JobResponsibilities", "HR");

                entity.HasIndex(e => e.JobPositionId, "IX_FK_JobPositionJobResponsibility");

                entity.HasIndex(e => e.JobPositionLevelId, "IX_FK_JobPositionLevelJobResponsibility");

                entity.HasIndex(e => e.JobResponsibilityGroupId, "IX_FK_JobResponsibilityGroupJobResponsibility");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffJobResponsibility");

                entity.HasOne(d => d.JobPosition)
                    .WithMany(p => p.JobResponsibilities)
                    .HasForeignKey(d => d.JobPositionId)
                    .HasConstraintName("FK_JobPositionJobResponsibility");

                entity.HasOne(d => d.JobPositionLevel)
                    .WithMany(p => p.JobResponsibilities)
                    .HasForeignKey(d => d.JobPositionLevelId)
                    .HasConstraintName("FK_JobPositionLevelJobResponsibility");

                entity.HasOne(d => d.JobResponsibilityGroup)
                    .WithMany(p => p.JobResponsibilities)
                    .HasForeignKey(d => d.JobResponsibilityGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobResponsibilityGroupJobResponsibility");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.JobResponsibilities)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK_StaffJobResponsibility");
            });

            modelBuilder.Entity<JobResponsibilityEvaluationForm>(entity =>
            {
                entity.ToTable("JobResponsibilityEvaluationForms", "HR");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffJobResponsibilityEvaluationForm");

                entity.Property(e => e.FirstEvaluatorPositionName).HasDefaultValueSql("('')");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.Property(e => e.SecondEvaluatorPositionName).HasDefaultValueSql("('')");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.JobResponsibilityEvaluationForms)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffJobResponsibilityEvaluationForm");
            });

            modelBuilder.Entity<JobResponsibilityEvaluationItem>(entity =>
            {
                entity.ToTable("JobResponsibilityEvaluationItems", "HR");

                entity.HasIndex(e => e.JobResponsibilityEvaluationFormId, "IX_FK_JobResponsibilityEvaluationFormJobResponsibilityEvaluationItem");

                entity.HasIndex(e => e.JobResponsibilityExpectScoreId, "IX_FK_JobResponsibilityExpectScoreJobResponsibilityEvaluationItem");

                entity.HasOne(d => d.JobResponsibilityEvaluationForm)
                    .WithMany(p => p.JobResponsibilityEvaluationItems)
                    .HasForeignKey(d => d.JobResponsibilityEvaluationFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobResponsibilityEvaluationFormJobResponsibilityEvaluationItem");

                entity.HasOne(d => d.JobResponsibilityExpectScore)
                    .WithMany(p => p.JobResponsibilityEvaluationItems)
                    .HasForeignKey(d => d.JobResponsibilityExpectScoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobResponsibilityExpectScoreJobResponsibilityEvaluationItem");
            });

            modelBuilder.Entity<JobResponsibilityExpectScore>(entity =>
            {
                entity.ToTable("JobResponsibilityExpectScores", "HR");

                entity.HasIndex(e => e.JobPositionLevelId, "IX_FK_JobPositionLevelJobResponsibilityExpectScore");

                entity.HasIndex(e => e.JobResponsibilityId, "IX_FK_JobResponsibilityJobResponsibilityExpectScore");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffJobResponsibilityExpectScore");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.JobPositionLevel)
                    .WithMany(p => p.JobResponsibilityExpectScores)
                    .HasForeignKey(d => d.JobPositionLevelId)
                    .HasConstraintName("FK_JobPositionLevelJobResponsibilityExpectScore");

                entity.HasOne(d => d.JobResponsibility)
                    .WithMany(p => p.JobResponsibilityExpectScores)
                    .HasForeignKey(d => d.JobResponsibilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobResponsibilityJobResponsibilityExpectScore");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.JobResponsibilityExpectScores)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffJobResponsibilityExpectScore");
            });

            modelBuilder.Entity<JobResponsibilityGroup>(entity =>
            {
                entity.ToTable("JobResponsibilityGroups", "HR");

                entity.HasIndex(e => e.JobPositionId, "IX_FK_JobPositionJobResponsibilityGroup");

                entity.HasOne(d => d.JobPosition)
                    .WithMany(p => p.JobResponsibilityGroups)
                    .HasForeignKey(d => d.JobPositionId)
                    .HasConstraintName("FK_JobPositionJobResponsibilityGroup");
            });

            modelBuilder.Entity<KeyCompetency>(entity =>
            {
                entity.ToTable("KeyCompetencies", "HR");
            });

            modelBuilder.Entity<Leaf>(entity =>
            {
                entity.ToTable("Leaves", "HR");

                entity.HasIndex(e => e.LeaveTypeId, "IX_FK_LeaveTypeLeave");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffLeave");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverSignDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.HrdepartmentName).HasColumnName("HRDepartmentName");

                entity.Property(e => e.UnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.LeaveType)
                    .WithMany(p => p.Leaves)
                    .HasForeignKey(d => d.LeaveTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeaveTypeLeave");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Leaves)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffLeave");
            });

            modelBuilder.Entity<LeaveArchievedRecord>(entity =>
            {
                entity.ToTable("LeaveArchievedRecords", "HR");

                entity.HasIndex(e => e.LeaveTypeId, "IX_FK_LeaveTypeLeaveArchievedRecord");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffLeaveArchievedRecord");

                entity.Property(e => e.RemainLeaveDayFy2559value).HasColumnName("RemainLeaveDayFY2559Value");

                entity.Property(e => e.RemainLeaveDayFy2560value)
                    .HasColumnName("RemainLeaveDayFY2560Value")
                    .HasDefaultValueSql("('00:00:00')");

                entity.Property(e => e.RemainLeaveDayValue).HasDefaultValueSql("('0.00:00:00')");

                entity.HasOne(d => d.LeaveType)
                    .WithMany(p => p.LeaveArchievedRecords)
                    .HasForeignKey(d => d.LeaveTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeaveTypeLeaveArchievedRecord");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.LeaveArchievedRecords)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffLeaveArchievedRecord");
            });

            modelBuilder.Entity<LeaveCancellationForm>(entity =>
            {
                entity.ToTable("LeaveCancellationForms", "HR");

                entity.HasIndex(e => e.LeaveId, "IX_FK_LeaveLeaveCancellationForm");

                entity.HasIndex(e => e.LeaveTypeId, "IX_FK_LeaveTypeLeaveCancellationForm");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverSignDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.UnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.Leave)
                    .WithMany(p => p.LeaveCancellationForms)
                    .HasForeignKey(d => d.LeaveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeaveLeaveCancellationForm");

                entity.HasOne(d => d.LeaveType)
                    .WithMany(p => p.LeaveCancellationForms)
                    .HasForeignKey(d => d.LeaveTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeaveTypeLeaveCancellationForm");
            });

            modelBuilder.Entity<LeaveType>(entity =>
            {
                entity.ToTable("LeaveTypes", "HR");
            });

            modelBuilder.Entity<LeaveTypeLimit>(entity =>
            {
                entity.ToTable("LeaveTypeLimits", "HR");

                entity.HasIndex(e => e.LeaveTypeId, "IX_FK_LeaveTypeLeaveTypeLimit");

                entity.HasOne(d => d.LeaveType)
                    .WithMany(p => p.LeaveTypeLimits)
                    .HasForeignKey(d => d.LeaveTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeaveTypeLeaveTypeLimit");
            });

            modelBuilder.Entity<MedicalReimbursement>(entity =>
            {
                entity.ToTable("MedicalReimbursements", "HR");

                entity.HasIndex(e => e.RelativePersonId, "IX_FK_RelativePersonMedicalReimbursement");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffMedicalReimbursement");

                entity.Property(e => e.Amount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ApprovalStatusEnum).HasDefaultValueSql("((10))");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovedSignHostAddress).HasDefaultValueSql("('')");

                entity.Property(e => e.ApprovedSignHostName).HasDefaultValueSql("('')");

                entity.Property(e => e.ApproverSignDate).HasColumnType("datetime");

                entity.Property(e => e.CaseNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.FullReimbursableAmount)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.IsIpd).HasColumnName("IsIPD");

                entity.Property(e => e.NonReimbursableAmount)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.Property(e => e.RemainAmountAtDate)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.RequestAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.SentMailDate).HasColumnType("datetime");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.UnitChiefName).HasDefaultValueSql("('')");

                entity.Property(e => e.UnitChiefPositionName).HasDefaultValueSql("('')");

                entity.Property(e => e.UnitChiefSignDate).HasColumnType("datetime");

                entity.HasOne(d => d.RelativePerson)
                    .WithMany(p => p.MedicalReimbursements)
                    .HasForeignKey(d => d.RelativePersonId)
                    .HasConstraintName("FK_RelativePersonMedicalReimbursement");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.MedicalReimbursements)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffMedicalReimbursement");
            });

            modelBuilder.Entity<MedicalRightRequestForm>(entity =>
            {
                entity.ToTable("MedicalRightRequestForms", "HR");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.IdcardNumber).HasColumnName("IDCardNumber");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("Messages", "Filing");

                entity.HasIndex(e => e.FilingDocumentId, "IX_FK_FilingDocumentMessage");

                entity.HasIndex(e => e.FilingGeneralOrderId, "IX_FK_FilingGeneralOrderMessage");

                entity.HasIndex(e => e.FromMessageId, "IX_FK_FromMessageToMessages");

                entity.Property(e => e.SenderHrdepartmentId).HasColumnName("SenderHRDepartmentId");

                entity.Property(e => e.SenderHrdepartmentName).HasColumnName("SenderHRDepartmentName");

                entity.Property(e => e.SenderIp).HasColumnName("SenderIP");

                entity.Property(e => e.SentDate).HasColumnType("datetime");

                entity.HasOne(d => d.FilingDocument)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.FilingDocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FilingDocumentMessage");

                entity.HasOne(d => d.FilingGeneralOrder)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.FilingGeneralOrderId)
                    .HasConstraintName("FK_FilingGeneralOrderMessage");

                entity.HasOne(d => d.FromMessage)
                    .WithMany(p => p.InverseFromMessage)
                    .HasForeignKey(d => d.FromMessageId)
                    .HasConstraintName("FK_FromMessageToMessages");
            });

            modelBuilder.Entity<MessageHistory>(entity =>
            {
                entity.ToTable("MessageHistories", "Filing");

                entity.HasIndex(e => e.MessageId, "IX_FK_MessageMessageHistory");

                entity.Property(e => e.EditDate).HasColumnType("datetime");

                entity.Property(e => e.EditorIp).HasColumnName("EditorIP");

                entity.Property(e => e.SenderHrdepartmentId).HasColumnName("SenderHRDepartmentId");

                entity.Property(e => e.SenderHrdepartmentName).HasColumnName("SenderHRDepartmentName");

                entity.Property(e => e.SenderIp).HasColumnName("SenderIP");

                entity.Property(e => e.SentDate).HasColumnType("datetime");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.MessageHistories)
                    .HasForeignKey(d => d.MessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MessageMessageHistory");
            });

            modelBuilder.Entity<MisGeneralExpenseMemoFormsSignList>(entity =>
            {
                entity.ToTable("MisGeneralExpenseMemoFormsSignList", "Plan");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.ProjectManagerSignDate).HasColumnType("datetime");

                entity.Property(e => e.Seq).HasColumnName("seq");
            });

            modelBuilder.Entity<MisSsoMatching>(entity =>
            {
                entity.ToTable("MisSsoMatching");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Mission>(entity =>
            {
                entity.ToTable("Mission", "Plan");
            });

            modelBuilder.Entity<MonthlyForecast>(entity =>
            {
                entity.ToTable("MonthlyForecasts", "Plan");

                entity.HasIndex(e => e.PlanItemId, "IX_FK_PlanItemMonthlyForecast");

                entity.Property(e => e.Amount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.BudgetPerPiece).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.PlanItem)
                    .WithMany(p => p.MonthlyForecasts)
                    .HasForeignKey(d => d.PlanItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanItemMonthlyForecast");
            });

            modelBuilder.Entity<MonthlyForecastAdjustment>(entity =>
            {
                entity.ToTable("MonthlyForecastAdjustments", "Plan");

                entity.HasIndex(e => e.PlanItemId, "IX_FK_PlanItemMonthlyForecastAdjustment");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.NetBudgetAtDate).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.PlanItem)
                    .WithMany(p => p.MonthlyForecastAdjustments)
                    .HasForeignKey(d => d.PlanItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanItemMonthlyForecastAdjustment");
            });

            modelBuilder.Entity<NameTitle>(entity =>
            {
                entity.ToTable("NameTitles", "HR");
            });

            modelBuilder.Entity<Nationality>(entity =>
            {
                entity.ToTable("Nationalities", "HR");
            });

            modelBuilder.Entity<OperationFile>(entity =>
            {
                entity.ToTable("OperationFiles", "Operation");

                entity.HasIndex(e => e.ProcureTrackingActionId, "IX_FK_ProcureTrackingActionOperationFile");

                entity.Property(e => e.UploadDate).HasColumnType("datetime");

                entity.HasOne(d => d.ProcureTrackingAction)
                    .WithMany(p => p.OperationFiles)
                    .HasForeignKey(d => d.ProcureTrackingActionId)
                    .HasConstraintName("FK_ProcureTrackingActionOperationFile");
            });

            modelBuilder.Entity<OrFormActionLog>(entity =>
            {
                entity.ToTable("OrFormActionLogs", "Procure");

                entity.HasIndex(e => e.OrderFormId, "IX_FK_OrderFormOrFormActionLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.Ip).HasColumnName("IP");

                entity.HasOne(d => d.OrderForm)
                    .WithMany(p => p.OrFormActionLogs)
                    .HasForeignKey(d => d.OrderFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderFormOrFormActionLog");
            });

            modelBuilder.Entity<OrderCheckItemTransform>(entity =>
            {
                entity.ToTable("OrderCheckItemTransforms", "Procure");

                entity.HasIndex(e => e.CheckItemId, "IX_FK_CheckItemOrderCheckItemTransform");

                entity.HasIndex(e => e.OrderItemId, "IX_FK_OrderItemOrderCheckItemTransform");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 5)");

                entity.HasOne(d => d.CheckItem)
                    .WithMany(p => p.OrderCheckItemTransforms)
                    .HasForeignKey(d => d.CheckItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CheckItemOrderCheckItemTransform");

                entity.HasOne(d => d.OrderItem)
                    .WithMany(p => p.OrderCheckItemTransforms)
                    .HasForeignKey(d => d.OrderItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderItemOrderCheckItemTransform");
            });

            modelBuilder.Entity<OrderContract>(entity =>
            {
                entity.ToTable("OrderContracts", "Procure");

                entity.HasIndex(e => e.OrderFormId, "IX_FK_OrderFormOrderContract");

                entity.HasIndex(e => e.SupplierId, "IX_FK_SupplierOrderContract");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.SentMailDate).HasColumnType("datetime");

                entity.HasOne(d => d.OrderForm)
                    .WithMany(p => p.OrderContracts)
                    .HasForeignKey(d => d.OrderFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderFormOrderContract");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.OrderContracts)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_SupplierOrderContract");
            });

            modelBuilder.Entity<OrderForm>(entity =>
            {
                entity.ToTable("OrderForms", "Procure");

                entity.HasIndex(e => e.SupplierId, "IX_FK_SupplierOrderForm");

                entity.Property(e => e.ApproveFormDate).HasColumnType("datetime");

                entity.Property(e => e.CheckEighthComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckNinthComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckOfficer).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckSecretaryAndComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckSeventhComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckSixthComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckViceChairman).HasDefaultValueSql("('')");

                entity.Property(e => e.ConsiderateConditionEnum).HasDefaultValueSql("((10))");

                entity.Property(e => e.ContractControlNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryEndDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryStartDate).HasColumnType("datetime");

                entity.Property(e => e.FineRate)
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("((0.10))");

                entity.Property(e => e.MedianPrice).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.ProjectControlNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.QuotationDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasDefaultValueSql("('')");

                entity.Property(e => e.RequestFormDate).HasColumnType("datetime");

                entity.Property(e => e.SupplierAddress).HasDefaultValueSql("('')");

                entity.Property(e => e.SupplierFaxNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.SupplierTaxNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.SupplierTelNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.SuppliesOfficer).HasDefaultValueSql("('')");

                entity.Property(e => e.Topic).HasDefaultValueSql("('')");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.OrderForms)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_SupplierOrderForm");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.ToTable("OrderItems", "Procure");

                entity.HasIndex(e => e.OrderFormId, "IX_FK_OrderFormOrderItem");

                entity.HasIndex(e => e.SupplierId, "IX_FK_SupplierOrderItem");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.PricePerPiece).HasColumnType("decimal(15, 5)");

                entity.HasOne(d => d.OrderForm)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderFormId)
                    .HasConstraintName("FK_OrderFormOrderItem");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_SupplierOrderItem");
            });

            modelBuilder.Entity<OrderItemPlanReferenceItem>(entity =>
            {
                entity.ToTable("OrderItemPlanReferenceItems", "Procure");

                entity.HasIndex(e => e.OrderFormId, "IX_FK_OrderFormOrderItemPlanReferenceItem");

                entity.HasIndex(e => e.OrderItemId, "IX_FK_OrderItemOrderItemPlanReferenceItem");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 5)");

                entity.HasOne(d => d.OrderForm)
                    .WithMany(p => p.OrderItemPlanReferenceItems)
                    .HasForeignKey(d => d.OrderFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderFormOrderItemPlanReferenceItem");

                entity.HasOne(d => d.OrderItem)
                    .WithMany(p => p.OrderItemPlanReferenceItems)
                    .HasForeignKey(d => d.OrderItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderItemOrderItemPlanReferenceItem");
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.ToTable("Organizations", "CollaborationNetwork");

                entity.HasIndex(e => e.CountryId, "IX_FK_CountryOrganization");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Organizations)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CountryOrganization");
            });

            modelBuilder.Entity<OrganizationVisiting>(entity =>
            {
                entity.ToTable("OrganizationVisitings", "CollaborationNetwork");

                entity.HasIndex(e => e.CollaborateReportId, "IX_FK_CollaborateReportOrganizationVisiting");

                entity.HasIndex(e => e.OrganizationId, "IX_FK_OrganizationOrganizationVisiting");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.HasOne(d => d.CollaborateReport)
                    .WithMany(p => p.OrganizationVisitings)
                    .HasForeignKey(d => d.CollaborateReportId)
                    .HasConstraintName("FK_CollaborateReportOrganizationVisiting");

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.OrganizationVisitings)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("FK_OrganizationOrganizationVisiting");
            });

            modelBuilder.Entity<OutsideDuty>(entity =>
            {
                entity.ToTable("OutsideDuties", "HR");

                entity.HasIndex(e => e.OutsideDutyGroupId, "IX_FK_OutsideDutyGroupOutsideDuty");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffOutsideDuty");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.HrdepartmentName).HasColumnName("HRDepartmentName");

                entity.HasOne(d => d.OutsideDutyGroup)
                    .WithMany(p => p.OutsideDuties)
                    .HasForeignKey(d => d.OutsideDutyGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutsideDutyGroupOutsideDuty");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.OutsideDuties)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffOutsideDuty");
            });

            modelBuilder.Entity<OutsideDutyCancellation>(entity =>
            {
                entity.ToTable("OutsideDutyCancellations", "HR");

                entity.HasIndex(e => e.OutsideDutyGroupCancellationId, "IX_FK_OutsideDutyGroupCancellationOutsideDutyCancellation");

                entity.HasIndex(e => e.OutsideDutyId, "IX_FK_OutsideDutyOutsideDutyCancellation");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffOutsideDutyCancellation");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.HrdepartmentName).HasColumnName("HRDepartmentName");

                entity.HasOne(d => d.OutsideDutyGroupCancellation)
                    .WithMany(p => p.OutsideDutyCancellations)
                    .HasForeignKey(d => d.OutsideDutyGroupCancellationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutsideDutyGroupCancellationOutsideDutyCancellation");

                entity.HasOne(d => d.OutsideDuty)
                    .WithMany(p => p.OutsideDutyCancellations)
                    .HasForeignKey(d => d.OutsideDutyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutsideDutyOutsideDutyCancellation");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.OutsideDutyCancellations)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffOutsideDutyCancellation");
            });

            modelBuilder.Entity<OutsideDutyGroup>(entity =>
            {
                entity.ToTable("OutsideDutyGroups", "HR");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverSignDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.DepartmentName).HasDefaultValueSql("('')");

                entity.Property(e => e.FundTypeName).HasDefaultValueSql("('')");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.HrdepartmentName).HasColumnName("HRDepartmentName");

                entity.Property(e => e.Location).HasDefaultValueSql("('')");

                entity.Property(e => e.OperationDate).HasDefaultValueSql("('')");

                entity.Property(e => e.OperationTime).HasDefaultValueSql("('')");

                entity.Property(e => e.OtherPeopleAttachText).HasDefaultValueSql("('')");

                entity.Property(e => e.OtherPeopleText).HasDefaultValueSql("('')");

                entity.Property(e => e.PlanActivityName).HasDefaultValueSql("('')");

                entity.Property(e => e.PlanCoreName).HasDefaultValueSql("('')");

                entity.Property(e => e.PlanCoreRemainBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.PlanTypeName).HasDefaultValueSql("('')");

                entity.Property(e => e.Purpose).HasDefaultValueSql("('')");

                entity.Property(e => e.RangeNumber).HasDefaultValueSql("((1))");

                entity.Property(e => e.Remark).HasDefaultValueSql("('')");

                entity.Property(e => e.Title).HasDefaultValueSql("('')");

                entity.Property(e => e.Topic).HasDefaultValueSql("('')");

                entity.Property(e => e.UnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<OutsideDutyGroupCancellation>(entity =>
            {
                entity.ToTable("OutsideDutyGroupCancellations", "HR");

                entity.HasIndex(e => e.OutsideDutyGroupId, "IX_FK_OutsideDutyGroupOutsideDutyGroupCancellation");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverSignDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.HrdepartmentName).HasColumnName("HRDepartmentName");

                entity.Property(e => e.UnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.OutsideDutyGroup)
                    .WithMany(p => p.OutsideDutyGroupCancellations)
                    .HasForeignKey(d => d.OutsideDutyGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutsideDutyGroupOutsideDutyGroupCancellation");
            });

            modelBuilder.Entity<OutsideDutyReportActionLog>(entity =>
            {
                entity.ToTable("OutsideDutyReportActionLogs", "Plan");

                entity.HasIndex(e => e.OutsideDutyReportFormId, "IX_FK_OutsideDutyReportFormOutsideDutyReportActionLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.Ip).HasColumnName("IP");

                entity.HasOne(d => d.OutsideDutyReportForm)
                    .WithMany(p => p.OutsideDutyReportActionLogs)
                    .HasForeignKey(d => d.OutsideDutyReportFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutsideDutyReportFormOutsideDutyReportActionLog");
            });

            modelBuilder.Entity<OutsideDutyReportForm>(entity =>
            {
                entity.ToTable("OutsideDutyReportForms", "Plan");

                entity.HasIndex(e => e.GeneralExpenseMemoFormId, "IX_FK_GeneralExpenseMemoFormOutsideDutyReportForm");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.IsOutsideDuty)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OtherRequest).HasDefaultValueSql("('')");

                entity.Property(e => e.RefDocumentDate).HasColumnType("datetime");

                entity.Property(e => e.RefTotalBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Remark).HasDefaultValueSql("('')");

                entity.Property(e => e.RequesterSignDate).HasColumnType("datetime");

                entity.Property(e => e.TotalExpense).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<OutsideDutyReportReceipt>(entity =>
            {
                entity.ToTable("OutsideDutyReportReceipts", "Plan");

                entity.HasIndex(e => e.OutsideDutyReportFormId, "IX_FK_OutsideDutyReportFormOutsideDutyReportReceipt");

                entity.Property(e => e.Amount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ReceiptDate).HasColumnType("datetime");

                entity.HasOne(d => d.OutsideDutyReportForm)
                    .WithMany(p => p.OutsideDutyReportReceipts)
                    .HasForeignKey(d => d.OutsideDutyReportFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutsideDutyReportFormOutsideDutyReportReceipt");
            });

            modelBuilder.Entity<OutsideDutyReportStaff>(entity =>
            {
                entity.ToTable("OutsideDutyReportStaffs", "Plan");

                entity.HasIndex(e => e.OutsideDutyReportFormId, "IX_FK_OutsideDutyReportFormOutsideDutyReportStaff");

                entity.Property(e => e.AccommodationCost).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.AllowancesCost).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.OtherCost).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.VehicleCost).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.OutsideDutyReportForm)
                    .WithMany(p => p.OutsideDutyReportStaffs)
                    .HasForeignKey(d => d.OutsideDutyReportFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutsideDutyReportFormOutsideDutyReportStaff");
            });

            modelBuilder.Entity<OverTimeMultiplyRate>(entity =>
            {
                entity.ToTable("OverTimeMultiplyRates", "HR");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");
            });

            modelBuilder.Entity<OverTimeRatePerHour>(entity =>
            {
                entity.ToTable("OverTimeRatePerHours", "HR");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffOverTimeRatePerHour");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.OverTimeRatePerHours)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffOverTimeRatePerHour");
            });

            modelBuilder.Entity<OverTimeRequestForm>(entity =>
            {
                entity.ToTable("OverTimeRequestForms", "HR");

                entity.HasIndex(e => e.OverTimeRequestFormGroupId, "IX_FK_OverTimeRequestFormGroupOverTimeRequestForm");

                entity.HasIndex(e => e.OverTimeRequestResultFormGroupId, "IX_FK_OverTimeRequestResultFormGroupOverTimeRequestForm");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffOverTimeRequestForm");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ClockIn).HasColumnType("datetime");

                entity.Property(e => e.ClockOut).HasColumnType("datetime");

                entity.Property(e => e.DailyAttendanceClockIn).HasColumnType("datetime");

                entity.Property(e => e.DailyAttendanceClockOut).HasColumnType("datetime");

                entity.Property(e => e.ForDate).HasColumnType("datetime");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.HrdepartmentName).HasColumnName("HRDepartmentName");

                entity.Property(e => e.StaffWorkShiftClockIn).HasColumnType("datetime");

                entity.Property(e => e.StaffWorkShiftClockOut).HasColumnType("datetime");

                entity.HasOne(d => d.OverTimeRequestFormGroup)
                    .WithMany(p => p.OverTimeRequestForms)
                    .HasForeignKey(d => d.OverTimeRequestFormGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OverTimeRequestFormGroupOverTimeRequestForm");

                entity.HasOne(d => d.OverTimeRequestResultFormGroup)
                    .WithMany(p => p.OverTimeRequestForms)
                    .HasForeignKey(d => d.OverTimeRequestResultFormGroupId)
                    .HasConstraintName("FK_OverTimeRequestResultFormGroupOverTimeRequestForm");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.OverTimeRequestForms)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffOverTimeRequestForm");
            });

            modelBuilder.Entity<OverTimeRequestFormGroup>(entity =>
            {
                entity.ToTable("OverTimeRequestFormGroups", "HR");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverSignDate).HasColumnType("datetime");

                entity.Property(e => e.ClockIn).HasColumnType("datetime");

                entity.Property(e => e.ClockOut).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentName).HasDefaultValueSql("('')");

                entity.Property(e => e.ForDate).HasColumnType("datetime");

                entity.Property(e => e.UnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.WorkShiftClockIn).HasColumnType("datetime");

                entity.Property(e => e.WorkShiftClockOut).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<OverTimeRequestResultFormGroup>(entity =>
            {
                entity.ToTable("OverTimeRequestResultFormGroups", "HR");

                entity.HasIndex(e => e.OverTimeRequestFormGroupId, "IX_FK_OverTimeRequestFormGroupOverTimeRequestResultFormGroup");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverSignDate).HasColumnType("datetime");

                entity.Property(e => e.OverTimeRequestFormGroupId).HasColumnName("OverTimeRequestFormGroup_Id");

                entity.Property(e => e.TotalBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.OverTimeRequestFormGroup)
                    .WithMany(p => p.OverTimeRequestResultFormGroups)
                    .HasForeignKey(d => d.OverTimeRequestFormGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OverTimeRequestFormGroupOverTimeRequestResultFormGroup");
            });

            modelBuilder.Entity<PastDevelopmentRecord>(entity =>
            {
                entity.ToTable("PastDevelopmentRecords", "HR");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffPastDevelopmentRecord");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.PastDevelopmentRecords)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffPastDevelopmentRecord");
            });

            modelBuilder.Entity<PerfYearlyEvalFormActionLog>(entity =>
            {
                entity.ToTable("PerfYearlyEvalFormActionLogs", "HR");

                entity.HasIndex(e => e.PerformanceYearlyEvaluationFormId, "IX_FK_PerformanceYearlyEvaluationFormPerfYearlyEvalFormActionLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.Ip).HasColumnName("IP");

                entity.Property(e => e.Jwtpayload).HasColumnName("JWTPayload");

                entity.HasOne(d => d.PerformanceYearlyEvaluationForm)
                    .WithMany(p => p.PerfYearlyEvalFormActionLogs)
                    .HasForeignKey(d => d.PerformanceYearlyEvaluationFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PerformanceYearlyEvaluationFormPerfYearlyEvalFormActionLog");
            });

            modelBuilder.Entity<PerformanceIndicator>(entity =>
            {
                entity.ToTable("PerformanceIndicators", "Plan");

                entity.HasIndex(e => e.ParentPerformanceIndicatorId, "IX_FK_PerformanceIndicatorParentPerformanceIndicator");

                entity.HasIndex(e => e.PlanActivityId, "IX_FK_PlanActivityPerformanceIndicator");

                entity.HasIndex(e => e.PlanCoreId, "IX_FK_PlanCorePerformanceIndicator");

                entity.HasIndex(e => e.StrategicIndicatorId, "IX_FK_StrategicIndicatorPerformanceIndicator");

                entity.Property(e => e.April).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.August).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.December).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.DetailApril).HasDefaultValueSql("('')");

                entity.Property(e => e.DetailAugust).HasDefaultValueSql("('')");

                entity.Property(e => e.DetailDecember).HasDefaultValueSql("('')");

                entity.Property(e => e.DetailFebruary).HasDefaultValueSql("('')");

                entity.Property(e => e.DetailJanuary).HasDefaultValueSql("('')");

                entity.Property(e => e.DetailJuly).HasDefaultValueSql("('')");

                entity.Property(e => e.DetailJune).HasDefaultValueSql("('')");

                entity.Property(e => e.DetailMarch).HasDefaultValueSql("('')");

                entity.Property(e => e.DetailMay).HasDefaultValueSql("('')");

                entity.Property(e => e.DetailNovember).HasDefaultValueSql("('')");

                entity.Property(e => e.DetailOctober).HasDefaultValueSql("('')");

                entity.Property(e => e.DetailQ1).HasDefaultValueSql("('')");

                entity.Property(e => e.DetailQ2).HasDefaultValueSql("('')");

                entity.Property(e => e.DetailQ3).HasDefaultValueSql("('')");

                entity.Property(e => e.DetailQ4).HasDefaultValueSql("('')");

                entity.Property(e => e.DetailSeptember).HasDefaultValueSql("('')");

                entity.Property(e => e.February).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.January).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.July).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.June).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.March).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.May).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.November).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ObstacleApril).HasDefaultValueSql("('')");

                entity.Property(e => e.ObstacleAugust).HasDefaultValueSql("('')");

                entity.Property(e => e.ObstacleDecember).HasDefaultValueSql("('')");

                entity.Property(e => e.ObstacleFebruary).HasDefaultValueSql("('')");

                entity.Property(e => e.ObstacleJanuary).HasDefaultValueSql("('')");

                entity.Property(e => e.ObstacleJuly).HasDefaultValueSql("('')");

                entity.Property(e => e.ObstacleJune).HasDefaultValueSql("('')");

                entity.Property(e => e.ObstacleMarch).HasDefaultValueSql("('')");

                entity.Property(e => e.ObstacleMay).HasDefaultValueSql("('')");

                entity.Property(e => e.ObstacleNovember).HasDefaultValueSql("('')");

                entity.Property(e => e.ObstacleOctober).HasDefaultValueSql("('')");

                entity.Property(e => e.ObstacleQ1).HasDefaultValueSql("('')");

                entity.Property(e => e.ObstacleQ2).HasDefaultValueSql("('')");

                entity.Property(e => e.ObstacleQ3).HasDefaultValueSql("('')");

                entity.Property(e => e.ObstacleQ4).HasDefaultValueSql("('')");

                entity.Property(e => e.ObstacleSeptember).HasDefaultValueSql("('')");

                entity.Property(e => e.October).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ResultApril).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ResultAugust).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ResultDecember).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ResultFebruary).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ResultJanuary).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ResultJuly).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ResultJune).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ResultMarch).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ResultMay).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ResultNovember).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ResultOctober).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ResultQ1)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ResultQ2)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ResultQ3)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ResultQ4)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ResultSeptember).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.September).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.SupportFactorApril).HasDefaultValueSql("('')");

                entity.Property(e => e.SupportFactorAugust).HasDefaultValueSql("('')");

                entity.Property(e => e.SupportFactorDecember).HasDefaultValueSql("('')");

                entity.Property(e => e.SupportFactorFebruary).HasDefaultValueSql("('')");

                entity.Property(e => e.SupportFactorJanuary).HasDefaultValueSql("('')");

                entity.Property(e => e.SupportFactorJuly).HasDefaultValueSql("('')");

                entity.Property(e => e.SupportFactorJune).HasDefaultValueSql("('')");

                entity.Property(e => e.SupportFactorMarch).HasDefaultValueSql("('')");

                entity.Property(e => e.SupportFactorMay).HasDefaultValueSql("('')");

                entity.Property(e => e.SupportFactorNovember).HasDefaultValueSql("('')");

                entity.Property(e => e.SupportFactorOctober).HasDefaultValueSql("('')");

                entity.Property(e => e.SupportFactorQ1).HasDefaultValueSql("('')");

                entity.Property(e => e.SupportFactorQ2).HasDefaultValueSql("('')");

                entity.Property(e => e.SupportFactorQ3).HasDefaultValueSql("('')");

                entity.Property(e => e.SupportFactorQ4).HasDefaultValueSql("('')");

                entity.Property(e => e.SupportFactorSeptember).HasDefaultValueSql("('')");

                entity.Property(e => e.TargetValueQ1).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.TargetValueQ2)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TargetValueQ3)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TargetValueQ4)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.HasOne(d => d.ParentPerformanceIndicator)
                    .WithMany(p => p.InverseParentPerformanceIndicator)
                    .HasForeignKey(d => d.ParentPerformanceIndicatorId)
                    .HasConstraintName("FK_PerformanceIndicatorParentPerformanceIndicator");

                entity.HasOne(d => d.PlanActivity)
                    .WithMany(p => p.PerformanceIndicators)
                    .HasForeignKey(d => d.PlanActivityId)
                    .HasConstraintName("FK_PlanActivityPerformanceIndicator");

                entity.HasOne(d => d.PlanCore)
                    .WithMany(p => p.PerformanceIndicators)
                    .HasForeignKey(d => d.PlanCoreId)
                    .HasConstraintName("FK_PlanCorePerformanceIndicator");

                entity.HasOne(d => d.StrategicIndicator)
                    .WithMany(p => p.PerformanceIndicators)
                    .HasForeignKey(d => d.StrategicIndicatorId)
                    .HasConstraintName("FK_StrategicIndicatorPerformanceIndicator");
            });

            modelBuilder.Entity<PerformanceIndicatorFile>(entity =>
            {
                entity.ToTable("PerformanceIndicatorFiles", "Plan");

                entity.HasIndex(e => e.PerformanceIndicatorId, "IX_FK_PerformanceIndicatorPerformanceIndicatorFile");

                entity.Property(e => e.UploadDate).HasColumnType("datetime");

                entity.HasOne(d => d.PerformanceIndicator)
                    .WithMany(p => p.PerformanceIndicatorFiles)
                    .HasForeignKey(d => d.PerformanceIndicatorId)
                    .HasConstraintName("FK_PerformanceIndicatorPerformanceIndicatorFile");
            });

            modelBuilder.Entity<PerformanceYearlyEvaluationForm>(entity =>
            {
                entity.ToTable("PerformanceYearlyEvaluationForms", "HR");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffPerformanceYearlyEvaluationForm");

                entity.Property(e => e.ApproverSignDate).HasColumnType("datetime");

                entity.Property(e => e.FirstEvaluator).HasDefaultValueSql("('')");

                entity.Property(e => e.FirstEvaluatorOpinion).HasDefaultValueSql("('')");

                entity.Property(e => e.FirstEvaluatorPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.FirstEvaluatorSentMailDate).HasColumnType("datetime");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.Property(e => e.SecondEvaluator).HasDefaultValueSql("('')");

                entity.Property(e => e.SecondEvaluatorOpinion).HasDefaultValueSql("('')");

                entity.Property(e => e.SecondEvaluatorPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.SecondEvaluatorSentMailDate).HasColumnType("datetime");

                entity.Property(e => e.Section11QuantityScore).HasColumnName("Section1_1_Quantity_Score");

                entity.Property(e => e.Section11QuantityWeight).HasColumnName("Section1_1_Quantity_Weight");

                entity.Property(e => e.Section12QualityScore).HasColumnName("Section1_2_Quality_Score");

                entity.Property(e => e.Section12QualityWeight).HasColumnName("Section1_2_Quality_Weight");

                entity.Property(e => e.Section210SelfControlScore).HasColumnName("Section2_10_SelfControl_Score");

                entity.Property(e => e.Section210SelfControlWeight).HasColumnName("Section2_10_SelfControl_Weight");

                entity.Property(e => e.Section21ResponsibilityScore).HasColumnName("Section2_1_Responsibility_Score");

                entity.Property(e => e.Section21ResponsibilityWeight).HasColumnName("Section2_1_Responsibility_Weight");

                entity.Property(e => e.Section22PlanningScore).HasColumnName("Section2_2_Planning_Score");

                entity.Property(e => e.Section22PlanningWeight).HasColumnName("Section2_2_Planning_Weight");

                entity.Property(e => e.Section23TeamworkScore).HasColumnName("Section2_3_Teamwork_Score");

                entity.Property(e => e.Section23TeamworkWeight).HasColumnName("Section2_3_Teamwork_Weight");

                entity.Property(e => e.Section24CautiouslyScore).HasColumnName("Section2_4_Cautiously_Score");

                entity.Property(e => e.Section24CautiouslyWeight).HasColumnName("Section2_4_Cautiously_Weight");

                entity.Property(e => e.Section25ManagementScore).HasColumnName("Section2_5_Management_Score");

                entity.Property(e => e.Section25ManagementWeight).HasColumnName("Section2_5_Management_Weight");

                entity.Property(e => e.Section26SolveAndDecisionScore).HasColumnName("Section2_6_SolveAndDecision_Score");

                entity.Property(e => e.Section26SolveAndDecisionWeight).HasColumnName("Section2_6_SolveAndDecision_Weight");

                entity.Property(e => e.Section27LeadershipScore).HasColumnName("Section2_7_Leadership_Score");

                entity.Property(e => e.Section27LeadershipWeight).HasColumnName("Section2_7_Leadership_Weight");

                entity.Property(e => e.Section28DisciplineScore).HasColumnName("Section2_8_Discipline_Score");

                entity.Property(e => e.Section28DisciplineWeight).HasColumnName("Section2_8_Discipline_Weight");

                entity.Property(e => e.Section29MoralScore).HasColumnName("Section2_9_Moral_Score");

                entity.Property(e => e.Section29MoralWeight).HasColumnName("Section2_9_Moral_Weight");

                entity.Property(e => e.SentMailDate).HasColumnType("datetime");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.PerformanceYearlyEvaluationForms)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffPerformanceYearlyEvaluationForm");
            });

            modelBuilder.Entity<PerformanceYearlyEvaluationWeight>(entity =>
            {
                entity.ToTable("PerformanceYearlyEvaluationWeights", "HR");

                entity.HasIndex(e => e.JobPositionGroupId, "IX_FK_JobPositionGroupPerformanceYearlyEvaluationWeight");

                entity.HasIndex(e => e.JobPositionLevelId, "IX_FK_JobPositionLevelPerformanceYearlyEvaluationWeight");

                entity.Property(e => e.Section11QuantityWeight).HasColumnName("Section1_1_Quantity_Weight");

                entity.Property(e => e.Section12QualityWeight).HasColumnName("Section1_2_Quality_Weight");

                entity.Property(e => e.Section210SelfControlWeight).HasColumnName("Section2_10_SelfControl_Weight");

                entity.Property(e => e.Section21ResponsibilityWeight).HasColumnName("Section2_1_Responsibility_Weight");

                entity.Property(e => e.Section22PlanningWeight).HasColumnName("Section2_2_Planning_Weight");

                entity.Property(e => e.Section23TeamworkWeight).HasColumnName("Section2_3_Teamwork_Weight");

                entity.Property(e => e.Section24CautiouslyWeight).HasColumnName("Section2_4_Cautiously_Weight");

                entity.Property(e => e.Section25ManagementWeight).HasColumnName("Section2_5_Management_Weight");

                entity.Property(e => e.Section26SolveAndDecisionWeight).HasColumnName("Section2_6_SolveAndDecision_Weight");

                entity.Property(e => e.Section27LeadershipWeight).HasColumnName("Section2_7_Leadership_Weight");

                entity.Property(e => e.Section28DisciplineWeight).HasColumnName("Section2_8_Discipline_Weight");

                entity.Property(e => e.Section29MoralWeight).HasColumnName("Section2_9_Moral_Weight");

                entity.HasOne(d => d.JobPositionGroup)
                    .WithMany(p => p.PerformanceYearlyEvaluationWeights)
                    .HasForeignKey(d => d.JobPositionGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobPositionGroupPerformanceYearlyEvaluationWeight");

                entity.HasOne(d => d.JobPositionLevel)
                    .WithMany(p => p.PerformanceYearlyEvaluationWeights)
                    .HasForeignKey(d => d.JobPositionLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobPositionLevelPerformanceYearlyEvaluationWeight");
            });

            modelBuilder.Entity<PersonalAbility>(entity =>
            {
                entity.ToTable("PersonalAbilities", "HR");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffPersonalAbility");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.PersonalAbilities)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffPersonalAbility");
            });

            modelBuilder.Entity<PlanActivity>(entity =>
            {
                entity.ToTable("PlanActivities", "Plan");

                entity.HasIndex(e => e.DepartmentId, "IX_FK_DepartmentPlanActivity");

                entity.HasIndex(e => e.PlanCoreId, "IX_FK_PlanActivityPlanCore");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasDefaultValueSql("((1))");

                entity.Property(e => e.OperationPeriod).HasMaxLength(50);

                entity.Property(e => e.Weight).HasColumnType("decimal(7, 4)");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.PlanActivities)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentPlanActivity");

                entity.HasOne(d => d.PlanCore)
                    .WithMany(p => p.PlanActivities)
                    .HasForeignKey(d => d.PlanCoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanActivityPlanCore");
            });

            modelBuilder.Entity<PlanActivityActionLog>(entity =>
            {
                entity.ToTable("PlanActivityActionLogs", "Plan");

                entity.HasIndex(e => e.PlanActivityId, "IX_FK_PlanActivityPlanActivityActionLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.Ip).HasColumnName("IP");

                entity.HasOne(d => d.PlanActivity)
                    .WithMany(p => p.PlanActivityActionLogs)
                    .HasForeignKey(d => d.PlanActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanActivityPlanActivityActionLog");
            });

            modelBuilder.Entity<PlanCore>(entity =>
            {
                entity.ToTable("PlanCores", "Plan");

                entity.HasIndex(e => e.DepartmentId, "IX_FK_DepartmentPlanCore");

                entity.HasIndex(e => e.FundTypeId, "IX_FK_FundTypePlanCore");

                entity.HasIndex(e => e.PlanTypeId, "IX_FK_PlanCorePlanType");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.FundCategoryEnum).HasDefaultValueSql("((10))");

                entity.Property(e => e.FundSourceEnum).HasDefaultValueSql("((10))");

                entity.Property(e => e.OtherTarget).HasDefaultValueSql("('')");

                entity.Property(e => e.Outcome).HasDefaultValueSql("('')");

                entity.Property(e => e.Output).HasDefaultValueSql("('')");

                entity.Property(e => e.TargetIdListValue).HasDefaultValueSql("('')");

                entity.Property(e => e.Weight).HasColumnType("decimal(7, 4)");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.PlanCores)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentPlanCore");

                entity.HasOne(d => d.FundType)
                    .WithMany(p => p.PlanCores)
                    .HasForeignKey(d => d.FundTypeId)
                    .HasConstraintName("FK_FundTypePlanCore");

                entity.HasOne(d => d.PlanType)
                    .WithMany(p => p.PlanCores)
                    .HasForeignKey(d => d.PlanTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanCorePlanType");

                entity.HasOne(d => d.PrinciplePlanTag)
                    .WithMany(p => p.PlanCores)
                    .HasForeignKey(d => d.PrinciplePlanTagId)
                    .HasConstraintName("FK_PrinciplePlanPlanCore");

                entity.HasMany(d => d.Strategies)
                    .WithMany(p => p.PlanCores)
                    .UsingEntity<Dictionary<string, object>>(
                        "PlanCoresStrategy",
                        l => l.HasOne<Strategy>().WithMany().HasForeignKey("StrategiesId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PlanCores_Strategies_Strategy"),
                        r => r.HasOne<PlanCore>().WithMany().HasForeignKey("PlanCoresId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_PlanCores_Strategies_PlanCore"),
                        j =>
                        {
                            j.HasKey("PlanCoresId", "StrategiesId").IsClustered(false);

                            j.ToTable("PlanCores_Strategies", "Plan");

                            j.HasIndex(new[] { "StrategiesId" }, "IX_FK_PlanCores_Strategies_Strategy");

                            j.IndexerProperty<int>("PlanCoresId").HasColumnName("PlanCores_Id");

                            j.IndexerProperty<int>("StrategiesId").HasColumnName("Strategies_Id");
                        });
            });

            modelBuilder.Entity<PlanCoreActionLog>(entity =>
            {
                entity.ToTable("PlanCoreActionLogs", "Plan");

                entity.HasIndex(e => e.PlanCoreId, "IX_FK_PlanCorePlanCoreActionLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.Ip).HasColumnName("IP");

                entity.HasOne(d => d.PlanCore)
                    .WithMany(p => p.PlanCoreActionLogs)
                    .HasForeignKey(d => d.PlanCoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanCorePlanCoreActionLog");
            });

            modelBuilder.Entity<PlanCoreStaffPermission>(entity =>
            {
                entity.ToTable("PlanCoreStaffPermissions", "Plan");
            });

            modelBuilder.Entity<PlanCrudpolicy>(entity =>
            {
                entity.ToTable("PlanCRUDPolicies", "Plan");

                entity.Property(e => e.BypassAuthenticateCrudplanActivity).HasColumnName("BypassAuthenticateCRUDPlanActivity");

                entity.Property(e => e.BypassAuthenticateCrudplanCore).HasColumnName("BypassAuthenticateCRUDPlanCore");

                entity.Property(e => e.BypassAuthenticateCrudplanItem).HasColumnName("BypassAuthenticateCRUDPlanItem");

                entity.Property(e => e.PerformanceIndicatorResultDay).HasDefaultValueSql("((3))");

                entity.Property(e => e.PlanActivityOperationPeriodResultDay).HasDefaultValueSql("((3))");
            });

            modelBuilder.Entity<PlanDepartmentStaffPermission>(entity =>
            {
                entity.ToTable("PlanDepartmentStaffPermissions", "Plan");
            });

            modelBuilder.Entity<PlanFile>(entity =>
            {
                entity.ToTable("PlanFiles", "Plan");

                entity.HasIndex(e => e.GeFormActionLogId, "IX_FK_GeFormActionLogPlanFile");

                entity.HasIndex(e => e.GeneralExpenseMemoFormId, "IX_FK_GeneralExpenseMemoFormPlanFile");

                entity.HasIndex(e => e.GeneralExpensePersonalBorrowFormId, "IX_FK_GeneralExpensePersonalBorrowFormPlanFile");

                entity.HasIndex(e => e.PlanMonthlyOperationId, "IX_FK_PlanMonthlyOperationPlanFile");

                entity.HasIndex(e => e.SettleReceiptFormId, "IX_FK_SettleReceiptFormPlanFile");

                entity.Property(e => e.UploadDate).HasColumnType("datetime");

                entity.HasOne(d => d.GeFormActionLog)
                    .WithMany(p => p.PlanFiles)
                    .HasForeignKey(d => d.GeFormActionLogId)
                    .HasConstraintName("FK_GeFormActionLogPlanFile");

                entity.HasOne(d => d.GeneralExpenseMemoForm)
                    .WithMany(p => p.PlanFiles)
                    .HasForeignKey(d => d.GeneralExpenseMemoFormId)
                    .HasConstraintName("FK_GeneralExpenseMemoFormPlanFile");

                entity.HasOne(d => d.GeneralExpensePersonalBorrowForm)
                    .WithMany(p => p.PlanFiles)
                    .HasForeignKey(d => d.GeneralExpensePersonalBorrowFormId)
                    .HasConstraintName("FK_GeneralExpensePersonalBorrowFormPlanFile");

                entity.HasOne(d => d.PlanMonthlyOperation)
                    .WithMany(p => p.PlanFiles)
                    .HasForeignKey(d => d.PlanMonthlyOperationId)
                    .HasConstraintName("FK_PlanMonthlyOperationPlanFile");

                entity.HasOne(d => d.SettleReceiptForm)
                    .WithMany(p => p.PlanFiles)
                    .HasForeignKey(d => d.SettleReceiptFormId)
                    .HasConstraintName("FK_SettleReceiptFormPlanFile");
            });

            modelBuilder.Entity<PlanFundSource>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Plan.FundSource");
            });

            modelBuilder.Entity<PlanItem>(entity =>
            {
                entity.ToTable("PlanItems", "Plan");

                entity.HasIndex(e => e.BudgetTypeId, "IX_FK_BudgetTypePlanItem");

                entity.HasIndex(e => e.CostTypeId, "IX_FK_CostTypePlanItem");

                entity.HasIndex(e => e.PlanActivityId, "IX_FK_FKPlanActivitiyPlanItems");

                entity.HasIndex(e => e.PlanItemTypeId, "IX_FK_PlanItemTypePlanItem");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ProtectBudget)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ReceivedBudget1)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ReceivedBudget2)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ReceivedBudget3)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ReceivedBudget4)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ReceivedBudgetDate1).HasColumnType("datetime");

                entity.Property(e => e.ReceivedBudgetDate2).HasColumnType("datetime");

                entity.Property(e => e.ReceivedBudgetDate3).HasColumnType("datetime");

                entity.Property(e => e.ReceivedBudgetDate4).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasDefaultValueSql("('')");

                entity.Property(e => e.ReservedBudget)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.UndefineReserveBudget)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.UndefineReserveByStaffName).HasDefaultValueSql("('')");

                entity.Property(e => e.UndefineReserveDate).HasColumnType("datetime");

                entity.Property(e => e.UndefineReserveForecastValue).HasDefaultValueSql("('')");

                entity.Property(e => e.UndefineReserveRemark).HasDefaultValueSql("('')");

                entity.Property(e => e.UndefineReserveReturnBudget)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.UndefineReserveReturnDate).HasColumnType("datetime");

                entity.HasOne(d => d.BudgetType)
                    .WithMany(p => p.PlanItems)
                    .HasForeignKey(d => d.BudgetTypeId)
                    .HasConstraintName("FK_BudgetTypePlanItem");

                entity.HasOne(d => d.CostType)
                    .WithMany(p => p.PlanItems)
                    .HasForeignKey(d => d.CostTypeId)
                    .HasConstraintName("FK_CostTypePlanItem");

                entity.HasOne(d => d.PlanActivity)
                    .WithMany(p => p.PlanItems)
                    .HasForeignKey(d => d.PlanActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FKPlanActivitiyPlanItems");

                entity.HasOne(d => d.PlanItemType)
                    .WithMany(p => p.PlanItems)
                    .HasForeignKey(d => d.PlanItemTypeId)
                    .HasConstraintName("FK_PlanItemTypePlanItem");
            });

            modelBuilder.Entity<PlanItemActionLog>(entity =>
            {
                entity.ToTable("PlanItemActionLogs", "Plan");

                entity.HasIndex(e => e.PlanItemId, "IX_FK_PlanItemPlanItemActionLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.Ip).HasColumnName("IP");

                entity.HasOne(d => d.PlanItem)
                    .WithMany(p => p.PlanItemActionLogs)
                    .HasForeignKey(d => d.PlanItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanItemPlanItemActionLog");
            });

            modelBuilder.Entity<PlanItemType>(entity =>
            {
                entity.ToTable("PlanItemTypes", "Plan");

                entity.HasIndex(e => e.ParentPlanItemTypeId, "IX_FK_PlanItemTypePlanItemType");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ParentPlanItemType)
                    .WithMany(p => p.InverseParentPlanItemType)
                    .HasForeignKey(d => d.ParentPlanItemTypeId)
                    .HasConstraintName("FK_PlanItemTypePlanItemType");
            });

            modelBuilder.Entity<PlanMonthlyOperation>(entity =>
            {
                entity.ToTable("PlanMonthlyOperations", "Plan");

                entity.HasIndex(e => e.PlanActivityId, "IX_FK_PlanActivityPlanMonthlyOperation");

                entity.HasIndex(e => e.ParentPlanMonthlyOperationId, "IX_FK_PlanMonthlyOperationParentPlanMonthlyOperation");

                entity.Property(e => e.April).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.August).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.December).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.DetailApril).HasDefaultValueSql("((0))");

                entity.Property(e => e.DetailAugust).HasDefaultValueSql("((0))");

                entity.Property(e => e.DetailDecember).HasDefaultValueSql("((0))");

                entity.Property(e => e.DetailFebruary).HasDefaultValueSql("((0))");

                entity.Property(e => e.DetailJanuary).HasDefaultValueSql("((0))");

                entity.Property(e => e.DetailJuly).HasDefaultValueSql("((0))");

                entity.Property(e => e.DetailJune).HasDefaultValueSql("((0))");

                entity.Property(e => e.DetailMarch).HasDefaultValueSql("((0))");

                entity.Property(e => e.DetailMay).HasDefaultValueSql("((0))");

                entity.Property(e => e.DetailNovember).HasDefaultValueSql("((0))");

                entity.Property(e => e.DetailOctober).HasDefaultValueSql("((0))");

                entity.Property(e => e.DetailSeptember).HasDefaultValueSql("((0))");

                entity.Property(e => e.February).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.January).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.July).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.June).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.March).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.May).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.November).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.October).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.ResultApril).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.ResultAugust).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.ResultDecember).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.ResultFebruary).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.ResultJanuary).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.ResultJuly).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.ResultJune).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.ResultMarch).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.ResultMay).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.ResultNovember).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.ResultOctober).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.ResultSeptember).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.September).HasColumnType("decimal(7, 4)");

                entity.Property(e => e.Weight).HasColumnType("decimal(7, 4)");

                entity.HasOne(d => d.ParentPlanMonthlyOperation)
                    .WithMany(p => p.InverseParentPlanMonthlyOperation)
                    .HasForeignKey(d => d.ParentPlanMonthlyOperationId)
                    .HasConstraintName("FK_PlanMonthlyOperationParentPlanMonthlyOperation");

                entity.HasOne(d => d.PlanActivity)
                    .WithMany(p => p.PlanMonthlyOperations)
                    .HasForeignKey(d => d.PlanActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanActivityPlanMonthlyOperation");
            });

            modelBuilder.Entity<PlanMonthlyOperationChangeLog>(entity =>
            {
                entity.ToTable("PlanMonthlyOperationChangeLogs", "Plan");

                entity.HasIndex(e => e.PlanMonthlyOperationId, "IX_FK_PlanMonthlyOperationPlanMonthlyOperationChangeLog");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Weight).HasColumnType("decimal(7, 4)");

                entity.HasOne(d => d.PlanMonthlyOperation)
                    .WithMany(p => p.PlanMonthlyOperationChangeLogs)
                    .HasForeignKey(d => d.PlanMonthlyOperationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanMonthlyOperationPlanMonthlyOperationChangeLog");
            });

            modelBuilder.Entity<PlanPerson>(entity =>
            {
                entity.ToTable("PlanPersons", "Plan");

                entity.HasIndex(e => e.DepartmentId, "IX_FK_DepartmentPlanPerson");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.PlanPeople)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_DepartmentPlanPerson");
            });

            modelBuilder.Entity<PlanType>(entity =>
            {
                entity.ToTable("PlanTypes", "Plan");

                entity.HasIndex(e => e.ParentPlanTypeId, "IX_FK_PlanTypeSubPlanTypes");

                entity.Property(e => e.Weight).HasColumnType("decimal(7, 4)");

                entity.HasOne(d => d.ParentPlanType)
                    .WithMany(p => p.InverseParentPlanType)
                    .HasForeignKey(d => d.ParentPlanTypeId)
                    .HasConstraintName("FK_PlanTypeSubPlanTypes");
            });

            modelBuilder.Entity<PostDevelopmentRecordEvaluationForm>(entity =>
            {
                entity.ToTable("PostDevelopmentRecordEvaluationForms", "HR");

                entity.HasIndex(e => e.DevelopmentRecordId, "IX_FK_DevelopmentRecordPostDevelopmentRecordEvaluationForm");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.HasOne(d => d.DevelopmentRecord)
                    .WithMany(p => p.PostDevelopmentRecordEvaluationForms)
                    .HasForeignKey(d => d.DevelopmentRecordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DevelopmentRecordPostDevelopmentRecordEvaluationForm");
            });

            modelBuilder.Entity<PrinciplePlanTag>(entity =>
            {
                entity.ToTable("PrinciplePlanTags", "Plan");

                entity.HasIndex(e => e.ParentPrinciplePlanTagId, "IX_FK_PrinciplePlanTagSubPrinciplePlanTags");

                entity.Property(e => e.Weight).HasColumnType("decimal(7, 4)");

                entity.HasOne(d => d.ParentPrinciplePlanTag)
                    .WithMany(p => p.InverseParentPrinciplePlanTag)
                    .HasForeignKey(d => d.ParentPrinciplePlanTagId)
                    .HasConstraintName("FK_PrinciplePlanTagSubPrinciplePlanTags");
            });

            modelBuilder.Entity<ProbationEvaluationForm>(entity =>
            {
                entity.ToTable("ProbationEvaluationForms", "HR");

                entity.HasIndex(e => e.EmploymentContractId, "IX_FK_EmploymentContractProbationEvaluationForm");

                entity.Property(e => e.FirstEvaluator).HasDefaultValueSql("('')");

                entity.Property(e => e.FirstEvaluatorOpinion).HasDefaultValueSql("('')");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.Issue101Opinion).HasColumnName("Issue10_1_Opinion");

                entity.Property(e => e.Issue101Score).HasColumnName("Issue10_1_Score");

                entity.Property(e => e.Issue11Opinion).HasColumnName("Issue1_1_Opinion");

                entity.Property(e => e.Issue11Score).HasColumnName("Issue1_1_Score");

                entity.Property(e => e.Issue12Opinion).HasColumnName("Issue1_2_Opinion");

                entity.Property(e => e.Issue12Score).HasColumnName("Issue1_2_Score");

                entity.Property(e => e.Issue13Opinion).HasColumnName("Issue1_3_Opinion");

                entity.Property(e => e.Issue13Score).HasColumnName("Issue1_3_Score");

                entity.Property(e => e.Issue21Opinion).HasColumnName("Issue2_1_Opinion");

                entity.Property(e => e.Issue21Score).HasColumnName("Issue2_1_Score");

                entity.Property(e => e.Issue31Opinion).HasColumnName("Issue3_1_Opinion");

                entity.Property(e => e.Issue31Score).HasColumnName("Issue3_1_Score");

                entity.Property(e => e.Issue41Opinion).HasColumnName("Issue4_1_Opinion");

                entity.Property(e => e.Issue41Score).HasColumnName("Issue4_1_Score");

                entity.Property(e => e.Issue51Opinion).HasColumnName("Issue5_1_Opinion");

                entity.Property(e => e.Issue51Score).HasColumnName("Issue5_1_Score");

                entity.Property(e => e.Issue61Opinion).HasColumnName("Issue6_1_Opinion");

                entity.Property(e => e.Issue61Score).HasColumnName("Issue6_1_Score");

                entity.Property(e => e.Issue71Opinion).HasColumnName("Issue7_1_Opinion");

                entity.Property(e => e.Issue71Score).HasColumnName("Issue7_1_Score");

                entity.Property(e => e.Issue81Opinion).HasColumnName("Issue8_1_Opinion");

                entity.Property(e => e.Issue81Score).HasColumnName("Issue8_1_Score");

                entity.Property(e => e.Issue91Opinion).HasColumnName("Issue9_1_Opinion");

                entity.Property(e => e.Issue91Score).HasColumnName("Issue9_1_Score");

                entity.Property(e => e.ProbationEndDate).HasColumnType("datetime");

                entity.Property(e => e.ProbationStartDate).HasColumnType("datetime");

                entity.Property(e => e.RecordDate).HasColumnType("datetime");

                entity.Property(e => e.RecorderSignDate).HasColumnType("datetime");

                entity.Property(e => e.SecondEvaluator).HasDefaultValueSql("('')");

                entity.Property(e => e.SecondEvaluatorOpinion).HasDefaultValueSql("('')");

                entity.Property(e => e.StaffPositionLevelName).HasDefaultValueSql("('')");

                entity.Property(e => e.StaffStartWorkingDate).HasColumnType("datetime");

                entity.HasOne(d => d.EmploymentContract)
                    .WithMany(p => p.ProbationEvaluationForms)
                    .HasForeignKey(d => d.EmploymentContractId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmploymentContractProbationEvaluationForm");
            });

            modelBuilder.Entity<ProcureComitteeGroup>(entity =>
            {
                entity.ToTable("ProcureComitteeGroups", "Operation");
            });

            modelBuilder.Entity<ProcureComitteePerson>(entity =>
            {
                entity.ToTable("ProcureComitteePersons", "Operation");

                entity.HasIndex(e => e.ProcureComitteeGroupId, "IX_FK_ProcureComitteeGroupProcureComitteePerson");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.HrdepartmentName).HasColumnName("HRDepartmentName");

                entity.HasOne(d => d.ProcureComitteeGroup)
                    .WithMany(p => p.ProcureComitteePeople)
                    .HasForeignKey(d => d.ProcureComitteeGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureComitteeGroupProcureComitteePerson");
            });

            modelBuilder.Entity<ProcureContract>(entity =>
            {
                entity.ToTable("ProcureContracts", "Procure");

                entity.HasIndex(e => e.OrderFormId, "IX_FK_OrderFormProcureContract");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.GuaranteeEndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.OrderForm)
                    .WithMany(p => p.ProcureContracts)
                    .HasForeignKey(d => d.OrderFormId)
                    .HasConstraintName("FK_OrderFormProcureContract");
            });

            modelBuilder.Entity<ProcureContractInstallment>(entity =>
            {
                entity.ToTable("ProcureContractInstallments", "Procure");

                entity.HasIndex(e => e.ProcureContractId, "IX_FK_ProcureContractProcureContractInstallment");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.ProcureContract)
                    .WithMany(p => p.ProcureContractInstallments)
                    .HasForeignKey(d => d.ProcureContractId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureContractProcureContractInstallment");
            });

            modelBuilder.Entity<ProcureDepartmentPermission>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.AspnetUsersUserId });

                entity.ToTable("Procure_DepartmentPermissions");

                entity.HasIndex(e => e.AspnetUsersUserId, "IX_FK_aspnet_UsersProcure_DepartmentPermission");

                entity.Property(e => e.AspnetUsersUserId).HasColumnName("aspnet_UsersUserId");

                entity.HasOne(d => d.AspnetUsersUser)
                    .WithMany(p => p.ProcureDepartmentPermissions)
                    .HasForeignKey(d => d.AspnetUsersUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aspnet_UsersProcure_DepartmentPermission");
            });

            modelBuilder.Entity<ProcureFile>(entity =>
            {
                entity.ToTable("ProcureFiles", "Procure");

                entity.HasIndex(e => e.AgreementFormId, "IX_FK_AgreementFormProcureFile");

                entity.HasIndex(e => e.ApproveFormId, "IX_FK_ApproveFormProcureFile");

                entity.HasIndex(e => e.CheckFormId, "IX_FK_CheckFormProcureFile");

                entity.HasIndex(e => e.OrderFormId, "IX_FK_OrderFormProcureFile");

                entity.HasIndex(e => e.ProcureContractId, "IX_FK_ProcureContractProcureFile");

                entity.HasIndex(e => e.RegisterDurableItemId, "IX_FK_RegisterDurableItemProcureFile");

                entity.HasIndex(e => e.RegisterItemCheckRecordId, "IX_FK_RegisterItemCheckRecordProcureFile");

                entity.HasIndex(e => e.RequestFormId, "IX_FK_RequestFormProcureFile");

                entity.HasIndex(e => e.RqFormActionLogId, "IX_FK_RqFormActionLogProcureFile");

                entity.Property(e => e.UploadDate).HasColumnType("datetime");

                entity.HasOne(d => d.AgreementForm)
                    .WithMany(p => p.ProcureFiles)
                    .HasForeignKey(d => d.AgreementFormId)
                    .HasConstraintName("FK_AgreementFormProcureFile");

                entity.HasOne(d => d.ApproveForm)
                    .WithMany(p => p.ProcureFiles)
                    .HasForeignKey(d => d.ApproveFormId)
                    .HasConstraintName("FK_ApproveFormProcureFile");

                entity.HasOne(d => d.CheckForm)
                    .WithMany(p => p.ProcureFiles)
                    .HasForeignKey(d => d.CheckFormId)
                    .HasConstraintName("FK_CheckFormProcureFile");

                entity.HasOne(d => d.OrderForm)
                    .WithMany(p => p.ProcureFiles)
                    .HasForeignKey(d => d.OrderFormId)
                    .HasConstraintName("FK_OrderFormProcureFile");

                entity.HasOne(d => d.ProcureContract)
                    .WithMany(p => p.ProcureFiles)
                    .HasForeignKey(d => d.ProcureContractId)
                    .HasConstraintName("FK_ProcureContractProcureFile");

                entity.HasOne(d => d.RegisterDurableItem)
                    .WithMany(p => p.ProcureFiles)
                    .HasForeignKey(d => d.RegisterDurableItemId)
                    .HasConstraintName("FK_RegisterDurableItemProcureFile");

                entity.HasOne(d => d.RegisterItemCheckRecord)
                    .WithMany(p => p.ProcureFiles)
                    .HasForeignKey(d => d.RegisterItemCheckRecordId)
                    .HasConstraintName("FK_RegisterItemCheckRecordProcureFile");

                entity.HasOne(d => d.RequestForm)
                    .WithMany(p => p.ProcureFiles)
                    .HasForeignKey(d => d.RequestFormId)
                    .HasConstraintName("FK_RequestFormProcureFile");

                entity.HasOne(d => d.RqFormActionLog)
                    .WithMany(p => p.ProcureFiles)
                    .HasForeignKey(d => d.RqFormActionLogId)
                    .HasConstraintName("FK_RqFormActionLogProcureFile");
            });

            modelBuilder.Entity<ProcureLoaningCancelForm>(entity =>
            {
                entity.ToTable("ProcureLoaningCancelForms", "Procure");

                entity.HasIndex(e => e.ProcureLoaningMemoFormId, "IX_FK_ProcureLoaningMemoFormProcureLoaningCancelForm");

                entity.Property(e => e.CancelDate).HasColumnType("datetime");

                entity.Property(e => e.StatementCalculationDate).HasColumnType("datetime");

                entity.HasOne(d => d.ProcureLoaningMemoForm)
                    .WithMany(p => p.ProcureLoaningCancelForms)
                    .HasForeignKey(d => d.ProcureLoaningMemoFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureLoaningMemoFormProcureLoaningCancelForm");
            });

            modelBuilder.Entity<ProcureLoaningFormActionLog>(entity =>
            {
                entity.ToTable("ProcureLoaningFormActionLogs", "Procure");

                entity.HasIndex(e => e.ProcureLoaningMemoFormId, "IX_FK_ProcureLoaningMemoFormProcureLoaningFormActionLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.Ip).HasColumnName("IP");

                entity.Property(e => e.ReturnDeadline).HasColumnType("datetime");

                entity.Property(e => e.ReturnReasonValue).HasDefaultValueSql("('')");

                entity.HasOne(d => d.ProcureLoaningMemoForm)
                    .WithMany(p => p.ProcureLoaningFormActionLogs)
                    .HasForeignKey(d => d.ProcureLoaningMemoFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureLoaningMemoFormProcureLoaningFormActionLog");
            });

            modelBuilder.Entity<ProcureLoaningItem>(entity =>
            {
                entity.ToTable("ProcureLoaningItems", "Procure");

                entity.HasIndex(e => e.ApproveItemId, "IX_FK_ApproveItemProcureLoaningItem");

                entity.HasIndex(e => e.ProcureLoaningCancelFormId, "IX_FK_ProcureLoaningCancelFormProcureLoaningItem");

                entity.HasIndex(e => e.ProcureLoaningMemoFormId, "IX_FK_ProcureLoaningMemoFormProcureLoaningItem");

                entity.HasIndex(e => e.ProcureLoaningReturnFormId, "IX_FK_ProcureLoaningReturnFormProcureLoaningItem");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.CancelAmount)
                    .HasColumnType("decimal(15, 5)")
                    .HasDefaultValueSql("((0.00000))");

                entity.Property(e => e.CancelBudget)
                    .HasColumnType("decimal(15, 5)")
                    .HasDefaultValueSql("((0.00000))");

                entity.Property(e => e.ChangedAmountOld)
                    .HasColumnType("decimal(15, 5)")
                    .HasColumnName("ChangedAmount_Old");

                entity.Property(e => e.EstimateUsedAmount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.EstimateUsedBudget).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.FinishSettleFormWriteDate).HasColumnType("datetime");

                entity.Property(e => e.FinishTransformDate).HasColumnType("datetime");

                entity.Property(e => e.IsBorrow)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PaidPricePerPieceOld)
                    .HasColumnType("decimal(15, 5)")
                    .HasColumnName("PaidPricePerPiece_Old");

                entity.Property(e => e.PricePerPiece).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.ProcureSettleMemoFormIdOld).HasColumnName("ProcureSettleMemoFormId_Old");

                entity.Property(e => e.ReturnAmount)
                    .HasColumnType("decimal(15, 5)")
                    .HasDefaultValueSql("((0.00000))");

                entity.Property(e => e.ReturnBudget)
                    .HasColumnType("decimal(15, 5)")
                    .HasDefaultValueSql("((0.00000))");

                entity.Property(e => e.SettleAmountOld)
                    .HasColumnType("decimal(15, 5)")
                    .HasColumnName("SettleAmount_Old");

                entity.Property(e => e.SettleApprovalStatusEnumOld).HasColumnName("SettleApprovalStatusEnum_Old");

                entity.Property(e => e.SettleApprovedDateOld)
                    .HasColumnType("datetime")
                    .HasColumnName("SettleApprovedDate_Old");

                entity.Property(e => e.SettleDateOld)
                    .HasColumnType("datetime")
                    .HasColumnName("SettleDate_Old");

                entity.HasOne(d => d.ApproveItem)
                    .WithMany(p => p.ProcureLoaningItems)
                    .HasForeignKey(d => d.ApproveItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApproveItemProcureLoaningItem");

                entity.HasOne(d => d.ProcureLoaningCancelForm)
                    .WithMany(p => p.ProcureLoaningItems)
                    .HasForeignKey(d => d.ProcureLoaningCancelFormId)
                    .HasConstraintName("FK_ProcureLoaningCancelFormProcureLoaningItem");

                entity.HasOne(d => d.ProcureLoaningMemoForm)
                    .WithMany(p => p.ProcureLoaningItems)
                    .HasForeignKey(d => d.ProcureLoaningMemoFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureLoaningMemoFormProcureLoaningItem");

                entity.HasOne(d => d.ProcureLoaningReturnForm)
                    .WithMany(p => p.ProcureLoaningItems)
                    .HasForeignKey(d => d.ProcureLoaningReturnFormId)
                    .HasConstraintName("FK_ProcureLoaningReturnFormProcureLoaningItem");
            });

            modelBuilder.Entity<ProcureLoaningItemPlanReferenceItem>(entity =>
            {
                entity.ToTable("ProcureLoaningItemPlanReferenceItems", "Procure");

                entity.HasIndex(e => e.ProcureLoaningItemId, "IX_FK_ProcureLoaningItemProcureLoaningItemPlanReferenceItem");

                entity.HasIndex(e => e.ProcureLoaningMemoFormId, "IX_FK_ProcureLoaningMemoFormProcureLoaningItemPlanReferenceItem");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 5)");

                entity.HasOne(d => d.ProcureLoaningItem)
                    .WithMany(p => p.ProcureLoaningItemPlanReferenceItems)
                    .HasForeignKey(d => d.ProcureLoaningItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureLoaningItemProcureLoaningItemPlanReferenceItem");

                entity.HasOne(d => d.ProcureLoaningMemoForm)
                    .WithMany(p => p.ProcureLoaningItemPlanReferenceItems)
                    .HasForeignKey(d => d.ProcureLoaningMemoFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureLoaningMemoFormProcureLoaningItemPlanReferenceItem");
            });

            modelBuilder.Entity<ProcureLoaningMemoForm>(entity =>
            {
                entity.ToTable("ProcureLoaningMemoForms", "Procure");

                entity.Property(e => e.ApproveFormDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverSignDate).HasColumnType("datetime");

                entity.Property(e => e.AttorneyName).HasDefaultValueSql("('')");

                entity.Property(e => e.AttorneySignDate).HasColumnType("datetime");

                entity.Property(e => e.BudgetCheckerSignDate).HasColumnType("datetime");

                entity.Property(e => e.BudgetTypeName).HasDefaultValueSql("('')");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Detail).HasDefaultValueSql("('')");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.LoaningAmount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.OperationSummary).HasDefaultValueSql("('')");

                entity.Property(e => e.OtherRequest).HasDefaultValueSql("('')");

                entity.Property(e => e.PlanActivityIdOld).HasColumnName("PlanActivityId_Old");

                entity.Property(e => e.PlanActivityName).HasDefaultValueSql("('')");

                entity.Property(e => e.PlanFormApprovalStatusEnum).HasDefaultValueSql("((10))");

                entity.Property(e => e.PlanItemName).HasDefaultValueSql("('')");

                entity.Property(e => e.RefDocumentDate).HasColumnType("datetime");

                entity.Property(e => e.RefDocumentNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.RelatedRegulation).HasDefaultValueSql("('')");

                entity.Property(e => e.RequestFormDate).HasColumnType("datetime");

                entity.Property(e => e.RequestFormTotalBudget)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.RequesterSignDate).HasColumnType("datetime");

                entity.Property(e => e.SettleDate).HasColumnType("datetime");

                entity.Property(e => e.SettleDay).HasDefaultValueSql("((15))");

                entity.Property(e => e.StaffContactNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.StaffDepartmentName).HasDefaultValueSql("('')");

                entity.Property(e => e.StaffPositionName).HasDefaultValueSql("('')");

                entity.Property(e => e.StartCountingDate).HasColumnType("datetime");

                entity.Property(e => e.StatementCalculationDate).HasColumnType("datetime");

                entity.Property(e => e.StatementPayStatusEnum).HasDefaultValueSql("((20))");

                entity.Property(e => e.SummaryStatementByPlanCoreValue).HasDefaultValueSql("('')");

                entity.Property(e => e.SuppliesUnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.UnitChiefName).HasDefaultValueSql("('')");

                entity.Property(e => e.UnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProcureLoaningReturnForm>(entity =>
            {
                entity.ToTable("ProcureLoaningReturnForms", "Procure");

                entity.HasIndex(e => e.ProcureLoaningMemoFormId, "IX_FK_ProcureLoaningMemoFormProcureLoaningReturnForm");

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");

                entity.Property(e => e.StatementCalculationDate).HasColumnType("datetime");

                entity.HasOne(d => d.ProcureLoaningMemoForm)
                    .WithMany(p => p.ProcureLoaningReturnForms)
                    .HasForeignKey(d => d.ProcureLoaningMemoFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureLoaningMemoFormProcureLoaningReturnForm");
            });

            modelBuilder.Entity<ProcureLoaningSettleItem>(entity =>
            {
                entity.ToTable("ProcureLoaningSettleItems", "Procure");

                entity.HasIndex(e => e.ProcureLoaningItemId, "IX_FK_ProcureLoaningItemProcureLoaningSettleItem");

                entity.HasIndex(e => e.ProcureSettleMemoFormId, "IX_FK_ProcureSettleMemoFormProcureLoaningSettleItem");

                entity.HasIndex(e => e.ProcureSettleReceiptItemId, "IX_FK_ProcureSettleReceiptItemProcureLoaningSettleItem");

                entity.Property(e => e.SettleAmount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.SettleMoney).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.SettleMoneyAsBudget).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.WithdrawnAmountAtDate).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.WithdrawnMoneyAtDate).HasColumnType("decimal(15, 5)");

                entity.HasOne(d => d.ProcureLoaningItem)
                    .WithMany(p => p.ProcureLoaningSettleItems)
                    .HasForeignKey(d => d.ProcureLoaningItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureLoaningItemProcureLoaningSettleItem");

                entity.HasOne(d => d.ProcureSettleMemoForm)
                    .WithMany(p => p.ProcureLoaningSettleItems)
                    .HasForeignKey(d => d.ProcureSettleMemoFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureSettleMemoFormProcureLoaningSettleItem");

                entity.HasOne(d => d.ProcureSettleReceiptItem)
                    .WithMany(p => p.ProcureLoaningSettleItems)
                    .HasForeignKey(d => d.ProcureSettleReceiptItemId)
                    .HasConstraintName("FK_ProcureSettleReceiptItemProcureLoaningSettleItem");
            });

            modelBuilder.Entity<ProcureLoaningWithdrawalForm>(entity =>
            {
                entity.ToTable("ProcureLoaningWithdrawalForms", "Procure");

                entity.HasIndex(e => e.ProcureLoaningMemoFormId, "IX_FK_ProcureLoaningMemoFormProcureLoaningWithdrawalForm");

                entity.Property(e => e.Borrower).HasDefaultValueSql("('')");

                entity.Property(e => e.BorrowerHrDepartmentName).HasDefaultValueSql("('')");

                entity.Property(e => e.BorrowerHrdepartmentId).HasColumnName("BorrowerHRDepartmentId");

                entity.Property(e => e.Payee).HasDefaultValueSql("('')");

                entity.Property(e => e.PayeeHrDepartmentName).HasDefaultValueSql("('')");

                entity.Property(e => e.PayeeHrdepartmentId).HasColumnName("PayeeHRDepartmentId");

                entity.Property(e => e.StatementCalculationDate).HasColumnType("datetime");

                entity.Property(e => e.WithdrawnDate).HasColumnType("datetime");

                entity.HasOne(d => d.ProcureLoaningMemoForm)
                    .WithMany(p => p.ProcureLoaningWithdrawalForms)
                    .HasForeignKey(d => d.ProcureLoaningMemoFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureLoaningMemoFormProcureLoaningWithdrawalForm");
            });

            modelBuilder.Entity<ProcureLoaningWithdrawalFormPlanView>(entity =>
            {
                entity.ToTable("ProcureLoaningWithdrawalFormPlanViews", "Plan");

                entity.HasIndex(e => e.RequestFormPlanViewId, "IX_FK_RequestFormPlanViewProcureLoaningWithdrawalFormPlanView");

                entity.Property(e => e.ChangedPlanItemWithdrawalItemsDataListValue2).HasDefaultValueSql("('')");

                entity.Property(e => e.MoneyAmount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.NetPayValue).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.ProceedDate).HasColumnType("datetime");

                entity.Property(e => e.StatementCalculationDate).HasColumnType("datetime");

                entity.Property(e => e.WithdrawalItemsDataListValue).HasDefaultValueSql("('')");

                entity.HasOne(d => d.RequestFormPlanView)
                    .WithMany(p => p.ProcureLoaningWithdrawalFormPlanViews)
                    .HasForeignKey(d => d.RequestFormPlanViewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestFormPlanViewProcureLoaningWithdrawalFormPlanView");
            });

            modelBuilder.Entity<ProcureLoaningWithdrawalItem>(entity =>
            {
                entity.ToTable("ProcureLoaningWithdrawalItems", "Procure");

                entity.HasIndex(e => e.ProcureLoaningItemId, "IX_FK_ProcureLoaningItemProcureLoaningWithdrawalItem");

                entity.HasIndex(e => e.ProcureLoaningMemoFormId, "IX_FK_ProcureLoaningMemoFormProcureLoaningWithdrawalItem");

                entity.HasIndex(e => e.ProcureLoaningSettleItemId, "IX_FK_ProcureLoaningSettleItemProcureLoaningWithdrawalItem");

                entity.HasIndex(e => e.ProcureLoaningWithdrawalFormId, "IX_FK_ProcureLoaningWithdrawalFormProcureLoaningWithdrawalItem");

                entity.HasIndex(e => e.ProcureSettleReceiptItemId, "IX_FK_ProcureSettleReceiptItemProcureLoaningWithdrawalItem");

                entity.Property(e => e.TotalAmountAtDate).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.WithdrawableAmountAtDate).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.WithdrawableBudgetAtDate).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.WithdrawnAmount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.WithdrawnMoney).HasColumnType("decimal(15, 5)");

                entity.HasOne(d => d.ProcureLoaningItem)
                    .WithMany(p => p.ProcureLoaningWithdrawalItems)
                    .HasForeignKey(d => d.ProcureLoaningItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureLoaningItemProcureLoaningWithdrawalItem");

                entity.HasOne(d => d.ProcureLoaningMemoForm)
                    .WithMany(p => p.ProcureLoaningWithdrawalItems)
                    .HasForeignKey(d => d.ProcureLoaningMemoFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureLoaningMemoFormProcureLoaningWithdrawalItem");

                entity.HasOne(d => d.ProcureLoaningSettleItem)
                    .WithMany(p => p.ProcureLoaningWithdrawalItems)
                    .HasForeignKey(d => d.ProcureLoaningSettleItemId)
                    .HasConstraintName("FK_ProcureLoaningSettleItemProcureLoaningWithdrawalItem");

                entity.HasOne(d => d.ProcureLoaningWithdrawalForm)
                    .WithMany(p => p.ProcureLoaningWithdrawalItems)
                    .HasForeignKey(d => d.ProcureLoaningWithdrawalFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureLoaningWithdrawalFormProcureLoaningWithdrawalItem");

                entity.HasOne(d => d.ProcureSettleReceiptItem)
                    .WithMany(p => p.ProcureLoaningWithdrawalItems)
                    .HasForeignKey(d => d.ProcureSettleReceiptItemId)
                    .HasConstraintName("FK_ProcureSettleReceiptItemProcureLoaningWithdrawalItem");
            });

            modelBuilder.Entity<ProcureRepairForm>(entity =>
            {
                entity.ToTable("ProcureRepairForms", "Procure");

                entity.HasIndex(e => e.RegisterDurableItemId, "IX_FK_RegisterDurableItemProcureRepairForm");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.CheckChairman).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckFirstComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckSecondComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckerSignDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ProcureApprovalStatusEnum).HasDefaultValueSql("((10))");

                entity.Property(e => e.RepairWarrantyDetail).HasDefaultValueSql("('')");

                entity.Property(e => e.RepairWarrantyDocumentNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.RepairWarrantyEndDate).HasColumnType("datetime");

                entity.Property(e => e.RepairWarrantyWriteDate).HasColumnType("datetime");

                entity.Property(e => e.RequesterSignDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.RegisterDurableItem)
                    .WithMany(p => p.ProcureRepairForms)
                    .HasForeignKey(d => d.RegisterDurableItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegisterDurableItemProcureRepairForm");
            });

            modelBuilder.Entity<ProcureRepairFormActionLog>(entity =>
            {
                entity.ToTable("ProcureRepairFormActionLogs", "Procure");

                entity.HasIndex(e => e.ProcureRepairFormId, "IX_FK_ProcureRepairFormProcureRepairFormActionLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.Ip).HasColumnName("IP");

                entity.HasOne(d => d.ProcureRepairForm)
                    .WithMany(p => p.ProcureRepairFormActionLogs)
                    .HasForeignKey(d => d.ProcureRepairFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureRepairFormProcureRepairFormActionLog");
            });

            modelBuilder.Entity<ProcureSeFormActionLog>(entity =>
            {
                entity.ToTable("ProcureSeFormActionLogs", "Procure");

                entity.HasIndex(e => e.ProcureSettleMemoFormId, "IX_FK_ProcureSettleMemoFormProcureSeFormActionLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.Detail).HasDefaultValueSql("('')");

                entity.Property(e => e.Ip).HasColumnName("IP");

                entity.Property(e => e.ReturnDeadline).HasColumnType("datetime");

                entity.Property(e => e.ReturnReasonValue).HasDefaultValueSql("('')");

                entity.HasOne(d => d.ProcureSettleMemoForm)
                    .WithMany(p => p.ProcureSeFormActionLogs)
                    .HasForeignKey(d => d.ProcureSettleMemoFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureSettleMemoFormProcureSeFormActionLog");
            });

            modelBuilder.Entity<ProcureSettleMemoForm>(entity =>
            {
                entity.ToTable("ProcureSettleMemoForms", "Procure");

                entity.HasIndex(e => e.ProcureLoaningMemoFormId, "IX_FK_ProcureLoaningMemoFormProcureSettleMemoForm");

                entity.Property(e => e.ApproveFormDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverSignDate).HasColumnType("datetime");

                entity.Property(e => e.BudgetCheckerSignDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.OperationSummary).HasDefaultValueSql("('')");

                entity.Property(e => e.OtherRequest).HasDefaultValueSql("('')");

                entity.Property(e => e.PlanActivityIdOld).HasColumnName("PlanActivityId_Old");

                entity.Property(e => e.PlanFormApprovalStatusEnum).HasDefaultValueSql("((10))");

                entity.Property(e => e.RelatedRegulation).HasDefaultValueSql("('')");

                entity.Property(e => e.RequesterSignDate).HasColumnType("datetime");

                entity.Property(e => e.StatementCalculationDate).HasColumnType("datetime");

                entity.Property(e => e.StatementPayStatusEnum).HasDefaultValueSql("((20))");

                entity.Property(e => e.SummaryStatementByPlanItem).HasDefaultValueSql("('')");

                entity.Property(e => e.SuppliesUnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.ProcureLoaningMemoForm)
                    .WithMany(p => p.ProcureSettleMemoForms)
                    .HasForeignKey(d => d.ProcureLoaningMemoFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureLoaningMemoFormProcureSettleMemoForm");
            });

            modelBuilder.Entity<ProcureSettleReceiptForm>(entity =>
            {
                entity.ToTable("ProcureSettleReceiptForms", "Procure");

                entity.HasIndex(e => e.ProcureLoaningMemoFormId, "IX_FK_ProcureLoaningMemoFormProcureSettleReceiptForm");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.BudgetCheckerSignDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.NetPayValue).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.RequesterSignDate).HasColumnType("datetime");

                entity.Property(e => e.StatementCalculationDate).HasColumnType("datetime");

                entity.Property(e => e.SummaryStatementByPlanItem).HasDefaultValueSql("('')");

                entity.Property(e => e.UnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.ProcureLoaningMemoForm)
                    .WithMany(p => p.ProcureSettleReceiptForms)
                    .HasForeignKey(d => d.ProcureLoaningMemoFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureLoaningMemoFormProcureSettleReceiptForm");
            });

            modelBuilder.Entity<ProcureSettleReceiptFormPlanView>(entity =>
            {
                entity.ToTable("ProcureSettleReceiptFormPlanViews", "Plan");

                entity.HasIndex(e => e.ProcureLoaningWithdrawalFormPlanViewId, "IX_FK_ProcureLoaningWithdrawalFormPlanViewProcureSettleReceiptFormPlanView");

                entity.Property(e => e.NetPayValue).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.StatementCalculationDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.ProcureLoaningWithdrawalFormPlanView)
                    .WithMany(p => p.ProcureSettleReceiptFormPlanViews)
                    .HasForeignKey(d => d.ProcureLoaningWithdrawalFormPlanViewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureLoaningWithdrawalFormPlanViewProcureSettleReceiptFormPlanView");
            });

            modelBuilder.Entity<ProcureSettleReceiptItem>(entity =>
            {
                entity.ToTable("ProcureSettleReceiptItems", "Procure");

                entity.HasIndex(e => e.ProcureLoaningItemId, "IX_FK_ProcureLoaningItemProcureSettleReceiptItem");

                entity.HasIndex(e => e.ProcureSettleReceiptFormId, "IX_FK_ProcureSettleReceiptFormProcureSettleReceiptItem");

                entity.Property(e => e.SettleAmount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.SettleMoney).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.SettleMoneyAsBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.TotalGeneralExpenseAtDate).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.UsedBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.WithdrawnAmountAtDate).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.WithdrawnMoneyAtDate).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.ProcureLoaningItem)
                    .WithMany(p => p.ProcureSettleReceiptItems)
                    .HasForeignKey(d => d.ProcureLoaningItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureLoaningItemProcureSettleReceiptItem");

                entity.HasOne(d => d.ProcureSettleReceiptForm)
                    .WithMany(p => p.ProcureSettleReceiptItems)
                    .HasForeignKey(d => d.ProcureSettleReceiptFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureSettleReceiptFormProcureSettleReceiptItem");
            });

            modelBuilder.Entity<ProcureSettleReceiptItemPlanView>(entity =>
            {
                entity.ToTable("ProcureSettleReceiptItemPlanViews", "Plan");

                entity.HasIndex(e => e.ProcureSettleReceiptFormPlanViewId, "IX_FK_ProcureSettleReceiptFormPlanViewProcureSettleReceiptItemPlanView");

                entity.HasIndex(e => e.RequestViewUsedPlanItemId, "IX_FK_RequestViewUsedPlanItemProcureSettleReceiptItemPlanView");

                entity.Property(e => e.SettleAmount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.SettleMoney).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.SettleMoneyAsBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.UsedBudget).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.ProcureSettleReceiptFormPlanView)
                    .WithMany(p => p.ProcureSettleReceiptItemPlanViews)
                    .HasForeignKey(d => d.ProcureSettleReceiptFormPlanViewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureSettleReceiptFormPlanViewProcureSettleReceiptItemPlanView");

                entity.HasOne(d => d.RequestViewUsedPlanItem)
                    .WithMany(p => p.ProcureSettleReceiptItemPlanViews)
                    .HasForeignKey(d => d.RequestViewUsedPlanItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestViewUsedPlanItemProcureSettleReceiptItemPlanView");
            });

            modelBuilder.Entity<ProcureStoreLocation>(entity =>
            {
                entity.ToTable("ProcureStoreLocations", "Procure");

                entity.HasIndex(e => e.ParentProcureStoreLocationId, "IX_FK_ProcureStoreLocationParentProcureStoreLocation");

                entity.Property(e => e.CanvasPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.Code).HasDefaultValueSql("('')");

                entity.Property(e => e.Detail).HasDefaultValueSql("('')");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.ImagePath).HasDefaultValueSql("('')");

                entity.HasOne(d => d.ParentProcureStoreLocation)
                    .WithMany(p => p.InverseParentProcureStoreLocation)
                    .HasForeignKey(d => d.ParentProcureStoreLocationId)
                    .HasConstraintName("FK_ProcureStoreLocationParentProcureStoreLocation");
            });

            modelBuilder.Entity<ProcureTrackingAction>(entity =>
            {
                entity.ToTable("ProcureTrackingActions", "Operation");

                entity.HasIndex(e => e.ProcureTrackingGroupId, "IX_FK_ProcureTrackingGroupProcureTrackingAction");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EndPauseDate).HasColumnType("datetime");

                entity.Property(e => e.ProcureFormDocNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.SpecificEndDate).HasColumnType("datetime");

                entity.Property(e => e.StartPauseDate).HasColumnType("datetime");

                entity.HasOne(d => d.ProcureTrackingGroup)
                    .WithMany(p => p.ProcureTrackingActions)
                    .HasForeignKey(d => d.ProcureTrackingGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureTrackingGroupProcureTrackingAction");
            });

            modelBuilder.Entity<ProcureTrackingBaseItem>(entity =>
            {
                entity.ToTable("ProcureTrackingBaseItems", "Operation");

                entity.Property(e => e.Amount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.HasTor).HasColumnName("HasTOR");

                entity.Property(e => e.PricePerPiece).HasColumnType("decimal(12, 2)");

                entity.HasMany(d => d.ProcureTrackingGroups)
                    .WithMany(p => p.ProcureTrackingBaseItems)
                    .UsingEntity<Dictionary<string, object>>(
                        "ProcureTrackingBaseItemProcureTrackingGroup",
                        l => l.HasOne<ProcureTrackingGroup>().WithMany().HasForeignKey("ProcureTrackingGroupsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ProcureTrackingBaseItemProcureTrackingGroup_ProcureTrackingGroup"),
                        r => r.HasOne<ProcureTrackingBaseItem>().WithMany().HasForeignKey("ProcureTrackingBaseItemsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ProcureTrackingBaseItemProcureTrackingGroup_ProcureTrackingBaseItem"),
                        j =>
                        {
                            j.HasKey("ProcureTrackingBaseItemsId", "ProcureTrackingGroupsId");

                            j.ToTable("ProcureTrackingBaseItemProcureTrackingGroup", "Operation");

                            j.HasIndex(new[] { "ProcureTrackingGroupsId" }, "IX_FK_ProcureTrackingBaseItemProcureTrackingGroup_ProcureTrackingGroup");

                            j.IndexerProperty<int>("ProcureTrackingBaseItemsId").HasColumnName("ProcureTrackingBaseItems_Id");

                            j.IndexerProperty<int>("ProcureTrackingGroupsId").HasColumnName("ProcureTrackingGroups_Id");
                        });

                entity.HasMany(d => d.ProcureTrackingItems)
                    .WithMany(p => p.ProcureTrackingBaseItems)
                    .UsingEntity<Dictionary<string, object>>(
                        "ProcureTrackingBaseItemProcureTrackingItem",
                        l => l.HasOne<ProcureTrackingItem>().WithMany().HasForeignKey("ProcureTrackingItemsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ProcureTrackingBaseItemProcureTrackingItem_ProcureTrackingItem"),
                        r => r.HasOne<ProcureTrackingBaseItem>().WithMany().HasForeignKey("ProcureTrackingBaseItemsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ProcureTrackingBaseItemProcureTrackingItem_ProcureTrackingBaseItem"),
                        j =>
                        {
                            j.HasKey("ProcureTrackingBaseItemsId", "ProcureTrackingItemsId");

                            j.ToTable("ProcureTrackingBaseItemProcureTrackingItem", "Operation");

                            j.HasIndex(new[] { "ProcureTrackingItemsId" }, "IX_FK_ProcureTrackingBaseItemProcureTrackingItem_ProcureTrackingItem");

                            j.IndexerProperty<int>("ProcureTrackingBaseItemsId").HasColumnName("ProcureTrackingBaseItems_Id");

                            j.IndexerProperty<int>("ProcureTrackingItemsId").HasColumnName("ProcureTrackingItems_Id");
                        });
            });

            modelBuilder.Entity<ProcureTrackingGroup>(entity =>
            {
                entity.ToTable("ProcureTrackingGroups", "Operation");

                entity.HasMany(d => d.ProcureComitteeGroups)
                    .WithMany(p => p.ProcureTrackingGroups)
                    .UsingEntity<Dictionary<string, object>>(
                        "ProcureTrackingGroupProcureComitteeGroup",
                        l => l.HasOne<ProcureComitteeGroup>().WithMany().HasForeignKey("ProcureComitteeGroupsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ProcureTrackingGroupProcureComitteeGroup_ProcureComitteeGroup"),
                        r => r.HasOne<ProcureTrackingGroup>().WithMany().HasForeignKey("ProcureTrackingGroupsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ProcureTrackingGroupProcureComitteeGroup_ProcureTrackingGroup"),
                        j =>
                        {
                            j.HasKey("ProcureTrackingGroupsId", "ProcureComitteeGroupsId");

                            j.ToTable("ProcureTrackingGroupProcureComitteeGroup", "Operation");

                            j.HasIndex(new[] { "ProcureComitteeGroupsId" }, "IX_FK_ProcureTrackingGroupProcureComitteeGroup_ProcureComitteeGroup");

                            j.IndexerProperty<int>("ProcureTrackingGroupsId").HasColumnName("ProcureTrackingGroups_Id");

                            j.IndexerProperty<int>("ProcureComitteeGroupsId").HasColumnName("ProcureComitteeGroups_Id");
                        });
            });

            modelBuilder.Entity<ProcureTrackingItem>(entity =>
            {
                entity.ToTable("ProcureTrackingItems", "Operation");

                entity.HasIndex(e => e.ProcureTrackingGroupId, "IX_FK_ProcureTrackingGroupProcureTrackingItem");

                entity.Property(e => e.Amount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.PricePerPiece).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.ProcureTrackingGroup)
                    .WithMany(p => p.ProcureTrackingItems)
                    .HasForeignKey(d => d.ProcureTrackingGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureTrackingGroupProcureTrackingItem");
            });

            modelBuilder.Entity<ProcureTrackingRefForm>(entity =>
            {
                entity.ToTable("ProcureTrackingRefForms", "Operation");

                entity.HasIndex(e => e.ProcureTrackingActionId, "IX_FK_ProcureTrackingActionProcureTrackingRefForm");

                entity.HasIndex(e => e.ProcureTrackingGroupId, "IX_FK_ProcureTrackingGroupProcureTrackingRefForm");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.ProcureTrackingAction)
                    .WithMany(p => p.ProcureTrackingRefForms)
                    .HasForeignKey(d => d.ProcureTrackingActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureTrackingActionProcureTrackingRefForm");

                entity.HasOne(d => d.ProcureTrackingGroup)
                    .WithMany(p => p.ProcureTrackingRefForms)
                    .HasForeignKey(d => d.ProcureTrackingGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureTrackingGroupProcureTrackingRefForm");
            });

            modelBuilder.Entity<ProcureTrackingRefItem>(entity =>
            {
                entity.ToTable("ProcureTrackingRefItems", "Operation");

                entity.HasIndex(e => e.ProcureTrackingItemId, "IX_FK_ProcureTrackingItemProcureTrackingRefItem");

                entity.HasIndex(e => e.ProcureTrackingRefFormId, "IX_FK_ProcureTrackingRefFormProcureTrackingRefItem");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.PricePerPiece).HasColumnType("decimal(15, 5)");

                entity.HasOne(d => d.ProcureTrackingItem)
                    .WithMany(p => p.ProcureTrackingRefItems)
                    .HasForeignKey(d => d.ProcureTrackingItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureTrackingItemProcureTrackingRefItem");

                entity.HasOne(d => d.ProcureTrackingRefForm)
                    .WithMany(p => p.ProcureTrackingRefItems)
                    .HasForeignKey(d => d.ProcureTrackingRefFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcureTrackingRefFormProcureTrackingRefItem");
            });

            modelBuilder.Entity<Quotation>(entity =>
            {
                entity.ToTable("Quotations", "Procure");

                entity.HasIndex(e => e.OrderFormId, "IX_FK_OrderFormQuotation");

                entity.HasIndex(e => e.SupplierId, "IX_FK_SupplierQuotation");

                entity.Property(e => e.Price).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.OrderForm)
                    .WithMany(p => p.Quotations)
                    .HasForeignKey(d => d.OrderFormId)
                    .HasConstraintName("FK_OrderFormQuotation");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Quotations)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_SupplierQuotation");
            });

            modelBuilder.Entity<Race>(entity =>
            {
                entity.ToTable("Races", "HR");
            });

            modelBuilder.Entity<Receiver>(entity =>
            {
                entity.ToTable("Receivers", "Filing");

                entity.HasIndex(e => e.FilingDocumentId, "IX_FK_FilingDocumentReceiver");

                entity.HasIndex(e => e.MessageId, "IX_FK_MessageReceiver");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.HrdepartmentName).HasColumnName("HRDepartmentName");

                entity.Property(e => e.IsCc).HasColumnName("IsCC");

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.ReceivedIp).HasColumnName("ReceivedIP");

                entity.Property(e => e.RoleActionDate).HasColumnType("datetime");

                entity.Property(e => e.RoleActionIp).HasColumnName("RoleActionIP");

                entity.Property(e => e.RoleActionShowDate).HasColumnType("datetime");

                entity.HasOne(d => d.FilingDocument)
                    .WithMany(p => p.Receivers)
                    .HasForeignKey(d => d.FilingDocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FilingDocumentReceiver");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.Receivers)
                    .HasForeignKey(d => d.MessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MessageReceiver");
            });

            modelBuilder.Entity<RegDurableItemActionLog>(entity =>
            {
                entity.ToTable("RegDurableItemActionLogs", "Procure");

                entity.HasIndex(e => e.RegisterDurableItemId, "IX_FK_RegisterDurableItemRegDurableItemActionLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.Ip).HasColumnName("IP");

                entity.HasOne(d => d.RegisterDurableItem)
                    .WithMany(p => p.RegDurableItemActionLogs)
                    .HasForeignKey(d => d.RegisterDurableItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegisterDurableItemRegDurableItemActionLog");
            });

            modelBuilder.Entity<RegItemTransferFormActionLog>(entity =>
            {
                entity.ToTable("RegItemTransferFormActionLogs", "Procure");

                entity.HasIndex(e => e.RegisterItemTransferFormId, "IX_FK_RegisterItemTransferFormRegItemTransferFormActionLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.Ip).HasColumnName("IP");

                entity.HasOne(d => d.RegisterItemTransferForm)
                    .WithMany(p => p.RegItemTransferFormActionLogs)
                    .HasForeignKey(d => d.RegisterItemTransferFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegisterItemTransferFormRegItemTransferFormActionLog");
            });

            modelBuilder.Entity<RegisterDurableItem>(entity =>
            {
                entity.ToTable("RegisterDurableItems", "Procure");

                entity.HasIndex(e => e.ProcureStoreLocationId, "IX_FK_ProcureStoreLocationRegisterDurableItem");

                entity.HasIndex(e => e.RegisterItemDisposedFormId, "IX_FK_RegisterItemDisposedFormRegisterDurableItem");

                entity.HasIndex(e => e.RegisterProcureItemId, "IX_FK_RegisterProcureItemRegisterDurableItem");

                entity.HasIndex(e => e.RegisterProcureItemTypeId, "IX_FK_RegisterProcureItemTypeRegisterDurableItem");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DisposedRemark).HasDefaultValueSql("('')");

                entity.Property(e => e.DurableItemStatus).HasDefaultValueSql("((10))");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.HrdepartmentName)
                    .HasColumnName("HRDepartmentName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ItemBrand).HasDefaultValueSql("('')");

                entity.Property(e => e.ItemModel).HasDefaultValueSql("('')");

                entity.Property(e => e.PricePerPiece).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.RegisterCodeDate).HasColumnType("datetime");

                entity.Property(e => e.SerialNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.StoreLocation).HasDefaultValueSql("('')");

                entity.Property(e => e.SupplierName).HasDefaultValueSql("('')");

                entity.Property(e => e.SuppliesOfficerName).HasDefaultValueSql("('')");

                entity.HasOne(d => d.ProcureStoreLocation)
                    .WithMany(p => p.RegisterDurableItems)
                    .HasForeignKey(d => d.ProcureStoreLocationId)
                    .HasConstraintName("FK_ProcureStoreLocationRegisterDurableItem");

                entity.HasOne(d => d.RegisterItemDisposedForm)
                    .WithMany(p => p.RegisterDurableItems)
                    .HasForeignKey(d => d.RegisterItemDisposedFormId)
                    .HasConstraintName("FK_RegisterItemDisposedFormRegisterDurableItem");

                entity.HasOne(d => d.RegisterProcureItem)
                    .WithMany(p => p.RegisterDurableItems)
                    .HasForeignKey(d => d.RegisterProcureItemId)
                    .HasConstraintName("FK_RegisterProcureItemRegisterDurableItem");

                entity.HasOne(d => d.RegisterProcureItemType)
                    .WithMany(p => p.RegisterDurableItems)
                    .HasForeignKey(d => d.RegisterProcureItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegisterProcureItemTypeRegisterDurableItem");
            });

            modelBuilder.Entity<RegisterItemCheckForm>(entity =>
            {
                entity.ToTable("RegisterItemCheckForms", "Procure");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RegisterItemCheckRecord>(entity =>
            {
                entity.ToTable("RegisterItemCheckRecords", "Procure");

                entity.HasIndex(e => e.RegisterDurableItemId, "IX_FK_RegisterDurableItemRegisterItemCheckRecord");

                entity.HasIndex(e => e.RegisterItemCheckFormId, "IX_FK_RegisterItemCheckFormRegisterItemCheckRecord");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.HasOne(d => d.RegisterDurableItem)
                    .WithMany(p => p.RegisterItemCheckRecords)
                    .HasForeignKey(d => d.RegisterDurableItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegisterDurableItemRegisterItemCheckRecord");

                entity.HasOne(d => d.RegisterItemCheckForm)
                    .WithMany(p => p.RegisterItemCheckRecords)
                    .HasForeignKey(d => d.RegisterItemCheckFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegisterItemCheckFormRegisterItemCheckRecord");
            });

            modelBuilder.Entity<RegisterItemDisposedForm>(entity =>
            {
                entity.ToTable("RegisterItemDisposedForms", "Procure");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RegisterItemTransferForm>(entity =>
            {
                entity.ToTable("RegisterItemTransferForms", "Procure");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.FromDepChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.FromDepUnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.ProcureApprovalStatusEnum).HasDefaultValueSql("((10))");

                entity.Property(e => e.SuppliesOfficerSignDate).HasColumnType("datetime");

                entity.Property(e => e.SuppliesUnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.ToDepChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.ToDepUnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RegisterItemTransferRecord>(entity =>
            {
                entity.ToTable("RegisterItemTransferRecords", "Procure");

                entity.HasIndex(e => e.FromProcureStoreLocationId, "IX_FK_FromProcureStoreLocationRegisterItemTransferRecord");

                entity.HasIndex(e => e.RegisterDurableItemId, "IX_FK_RegisterDurableItemRegisterItemTransferRecord");

                entity.HasIndex(e => e.RegisterItemTransferFormId, "IX_FK_RegisterItemTransferFormRegisterItemTransferRecord");

                entity.HasIndex(e => e.ToProcureStoreLocationId, "IX_FK_ToProcureStoreLocationRegisterItemTransferRecord");

                entity.Property(e => e.FromHrdepartmentId).HasColumnName("FromHRDepartmentId");

                entity.Property(e => e.ToHrdepartmentId).HasColumnName("ToHRDepartmentId");

                entity.HasOne(d => d.FromProcureStoreLocation)
                    .WithMany(p => p.RegisterItemTransferRecordFromProcureStoreLocations)
                    .HasForeignKey(d => d.FromProcureStoreLocationId)
                    .HasConstraintName("FK_FromProcureStoreLocationRegisterItemTransferRecord");

                entity.HasOne(d => d.RegisterDurableItem)
                    .WithMany(p => p.RegisterItemTransferRecords)
                    .HasForeignKey(d => d.RegisterDurableItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegisterDurableItemRegisterItemTransferRecord");

                entity.HasOne(d => d.RegisterItemTransferForm)
                    .WithMany(p => p.RegisterItemTransferRecords)
                    .HasForeignKey(d => d.RegisterItemTransferFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegisterItemTransferFormRegisterItemTransferRecord");

                entity.HasOne(d => d.ToProcureStoreLocation)
                    .WithMany(p => p.RegisterItemTransferRecordToProcureStoreLocations)
                    .HasForeignKey(d => d.ToProcureStoreLocationId)
                    .HasConstraintName("FK_ToProcureStoreLocationRegisterItemTransferRecord");
            });

            modelBuilder.Entity<RegisterProcureItem>(entity =>
            {
                entity.ToTable("RegisterProcureItems", "Procure");

                entity.HasIndex(e => e.CheckItemId1, "IX_FK_CheckItemRegisterProcureItem");

                entity.HasIndex(e => e.ProcureLoaningItemId, "IX_FK_ProcureLoaningItemRegisterProcureItem");

                entity.HasIndex(e => e.ProcureLoaningSettleItemId, "IX_FK_ProcureLoaningSettleItemRegisterProcureItem");

                entity.HasIndex(e => e.RegisterProcureItemTypeId, "IX_FK_RegisterProcureItemTypeRegisterProcureItem");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.CheckItemId1).HasColumnName("CheckItem_Id");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.PricePerPiece).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.SupplierName).HasColumnName("Supplier_Name");

                entity.HasOne(d => d.CheckItemId1Navigation)
                    .WithMany(p => p.RegisterProcureItems)
                    .HasForeignKey(d => d.CheckItemId1)
                    .HasConstraintName("FK_CheckItemRegisterProcureItem");

                entity.HasOne(d => d.ProcureLoaningItem)
                    .WithMany(p => p.RegisterProcureItems)
                    .HasForeignKey(d => d.ProcureLoaningItemId)
                    .HasConstraintName("FK_ProcureLoaningItemRegisterProcureItem");

                entity.HasOne(d => d.ProcureLoaningSettleItem)
                    .WithMany(p => p.RegisterProcureItems)
                    .HasForeignKey(d => d.ProcureLoaningSettleItemId)
                    .HasConstraintName("FK_ProcureLoaningSettleItemRegisterProcureItem");

                entity.HasOne(d => d.RegisterProcureItemType)
                    .WithMany(p => p.RegisterProcureItems)
                    .HasForeignKey(d => d.RegisterProcureItemTypeId)
                    .HasConstraintName("FK_RegisterProcureItemTypeRegisterProcureItem");
            });

            modelBuilder.Entity<RegisterProcureItemType>(entity =>
            {
                entity.ToTable("RegisterProcureItemTypes", "Procure");

                entity.HasIndex(e => e.ParentRegisterProcureItemTypeId, "IX_FK_RegisterProcureItemTypeRegisterProcureItemType");

                entity.HasOne(d => d.ParentRegisterProcureItemType)
                    .WithMany(p => p.InverseParentRegisterProcureItemType)
                    .HasForeignKey(d => d.ParentRegisterProcureItemTypeId)
                    .HasConstraintName("FK_RegisterProcureItemTypeRegisterProcureItemType");
            });

            modelBuilder.Entity<RelativePerson>(entity =>
            {
                entity.ToTable("RelativePersons", "HR");

                entity.HasIndex(e => e.FamilialRelationshipId, "IX_FK_FamilialRelationshipRelativePerson");

                entity.HasIndex(e => e.NameTitleId, "IX_FK_NameTitleRelativePerson");

                entity.HasIndex(e => e.NationalityId, "IX_FK_NationalityRelativePerson");

                entity.HasIndex(e => e.RaceId, "IX_FK_RaceRelativePerson");

                entity.HasIndex(e => e.ReligionId, "IX_FK_ReligionRelativePerson");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffRelativePerson");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.IdcardNumber).HasColumnName("IDCardNumber");

                entity.Property(e => e.ImageUrl).HasColumnName("ImageURL");

                entity.Property(e => e.MobilePhoneNumber).HasMaxLength(50);

                entity.Property(e => e.Nickname).HasMaxLength(50);

                entity.HasOne(d => d.FamilialRelationship)
                    .WithMany(p => p.RelativePeople)
                    .HasForeignKey(d => d.FamilialRelationshipId)
                    .HasConstraintName("FK_FamilialRelationshipRelativePerson");

                entity.HasOne(d => d.NameTitle)
                    .WithMany(p => p.RelativePeople)
                    .HasForeignKey(d => d.NameTitleId)
                    .HasConstraintName("FK_NameTitleRelativePerson");

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.RelativePeople)
                    .HasForeignKey(d => d.NationalityId)
                    .HasConstraintName("FK_NationalityRelativePerson");

                entity.HasOne(d => d.Race)
                    .WithMany(p => p.RelativePeople)
                    .HasForeignKey(d => d.RaceId)
                    .HasConstraintName("FK_RaceRelativePerson");

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.RelativePeople)
                    .HasForeignKey(d => d.ReligionId)
                    .HasConstraintName("FK_ReligionRelativePerson");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.RelativePeople)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffRelativePerson");
            });

            modelBuilder.Entity<Religion>(entity =>
            {
                entity.ToTable("Religions", "HR");
            });

            modelBuilder.Entity<RequestAgreementItemTransform>(entity =>
            {
                entity.ToTable("RequestAgreementItemTransforms", "Procure");

                entity.HasIndex(e => e.AgreementItemId, "IX_FK_AgreementItemRequestAgreementItemTransform");

                entity.HasIndex(e => e.RequestItemId, "IX_FK_RequestItemRequestAgreementItemTransform");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 5)");

                entity.HasOne(d => d.AgreementItem)
                    .WithMany(p => p.RequestAgreementItemTransforms)
                    .HasForeignKey(d => d.AgreementItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AgreementItemRequestAgreementItemTransform");

                entity.HasOne(d => d.RequestItem)
                    .WithMany(p => p.RequestAgreementItemTransforms)
                    .HasForeignKey(d => d.RequestItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestItemRequestAgreementItemTransform");
            });

            modelBuilder.Entity<RequestApproveItemTransform>(entity =>
            {
                entity.ToTable("RequestApproveItemTransforms", "Procure");

                entity.HasIndex(e => e.ApproveItemId, "IX_FK_ApproveItemRequestApproveItemTransform");

                entity.HasIndex(e => e.RequestItemId, "IX_FK_RequestItemRequestApproveItemTransform");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 5)");

                entity.HasOne(d => d.ApproveItem)
                    .WithMany(p => p.RequestApproveItemTransforms)
                    .HasForeignKey(d => d.ApproveItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApproveItemRequestApproveItemTransform");

                entity.HasOne(d => d.RequestItem)
                    .WithMany(p => p.RequestApproveItemTransforms)
                    .HasForeignKey(d => d.RequestItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestItemRequestApproveItemTransform");
            });

            modelBuilder.Entity<RequestForm>(entity =>
            {
                entity.ToTable("RequestForms", "Procure");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.BudgetCheckerPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.BudgetCheckerSignDate).HasColumnType("datetime");

                entity.Property(e => e.BudgetTypeEnum).HasDefaultValueSql("((30))");

                entity.Property(e => e.CheckEighthComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckNinthComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckSecretaryAndComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckSeventhComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckSixthComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.CheckViceChairman).HasDefaultValueSql("('')");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.MedianPrice).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.PlanActivityIdOld).HasColumnName("PlanActivityId_Old");

                entity.Property(e => e.ProcureFormApprovalStatusEnum).HasDefaultValueSql("((10))");

                entity.Property(e => e.ProcureSecretaryAndComittee).HasDefaultValueSql("('')");

                entity.Property(e => e.ProcureViceChairman).HasDefaultValueSql("('')");

                entity.Property(e => e.ProjectManager).HasDefaultValueSql("('')");

                entity.Property(e => e.ProjectManagerPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.ProjectManagerSignDate).HasColumnType("datetime");

                entity.Property(e => e.RequestDepartmentName).HasDefaultValueSql("('')");

                entity.Property(e => e.RequesterPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.RequesterSignDate).HasColumnType("datetime");

                entity.Property(e => e.SuppliesOfficerPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.SuppliesUnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.Topic).HasDefaultValueSql("('')");

                entity.Property(e => e.UnitChiefPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.UnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.WithInDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RequestFormPlanView>(entity =>
            {
                entity.ToTable("RequestFormPlanViews", "Plan");

                entity.Property(e => e.ApprovalStatusEnum).HasDefaultValueSql("((10))");

                entity.Property(e => e.BudgetTypeName).HasDefaultValueSql("('')");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentName).HasDefaultValueSql("('')");

                entity.Property(e => e.FinishedTransformDate).HasColumnType("datetime");

                entity.Property(e => e.PlanActivityIdOld).HasColumnName("PlanActivityId_Old");

                entity.Property(e => e.PlanActivityName).HasDefaultValueSql("('')");

                entity.Property(e => e.PlanCoreName).HasDefaultValueSql("('')");

                entity.Property(e => e.PlanTypeName).HasDefaultValueSql("('')");

                entity.Property(e => e.RequestDepartmentName).HasDefaultValueSql("('')");

                entity.Property(e => e.ReserveByStaffName).HasDefaultValueSql("('')");

                entity.Property(e => e.ReserveDate).HasColumnType("datetime");

                entity.Property(e => e.ReserveDepartmentName).HasDefaultValueSql("('')");

                entity.Property(e => e.ReserveForecastValue).HasDefaultValueSql("('')");

                entity.Property(e => e.ReserveRemark).HasDefaultValueSql("('')");

                entity.Property(e => e.StatementCalculationDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasMany(d => d.CheckFormPlanViewsNavigation)
                    .WithMany(p => p.RequestFormPlanViews)
                    .UsingEntity<Dictionary<string, object>>(
                        "RequestFormPlanViewsCheckFormPlanView",
                        l => l.HasOne<CheckFormPlanView>().WithMany().HasForeignKey("CheckFormPlanViewsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_RequestFormPlanViewsCheckFormPlanViews_CheckFormPlanView"),
                        r => r.HasOne<RequestFormPlanView>().WithMany().HasForeignKey("RequestFormPlanViewsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_RequestFormPlanViewsCheckFormPlanViews_RequestFormPlanView"),
                        j =>
                        {
                            j.HasKey("RequestFormPlanViewsId", "CheckFormPlanViewsId");

                            j.ToTable("RequestFormPlanViewsCheckFormPlanViews", "Plan");

                            j.HasIndex(new[] { "CheckFormPlanViewsId" }, "IX_FK_RequestFormPlanViewsCheckFormPlanViews_CheckFormPlanView");

                            j.IndexerProperty<int>("RequestFormPlanViewsId").HasColumnName("RequestFormPlanViews_Id");

                            j.IndexerProperty<int>("CheckFormPlanViewsId").HasColumnName("CheckFormPlanViews_Id");
                        });
            });

            modelBuilder.Entity<RequestItem>(entity =>
            {
                entity.ToTable("RequestItems", "Procure");

                entity.HasIndex(e => e.RequestFormId, "IX_FK_RequestFormRequestItem");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.MedianPrice).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.PricePerPiece).HasColumnType("decimal(15, 5)");

                entity.HasOne(d => d.RequestForm)
                    .WithMany(p => p.RequestItems)
                    .HasForeignKey(d => d.RequestFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestFormRequestItem");
            });

            modelBuilder.Entity<RequestItemPlanReferenceItem>(entity =>
            {
                entity.ToTable("RequestItemPlanReferenceItems", "Procure");

                entity.HasIndex(e => e.RequestFormId, "IX_FK_RequestFormRequestItemPlanReferenceItem");

                entity.HasIndex(e => e.RequestItemId, "IX_FK_RequestItemRequestItemPlanReferenceItem");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 5)");

                entity.HasOne(d => d.RequestForm)
                    .WithMany(p => p.RequestItemPlanReferenceItems)
                    .HasForeignKey(d => d.RequestFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestFormRequestItemPlanReferenceItem");

                entity.HasOne(d => d.RequestItem)
                    .WithMany(p => p.RequestItemPlanReferenceItems)
                    .HasForeignKey(d => d.RequestItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestItemRequestItemPlanReferenceItem");
            });

            modelBuilder.Entity<RequestViewUsedPlanItem>(entity =>
            {
                entity.ToTable("RequestViewUsedPlanItems", "Plan");

                entity.HasIndex(e => e.ChangedPlanItemId, "IX_FK_ChangedPlanItemRequestViewUsedPlanItem");

                entity.HasIndex(e => e.PlanItemId, "IX_FK_PlanItemRequestViewUsedPlanItem");

                entity.HasIndex(e => e.PlanItemTypeId, "IX_FK_PlanItemTypeRequestViewUsedPlanItem");

                entity.HasIndex(e => e.RequestFormPlanViewId, "IX_FK_RequestFormPlanViewRequestViewUsedPlanItem");

                entity.HasIndex(e => e.BaseRequestViewUsedPlanItemId, "IX_FK_RequestViewUsedPlanItemRequestViewUsedPlanItem");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.ApprovalStatusEnum).HasDefaultValueSql("((10))");

                entity.Property(e => e.ApproveFormCreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ApproveFormDocumentNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.ApproveFormStatementName).HasDefaultValueSql("('')");

                entity.Property(e => e.ApproveFormWriteDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovePricePerPiece)
                    .HasColumnType("decimal(15, 5)")
                    .HasDefaultValueSql("((0.00000))");

                entity.Property(e => e.ApproveRemark).HasDefaultValueSql("('')");

                entity.Property(e => e.ChangedPlanItemDate).HasColumnType("datetime");

                entity.Property(e => e.ChangedPlanItemRemark).HasDefaultValueSql("('')");

                entity.Property(e => e.FinishedTransformDate).HasColumnType("datetime");

                entity.Property(e => e.MutiplyAmount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.NoSupplierAmount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.PricePerPiece).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.ReturnBudgetDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.WithInDate).HasColumnType("datetime");

                entity.HasOne(d => d.BaseRequestViewUsedPlanItem)
                    .WithMany(p => p.InverseBaseRequestViewUsedPlanItem)
                    .HasForeignKey(d => d.BaseRequestViewUsedPlanItemId)
                    .HasConstraintName("FK_RequestViewUsedPlanItemRequestViewUsedPlanItem");

                entity.HasOne(d => d.ChangedPlanItem)
                    .WithMany(p => p.RequestViewUsedPlanItemChangedPlanItems)
                    .HasForeignKey(d => d.ChangedPlanItemId)
                    .HasConstraintName("FK_ChangedPlanItemRequestViewUsedPlanItem");

                entity.HasOne(d => d.PlanItem)
                    .WithMany(p => p.RequestViewUsedPlanItemPlanItems)
                    .HasForeignKey(d => d.PlanItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanItemRequestViewUsedPlanItem");

                entity.HasOne(d => d.PlanItemType)
                    .WithMany(p => p.RequestViewUsedPlanItems)
                    .HasForeignKey(d => d.PlanItemTypeId)
                    .HasConstraintName("FK_PlanItemTypeRequestViewUsedPlanItem");

                entity.HasOne(d => d.RequestFormPlanView)
                    .WithMany(p => p.RequestViewUsedPlanItems)
                    .HasForeignKey(d => d.RequestFormPlanViewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestFormPlanViewRequestViewUsedPlanItem");
            });

            modelBuilder.Entity<RequisitionForm>(entity =>
            {
                entity.ToTable("RequisitionForms", "Procure");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<RequisitionItem>(entity =>
            {
                entity.ToTable("RequisitionItems", "Procure");

                entity.HasIndex(e => e.RequisitionFormId, "IX_FK_RequisitionFormRequisitionItem");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("decimal(15, 5)");

                entity.Property(e => e.PricePerPiece).HasColumnType("decimal(15, 5)");

                entity.HasOne(d => d.RequisitionForm)
                    .WithMany(p => p.RequisitionItems)
                    .HasForeignKey(d => d.RequisitionFormId)
                    .HasConstraintName("FK_RequisitionFormRequisitionItem");
            });

            modelBuilder.Entity<RequisitionItemPlanReferenceItem>(entity =>
            {
                entity.ToTable("RequisitionItemPlanReferenceItems", "Procure");

                entity.HasIndex(e => e.RequisitionFormId, "IX_FK_RequisitionFormRequisitionItemPlanReferenceItem");

                entity.HasIndex(e => e.RequisitionItemId, "IX_FK_RequisitionItemRequisitionItemPlanReferenceItem");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 5)");

                entity.HasOne(d => d.RequisitionForm)
                    .WithMany(p => p.RequisitionItemPlanReferenceItems)
                    .HasForeignKey(d => d.RequisitionFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequisitionFormRequisitionItemPlanReferenceItem");

                entity.HasOne(d => d.RequisitionItem)
                    .WithMany(p => p.RequisitionItemPlanReferenceItems)
                    .HasForeignKey(d => d.RequisitionItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequisitionItemRequisitionItemPlanReferenceItem");
            });

            modelBuilder.Entity<ReserveBudgetMonthlyReason>(entity =>
            {
                entity.ToTable("ReserveBudgetMonthlyReasons", "Plan");

                entity.HasIndex(e => e.GeneralExpenseMemoFormId, "IX_FK_GeneralExpenseMemoFormReserveBudgetMonthlyReason");

                entity.HasIndex(e => e.RequestFormPlanViewId, "IX_FK_RequestFormPlanViewReserveBudgetMonthlyReason");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.GeneralExpenseMemoForm)
                    .WithMany(p => p.ReserveBudgetMonthlyReasons)
                    .HasForeignKey(d => d.GeneralExpenseMemoFormId)
                    .HasConstraintName("FK_GeneralExpenseMemoFormReserveBudgetMonthlyReason");

                entity.HasOne(d => d.RequestFormPlanView)
                    .WithMany(p => p.ReserveBudgetMonthlyReasons)
                    .HasForeignKey(d => d.RequestFormPlanViewId)
                    .HasConstraintName("FK_RequestFormPlanViewReserveBudgetMonthlyReason");
            });

            modelBuilder.Entity<ResponsiblePerson>(entity =>
            {
                entity.ToTable("ResponsiblePersons", "Plan");

                entity.HasIndex(e => e.PlanActivityId, "IX_FK_PlanActivityResponsiblePerson");

                entity.HasIndex(e => e.PlanCoreId, "IX_FK_PlanCoreResponsiblePerson");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.HrdepartmentName)
                    .HasColumnName("HRDepartmentName")
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.PlanActivity)
                    .WithMany(p => p.ResponsiblePeople)
                    .HasForeignKey(d => d.PlanActivityId)
                    .HasConstraintName("FK_PlanActivityResponsiblePerson");

                entity.HasOne(d => d.PlanCore)
                    .WithMany(p => p.ResponsiblePeople)
                    .HasForeignKey(d => d.PlanCoreId)
                    .HasConstraintName("FK_PlanCoreResponsiblePerson");
            });

            modelBuilder.Entity<RolesGroup>(entity =>
            {
                entity.HasMany(d => d.AspnetRolesRoles)
                    .WithMany(p => p.RolesGroups)
                    .UsingEntity<Dictionary<string, object>>(
                        "RolesGroupaspnetRole",
                        l => l.HasOne<AspnetRole>().WithMany().HasForeignKey("AspnetRolesRoleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_RolesGroup_Aspnet_Roles_aspnet_Roles"),
                        r => r.HasOne<RolesGroup>().WithMany().HasForeignKey("RolesGroupsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_RolesGroup_Aspnet_Roles_RolesGroup"),
                        j =>
                        {
                            j.HasKey("RolesGroupsId", "AspnetRolesRoleId").IsClustered(false);

                            j.ToTable("RolesGroupaspnet_Roles");

                            j.HasIndex(new[] { "AspnetRolesRoleId" }, "IX_FK_RolesGroup_Aspnet_Roles_aspnet_Roles");

                            j.IndexerProperty<int>("RolesGroupsId").HasColumnName("RolesGroups_Id");

                            j.IndexerProperty<Guid>("AspnetRolesRoleId").HasColumnName("aspnet_Roles_RoleId");
                        });
            });

            modelBuilder.Entity<RqFormActionLog>(entity =>
            {
                entity.ToTable("RqFormActionLogs", "Procure");

                entity.HasIndex(e => e.RequestFormId, "IX_FK_RequestFormRqFormActionLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.Detail).HasDefaultValueSql("('')");

                entity.Property(e => e.Ip).HasColumnName("IP");

                entity.Property(e => e.Jwtpayload)
                    .HasColumnName("JWTPayload")
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.RequestForm)
                    .WithMany(p => p.RqFormActionLogs)
                    .HasForeignKey(d => d.RequestFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestFormRqFormActionLog");
            });

            modelBuilder.Entity<ScheduleFisicalYear>(entity =>
            {
                entity.ToTable("ScheduleFisicalYear", "Plan");

                entity.Property(e => e.AddPlanCoreStatusEndDate).IsUnicode(false);

                entity.Property(e => e.AddPlanCoreStatusStartDate).IsUnicode(false);

                entity.Property(e => e.ApprovePlanCoreStatusEndDate).IsUnicode(false);

                entity.Property(e => e.ApprovePlanCoreStatusStartDate).IsUnicode(false);

                entity.Property(e => e.DisplayPlanCoreStatusEndDate).IsUnicode(false);

                entity.Property(e => e.DisplayPlanCoreStatusStartDate).IsUnicode(false);

                entity.Property(e => e.EditPlanCoreStatusEndDate).IsUnicode(false);

                entity.Property(e => e.EditPlanCoreStatusStartDate).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<SeFormActionLog>(entity =>
            {
                entity.ToTable("SeFormActionLogs", "Plan");

                entity.HasIndex(e => e.GeneralExpenseSettleFormId, "IX_FK_GeneralExpenseSettleFormSeFormActionLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.Detail).HasDefaultValueSql("('')");

                entity.Property(e => e.Ip).HasColumnName("IP");

                entity.Property(e => e.ReturnDeadline).HasColumnType("datetime");

                entity.Property(e => e.ReturnReasonValue).HasDefaultValueSql("('')");

                entity.HasOne(d => d.GeneralExpenseSettleForm)
                    .WithMany(p => p.SeFormActionLogs)
                    .HasForeignKey(d => d.GeneralExpenseSettleFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpenseSettleFormSeFormActionLog");
            });

            modelBuilder.Entity<SeReceiptFormActionLog>(entity =>
            {
                entity.ToTable("SeReceiptFormActionLogs", "Plan");

                entity.HasIndex(e => e.SettleReceiptFormId, "IX_FK_SettleReceiptFormSeReceiptFormActionLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.CipherKeyPairId).HasDefaultValueSql("('')");

                entity.Property(e => e.Detail).HasDefaultValueSql("('')");

                entity.Property(e => e.Ip).HasColumnName("IP");

                entity.Property(e => e.Jwtpayload)
                    .HasColumnName("JWTPayload")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SignedHashText).HasDefaultValueSql("('')");

                entity.Property(e => e.SignedHashValue).HasDefaultValueSql("('')");

                entity.Property(e => e.VerifyData).HasDefaultValueSql("('')");

                entity.HasOne(d => d.SettleReceiptForm)
                    .WithMany(p => p.SeReceiptFormActionLogs)
                    .HasForeignKey(d => d.SettleReceiptFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SettleReceiptFormSeReceiptFormActionLog");
            });

            modelBuilder.Entity<Secondment>(entity =>
            {
                entity.ToTable("Secondments", "HR");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffSecondment");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverSignDate).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.HrdepartmentName).HasColumnName("HRDepartmentName");

                entity.Property(e => e.UnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Secondments)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffSecondment");
            });

            modelBuilder.Entity<SettleDirectPaymentItem>(entity =>
            {
                entity.ToTable("SettleDirectPaymentItems", "Plan");

                entity.HasIndex(e => e.GeneralExpenseId, "IX_FK_GeneralExpenseSettleDirectPaymentItem");

                entity.HasIndex(e => e.GeneralExpenseSettleFormId, "IX_FK_GeneralExpenseSettleFormSettleDirectPaymentItem");

                entity.Property(e => e.UsedBudget).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.GeneralExpense)
                    .WithMany(p => p.SettleDirectPaymentItems)
                    .HasForeignKey(d => d.GeneralExpenseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpenseSettleDirectPaymentItem");

                entity.HasOne(d => d.GeneralExpenseSettleForm)
                    .WithMany(p => p.SettleDirectPaymentItems)
                    .HasForeignKey(d => d.GeneralExpenseSettleFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpenseSettleFormSettleDirectPaymentItem");
            });

            modelBuilder.Entity<SettleReceiptForm>(entity =>
            {
                entity.ToTable("SettleReceiptForms", "Plan");

                entity.HasIndex(e => e.GeneralExpenseMemoFormId, "IX_FK_GeneralExpenseMemoFormSettleReceiptForm");

                entity.Property(e => e.AccountantName).HasDefaultValueSql("('')");

                entity.Property(e => e.AccountantSignDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.BudgetCheckerSignDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.NetPayValue).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.RequesterSignDate).HasColumnType("datetime");

                entity.Property(e => e.StatementCalculationDate).HasColumnType("datetime");

                entity.Property(e => e.UnitChiefName).HasDefaultValueSql("('')");

                entity.Property(e => e.UnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.GeneralExpenseMemoForm)
                    .WithMany(p => p.SettleReceiptForms)
                    .HasForeignKey(d => d.GeneralExpenseMemoFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpenseMemoFormSettleReceiptForm");
            });

            modelBuilder.Entity<SettleReceiptItem>(entity =>
            {
                entity.ToTable("SettleReceiptItems", "Plan");

                entity.HasIndex(e => e.GeneralExpenseId, "IX_FK_GeneralExpenseSettleReceiptItem");

                entity.HasIndex(e => e.SettleReceiptFormId, "IX_FK_SettleReceiptFormSettleReceiptItem");

                entity.Property(e => e.SettleAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.SettleAmountAsBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.TotalGeneralExpenseAtDate).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.UsedBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.WithdrawnAmountAtDate).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.GeneralExpense)
                    .WithMany(p => p.SettleReceiptItems)
                    .HasForeignKey(d => d.GeneralExpenseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpenseSettleReceiptItem");

                entity.HasOne(d => d.SettleReceiptForm)
                    .WithMany(p => p.SettleReceiptItems)
                    .HasForeignKey(d => d.SettleReceiptFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SettleReceiptFormSettleReceiptItem");
            });

            modelBuilder.Entity<SettlementItem>(entity =>
            {
                entity.ToTable("SettlementItems", "Plan");

                entity.HasIndex(e => e.GeneralExpenseSettleFormId, "IX_FK_GeneralExpenseSettleFormSettlementItem");

                entity.HasIndex(e => e.GeneralExpenseId, "IX_FK_GeneralExpenseSettlementItem");

                entity.HasIndex(e => e.SettleReceiptItemId, "IX_FK_SettleReceiptItemSettlementItem");

                entity.HasIndex(e => e.WithdrawalItemId, "IX_FK_WithdrawalItemSettlementItem");

                entity.Property(e => e.SettleAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.SettleAmountAsBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.TotalGeneralExpenseAtDate).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.UsedBudget)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.WithdrawnAmountAtDate).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.GeneralExpense)
                    .WithMany(p => p.SettlementItems)
                    .HasForeignKey(d => d.GeneralExpenseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpenseSettlementItem");

                entity.HasOne(d => d.GeneralExpenseSettleForm)
                    .WithMany(p => p.SettlementItems)
                    .HasForeignKey(d => d.GeneralExpenseSettleFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpenseSettleFormSettlementItem");

                entity.HasOne(d => d.SettleReceiptItem)
                    .WithMany(p => p.SettlementItems)
                    .HasForeignKey(d => d.SettleReceiptItemId)
                    .HasConstraintName("FK_SettleReceiptItemSettlementItem");

                entity.HasOne(d => d.WithdrawalItem)
                    .WithMany(p => p.SettlementItems)
                    .HasForeignKey(d => d.WithdrawalItemId)
                    .HasConstraintName("FK_WithdrawalItemSettlementItem");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.ToTable("Staffs", "HR");

                entity.HasIndex(e => e.BossId, "IX_FK_BossSubordinators");

                entity.HasIndex(e => e.FirstEvaluatorStaffId, "IX_FK_FirstEvaluatorFirstEvaluatees");

                entity.HasIndex(e => e.HrdepartmentId, "IX_FK_HRDepartmentStaff");

                entity.HasIndex(e => e.JobFunctionalPositionId, "IX_FK_JobFunctionalPositionStaff");

                entity.HasIndex(e => e.JobPositionGroupId, "IX_FK_JobPositionGroupStaff");

                entity.HasIndex(e => e.JobPositionLevelId, "IX_FK_JobPositionLevelStaff");

                entity.HasIndex(e => e.JobPositionId, "IX_FK_JobPositionStaff");

                entity.HasIndex(e => e.JobPositionTypeId, "IX_FK_JobPositionTypeStaff");

                entity.HasIndex(e => e.NameTitleId, "IX_FK_NameTitleStaff");

                entity.HasIndex(e => e.NationalityId, "IX_FK_NationalityStaff");

                entity.HasIndex(e => e.RaceId, "IX_FK_RaceStaff");

                entity.HasIndex(e => e.ReligionId, "IX_FK_ReligionStaff");

                entity.HasIndex(e => e.SecondEvaluatorStaffId, "IX_FK_SecondEvaluatorSecondEvaluatees");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.DriverLicenceExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.DriverLicenceIssueDate).HasColumnType("datetime");

                entity.Property(e => e.DriverLicenceNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.EMailAddress).HasColumnName("eMailAddress");

                entity.Property(e => e.FingerScanForSqlnumber).HasColumnName("FingerScanForSQLNumber");

                entity.Property(e => e.GovernmentIdExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.GovernmentIdIssueDate).HasColumnType("datetime");

                entity.Property(e => e.GovernmentIdNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.IdcardExpireDate)
                    .HasColumnType("datetime")
                    .HasColumnName("IDCardExpireDate");

                entity.Property(e => e.IdcardIssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("IDCardIssueDate");

                entity.Property(e => e.IdcardNumber).HasColumnName("IDCardNumber");

                entity.Property(e => e.ImageUrl).HasColumnName("ImageURL");

                entity.Property(e => e.IsFirstEvaluatorForApprove)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSendHrapproveNotificationMail).HasColumnName("IsSendHRApproveNotificationMail");

                entity.Property(e => e.IsSendWeeklyAbsentNotificationEmail)
                    .IsRequired()
                    .HasColumnName("IsSendWeeklyAbsentNotificationEMail")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JobPositionWageTypeEnum).HasDefaultValueSql("((30))");

                entity.Property(e => e.LatestPositionStartDate).HasColumnType("datetime");

                entity.Property(e => e.MilitaryServiceStatusRemark).HasDefaultValueSql("('')");

                entity.Property(e => e.MobilePhoneNumber).HasMaxLength(50);

                entity.Property(e => e.MotorcycleDriverLicenceExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.MotorcycleDriverLicenceIssueDate).HasColumnType("datetime");

                entity.Property(e => e.MotorcycleDriverLicenceNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.Nickname).HasMaxLength(50);

                entity.Property(e => e.PassportNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.PersonalEmailAddress)
                    .HasColumnName("PersonalEMailAddress")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReferencePerson1Name).HasDefaultValueSql("('')");

                entity.Property(e => e.ReferencePerson1PhoneNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.ReferencePerson1Relation).HasDefaultValueSql("('')");

                entity.Property(e => e.ReferencePerson2Name).HasDefaultValueSql("('')");

                entity.Property(e => e.ReferencePerson2PhoneNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.ReferencePerson2Relation).HasDefaultValueSql("('')");

                entity.Property(e => e.ResignedDate).HasColumnType("datetime");

                entity.Property(e => e.ResignedReason).HasDefaultValueSql("('')");

                entity.Property(e => e.StartWorkingDate).HasColumnType("datetime");

                entity.Property(e => e.VisaExpireDate).HasColumnType("datetime");

                entity.Property(e => e.VisaNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.WorkPermitExpireDate).HasColumnType("datetime");

                entity.Property(e => e.WorkPermitIssueDate).HasColumnType("datetime");

                entity.Property(e => e.WorkPermitNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.WorkStatusEnum).HasDefaultValueSql("((10))");

                entity.HasOne(d => d.Boss)
                    .WithMany(p => p.InverseBoss)
                    .HasForeignKey(d => d.BossId)
                    .HasConstraintName("FK_BossSubordinators");

                entity.HasOne(d => d.FirstEvaluatorStaff)
                    .WithMany(p => p.InverseFirstEvaluatorStaff)
                    .HasForeignKey(d => d.FirstEvaluatorStaffId)
                    .HasConstraintName("FK_FirstEvaluatorFirstEvaluatees");

                entity.HasOne(d => d.Hrdepartment)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.HrdepartmentId)
                    .HasConstraintName("FK_HRDepartmentStaff");

                entity.HasOne(d => d.JobFunctionalPosition)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.JobFunctionalPositionId)
                    .HasConstraintName("FK_JobFunctionalPositionStaff");

                entity.HasOne(d => d.JobPositionGroup)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.JobPositionGroupId)
                    .HasConstraintName("FK_JobPositionGroupStaff");

                entity.HasOne(d => d.JobPosition)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.JobPositionId)
                    .HasConstraintName("FK_JobPositionStaff");

                entity.HasOne(d => d.JobPositionLevel)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.JobPositionLevelId)
                    .HasConstraintName("FK_JobPositionLevelStaff");

                entity.HasOne(d => d.JobPositionType)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.JobPositionTypeId)
                    .HasConstraintName("FK_JobPositionTypeStaff");

                entity.HasOne(d => d.NameTitle)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.NameTitleId)
                    .HasConstraintName("FK_NameTitleStaff");

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.NationalityId)
                    .HasConstraintName("FK_NationalityStaff");

                entity.HasOne(d => d.Race)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.RaceId)
                    .HasConstraintName("FK_RaceStaff");

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.ReligionId)
                    .HasConstraintName("FK_ReligionStaff");

                entity.HasOne(d => d.SecondEvaluatorStaff)
                    .WithMany(p => p.InverseSecondEvaluatorStaff)
                    .HasForeignKey(d => d.SecondEvaluatorStaffId)
                    .HasConstraintName("FK_SecondEvaluatorSecondEvaluatees");
            });

            modelBuilder.Entity<StaffCipherKeyPair>(entity =>
            {
                entity.ToTable("StaffCipherKeyPairs", "HR");

                entity.Property(e => e.Cad)
                    .HasColumnName("CAD")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.Jwtheader)
                    .HasColumnName("JWTHeader")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.X509PublicCertificate)
                    .HasColumnName("x509PublicCertificate")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<StaffPositionInHrdepartment>(entity =>
            {
                entity.ToTable("StaffPositionInHRDepartments", "HR");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.PositionInHrdepartmentEnum).HasColumnName("PositionInHRDepartmentEnum");
            });

            modelBuilder.Entity<StaffSecurity>(entity =>
            {
                entity.HasIndex(e => e.AspnetUsersUserId, "IX_FK_aspnet_UsersStaffSecurity");

                entity.Property(e => e.AspnetUsersUserId).HasColumnName("aspnet_UsersUserId");

                entity.Property(e => e.IsHrdepPowerUser).HasColumnName("IsHRDepPowerUser");

                entity.Property(e => e.IsPdpa)
                    .IsRequired()
                    .HasColumnName("IsPDPA")
                    .HasDefaultValueSql("('0')")
                    .HasComment("");

                entity.HasOne(d => d.AspnetUsersUser)
                    .WithMany(p => p.StaffSecurities)
                    .HasForeignKey(d => d.AspnetUsersUserId)
                    .HasConstraintName("FK_aspnet_UsersStaffSecurity");

                entity.HasMany(d => d.RolesGroups)
                    .WithMany(p => p.StaffSecurities)
                    .UsingEntity<Dictionary<string, object>>(
                        "StaffSecurityRolesGroup",
                        l => l.HasOne<RolesGroup>().WithMany().HasForeignKey("RolesGroupsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_StaffSecurityRolesGroup_RolesGroup"),
                        r => r.HasOne<StaffSecurity>().WithMany().HasForeignKey("StaffSecuritiesId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_StaffSecurityRolesGroup_StaffSecurity"),
                        j =>
                        {
                            j.HasKey("StaffSecuritiesId", "RolesGroupsId").IsClustered(false);

                            j.ToTable("StaffSecurityRolesGroup");

                            j.HasIndex(new[] { "RolesGroupsId" }, "IX_FK_StaffSecurityRolesGroup_RolesGroup");

                            j.IndexerProperty<int>("StaffSecuritiesId").HasColumnName("StaffSecurities_Id");

                            j.IndexerProperty<int>("RolesGroupsId").HasColumnName("RolesGroups_Id");
                        });
            });

            modelBuilder.Entity<StaffSignature>(entity =>
            {
                entity.ToTable("StaffSignatures", "Filing");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");
            });

            modelBuilder.Entity<StaffSignature1>(entity =>
            {
                entity.ToTable("StaffSignatures", "HR");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");
            });

            modelBuilder.Entity<StaffWorkShift>(entity =>
            {
                entity.ToTable("StaffWorkShifts", "HR");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffStaffWorkShift");

                entity.HasIndex(e => e.WorkShiftDataId, "IX_FK_WorkShiftDataStaffWorkShift");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.StaffWorkShifts)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffStaffWorkShift");

                entity.HasOne(d => d.WorkShiftData)
                    .WithMany(p => p.StaffWorkShifts)
                    .HasForeignKey(d => d.WorkShiftDataId)
                    .HasConstraintName("FK_WorkShiftDataStaffWorkShift");
            });

            modelBuilder.Entity<StaffWorkShiftSpecificDayOff>(entity =>
            {
                entity.ToTable("StaffWorkShiftSpecificDayOffs", "HR");

                entity.HasIndex(e => e.StaffWorkShiftId, "IX_FK_StaffWorkShiftStaffWorkShiftSpecificDayOff");

                entity.Property(e => e.StaffWorkShiftId).HasColumnName("StaffWorkShift_Id");

                entity.HasOne(d => d.StaffWorkShift)
                    .WithMany(p => p.StaffWorkShiftSpecificDayOffs)
                    .HasForeignKey(d => d.StaffWorkShiftId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffWorkShiftStaffWorkShiftSpecificDayOff");
            });

            modelBuilder.Entity<StaffWorkShiftSpecificHoliday>(entity =>
            {
                entity.ToTable("StaffWorkShiftSpecificHolidays", "HR");

                entity.HasIndex(e => e.StaffWorkShiftId, "IX_FK_StaffWorkShiftStaffWorkShiftSpecificHoliday");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.HasOne(d => d.StaffWorkShift)
                    .WithMany(p => p.StaffWorkShiftSpecificHolidays)
                    .HasForeignKey(d => d.StaffWorkShiftId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffWorkShiftStaffWorkShiftSpecificHoliday");
            });

            modelBuilder.Entity<StrategicIndicator>(entity =>
            {
                entity.ToTable("StrategicIndicators", "Plan");

                entity.HasIndex(e => e.ParentStrategicIndicatorId, "IX_FK_ParentStrategicIndicatorSubStrategicIndicator");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.StrategyId).HasComment("");

                entity.Property(e => e.Unit).HasDefaultValueSql("('')");

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.HasOne(d => d.ParentStrategicIndicator)
                    .WithMany(p => p.InverseParentStrategicIndicator)
                    .HasForeignKey(d => d.ParentStrategicIndicatorId)
                    .HasConstraintName("FK_ParentStrategicIndicatorSubStrategicIndicator");
            });

            modelBuilder.Entity<StrategiesBudget>(entity =>
            {
                entity.ToTable("StrategiesBudgets", "Plan");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Strategy>(entity =>
            {
                entity.ToTable("Strategies", "Plan");

                entity.HasIndex(e => e.ParentStrategyId, "IX_FK_StrategySubStrategies");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ParentStrategy)
                    .WithMany(p => p.InverseParentStrategy)
                    .HasForeignKey(d => d.ParentStrategyId)
                    .HasConstraintName("FK_StrategySubStrategies");
            });

            modelBuilder.Entity<SummaryStatementCache>(entity =>
            {
                entity.ToTable("SummaryStatementCaches", "Plan");

                entity.HasIndex(e => e.PlanItemId, "IX_FK_PlanItemSummaryStatementCache");

                entity.Property(e => e.CalDate).HasColumnType("datetime");

                entity.Property(e => e.ContractBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.InProcessBudgetAcc).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.InternalBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.NetBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.NetBudgetPlanView)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.PaidBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.PaidBudgetAcc).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.RemainBudgetPlanView)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalBudgetPlanView)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.UsedBudgetPlanView)
                    .HasColumnType("decimal(12, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.HasOne(d => d.PlanItem)
                    .WithMany(p => p.SummaryStatementCaches)
                    .HasForeignKey(d => d.PlanItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanItemSummaryStatementCache");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("Suppliers", "Procure");

                entity.HasIndex(e => e.SupplierTypeId, "IX_FK_SupplierTypeSupplier");

                entity.Property(e => e.CertificateOfPartnershipDate).HasColumnType("datetime");

                entity.HasOne(d => d.SupplierType)
                    .WithMany(p => p.Suppliers)
                    .HasForeignKey(d => d.SupplierTypeId)
                    .HasConstraintName("FK_SupplierTypeSupplier");
            });

            modelBuilder.Entity<SupplierType>(entity =>
            {
                entity.ToTable("SupplierTypes", "Procure");
            });

            modelBuilder.Entity<Syllabuse>(entity =>
            {
                entity.ToTable("Syllabuses", "HR");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");
            });

            modelBuilder.Entity<TelephoneBill>(entity =>
            {
                entity.ToTable("TelephoneBills", "Operation");

                entity.HasIndex(e => e.BillingLocationId, "IX_FK_BillingLocationTelephoneBill");

                entity.Property(e => e.BillingDate).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.MonthlyPackage).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Remark).HasDefaultValueSql("('')");

                entity.Property(e => e.TotalBill).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.BillingLocation)
                    .WithMany(p => p.TelephoneBills)
                    .HasForeignKey(d => d.BillingLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillingLocationTelephoneBill");
            });

            modelBuilder.Entity<TempYearlyEvaluation5859Score>(entity =>
            {
                entity.ToTable("TempYearlyEvaluation5859Scores", "HR");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffTempYearlyEvaluation5859Score");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.TempYearlyEvaluation5859Scores)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffTempYearlyEvaluation5859Score");
            });

            modelBuilder.Entity<TemporaryEmployeeRequestForm>(entity =>
            {
                entity.ToTable("TemporaryEmployeeRequestForms", "HR");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.OutwardPlanCoreNetBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.OutwardPlanCoreRemainBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.OutwardPlanItemNetBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.OutwardPlanItemRemainBudget).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Salary).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewFormRequestAndPlanCoresDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewFormRequestAndPlanCoresDetail");
            });

            modelBuilder.Entity<ViewRequestFormDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_RequestFormDetail");
            });

            modelBuilder.Entity<VwAspnetApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Applications");

                entity.Property(e => e.ApplicationName).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName).HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetMembershipUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_MembershipUsers");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.MobilePin)
                    .HasMaxLength(16)
                    .HasColumnName("MobilePIN");

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Profiles");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Roles");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName).HasMaxLength(256);

                entity.Property(e => e.RoleName).HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Users");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName).HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUsersInRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_UsersInRoles");
            });

            modelBuilder.Entity<VwAspnetWebPartStatePath>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_Paths");

                entity.Property(e => e.LoweredPath).HasMaxLength(256);

                entity.Property(e => e.Path).HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetWebPartStateShared>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_Shared");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetWebPartStateUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_User");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<WaterBill>(entity =>
            {
                entity.ToTable("WaterBills", "Operation");

                entity.HasIndex(e => e.BillingLocationId, "IX_FK_BillingLocationWaterBill");

                entity.Property(e => e.BilingNumber).HasDefaultValueSql("('')");

                entity.Property(e => e.BillingDate).HasColumnType("datetime");

                entity.Property(e => e.MeterReadDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasDefaultValueSql("('')");

                entity.Property(e => e.ServiceBill).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.TotalBill).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.Unit).HasColumnType("decimal(12, 4)");

                entity.HasOne(d => d.BillingLocation)
                    .WithMany(p => p.WaterBills)
                    .HasForeignKey(d => d.BillingLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillingLocationWaterBill");
            });

            modelBuilder.Entity<WdFormActionLog>(entity =>
            {
                entity.ToTable("WdFormActionLogs", "Plan");

                entity.HasIndex(e => e.WithdrawalFormId, "IX_FK_WithdrawalFormWdFormActionLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.Ip).HasColumnName("IP");

                entity.HasOne(d => d.WithdrawalForm)
                    .WithMany(p => p.WdFormActionLogs)
                    .HasForeignKey(d => d.WithdrawalFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WithdrawalFormWdFormActionLog");
            });

            modelBuilder.Entity<WithdrawalForm>(entity =>
            {
                entity.ToTable("WithdrawalForms", "Plan");

                entity.HasIndex(e => e.GeneralExpenseMemoFormId, "IX_FK_GeneralExpenseMemoFormWithdrawalForm");

                entity.Property(e => e.Borrower).HasDefaultValueSql("('')");

                entity.Property(e => e.BorrowerHrDepartmentName).HasDefaultValueSql("('')");

                entity.Property(e => e.BorrowerHrdepartmentId).HasColumnName("BorrowerHRDepartmentId");

                entity.Property(e => e.BorrowerPosition).HasDefaultValueSql("('')");

                entity.Property(e => e.Payee).HasDefaultValueSql("('')");

                entity.Property(e => e.PayeeHrDepartmentName).HasDefaultValueSql("('')");

                entity.Property(e => e.PayeeHrdepartmentId).HasColumnName("PayeeHRDepartmentId");

                entity.Property(e => e.StatementCalculationDate).HasColumnType("datetime");

                entity.Property(e => e.WithdrawnDate).HasColumnType("datetime");

                entity.HasOne(d => d.GeneralExpenseMemoForm)
                    .WithMany(p => p.WithdrawalForms)
                    .HasForeignKey(d => d.GeneralExpenseMemoFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpenseMemoFormWithdrawalForm");
            });

            modelBuilder.Entity<WithdrawalItem>(entity =>
            {
                entity.ToTable("WithdrawalItems", "Plan");

                entity.HasIndex(e => e.GeneralExpenseMemoFormId, "IX_FK_GeneralExpenseMemoFormWithdrawalItem");

                entity.HasIndex(e => e.GeneralExpenseId, "IX_FK_GeneralExpenseWithdrawalItem");

                entity.HasIndex(e => e.SettleReceiptItemId, "IX_FK_SettleReceiptItemWithdrawalItem");

                entity.HasIndex(e => e.SettlementItemId, "IX_FK_SettlementItemWithdrawalItem");

                entity.HasIndex(e => e.WithdrawalFormId, "IX_FK_WithdrawalFormWithdrawalItem");

                entity.Property(e => e.TotalGeneralExpenseAtDate).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.WithDrawnAmount).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.WithdrawableGeneralExpenseAtDate).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.GeneralExpense)
                    .WithMany(p => p.WithdrawalItems)
                    .HasForeignKey(d => d.GeneralExpenseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpenseWithdrawalItem");

                entity.HasOne(d => d.GeneralExpenseMemoForm)
                    .WithMany(p => p.WithdrawalItems)
                    .HasForeignKey(d => d.GeneralExpenseMemoFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralExpenseMemoFormWithdrawalItem");

                entity.HasOne(d => d.SettleReceiptItem)
                    .WithMany(p => p.WithdrawalItems)
                    .HasForeignKey(d => d.SettleReceiptItemId)
                    .HasConstraintName("FK_SettleReceiptItemWithdrawalItem");

                entity.HasOne(d => d.SettlementItem)
                    .WithMany(p => p.WithdrawalItems)
                    .HasForeignKey(d => d.SettlementItemId)
                    .HasConstraintName("FK_SettlementItemWithdrawalItem");

                entity.HasOne(d => d.WithdrawalForm)
                    .WithMany(p => p.WithdrawalItems)
                    .HasForeignKey(d => d.WithdrawalFormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WithdrawalFormWithdrawalItem");
            });

            modelBuilder.Entity<WorkHistory>(entity =>
            {
                entity.ToTable("WorkHistories", "HR");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffWorkHistory");

                entity.Property(e => e.JobChangingTypeEnum).HasDefaultValueSql("((10))");

                entity.Property(e => e.JobPositionGroup).HasDefaultValueSql("('')");

                entity.Property(e => e.JobPositionLevel).HasDefaultValueSql("('')");

                entity.Property(e => e.StartWorkingDate).HasColumnType("datetime");

                entity.Property(e => e.ToWorkingDate).HasColumnType("datetime");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.WorkHistories)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffWorkHistory");
            });

            modelBuilder.Entity<WorkShiftData>(entity =>
            {
                entity.ToTable("WorkShiftDatas", "HR");
            });

            modelBuilder.Entity<WorkShiftExtraAllowance>(entity =>
            {
                entity.ToTable("WorkShiftExtraAllowances", "HR");

                entity.HasIndex(e => e.WorkShiftDataId, "IX_FK_WorkShiftDataWorkShiftExtraAllowance");

                entity.Property(e => e.AmountPerShift).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.HasOne(d => d.WorkShiftData)
                    .WithMany(p => p.WorkShiftExtraAllowances)
                    .HasForeignKey(d => d.WorkShiftDataId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkShiftDataWorkShiftExtraAllowance");
            });

            modelBuilder.Entity<WorkShiftSwitchForm>(entity =>
            {
                entity.ToTable("WorkShiftSwitchForms", "HR");

                entity.HasIndex(e => e.FromStaffWorkShiftId, "IX_FK_FromStaffWorkShiftWorkShiftSwitchForm");

                entity.HasIndex(e => e.FromSwitchedStaffWorkShiftId, "IX_FK_FromSwitchedStaffWorkShiftWorkShiftSwitchForm");

                entity.HasIndex(e => e.StaffId, "IX_FK_StaffWorkShiftSwitch");

                entity.HasIndex(e => e.SwitchedStaffId, "IX_FK_SwitchedStaffWorkShiftSwitchForm");

                entity.HasIndex(e => e.ToStaffWorkShiftId, "IX_FK_ToStaffWorkShiftWorkShiftSwitchForm");

                entity.HasIndex(e => e.ToSwitchedStaffWorkShiftId, "IX_FK_ToSwitchedStaffWorkShiftWorkShiftSwitchForm");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.ApproverSignDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.HrdepartmentId).HasColumnName("HRDepartmentId");

                entity.Property(e => e.HrdepartmentName).HasColumnName("HRDepartmentName");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.UnitChiefSignDate).HasColumnType("datetime");

                entity.Property(e => e.WriteDate).HasColumnType("datetime");

                entity.HasOne(d => d.FromStaffWorkShift)
                    .WithMany(p => p.WorkShiftSwitchFormFromStaffWorkShifts)
                    .HasForeignKey(d => d.FromStaffWorkShiftId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FromStaffWorkShiftWorkShiftSwitchForm");

                entity.HasOne(d => d.FromSwitchedStaffWorkShift)
                    .WithMany(p => p.WorkShiftSwitchFormFromSwitchedStaffWorkShifts)
                    .HasForeignKey(d => d.FromSwitchedStaffWorkShiftId)
                    .HasConstraintName("FK_FromSwitchedStaffWorkShiftWorkShiftSwitchForm");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.WorkShiftSwitchFormStaffs)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StaffWorkShiftSwitch");

                entity.HasOne(d => d.SwitchedStaff)
                    .WithMany(p => p.WorkShiftSwitchFormSwitchedStaffs)
                    .HasForeignKey(d => d.SwitchedStaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SwitchedStaffWorkShiftSwitchForm");

                entity.HasOne(d => d.ToStaffWorkShift)
                    .WithMany(p => p.WorkShiftSwitchFormToStaffWorkShifts)
                    .HasForeignKey(d => d.ToStaffWorkShiftId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ToStaffWorkShiftWorkShiftSwitchForm");

                entity.HasOne(d => d.ToSwitchedStaffWorkShift)
                    .WithMany(p => p.WorkShiftSwitchFormToSwitchedStaffWorkShifts)
                    .HasForeignKey(d => d.ToSwitchedStaffWorkShiftId)
                    .HasConstraintName("FK_ToSwitchedStaffWorkShiftWorkShiftSwitchForm");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
