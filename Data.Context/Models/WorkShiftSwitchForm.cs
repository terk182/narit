using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class WorkShiftSwitchForm
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int StaffId { get; set; }
        public TimeSpan? ToTimeStart { get; set; }
        public TimeSpan? ToTimeEnd { get; set; }
        public string Detail { get; set; } = null!;
        public DateTime? WriteDate { get; set; }
        public string Inform { get; set; } = null!;
        public string WriteAt { get; set; } = null!;
        public int FiscalYear { get; set; }
        public DateTime? UnitChiefSignDate { get; set; }
        public string UnitChiefName { get; set; } = null!;
        public string UnitChiefOpinion { get; set; } = null!;
        public string UnitChiefPositionName { get; set; } = null!;
        public string Approver { get; set; } = null!;
        public DateTime? ApproverSignDate { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ApproverPosition { get; set; } = null!;
        public string ApproverOpinion { get; set; } = null!;
        public int? HrdepartmentId { get; set; }
        public string HrdepartmentName { get; set; } = null!;
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool FromIsHolidayOrDayOff { get; set; }
        public bool ToIsHolidayOrDayOff { get; set; }
        public int FromStaffWorkShiftId { get; set; }
        public int ToStaffWorkShiftId { get; set; }
        public string FromOfficeHourText { get; set; } = null!;
        public string ToOfficeHourText { get; set; } = null!;
        public int SwitchedStaffId { get; set; }
        public int? FromSwitchedStaffWorkShiftId { get; set; }
        public int? ToSwitchedStaffWorkShiftId { get; set; }
        public int? ApproverId { get; set; }
        public int? ApprovedSignStaffId { get; set; }
        public string ApprovedSignHostName { get; set; } = null!;
        public string ApprovedSignHostAddress { get; set; } = null!;
        public int? CreatorStaffId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatorHostName { get; set; } = null!;
        public string CreatorHostAddress { get; set; } = null!;

        public virtual StaffWorkShift FromStaffWorkShift { get; set; } = null!;
        public virtual StaffWorkShift? FromSwitchedStaffWorkShift { get; set; }
        public virtual Staff Staff { get; set; } = null!;
        public virtual Staff SwitchedStaff { get; set; } = null!;
        public virtual StaffWorkShift ToStaffWorkShift { get; set; } = null!;
        public virtual StaffWorkShift? ToSwitchedStaffWorkShift { get; set; }
    }
}
