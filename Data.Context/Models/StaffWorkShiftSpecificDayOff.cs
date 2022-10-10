using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class StaffWorkShiftSpecificDayOff
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public bool OnMonday { get; set; }
        public bool OnTuesday { get; set; }
        public bool OnWednesday { get; set; }
        public bool OnThursday { get; set; }
        public bool OnFriday { get; set; }
        public bool OnSaturday { get; set; }
        public bool OnSunday { get; set; }
        public int StaffWorkShiftId { get; set; }

        public virtual StaffWorkShift StaffWorkShift { get; set; } = null!;
    }
}
