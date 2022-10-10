using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class OrderContract
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public DateTime? SentMailDate { get; set; }
        public int TimeCount { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int OrderFormId { get; set; }
        public int? SupplierId { get; set; }

        public virtual OrderForm OrderForm { get; set; } = null!;
        public virtual Supplier? Supplier { get; set; }
    }
}
