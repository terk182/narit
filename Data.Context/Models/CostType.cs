using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class CostType
    {
        public CostType()
        {
            InverseParentCostType = new HashSet<CostType>();
            PlanItems = new HashSet<PlanItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int? ParentCostTypeId { get; set; }
        public int? ReferenceOldId { get; set; }

        public virtual CostType? ParentCostType { get; set; }
        public virtual ICollection<CostType> InverseParentCostType { get; set; }
        public virtual ICollection<PlanItem> PlanItems { get; set; }
    }
}
