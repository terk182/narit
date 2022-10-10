using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class OverTimeRequestForm
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime ClockIn { get; set; }
        public DateTime ClockOut { get; set; }
        public string Detail { get; set; } = null!;
        public int FiscalYear { get; set; }
        public int? HrdepartmentId { get; set; }
        public string HrdepartmentName { get; set; } = null!;
        public DateTime ForDate { get; set; }
        public TimeSpan TotalHour { get; set; }
        public int StaffId { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string OfficeHourText { get; set; } = null!;
        public bool IsHolidayOrDayOff { get; set; }
        public int OverTimeRequestFormGroupId { get; set; }
        public int StaffWorkShiftId { get; set; }
        public string StaffWorkShiftName { get; set; } = null!;
        public int WorkShiftDataId { get; set; }
        public DateTime StaffWorkShiftClockIn { get; set; }
        public DateTime StaffWorkShiftClockOut { get; set; }
        public DateTime? DailyAttendanceClockIn { get; set; }
        public DateTime? DailyAttendanceClockOut { get; set; }
        public string? RatePerHourEncrypted { get; set; }
        public int? OverTimeRequestResultFormGroupId { get; set; }

        public virtual OverTimeRequestFormGroup OverTimeRequestFormGroup { get; set; } = null!;
        public virtual OverTimeRequestResultFormGroup? OverTimeRequestResultFormGroup { get; set; }
        public virtual Staff Staff { get; set; } = null!;
    }
}
