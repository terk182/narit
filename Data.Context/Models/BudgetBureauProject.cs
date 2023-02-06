using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class BudgetBureauProject
    {
        public int Id { get; set; }
        public bool? Active { get; set; }
        public string? Code { get; set; }
        public int? FiscalYear { get; set; }
        public string Name { get; set; } = null!;
        public string? Remark { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? BudgetBureauPlansId { get; set; }
        public int? BudgetBureauStrategiesId { get; set; }

        public virtual BudgetBureauPlan? BudgetBureauPlans { get; set; }
        public virtual BudgetBureauStrategy? BudgetBureauStrategies { get; set; }
    }
}
