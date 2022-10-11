using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class SettleDirectPaymentItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public decimal UsedBudget { get; set; }
        public int GeneralExpenseSettleFormId { get; set; }
        public int GeneralExpenseId { get; set; }

        public virtual GeneralExpense GeneralExpense { get; set; } = null!;
        public virtual GeneralExpenseSettleForm GeneralExpenseSettleForm { get; set; } = null!;
    }
}
