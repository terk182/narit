using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class GeneralExpenseCancelItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public decimal CancelBudget { get; set; }
        public decimal RemainWithdrawableBudgetAtDate { get; set; }
        public int PlanItemId { get; set; }
        public int PlanActivityId { get; set; }
        public int GeneralExpenseCancelFormId { get; set; }
        public int GeneralExpenseId { get; set; }
        public int PlanCoreId { get; set; }

        public virtual GeneralExpense GeneralExpense { get; set; } = null!;
        public virtual GeneralExpenseCancelForm GeneralExpenseCancelForm { get; set; } = null!;
    }
}
