using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class BillingLocation
    {
        public BillingLocation()
        {
            DrinkingWaterBills = new HashSet<DrinkingWaterBill>();
            ElectricityBills = new HashSet<ElectricityBill>();
            GarbageBills = new HashSet<GarbageBill>();
            InverseParentBillingLocation = new HashSet<BillingLocation>();
            TelephoneBills = new HashSet<TelephoneBill>();
            WaterBills = new HashSet<WaterBill>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public string Detail { get; set; } = null!;
        public int BillingLocationTypeEnum { get; set; }
        public string MeterId { get; set; } = null!;
        public string MeterSize { get; set; } = null!;
        public string UserCode { get; set; } = null!;
        public decimal Multiplier { get; set; }
        public string Location { get; set; } = null!;
        public string ServiceProviderCode { get; set; } = null!;
        public string UserType { get; set; } = null!;
        public int? ParentBillingLocationId { get; set; }

        public virtual BillingLocation? ParentBillingLocation { get; set; }
        public virtual ICollection<DrinkingWaterBill> DrinkingWaterBills { get; set; }
        public virtual ICollection<ElectricityBill> ElectricityBills { get; set; }
        public virtual ICollection<GarbageBill> GarbageBills { get; set; }
        public virtual ICollection<BillingLocation> InverseParentBillingLocation { get; set; }
        public virtual ICollection<TelephoneBill> TelephoneBills { get; set; }
        public virtual ICollection<WaterBill> WaterBills { get; set; }
    }
}
