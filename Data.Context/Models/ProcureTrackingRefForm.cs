using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class ProcureTrackingRefForm
    {
        public ProcureTrackingRefForm()
        {
            ProcureTrackingRefItems = new HashSet<ProcureTrackingRefItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int ProcureTrackingFormTypeEnum { get; set; }
        public int ProcureFormId { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public DateTime? WriteDate { get; set; }
        public int ProcureMethodEnum { get; set; }
        public int ProcureTrackingGroupId { get; set; }
        public int ProcureTrackingActionId { get; set; }

        public virtual ProcureTrackingAction ProcureTrackingAction { get; set; } = null!;
        public virtual ProcureTrackingGroup ProcureTrackingGroup { get; set; } = null!;
        public virtual ICollection<ProcureTrackingRefItem> ProcureTrackingRefItems { get; set; }
    }
}
