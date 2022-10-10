using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class ProcureTrackingItem
    {
        public ProcureTrackingItem()
        {
            ProcureTrackingRefItems = new HashSet<ProcureTrackingRefItem>();
            ProcureTrackingBaseItems = new HashSet<ProcureTrackingBaseItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public decimal Amount { get; set; }
        public decimal PricePerPiece { get; set; }
        public string Unit { get; set; } = null!;
        public string Remark { get; set; } = null!;
        public int ProcureTrackingMethodEnum { get; set; }
        public int ProcureMethodEnum { get; set; }
        public int ProcureTrackingGroupId { get; set; }

        public virtual ProcureTrackingGroup ProcureTrackingGroup { get; set; } = null!;
        public virtual ICollection<ProcureTrackingRefItem> ProcureTrackingRefItems { get; set; }

        public virtual ICollection<ProcureTrackingBaseItem> ProcureTrackingBaseItems { get; set; }
    }
}
