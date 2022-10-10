using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class DailyAttendanceRequestForm
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime? ClockIn { get; set; }
        public DateTime? ClockOut { get; set; }
        public string Detail { get; set; } = null!;
        public int FiscalYear { get; set; }
        public int? HrdepartmentId { get; set; }
        public string HrdepartmentName { get; set; } = null!;
        public DateTime ForDate { get; set; }
        public int StaffId { get; set; }
        public DateTime? WriteDate { get; set; }
        public string Inform { get; set; } = null!;
        public string WriteAt { get; set; } = null!;
        public DateTime? UnitChiefSignDate { get; set; }
        public string UnitChiefName { get; set; } = null!;
        public string UnitChiefOpinion { get; set; } = null!;
        public string UnitChiefPositionName { get; set; } = null!;
        public string Approver { get; set; } = null!;
        public DateTime? ApproverSignDate { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ApproverPosition { get; set; } = null!;
        public string DocumentNumber { get; set; } = null!;
        public string ApproverOpinion { get; set; } = null!;
        public int WorkAttendanceTimeRangeEnum { get; set; }
        public int ClockInOutStatusEnum { get; set; }
        public string StaffWorkShiftName { get; set; } = null!;
        public DateTime StaffWorkShiftClockIn { get; set; }
        public DateTime StaffWorkShiftClockOut { get; set; }
        public int StaffWorkShiftId { get; set; }
        public int WorkShiftDataId { get; set; }
        public int? ApproverId { get; set; }
        public int? ApprovedSignStaffId { get; set; }
        public string ApprovedSignHostName { get; set; } = null!;
        public string ApprovedSignHostAddress { get; set; } = null!;
        public int? CreatorStaffId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatorHostName { get; set; } = null!;
        public string CreatorHostAddress { get; set; } = null!;

        public virtual Staff Staff { get; set; } = null!;
    }
}
