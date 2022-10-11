using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class ProcureLoaningSettleItem
    {
        public ProcureLoaningSettleItem()
        {
            ProcureLoaningWithdrawalItems = new HashSet<ProcureLoaningWithdrawalItem>();
            RegisterProcureItems = new HashSet<RegisterProcureItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public decimal? SettleMoney { get; set; }
        public decimal? SettleMoneyAsBudget { get; set; }
        public decimal? WithdrawnMoneyAtDate { get; set; }
        public int ProcureSettleMemoFormId { get; set; }
        public int ProcureLoaningItemId { get; set; }
        public decimal? SettleAmount { get; set; }
        public decimal? WithdrawnAmountAtDate { get; set; }
        public int? ProcureSettleReceiptItemId { get; set; }

        public virtual ProcureLoaningItem ProcureLoaningItem { get; set; } = null!;
        public virtual ProcureSettleMemoForm ProcureSettleMemoForm { get; set; } = null!;
        public virtual ProcureSettleReceiptItem? ProcureSettleReceiptItem { get; set; }
        public virtual ICollection<ProcureLoaningWithdrawalItem> ProcureLoaningWithdrawalItems { get; set; }
        public virtual ICollection<RegisterProcureItem> RegisterProcureItems { get; set; }
    }
}
