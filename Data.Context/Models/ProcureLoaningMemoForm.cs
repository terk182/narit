using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class ProcureLoaningMemoForm
    {
        public ProcureLoaningMemoForm()
        {
            ProcureLoaningCancelForms = new HashSet<ProcureLoaningCancelForm>();
            ProcureLoaningFormActionLogs = new HashSet<ProcureLoaningFormActionLog>();
            ProcureLoaningItemPlanReferenceItems = new HashSet<ProcureLoaningItemPlanReferenceItem>();
            ProcureLoaningItems = new HashSet<ProcureLoaningItem>();
            ProcureLoaningReturnForms = new HashSet<ProcureLoaningReturnForm>();
            ProcureLoaningWithdrawalForms = new HashSet<ProcureLoaningWithdrawalForm>();
            ProcureLoaningWithdrawalItems = new HashSet<ProcureLoaningWithdrawalItem>();
            ProcureSettleMemoForms = new HashSet<ProcureSettleMemoForm>();
            ProcureSettleReceiptForms = new HashSet<ProcureSettleReceiptForm>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public DateTime? WriteDate { get; set; }
        public string Inform { get; set; } = null!;
        public string Enclosures { get; set; } = null!;
        public string Purpose { get; set; } = null!;
        public string RequesterName { get; set; } = null!;
        public DateTime? RequesterSignDate { get; set; }
        public string SuppliesUnitChiefName { get; set; } = null!;
        public DateTime? SuppliesUnitChiefSignDate { get; set; }
        public string BudgetCheckerName { get; set; } = null!;
        public DateTime? BudgetCheckerSignDate { get; set; }
        public string Approver { get; set; } = null!;
        public DateTime? ApproverSignDate { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public string DepartmentName { get; set; } = null!;
        public int DepartmentId { get; set; }
        public string PlanTypeName { get; set; } = null!;
        public int PlanTypeId { get; set; }
        public string PlanCoreName { get; set; } = null!;
        public int PlanCoreId { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int RequestFormId { get; set; }
        public string RequestFormNumber { get; set; } = null!;
        public DateTime? RequestFormDate { get; set; }
        public int ApproveFormId { get; set; }
        public DateTime? ApproveFormDate { get; set; }
        public string ApproveFormNumber { get; set; } = null!;
        public decimal? LoaningAmount { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public DateTime StatementCalculationDate { get; set; }
        public int PlanActivityIdOld { get; set; }
        public string FundTypeName { get; set; } = null!;
        public int FundTypeId { get; set; }
        public string StatementName { get; set; } = null!;
        public int ProcureTypeEnum { get; set; }
        public bool? IsBorrow { get; set; }
        public int StatementPayStatusEnum { get; set; }
        public string StaffPositionName { get; set; } = null!;
        public string StaffDepartmentName { get; set; } = null!;
        public string AttorneyName { get; set; } = null!;
        public string PlanActivityName { get; set; } = null!;
        public string BudgetTypeName { get; set; } = null!;
        public string PlanItemName { get; set; } = null!;
        public string StaffContactNumber { get; set; } = null!;
        public string RefDocumentNumber { get; set; } = null!;
        public DateTime? RefDocumentDate { get; set; }
        public DateTime? SettleDate { get; set; }
        public DateTime? DueDate { get; set; }
        public int SettleDay { get; set; }
        public DateTime? StartCountingDate { get; set; }
        public DateTime? AttorneySignDate { get; set; }
        public string UnitChiefName { get; set; } = null!;
        public int? UnitChiefId { get; set; }
        public DateTime? UnitChiefSignDate { get; set; }
        public string OperationSummary { get; set; } = null!;
        public string RelatedRegulation { get; set; } = null!;
        public string OtherRequest { get; set; } = null!;
        public int? SuppliesUnitChiefId { get; set; }
        public decimal RequestFormTotalBudget { get; set; }
        public string SummaryStatementByPlanCoreValue { get; set; } = null!;
        public int? RequesterId { get; set; }
        public int? ApproverId { get; set; }
        public string Detail { get; set; } = null!;
        public int PlanFormApprovalStatusEnum { get; set; }

        public virtual ICollection<ProcureLoaningCancelForm> ProcureLoaningCancelForms { get; set; }
        public virtual ICollection<ProcureLoaningFormActionLog> ProcureLoaningFormActionLogs { get; set; }
        public virtual ICollection<ProcureLoaningItemPlanReferenceItem> ProcureLoaningItemPlanReferenceItems { get; set; }
        public virtual ICollection<ProcureLoaningItem> ProcureLoaningItems { get; set; }
        public virtual ICollection<ProcureLoaningReturnForm> ProcureLoaningReturnForms { get; set; }
        public virtual ICollection<ProcureLoaningWithdrawalForm> ProcureLoaningWithdrawalForms { get; set; }
        public virtual ICollection<ProcureLoaningWithdrawalItem> ProcureLoaningWithdrawalItems { get; set; }
        public virtual ICollection<ProcureSettleMemoForm> ProcureSettleMemoForms { get; set; }
        public virtual ICollection<ProcureSettleReceiptForm> ProcureSettleReceiptForms { get; set; }
    }
}
