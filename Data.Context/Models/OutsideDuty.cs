using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class OutsideDuty
    {
        public OutsideDuty()
        {
            OutsideDutyCancellations = new HashSet<OutsideDutyCancellation>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Place { get; set; } = null!;
        public string OrderNumber { get; set; } = null!;
        public string Detail { get; set; } = null!;
        public int OutsideDutyGroupId { get; set; }
        public int StaffId { get; set; }
        public int FiscalYear { get; set; }
        public int? HrdepartmentId { get; set; }
        public string HrdepartmentName { get; set; } = null!;
        public int WorkAttendanceTimeRangeEnum { get; set; }
        public TimeSpan? TimeStart { get; set; }
        public TimeSpan? TimeEnd { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ExceptionDateValue { get; set; } = null!;
        public bool AllowExceptionDate { get; set; }
        public int? EndWorkAttendanceTimeRangeEnum { get; set; }

        public virtual OutsideDutyGroup OutsideDutyGroup { get; set; } = null!;
        public virtual Staff Staff { get; set; } = null!;
        public virtual ICollection<OutsideDutyCancellation> OutsideDutyCancellations { get; set; }
    }
}
