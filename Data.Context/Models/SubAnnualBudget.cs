using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class SubAnnualBudget
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public bool Active { get; set; }
        public int? ParentsubAnnualBudgetId { get; set; }
        public int ExpenseTypeEnum { get; set; }
        public int GovExpenseTypeEnum { get; set; }
        public int? AnnualBudgetId { get; set; }
    }
}
