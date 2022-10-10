using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class FingerPrintDbrawData
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int SensorId { get; set; }
        public int BadgeNumber { get; set; }
        public DateTime CheckTime { get; set; }
        public int StaffId { get; set; }
        public int FingerPrintDbconnectorId { get; set; }
        public int RawDbid { get; set; }
        public DateTime ReadDate { get; set; }
        public int FiscalYear { get; set; }
        public string StaffName { get; set; } = null!;
        public DateTime ForDate { get; set; }
        public bool IsPassToDailyAttendance { get; set; }
        public string FailReasonValue { get; set; } = null!;
    }
}
