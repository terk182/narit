using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class DailyAttendance
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime? ClockIn { get; set; }
        public DateTime? ClockOut { get; set; }
        public string Remark { get; set; } = null!;
        public int StaffId { get; set; }
        public int FiscalYear { get; set; }
        public int? HrdepartmentId { get; set; }
        public string HrdepartmentName { get; set; } = null!;
        public DateTime ForDate { get; set; }
        public int SensorId { get; set; }
        public int WorkAttendanceTimeRangeEnum { get; set; }
        public string RawDataValue { get; set; } = null!;
        public int DailyAttendanceSourceEnum { get; set; }
        public int StaffWorkShiftId { get; set; }
        public int WorkShiftDataId { get; set; }
        public bool IsWorkShiftExtraAllowanceApproved { get; set; }

        public virtual Staff Staff { get; set; } = null!;
        public virtual StaffWorkShift StaffWorkShift { get; set; } = null!;
    }
}
