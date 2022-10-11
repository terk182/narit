using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class OutsideDutyReportStaff
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public string StaffName { get; set; } = null!;
        public int StaffId { get; set; }
        public string PositionName { get; set; } = null!;
        public decimal VehicleCost { get; set; }
        public decimal AllowancesCost { get; set; }
        public decimal AccommodationCost { get; set; }
        public decimal OtherCost { get; set; }
        public int OutsideDutyReportFormId { get; set; }
        public string Name { get; set; } = null!;

        public virtual OutsideDutyReportForm OutsideDutyReportForm { get; set; } = null!;
    }
}
