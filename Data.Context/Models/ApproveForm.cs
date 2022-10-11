using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class ApproveForm
    {
        public ApproveForm()
        {
            AppFormActionLogs = new HashSet<AppFormActionLog>();
            ApproveItemPlanReferenceItems = new HashSet<ApproveItemPlanReferenceItem>();
            ApproveItems = new HashSet<ApproveItem>();
            ProcureFiles = new HashSet<ProcureFile>();
        }

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

        public virtual ICollection<AppFormActionLog> AppFormActionLogs { get; set; }
        public virtual ICollection<ApproveItemPlanReferenceItem> ApproveItemPlanReferenceItems { get; set; }
        public virtual ICollection<ApproveItem> ApproveItems { get; set; }
        public virtual ICollection<ProcureFile> ProcureFiles { get; set; }
    }
}
