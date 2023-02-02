using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class PlanBudget
    {
        public PlanBudget()
        {
            ProjectBudgets = new HashSet<ProjectBudget>();
        }

        public int Id { get; set; }
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public int? Remark { get; set; }
        public byte[]? CreateDate { get; set; }

        public virtual ICollection<ProjectBudget> ProjectBudgets { get; set; }
    }
}
