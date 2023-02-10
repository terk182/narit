using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class PlanType
    {
        public PlanType()
        {
            InverseParentPlanType = new HashSet<PlanType>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public bool Active { get; set; }
        public int? ParentPlanTypeId { get; set; }
        public int? ReferenceOldId { get; set; }
        public decimal Weight { get; set; }

        public virtual PlanType? ParentPlanType { get; set; }
        public virtual ICollection<PlanType> InverseParentPlanType { get; set; }
    }
}
