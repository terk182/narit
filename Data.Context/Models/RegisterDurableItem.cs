using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class RegisterDurableItem
    {
        public RegisterDurableItem()
        {
            ProcureFiles = new HashSet<ProcureFile>();
            ProcureRepairForms = new HashSet<ProcureRepairForm>();
            RegDurableItemActionLogs = new HashSet<RegDurableItemActionLog>();
            RegisterItemCheckRecords = new HashSet<RegisterItemCheckRecord>();
            RegisterItemTransferRecords = new HashSet<RegisterItemTransferRecord>();
        }

        public int Id { get; set; }
        public int? RegisterProcureItemId { get; set; }
        public string RegisterCode { get; set; } = null!;
        public bool Active { get; set; }
        public int Status { get; set; }
        public string Name { get; set; } = null!;
        public int DepartmentId { get; set; }
        public int PlanActivityId { get; set; }
        public int FiscalYear { get; set; }
        public string Unit { get; set; } = null!;
        public decimal? PricePerPiece { get; set; }
        public DateTime? Date { get; set; }
        public string NumberCode { get; set; } = null!;
        public string PaidEvidenceNumber { get; set; } = null!;
        public int? ResponsiblePersonId { get; set; }
        public string ResponsiblePersonName { get; set; } = null!;
        public int RegisterProcureItemTypeId { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public string Comment { get; set; } = null!;
        public int? EnduranceTypeEnum { get; set; }
        public int? RegisterItemDisposedFormId { get; set; }
        public int? HrdepartmentId { get; set; }
        public int WarrantyPeriodWeek { get; set; }
        public DateTime? RegisterCodeDate { get; set; }
        public string ItemBrand { get; set; } = null!;
        public string ItemModel { get; set; } = null!;
        public string SuppliesOfficerName { get; set; } = null!;
        public string SupplierName { get; set; } = null!;
        public string StoreLocation { get; set; } = null!;
        public string SerialNumber { get; set; } = null!;
        public string HrdepartmentName { get; set; } = null!;
        public int? ProcureStoreLocationId { get; set; }
        public string DisposedRemark { get; set; } = null!;
        public int DurableItemStatus { get; set; }
        public int? WarrantyYear { get; set; }
        public int? WarrantyMonth { get; set; }
        public int? WarrantyDay { get; set; }

        public virtual ProcureStoreLocation? ProcureStoreLocation { get; set; }
        public virtual RegisterItemDisposedForm? RegisterItemDisposedForm { get; set; }
        public virtual RegisterProcureItem? RegisterProcureItem { get; set; }
        public virtual RegisterProcureItemType RegisterProcureItemType { get; set; } = null!;
        public virtual ICollection<ProcureFile> ProcureFiles { get; set; }
        public virtual ICollection<ProcureRepairForm> ProcureRepairForms { get; set; }
        public virtual ICollection<RegDurableItemActionLog> RegDurableItemActionLogs { get; set; }
        public virtual ICollection<RegisterItemCheckRecord> RegisterItemCheckRecords { get; set; }
        public virtual ICollection<RegisterItemTransferRecord> RegisterItemTransferRecords { get; set; }
    }
}
