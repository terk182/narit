using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class SettleReceiptItem
    {
        public SettleReceiptItem()
        {
            SettlementItems = new HashSet<SettlementItem>();
            WithdrawalItems = new HashSet<WithdrawalItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public decimal SettleAmount { get; set; }
        public decimal? SettleAmountAsBudget { get; set; }
        public decimal TotalGeneralExpenseAtDate { get; set; }
        public decimal WithdrawnAmountAtDate { get; set; }
        public decimal UsedBudget { get; set; }
        public int GeneralExpenseId { get; set; }
        public int SettleReceiptFormId { get; set; }

        public virtual GeneralExpense GeneralExpense { get; set; } = null!;
        public virtual SettleReceiptForm SettleReceiptForm { get; set; } = null!;
        public virtual ICollection<SettlementItem> SettlementItems { get; set; }
        public virtual ICollection<WithdrawalItem> WithdrawalItems { get; set; }
    }
}
