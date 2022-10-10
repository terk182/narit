using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class WorkShiftData
    {
        public WorkShiftData()
        {
            StaffWorkShifts = new HashSet<StaffWorkShift>();
            WorkShiftExtraAllowances = new HashSet<WorkShiftExtraAllowance>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public bool IsSingleTimeStamp { get; set; }
        public bool IsFlexibleTimeStamp { get; set; }
        public TimeSpan TimeStart { get; set; }
        public TimeSpan TimeEnd { get; set; }
        public string PermittedSensorIdValue { get; set; } = null!;
        public string Remark { get; set; } = null!;
        public TimeSpan TimeBreakStart { get; set; }
        public TimeSpan TimeBreakEnd { get; set; }
        public bool UsedGenericHoliday { get; set; }
        public string ColorCode { get; set; } = null!;

        public virtual ICollection<StaffWorkShift> StaffWorkShifts { get; set; }
        public virtual ICollection<WorkShiftExtraAllowance> WorkShiftExtraAllowances { get; set; }
    }
}
