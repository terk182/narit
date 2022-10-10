using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class ProcureContractInstallment
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? WriteDate { get; set; }
        public bool Active { get; set; }
        public int ProcureContractId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string Remark { get; set; } = null!;
        public int? DeliveryDay { get; set; }
        public decimal Price { get; set; }
        public int FiscalYear { get; set; }

        public virtual ProcureContract ProcureContract { get; set; } = null!;
    }
}
