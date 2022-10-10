using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class DocumentWarehouse
    {
        public DocumentWarehouse()
        {
            FilingDocWarehouseRelations = new HashSet<FilingDocWarehouseRelation>();
            InverseParentDocumentWarehouse = new HashSet<DocumentWarehouse>();
        }

        public int Id { get; set; }
        public bool Active { get; set; }
        public string Detail { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int PermissionLevelEnum { get; set; }
        public string StaffGroupValue { get; set; } = null!;
        public string DepGroupValue { get; set; } = null!;
        public int? ParentDocumentWarehouseId { get; set; }

        public virtual DocumentWarehouse? ParentDocumentWarehouse { get; set; }
        public virtual ICollection<FilingDocWarehouseRelation> FilingDocWarehouseRelations { get; set; }
        public virtual ICollection<DocumentWarehouse> InverseParentDocumentWarehouse { get; set; }
    }
}
