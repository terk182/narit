using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class BillingFile
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int Size { get; set; }
        public string Path { get; set; } = null!;
        public DateTime UploadDate { get; set; }
        public int? UploadUserId { get; set; }
        public string Type { get; set; } = null!;
        public int Month { get; set; }
        public int? ElectricityBillId { get; set; }
        public int? DrinkingWaterBillId { get; set; }
        public int? TelephoneBillId { get; set; }
        public int? WaterBillId { get; set; }
        public int? GarbageBillId { get; set; }

        public virtual DrinkingWaterBill? DrinkingWaterBill { get; set; }
        public virtual ElectricityBill? ElectricityBill { get; set; }
        public virtual GarbageBill? GarbageBill { get; set; }
        public virtual TelephoneBill? TelephoneBill { get; set; }
        public virtual WaterBill? WaterBill { get; set; }
    }
}
