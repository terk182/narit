using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class ProcureLoaningWithdrawalItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public decimal? WithdrawnMoney { get; set; }
        public decimal? WithdrawableBudgetAtDate { get; set; }
        public decimal? TotalAmountAtDate { get; set; }
        public int ProcureLoaningItemId { get; set; }
        public int ProcureLoaningMemoFormId { get; set; }
        public int ProcureLoaningWithdrawalFormId { get; set; }
        public int? ProcureLoaningSettleItemId { get; set; }
        public decimal? WithdrawnAmount { get; set; }
        public decimal? WithdrawableAmountAtDate { get; set; }
        public int? ProcureSettleReceiptItemId { get; set; }

        public virtual ProcureLoaningItem ProcureLoaningItem { get; set; } = null!;
        public virtual ProcureLoaningMemoForm ProcureLoaningMemoForm { get; set; } = null!;
        public virtual ProcureLoaningSettleItem? ProcureLoaningSettleItem { get; set; }
        public virtual ProcureLoaningWithdrawalForm ProcureLoaningWithdrawalForm { get; set; } = null!;
        public virtual ProcureSettleReceiptItem? ProcureSettleReceiptItem { get; set; }
    }
}
