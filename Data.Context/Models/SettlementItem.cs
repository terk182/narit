using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class SettlementItem
    {
        public SettlementItem()
        {
            WithdrawalItems = new HashSet<WithdrawalItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int GeneralExpenseSettleFormId { get; set; }
        public int GeneralExpenseId { get; set; }
        public decimal SettleAmount { get; set; }
        public decimal? SettleAmountAsBudget { get; set; }
        public decimal TotalGeneralExpenseAtDate { get; set; }
        public decimal WithdrawnAmountAtDate { get; set; }
        public bool IsLateAdded { get; set; }
        public decimal UsedBudget { get; set; }
        public int? WithdrawalItemRefForLatedAddId { get; set; }
        public int? WithdrawalItemId { get; set; }
        public int? SettleReceiptItemId { get; set; }
        public int? BorrowerStaffId { get; set; }

        public virtual GeneralExpense GeneralExpense { get; set; } = null!;
        public virtual GeneralExpenseSettleForm GeneralExpenseSettleForm { get; set; } = null!;
        public virtual SettleReceiptItem? SettleReceiptItem { get; set; }
        public virtual WithdrawalItem? WithdrawalItem { get; set; }
        public virtual ICollection<WithdrawalItem> WithdrawalItems { get; set; }
    }
}
