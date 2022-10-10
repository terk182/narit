using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class OverTimeRequestFormGroup
    {
        public OverTimeRequestFormGroup()
        {
            OverTimeRequestForms = new HashSet<OverTimeRequestForm>();
            OverTimeRequestResultFormGroups = new HashSet<OverTimeRequestResultFormGroup>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public string Detail { get; set; } = null!;
        public int FiscalYear { get; set; }
        public DateTime ForDate { get; set; }
        public TimeSpan TotalHour { get; set; }
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
        public string RequesterName { get; set; } = null!;
        public DateTime ClockIn { get; set; }
        public DateTime ClockOut { get; set; }
        public string WorkShiftName { get; set; } = null!;
        public DateTime WorkShiftClockIn { get; set; }
        public DateTime WorkShiftClockOut { get; set; }
        public string WorkShiftExtraAllowanceRemark { get; set; } = null!;
        public string BudgetSourceName { get; set; } = null!;
        public int? PlanItemId { get; set; }
        public int? PlanActivityId { get; set; }
        public int? PlanCoreId { get; set; }
        public int? ApproverId { get; set; }
        public int? ApprovedSignStaffId { get; set; }
        public string ApprovedSignHostName { get; set; } = null!;
        public string ApprovedSignHostAddress { get; set; } = null!;
        public int? CreatorStaffId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatorHostName { get; set; } = null!;
        public string CreatorHostAddress { get; set; } = null!;
        public bool? IsHolidayOrDayOff { get; set; }
        public bool? IsPaid { get; set; }
        public int ObjectiveTypeEnum { get; set; }
        public bool UsePlanCoreBudget { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;

        public virtual ICollection<OverTimeRequestForm> OverTimeRequestForms { get; set; }
        public virtual ICollection<OverTimeRequestResultFormGroup> OverTimeRequestResultFormGroups { get; set; }
    }
}
