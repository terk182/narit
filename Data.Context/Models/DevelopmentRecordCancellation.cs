using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class DevelopmentRecordCancellation
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public string OrderNumber { get; set; } = null!;
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Detail { get; set; } = null!;
        public string Remark { get; set; } = null!;
        public int FiscalYear { get; set; }
        public int? HrdepartmentId { get; set; }
        public string HrdepartmentName { get; set; } = null!;
        public int WorkAttendanceTimeRangeEnum { get; set; }
        public bool IsInHouseTraining { get; set; }
        public TimeSpan? TimeStart { get; set; }
        public TimeSpan? TimeEnd { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int DevelopmentRecordGroupCancellationId { get; set; }
        public int DevelopmentRecordId { get; set; }
        public int StaffId { get; set; }
        public bool NeedTimeStamp { get; set; }

        public virtual DevelopmentRecord DevelopmentRecord { get; set; } = null!;
        public virtual DevelopmentRecordGroupCancellation DevelopmentRecordGroupCancellation { get; set; } = null!;
        public virtual Staff Staff { get; set; } = null!;
    }
}
