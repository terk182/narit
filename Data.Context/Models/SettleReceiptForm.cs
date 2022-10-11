using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class SettleReceiptForm
    {
        public SettleReceiptForm()
        {
            PlanFiles = new HashSet<PlanFile>();
            SeReceiptFormActionLogs = new HashSet<SeReceiptFormActionLog>();
            SettleReceiptItems = new HashSet<SettleReceiptItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int GeneralExpenseMemoFormId { get; set; }
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
        public bool IsSent { get; set; }
        public int? UnitChiefStaffId { get; set; }
        public int BankAccountEnum { get; set; }
        public int? RequesterSignatureId { get; set; }
        public int? RequesterStaffId { get; set; }
        public int? BudgetCheckerStaffId { get; set; }
        public int? BudgetCheckerSignatureId { get; set; }
        public int? UnitChiefSignatureId { get; set; }
        public string AccountantName { get; set; } = null!;
        public DateTime? AccountantSignDate { get; set; }
        public int? AccountantStaffId { get; set; }
        public int? AccountantSignatureId { get; set; }

        public virtual GeneralExpenseMemoForm GeneralExpenseMemoForm { get; set; } = null!;
        public virtual ICollection<PlanFile> PlanFiles { get; set; }
        public virtual ICollection<SeReceiptFormActionLog> SeReceiptFormActionLogs { get; set; }
        public virtual ICollection<SettleReceiptItem> SettleReceiptItems { get; set; }
    }
}
