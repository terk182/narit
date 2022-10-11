using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class WithdrawalItem
    {
        public WithdrawalItem()
        {
            SettlementItems = new HashSet<SettlementItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int GeneralExpenseId { get; set; }
        public int? SettlementItemId { get; set; }
        public decimal WithDrawnAmount { get; set; }
        public int GeneralExpenseMemoFormId { get; set; }
        public int WithdrawalFormId { get; set; }
        public decimal WithdrawableGeneralExpenseAtDate { get; set; }
        public decimal TotalGeneralExpenseAtDate { get; set; }
        public bool IsExtraAdded { get; set; }
        public int? SettleReceiptItemId { get; set; }

        public virtual GeneralExpense GeneralExpense { get; set; } = null!;
        public virtual GeneralExpenseMemoForm GeneralExpenseMemoForm { get; set; } = null!;
        public virtual SettleReceiptItem? SettleReceiptItem { get; set; }
        public virtual SettlementItem? SettlementItem { get; set; }
        public virtual WithdrawalForm WithdrawalForm { get; set; } = null!;
        public virtual ICollection<SettlementItem> SettlementItems { get; set; }
    }
}
