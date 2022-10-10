using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class ProcureTrackingRefItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int ProcureTrackingItemTypeEnum { get; set; }
        public decimal Amount { get; set; }
        public decimal PricePerPiece { get; set; }
        public string Unit { get; set; } = null!;
        public int ProcureMethodEnum { get; set; }
        public int ProcureItemId { get; set; }
        public int ProcureTrackingItemId { get; set; }
        public int ProcureTrackingRefFormId { get; set; }

        public virtual ProcureTrackingItem ProcureTrackingItem { get; set; } = null!;
        public virtual ProcureTrackingRefForm ProcureTrackingRefForm { get; set; } = null!;
    }
}
