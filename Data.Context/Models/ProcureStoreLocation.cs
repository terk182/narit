using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class ProcureStoreLocation
    {
        public ProcureStoreLocation()
        {
            InverseParentProcureStoreLocation = new HashSet<ProcureStoreLocation>();
            RegisterDurableItems = new HashSet<RegisterDurableItem>();
            RegisterItemTransferRecordFromProcureStoreLocations = new HashSet<RegisterItemTransferRecord>();
            RegisterItemTransferRecordToProcureStoreLocations = new HashSet<RegisterItemTransferRecord>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int? ParentProcureStoreLocationId { get; set; }
        public int ProcureStoreLocationTypeEnum { get; set; }
        public string Detail { get; set; } = null!;
        public string Code { get; set; } = null!;
        public double? Area { get; set; }
        public string CanvasPosition { get; set; } = null!;
        public int? HrdepartmentId { get; set; }
        public string ImagePath { get; set; } = null!;

        public virtual ProcureStoreLocation? ParentProcureStoreLocation { get; set; }
        public virtual ICollection<ProcureStoreLocation> InverseParentProcureStoreLocation { get; set; }
        public virtual ICollection<RegisterDurableItem> RegisterDurableItems { get; set; }
        public virtual ICollection<RegisterItemTransferRecord> RegisterItemTransferRecordFromProcureStoreLocations { get; set; }
        public virtual ICollection<RegisterItemTransferRecord> RegisterItemTransferRecordToProcureStoreLocations { get; set; }
    }
}
