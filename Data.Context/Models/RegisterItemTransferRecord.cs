using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class RegisterItemTransferRecord
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int RegisterItemTransferFormId { get; set; }
        public int FromHrdepartmentId { get; set; }
        public int ToHrdepartmentId { get; set; }
        public int RegisterDurableItemId { get; set; }
        public string FromDepartmentName { get; set; } = null!;
        public string ToDepartmentName { get; set; } = null!;
        public int DurableItemStatus { get; set; }
        public string Reason { get; set; } = null!;
        public string StoreLocation { get; set; } = null!;
        public string ResponsiblePersonName { get; set; } = null!;
        public int? FromProcureStoreLocationId { get; set; }
        public int? ToProcureStoreLocationId { get; set; }
        public int ResponsiblePersonId { get; set; }

        public virtual ProcureStoreLocation? FromProcureStoreLocation { get; set; }
        public virtual RegisterDurableItem RegisterDurableItem { get; set; } = null!;
        public virtual RegisterItemTransferForm RegisterItemTransferForm { get; set; } = null!;
        public virtual ProcureStoreLocation? ToProcureStoreLocation { get; set; }
    }
}
