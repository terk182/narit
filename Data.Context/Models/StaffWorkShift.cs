using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class StaffWorkShift
    {
        public StaffWorkShift()
        {
            DailyAttendances = new HashSet<DailyAttendance>();
            StaffWorkShiftSpecificDayOffs = new HashSet<StaffWorkShiftSpecificDayOff>();
            StaffWorkShiftSpecificHolidays = new HashSet<StaffWorkShiftSpecificHoliday>();
            WorkShiftSwitchFormFromStaffWorkShifts = new HashSet<WorkShiftSwitchForm>();
            WorkShiftSwitchFormFromSwitchedStaffWorkShifts = new HashSet<WorkShiftSwitchForm>();
            WorkShiftSwitchFormToStaffWorkShifts = new HashSet<WorkShiftSwitchForm>();
            WorkShiftSwitchFormToSwitchedStaffWorkShifts = new HashSet<WorkShiftSwitchForm>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public bool InUsed { get; set; }
        public int StaffId { get; set; }
        public bool UsedGenericHoliday { get; set; }
        public string WorkShiftDataName { get; set; } = null!;
        public bool IsSingleTimeStamp { get; set; }
        public bool IsFlexibleTimeStamp { get; set; }
        public TimeSpan TimeStart { get; set; }
        public TimeSpan TimeEnd { get; set; }
        public string PermittedSensorIdValue { get; set; } = null!;
        public string Remark { get; set; } = null!;
        public TimeSpan TimeBreakStart { get; set; }
        public TimeSpan TimeBreakEnd { get; set; }
        public int? WorkShiftDataId { get; set; }

        public virtual Staff Staff { get; set; } = null!;
        public virtual WorkShiftData? WorkShiftData { get; set; }
        public virtual ICollection<DailyAttendance> DailyAttendances { get; set; }
        public virtual ICollection<StaffWorkShiftSpecificDayOff> StaffWorkShiftSpecificDayOffs { get; set; }
        public virtual ICollection<StaffWorkShiftSpecificHoliday> StaffWorkShiftSpecificHolidays { get; set; }
        public virtual ICollection<WorkShiftSwitchForm> WorkShiftSwitchFormFromStaffWorkShifts { get; set; }
        public virtual ICollection<WorkShiftSwitchForm> WorkShiftSwitchFormFromSwitchedStaffWorkShifts { get; set; }
        public virtual ICollection<WorkShiftSwitchForm> WorkShiftSwitchFormToStaffWorkShifts { get; set; }
        public virtual ICollection<WorkShiftSwitchForm> WorkShiftSwitchFormToSwitchedStaffWorkShifts { get; set; }
    }
}
