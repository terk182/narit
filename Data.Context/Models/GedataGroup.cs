using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class GedataGroup
    {
        public GedataGroup()
        {
            GeneralExpenses = new HashSet<GeneralExpense>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int RangeNumber { get; set; }
        public string Detail { get; set; } = null!;
        public int? GeneralExpenseMemoFormId { get; set; }
        public string FundTypeName { get; set; } = null!;
        public string DepartmentName { get; set; } = null!;
        public string PlanTypeName { get; set; } = null!;
        public string PlanCoreName { get; set; } = null!;
        public string PlanActivityName { get; set; } = null!;
        public decimal? PlanCoreRemainBudget { get; set; }

        public virtual ICollection<GeneralExpense> GeneralExpenses { get; set; }
    }
}
