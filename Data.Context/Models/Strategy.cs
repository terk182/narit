using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class Strategy
    {
        public Strategy()
        {
            InverseParentStrategy = new HashSet<Strategy>();
            PlanCores = new HashSet<PlanCore>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? ParentStrategyId { get; set; }
        public int? ReferenceOldId { get; set; }
        public string? Type { get; set; }
        public string? Category { get; set; }

        public virtual Strategy? ParentStrategy { get; set; }
        public virtual ICollection<Strategy> InverseParentStrategy { get; set; }

        public virtual ICollection<PlanCore> PlanCores { get; set; }
    }
}
