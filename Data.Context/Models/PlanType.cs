using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class PlanType
    {
        public PlanType()
        {
            InverseParentPlanType = new HashSet<PlanType>();
            PlanCores = new HashSet<PlanCore>();
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
        public virtual ICollection<PlanCore> PlanCores { get; set; }
    }
}
