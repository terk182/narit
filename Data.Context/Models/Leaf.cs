using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class Leaf
    {
        public Leaf()
        {
            Hrfiles = new HashSet<Hrfile>();
            LeaveCancellationForms = new HashSet<LeaveCancellationForm>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Remark { get; set; } = null!;
        public int LeaveTypeId { get; set; }
        public int StaffId { get; set; }
        public DateTime? WriteDate { get; set; }
        public string Inform { get; set; } = null!;
        public string WriteAt { get; set; } = null!;
        public string Detail { get; set; } = null!;
        public string ContactNumber { get; set; } = null!;
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
        public string DocumentNumber { get; set; } = null!;
        public string ApproverOpinion { get; set; } = null!;
        public string PastRecordValue { get; set; } = null!;
        public int? HrdepartmentId { get; set; }
        public string HrdepartmentName { get; set; } = null!;
        public int WorkAttendanceTimeRangeEnum { get; set; }
        public TimeSpan? TimeStart { get; set; }
        public TimeSpan? TimeEnd { get; set; }
        public string ExceptionDateValue { get; set; } = null!;
        public int? ApproverId { get; set; }
        public int? ApprovedSignStaffId { get; set; }
        public string ApprovedSignHostName { get; set; } = null!;
        public string ApprovedSignHostAddress { get; set; } = null!;
        public int? CreatorStaffId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatorHostName { get; set; } = null!;
        public string CreatorHostAddress { get; set; } = null!;
        public int? EndWorkAttendanceTimeRangeEnum { get; set; }

        public virtual LeaveType LeaveType { get; set; } = null!;
        public virtual Staff Staff { get; set; } = null!;
        public virtual ICollection<Hrfile> Hrfiles { get; set; }
        public virtual ICollection<LeaveCancellationForm> LeaveCancellationForms { get; set; }
    }
}
