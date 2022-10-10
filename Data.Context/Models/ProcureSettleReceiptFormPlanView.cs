using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class ProcureSettleReceiptFormPlanView
    {
        public ProcureSettleReceiptFormPlanView()
        {
            ProcureSettleReceiptItemPlanViews = new HashSet<ProcureSettleReceiptItemPlanView>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public DateTime? WriteDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public string RequesterName { get; set; } = null!;
        public int? StatementPayMethodEnum { get; set; }
        public int StatementPayStatusEnum { get; set; }
        public DateTime? PayDate { get; set; }
        public decimal? NetPayValue { get; set; }
        public string PaymentDocumentNumber { get; set; } = null!;
        public DateTime StatementCalculationDate { get; set; }
        public string PaymentRemark { get; set; } = null!;
        public string StatementName { get; set; } = null!;
        public string SummaryStatementByPlanItem { get; set; } = null!;
        public int ProcureSettleReceiptFormId { get; set; }
        public int ProcureLoaningWithdrawalFormPlanViewId { get; set; }
        public string SettleMoneyByPlanItemValue { get; set; } = null!;
        public string SettleMoneyByPlanActivityValue { get; set; } = null!;
        public string UsedBudgetByPlanItemValue { get; set; } = null!;
        public string UsedBudgetByPlanActivityValue { get; set; } = null!;

        public virtual ProcureLoaningWithdrawalFormPlanView ProcureLoaningWithdrawalFormPlanView { get; set; } = null!;
        public virtual ICollection<ProcureSettleReceiptItemPlanView> ProcureSettleReceiptItemPlanViews { get; set; }
    }
}
