using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class ElectricityBill
    {
        public ElectricityBill()
        {
            BillingFiles = new HashSet<BillingFile>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal PeakUnit { get; set; }
        public decimal OffPeakUnit { get; set; }
        public decimal HolidayUnit { get; set; }
        public decimal TotalBill { get; set; }
        public decimal PeakBill { get; set; }
        public decimal KwpeakBill { get; set; }
        public decimal OffPeakBill { get; set; }
        public decimal ServiceBill { get; set; }
        public decimal Ft { get; set; }
        public DateTime BillingDate { get; set; }
        public DateTime MeterReadDate { get; set; }
        public decimal PeakKwunit { get; set; }
        public decimal OffPeakKwunit { get; set; }
        public decimal HolidayKwunit { get; set; }
        public int BillingLocationId { get; set; }
        public string BilingNumber { get; set; } = null!;
        public string Remark { get; set; } = null!;

        public virtual BillingLocation BillingLocation { get; set; } = null!;
        public virtual ICollection<BillingFile> BillingFiles { get; set; }
    }
}
