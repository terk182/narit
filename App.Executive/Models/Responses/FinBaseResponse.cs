
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.FIN.Models.Responses
{
    public class FinBaseResponse 
    {
        public bool Success { get; set; }
        public string? Errors { get; set; }
        public string? Messsage { get; set; }
        //public requestform requestformdto { get; set; }
        public approveform approveformdto { get; set; }
        public orderform orderformdto { get; set; }
        public checkform checkformdto { get; set; }

        internal class requestformdto : FinBaseResponse
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public bool Active { get; set; }
        }
    }
    public class requestform 
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? WriteDate { get; set; }
        public string WriteAt { get; set; } = null!;
        public string Purpose { get; set; } = null!;
        public bool Active { get; set; }
        public string Inform { get; set; } = null!;
        public string DocumentNumber { get; set; } = null!;
        public int FiscalYear { get; set; }
        public int ProcureTypeEnum { get; set; }
        public int ProcureMethodEnum { get; set; }
        public string DepartmentName { get; set; } = null!;
        public string PlanTypeName { get; set; } = null!;
        public string Enclosure { get; set; } = null!;
        public string OtherProcureMethodName { get; set; } = null!;
        public string PlanCoreName { get; set; } = null!;
        public string BudgetTypeName { get; set; } = null!;
        public string ProcureChairman { get; set; } = null!;
        public string ProcureFirstComittee { get; set; } = null!;
        public string ProcureSecondComittee { get; set; } = null!;
        public string CheckChairman { get; set; } = null!;
        public string CheckFirstComittee { get; set; } = null!;
        public string CheckSecondComittee { get; set; } = null!;
        public string Requester { get; set; } = null!;
        public DateTime? RequesterSignDate { get; set; }
        public string UnitChief { get; set; } = null!;
        public DateTime? UnitChiefSignDate { get; set; }
        public string BudgetChecker { get; set; } = null!;
        public DateTime? BudgetCheckerSignDate { get; set; }
        public string SuppliesOfficer { get; set; } = null!;
        public string SuppliesUnitChief { get; set; } = null!;
        public DateTime? SuppliesUnitChiefSignDate { get; set; }
        public int PlanCoreId { get; set; }
        public int PlanTypeId { get; set; }
        public int DepartmentId { get; set; }
        public int ProcureApprovalStatusEnum { get; set; }
        public int ProcureTransformStatusEnum { get; set; }
        public int? WithInDay { get; set; }
        public int FundTypeId { get; set; }
        public string FundTypeName { get; set; } = null!;
        public int PlanActivityIdOld { get; set; }
        public string PlanActivityName { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public DateTime? WithInDate { get; set; }
        public string StatementName { get; set; } = null!;
        public string CheckThirdComittee { get; set; } = null!;
        public string CheckFourthComittee { get; set; } = null!;
        public string CheckFifthComittee { get; set; } = null!;
        public string CheckSecretaryComittee { get; set; } = null!;
        public string ProcureThirdComittee { get; set; } = null!;
        public string ProcureFourthComittee { get; set; } = null!;
        public string ProcureFifthComittee { get; set; } = null!;
        public string ProcureSecretaryComittee { get; set; } = null!;
        public bool IsForeign { get; set; }
        public bool IsUrgent { get; set; }
        public int BudgetTypeEnum { get; set; }
        public string Topic { get; set; } = null!;
        public string ProcureViceChairman { get; set; } = null!;
        public string CheckViceChairman { get; set; } = null!;
        public string CheckSecretaryAndComittee { get; set; } = null!;
        public string ProcureSecretaryAndComittee { get; set; } = null!;
        public string RequesterPosition { get; set; } = null!;
        public string UnitChiefPosition { get; set; } = null!;
        public decimal? MedianPrice { get; set; }
        public int RequestDepartmentId { get; set; }
        public string RequestDepartmentName { get; set; } = null!;
        public bool IsContinuousProject { get; set; }
        public string CheckSixthComittee { get; set; } = null!;
        public string CheckSeventhComittee { get; set; } = null!;
        public string CheckEighthComittee { get; set; } = null!;
        public string CheckNinthComittee { get; set; } = null!;
        public int ProcureFormApprovalStatusEnum { get; set; }
        public int? RequesterStaffId { get; set; }
        public int? DocCheckerStaffId { get; set; }
        public int? UnitChiefStaffId { get; set; }
        public int? ProjectManagerStaffId { get; set; }
        public int? BudgetCheckerStaffId { get; set; }
        public int? SuppliesUnitChiefStaffId { get; set; }
        public bool IsSent { get; set; }
        public DateTime? ProjectManagerSignDate { get; set; }
        public string ProjectManager { get; set; } = null!;
        public string ProjectManagerPosition { get; set; } = null!;
        public int? UnitChiefSignatureId { get; set; }
        public int? ProjectManagerSignatureId { get; set; }
        public int? RequesterSignatureId { get; set; }
        public int? BudgetCheckerSignatureId { get; set; }
        public int? SuppliesUnitChiefSignatureId { get; set; }
        public string BudgetCheckerPosition { get; set; } = null!;
        public string SuppliesOfficerPosition { get; set; } = null!;
    }
    public class approveform
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? WriteDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public bool Active { get; set; }
        public string Inform { get; set; } = null!;
        public int FiscalYear { get; set; }
        public int ProcureTypeEnum { get; set; }
        public string PlanTypeCode { get; set; } = null!;
        public string DepartmentCode { get; set; } = null!;
        public string BudgetTypeCode { get; set; } = null!;
        public string PlanTypeName { get; set; } = null!;
        public string PlanCoreName { get; set; } = null!;
        public string BudgetTypeName { get; set; } = null!;
        public string Purpose { get; set; } = null!;
        public string CheckChairman { get; set; } = null!;
        public string CheckFirstComittee { get; set; } = null!;
        public string CheckSecondComittee { get; set; } = null!;
        public string CheckChairmanPosition { get; set; } = null!;
        public string CheckFirstComitteePosition { get; set; } = null!;
        public string CheckSecondComitteePosition { get; set; } = null!;
        public string SuppliesOfficer { get; set; } = null!;
        public DateTime? SuppliesOfficerSignDate { get; set; }
        public string SuppliesUnitChief { get; set; } = null!;
        public DateTime? SuppliesUnitChiefSignDate { get; set; }
        public string Approver { get; set; } = null!;
        public DateTime? ApproverSignDate { get; set; }
        public int ProcureTransformStatusEnum { get; set; }
        public int? AgreementFormId { get; set; }
        public string AgreementFormNumber { get; set; } = null!;
        public string DepartmentName { get; set; } = null!;
        public int DepartmentId { get; set; }
        public int PlanTypeId { get; set; }
        public int PlanCoreId { get; set; }
        public DateTime? AgreementFormDate { get; set; }
        public int RequestFormId { get; set; }
        public string RequestFormNumber { get; set; } = null!;
        public DateTime? RequestFormDate { get; set; }
        public string BudgetChecker { get; set; } = null!;
        public int FundTypeId { get; set; }
        public string FundTypeName { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public string Detail { get; set; } = null!;
        public string CheckThirdComittee { get; set; } = null!;
        public string CheckFourthComittee { get; set; } = null!;
        public string CheckFifthComittee { get; set; } = null!;
        public string CheckSecretaryComittee { get; set; } = null!;
        public string ProcureThirdComittee { get; set; } = null!;
        public string ProcureFourthComittee { get; set; } = null!;
        public string ProcureFifthComittee { get; set; } = null!;
        public string ProcureSecretaryComittee { get; set; } = null!;
        public string ProcureChairman { get; set; } = null!;
        public string ProcureFirstComittee { get; set; } = null!;
        public string ProcureSecondComittee { get; set; } = null!;
        public int ProcureMethodEnum { get; set; }
        public string StatementName { get; set; } = null!;
        public string PlanActivityName { get; set; } = null!;
        public string PlanItemName { get; set; } = null!;
        public string Borrower { get; set; } = null!;
        public string CheckSecretaryAndComittee { get; set; } = null!;
        public string CheckSecretaryComitteePosition { get; set; } = null!;
        public string CheckSecretaryAndComitteePosition { get; set; } = null!;
        public string CheckOfficer { get; set; } = null!;
        public string CheckOfficerPosition { get; set; } = null!;
        public string BorrowReason { get; set; } = null!;
        public string ProcureSecretaryAndComittee { get; set; } = null!;
        public string CheckViceChairmanPosition { get; set; } = null!;
        public string ProcureViceChairman { get; set; } = null!;
        public string CheckViceChairman { get; set; } = null!;
        public string AuthorizeFormDocumentNumber { get; set; } = null!;
        public DateTime? AuthorizeFormWriteDate { get; set; }
        public DateTime? AnnouncementDate { get; set; }
        public string MemoTitle { get; set; } = null!;
        public bool? IsConsiderationByLowestPrice { get; set; }
        public bool? IsConsiderationByPerformancePerPrice { get; set; }
        public string MemoDocumentNumber { get; set; } = null!;
        public DateTime? MemoWriteDate { get; set; }
        public string MemoPurpose { get; set; } = null!;
        public string CheckSixthComittee { get; set; } = null!;
        public string CheckSeventhComittee { get; set; } = null!;
        public string CheckEighthComittee { get; set; } = null!;
        public string CheckNinthComittee { get; set; } = null!;
        public string CheckSixthComitteePosition { get; set; } = null!;
        public string CheckSeventhComitteePosition { get; set; } = null!;
        public string CheckEighthComitteePosition { get; set; } = null!;
        public string CheckNinthComitteePosition { get; set; } = null!;
        public string CheckThirdComitteePosition { get; set; } = null!;
        public string CheckFourthComitteePosition { get; set; } = null!;
        public string CheckFifthComitteePosition { get; set; } = null!;
        public string MemoAnnouncementTitle { get; set; } = null!;
    }
    public class orderform
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? WriteDate { get; set; }
        public string Inform { get; set; } = null!;
        public string DocumentNumber { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int ProcureTypeEnum { get; set; }
        public string QuotationNumber { get; set; } = null!;
        public DateTime? QuotationDate { get; set; }
        public string DepartmentName { get; set; } = null!;
        public int? SupplierId { get; set; }
        public int DeliveryDay { get; set; }
        public int PaymentDay { get; set; }
        public string RequestFormNumber { get; set; } = null!;
        public DateTime? RequestFormDate { get; set; }
        public int RequestFormId { get; set; }
        public string DeliveryPlace { get; set; } = null!;
        public string Orderer { get; set; } = null!;
        public int ProcureTransformStatusEnum { get; set; }
        public string CheckFirstComittee { get; set; } = null!;
        public string CheckSecondComittee { get; set; } = null!;
        public string CheckChairman { get; set; } = null!;
        public string BudgetTypeName { get; set; } = null!;
        public string PlanCoreName { get; set; } = null!;
        public string PlanTypeName { get; set; } = null!;
        public string BudgetTypeCode { get; set; } = null!;
        public string DepartmentCode { get; set; } = null!;
        public string PlanTypeCode { get; set; } = null!;
        public int PlanTypeId { get; set; }
        public int DepartmentId { get; set; }
        public int PlanCoreId { get; set; }
        public int? ApproveFormId { get; set; }
        public int? ApproveMemorandumId { get; set; }
        public string BudgetChecker { get; set; } = null!;
        public string SuppliesUnitChief { get; set; } = null!;
        public string SupplierName { get; set; } = null!;
        public string ApproveFormNumber { get; set; } = null!;
        public DateTime? ApproveFormDate { get; set; }
        public int FundTypeId { get; set; }
        public string FundTypeName { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public string CheckThirdComittee { get; set; } = null!;
        public string CheckFourthComittee { get; set; } = null!;
        public string CheckFifthComittee { get; set; } = null!;
        public string CheckSecretaryComittee { get; set; } = null!;
        public int ProcureMethodEnum { get; set; }
        public string CountStartReason { get; set; } = null!;
        public DateTime? DeliveryStartDate { get; set; }
        public string SupplierAddress { get; set; } = null!;
        public string SupplierTaxNumber { get; set; } = null!;
        public string SupplierTelNumber { get; set; } = null!;
        public string SupplierFaxNumber { get; set; } = null!;
        public int? CountMethodEnum { get; set; }
        public string CheckViceChairman { get; set; } = null!;
        public string CheckOfficer { get; set; } = null!;
        public string CheckSecretaryAndComittee { get; set; } = null!;
        public string SuppliesOfficer { get; set; } = null!;
        public decimal FineRate { get; set; }
        public string Remark { get; set; } = null!;
        public int? WarrantyDay { get; set; }
        public int? WarrantyMonth { get; set; }
        public int? WarrantyYear { get; set; }
        public DateTime? DeliveryEndDate { get; set; }
        public string ProjectControlNumber { get; set; } = null!;
        public string ContractControlNumber { get; set; } = null!;
        public decimal? MedianPrice { get; set; }
        public int ConsiderateConditionEnum { get; set; }
        public string Topic { get; set; } = null!;
        public string CheckSixthComittee { get; set; } = null!;
        public string CheckSeventhComittee { get; set; } = null!;
        public string CheckEighthComittee { get; set; } = null!;
        public string CheckNinthComittee { get; set; } = null!;
        public int? CheckChairmanStaffId { get; set; }
        public int? CheckFirstComitteeStaffId { get; set; }
        public int? CheckSecondComitteeStaffId { get; set; }
        public int? CheckThirdComitteeStaffId { get; set; }
        public int? CheckFourthComitteeStaffId { get; set; }
        public int? CheckFifthComitteeStaffId { get; set; }
        public int? CheckSecretaryComitteeStaffId { get; set; }
        public int? CheckSecretaryAndComitteeStaffId { get; set; }
        public int? SuppliesOfficerStaffId { get; set; }
        public int? CheckViceChairmanStaffId { get; set; }
        public int? CheckOfficerStaffId { get; set; }
        public int? CheckSixthComitteeStaffId { get; set; }
        public int? CheckSeventhComitteeStaffId { get; set; }
        public int? CheckEighthComitteeStaffId { get; set; }
        public int? CheckNinthComitteeStaffId { get; set; }
    }
    public class checkform
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string DocumentNumber { get; set; } = null!;
        public DateTime? WriteDate { get; set; }
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int ProcureTypeEnum { get; set; }
        public string OrderDocumentNumber { get; set; } = null!;
        public DateTime? OrderDate { get; set; }
        public string DepartmentName { get; set; } = null!;
        public int? SupplierId { get; set; }
        public int CountTime { get; set; }
        public string PlanTypeCode { get; set; } = null!;
        public string DepartmentCode { get; set; } = null!;
        public string BudgetTypeCode { get; set; } = null!;
        public string PlanTypeName { get; set; } = null!;
        public string PlanCoreName { get; set; } = null!;
        public string BudgetTypeName { get; set; } = null!;
        public string SupplierName { get; set; } = null!;
        public string DeliveryRequestFormNumber { get; set; } = null!;
        public DateTime? DeliveryRequestFormDate { get; set; }
        public string DeliveryFormNumber { get; set; } = null!;
        public DateTime? DeliveryFormDate { get; set; }
        public decimal? LateDeliveryFineRate { get; set; }
        public int LateDeliveryDay { get; set; }
        public string CheckChairman { get; set; } = null!;
        public string CheckFirstComittee { get; set; } = null!;
        public string CheckSecondComittee { get; set; } = null!;
        public string SuppliesUnitChief { get; set; } = null!;
        public DateTime? SuppliesUnitChiefSignDate { get; set; }
        public string BudgetChecker { get; set; } = null!;
        public DateTime? BudgetCheckerSignDate { get; set; }
        public int ProcureTransformStatusEnum { get; set; }
        public int OrderFormId { get; set; }
        public int PlanTypeId { get; set; }
        public int DepartmentId { get; set; }
        public int PlanCoreId { get; set; }
        public decimal? LateDeliveryFineValue { get; set; }
        public int FundTypeId { get; set; }
        public string FundTypeName { get; set; } = null!;
        public string RequestFormNumber { get; set; } = null!;
        public int RequestFormId { get; set; }
        public DateTime? RequestFormDate { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public bool IsSinglePassCheck { get; set; }
        public string CountTimeText { get; set; } = null!;
        public string CheckThirdComittee { get; set; } = null!;
        public string CheckFourthComittee { get; set; } = null!;
        public string CheckFifthComittee { get; set; } = null!;
        public string CheckSecretaryComittee { get; set; } = null!;
        public int ProcureMethodEnum { get; set; }
        public string PlanActivityName { get; set; } = null!;
        public string PlanItemName { get; set; } = null!;
        public bool IsPaymentHold { get; set; }
        public string CheckViceChairman { get; set; } = null!;
        public string CheckOfficer { get; set; } = null!;
        public string CheckSecretaryAndComittee { get; set; } = null!;
        public string SuppliesOfficer { get; set; } = null!;
        public bool? IsShowCountTimeOnPrint { get; set; }
        public string DeliveryFormManualText { get; set; } = null!;
        public DateTime? SuppliesOfficerSignDate { get; set; }
        public DateTime? ComitteeCheckDate { get; set; }
        public DateTime? CheckReportWriteDate { get; set; }
        public string RefDocumentNumber { get; set; } = null!;
        public DateTime? RefDocumentDate { get; set; }
        public string CheckReportSupplierName { get; set; } = null!;
        public string CheckReportProcureTypeMethodName { get; set; } = null!;
        public string CheckReportPlanCoreName { get; set; } = null!;
        public int CheckReportAmount { get; set; }
        public decimal CheckReportTotalBill { get; set; }
        public decimal CheckReportLateDeliveryFineValue { get; set; }
        public bool IsByBudgetControl { get; set; }
        public bool IsFinalCheckByBudgetControl { get; set; }
        public bool HasFine { get; set; }
        public bool? IsResultCheckedCorrect { get; set; }
        public string ItemName { get; set; } = null!;
        public string CheckSixthComittee { get; set; } = null!;
        public string CheckSeventhComittee { get; set; } = null!;
        public string CheckEighthComittee { get; set; } = null!;
        public string CheckNinthComittee { get; set; } = null!;
    }
}