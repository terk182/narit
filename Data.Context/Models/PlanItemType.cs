using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class PlanItemType
    {
        public PlanItemType()
        {
            CheckViewUsedPlanItems = new HashSet<CheckViewUsedPlanItem>();
            InverseParentPlanItemType = new HashSet<PlanItemType>();
            PlanItems = new HashSet<PlanItem>();
            RequestViewUsedPlanItems = new HashSet<RequestViewUsedPlanItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int FiscalYear { get; set; }
        public int? ParentPlanItemTypeId { get; set; }
        public int? ReferenceOldId { get; set; }

        public virtual PlanItemType? ParentPlanItemType { get; set; }
        public virtual ICollection<CheckViewUsedPlanItem> CheckViewUsedPlanItems { get; set; }
        public virtual ICollection<PlanItemType> InverseParentPlanItemType { get; set; }
        public virtual ICollection<PlanItem> PlanItems { get; set; }
        public virtual ICollection<RequestViewUsedPlanItem> RequestViewUsedPlanItems { get; set; }
    }
}
