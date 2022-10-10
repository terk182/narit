using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class Quotation
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string SupplierName { get; set; } = null!;
        public string SupplierAddress { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public DateTime? WriteDate { get; set; }
        public decimal? Price { get; set; }
        public int? OrderFormId { get; set; }
        public int? SupplierId { get; set; }

        public virtual OrderForm? OrderForm { get; set; }
        public virtual Supplier? Supplier { get; set; }
    }
}
