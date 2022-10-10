using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class PrinciplePlanTag
    {
        public PrinciplePlanTag()
        {
            InverseParentPrinciplePlanTag = new HashSet<PrinciplePlanTag>();
            PlanCores = new HashSet<PlanCore>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public decimal Weight { get; set; }
        public int? ParentPrinciplePlanTagId { get; set; }

        public virtual PrinciplePlanTag? ParentPrinciplePlanTag { get; set; }
        public virtual ICollection<PrinciplePlanTag> InverseParentPrinciplePlanTag { get; set; }
        public virtual ICollection<PlanCore> PlanCores { get; set; }
    }
}
