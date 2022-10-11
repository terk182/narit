using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class ProcureSettleReceiptItemPlanView
    {
        public ProcureSettleReceiptItemPlanView()
        {
            CheckViewUsedPlanItems = new HashSet<CheckViewUsedPlanItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public decimal SettleMoney { get; set; }
        public decimal? SettleMoneyAsBudget { get; set; }
        public decimal UsedBudget { get; set; }
        public decimal SettleAmount { get; set; }
        public int ProcureSettleReceiptItemId { get; set; }
        public int ProcureSettleReceiptFormPlanViewId { get; set; }
        public int RequestViewUsedPlanItemId { get; set; }
        public int PlanItemId { get; set; }
        public int ProcureLoaningItemId { get; set; }

        public virtual ProcureSettleReceiptFormPlanView ProcureSettleReceiptFormPlanView { get; set; } = null!;
        public virtual RequestViewUsedPlanItem RequestViewUsedPlanItem { get; set; } = null!;
        public virtual ICollection<CheckViewUsedPlanItem> CheckViewUsedPlanItems { get; set; }
    }
}
