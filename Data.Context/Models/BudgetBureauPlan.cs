using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class BudgetBureauPlan
    {
        public BudgetBureauPlan()
        {
            BudgetBureauProjects = new HashSet<BudgetBureauProject>();
        }

        public int Id { get; set; }
        public bool? Active { get; set; }
        public string? Code { get; set; }
        public int? FiscalYear { get; set; }
        public string Name { get; set; } = null!;
        public string? Remark { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual ICollection<BudgetBureauProject> BudgetBureauProjects { get; set; }
    }
}
