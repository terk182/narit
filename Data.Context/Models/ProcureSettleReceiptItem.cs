using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class ProcureSettleReceiptItem
    {
        public ProcureSettleReceiptItem()
        {
            ProcureLoaningSettleItems = new HashSet<ProcureLoaningSettleItem>();
            ProcureLoaningWithdrawalItems = new HashSet<ProcureLoaningWithdrawalItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public decimal SettleMoney { get; set; }
        public decimal? SettleMoneyAsBudget { get; set; }
        public decimal TotalGeneralExpenseAtDate { get; set; }
        public decimal WithdrawnMoneyAtDate { get; set; }
        public decimal UsedBudget { get; set; }
        public int ProcureSettleReceiptFormId { get; set; }
        public int ProcureLoaningItemId { get; set; }
        public decimal WithdrawnAmountAtDate { get; set; }
        public decimal SettleAmount { get; set; }

        public virtual ProcureLoaningItem ProcureLoaningItem { get; set; } = null!;
        public virtual ProcureSettleReceiptForm ProcureSettleReceiptForm { get; set; } = null!;
        public virtual ICollection<ProcureLoaningSettleItem> ProcureLoaningSettleItems { get; set; }
        public virtual ICollection<ProcureLoaningWithdrawalItem> ProcureLoaningWithdrawalItems { get; set; }
    }
}
