using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class ProcureTrackingGroup
    {
        public ProcureTrackingGroup()
        {
            ProcureTrackingActions = new HashSet<ProcureTrackingAction>();
            ProcureTrackingItems = new HashSet<ProcureTrackingItem>();
            ProcureTrackingRefForms = new HashSet<ProcureTrackingRefForm>();
            ProcureComitteeGroups = new HashSet<ProcureComitteeGroup>();
            ProcureTrackingBaseItems = new HashSet<ProcureTrackingBaseItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }

        public virtual ICollection<ProcureTrackingAction> ProcureTrackingActions { get; set; }
        public virtual ICollection<ProcureTrackingItem> ProcureTrackingItems { get; set; }
        public virtual ICollection<ProcureTrackingRefForm> ProcureTrackingRefForms { get; set; }

        public virtual ICollection<ProcureComitteeGroup> ProcureComitteeGroups { get; set; }
        public virtual ICollection<ProcureTrackingBaseItem> ProcureTrackingBaseItems { get; set; }
    }
}
