using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class StaffWorkShiftSpecificHoliday
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int StaffWorkShiftId { get; set; }

        public virtual StaffWorkShift StaffWorkShift { get; set; } = null!;
    }
}
