using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class WaterBill
    {
        public WaterBill()
        {
            BillingFiles = new HashSet<BillingFile>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Year { get; set; }
        public bool Active { get; set; }
        public int Month { get; set; }
        public DateTime BillingDate { get; set; }
        public DateTime MeterReadDate { get; set; }
        public decimal ServiceBill { get; set; }
        public decimal TotalBill { get; set; }
        public decimal Unit { get; set; }
        public int BillingLocationId { get; set; }
        public string BilingNumber { get; set; } = null!;
        public string Remark { get; set; } = null!;

        public virtual BillingLocation BillingLocation { get; set; } = null!;
        public virtual ICollection<BillingFile> BillingFiles { get; set; }
    }
}
