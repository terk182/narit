using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class GeneralExpenseReturnItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public decimal ReturnBudget { get; set; }
        public decimal RemainWithdrawableBudgetAtDate { get; set; }
        public int GeneralExpenseReturnFormId { get; set; }
        public int GeneralExpenseId { get; set; }
        public int PlanItemId { get; set; }
        public int PlanActivityId { get; set; }
        public int PlanCoreId { get; set; }

        public virtual GeneralExpense GeneralExpense { get; set; } = null!;
        public virtual GeneralExpenseReturnForm GeneralExpenseReturnForm { get; set; } = null!;
    }
}
