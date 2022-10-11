using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class ProcureSettleReceiptForm
    {
        public ProcureSettleReceiptForm()
        {
            ProcureSettleReceiptItems = new HashSet<ProcureSettleReceiptItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public DateTime? WriteDate { get; set; }
        public string Inform { get; set; } = null!;
        public string Purpose { get; set; } = null!;
        public string DocumentNumber { get; set; } = null!;
        public string RequesterName { get; set; } = null!;
        public DateTime? RequesterSignDate { get; set; }
        public string BudgetCheckerName { get; set; } = null!;
        public DateTime? BudgetCheckerSignDate { get; set; }
        public int? StatementPayMethodEnum { get; set; }
        public int StatementPayStatusEnum { get; set; }
        public DateTime? PayDate { get; set; }
        public decimal? NetPayValue { get; set; }
        public string PaymentDocumentNumber { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public DateTime StatementCalculationDate { get; set; }
        public string PaymentRemark { get; set; } = null!;
        public string StatementName { get; set; } = null!;
        public int PlanFormApprovalStatusEnum { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime? UnitChiefSignDate { get; set; }
        public string UnitChiefName { get; set; } = null!;
        public int ProcureLoaningMemoFormId { get; set; }
        public string SummaryStatementByPlanItem { get; set; } = null!;

        public virtual ProcureLoaningMemoForm ProcureLoaningMemoForm { get; set; } = null!;
        public virtual ICollection<ProcureSettleReceiptItem> ProcureSettleReceiptItems { get; set; }
    }
}
