using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class OutsideDutyGroupCancellation
    {
        public OutsideDutyGroupCancellation()
        {
            OutsideDutyCancellations = new HashSet<OutsideDutyCancellation>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string OrderNumber { get; set; } = null!;
        public string Detail { get; set; } = null!;
        public int FiscalYear { get; set; }
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
        public int? HrdepartmentId { get; set; }
        public string HrdepartmentName { get; set; } = null!;
        public int WorkAttendanceTimeRangeEnum { get; set; }
        public TimeSpan? TimeStart { get; set; }
        public TimeSpan? TimeEnd { get; set; }
        public int OutsideDutyGroupId { get; set; }
        public string RequesterName { get; set; } = null!;
        public int? ApproverId { get; set; }
        public int? ApprovedSignStaffId { get; set; }
        public string ApprovedSignHostName { get; set; } = null!;
        public string ApprovedSignHostAddress { get; set; } = null!;
        public int? CreatorStaffId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatorHostName { get; set; } = null!;
        public string CreatorHostAddress { get; set; } = null!;

        public virtual OutsideDutyGroup OutsideDutyGroup { get; set; } = null!;
        public virtual ICollection<OutsideDutyCancellation> OutsideDutyCancellations { get; set; }
    }
}
