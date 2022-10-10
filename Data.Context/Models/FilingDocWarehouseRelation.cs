using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class FilingDocWarehouseRelation
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public int FilingDocumentId { get; set; }
        public int DocumentWarehouseId { get; set; }

        public virtual DocumentWarehouse DocumentWarehouse { get; set; } = null!;
        public virtual FilingDocument FilingDocument { get; set; } = null!;
    }
}
