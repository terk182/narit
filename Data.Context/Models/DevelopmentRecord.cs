using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class DevelopmentRecord
    {
        public DevelopmentRecord()
        {
            DevelopmentRecordCancellations = new HashSet<DevelopmentRecordCancellation>();
            DevelopmentRecordFollowUpForms = new HashSet<DevelopmentRecordFollowUpForm>();
            PostDevelopmentRecordEvaluationForms = new HashSet<PostDevelopmentRecordEvaluationForm>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public string OrderNumber { get; set; } = null!;
        public string InstituteName { get; set; } = null!;
        public string Instructor { get; set; } = null!;
        public string DevelopmentType { get; set; } = null!;
        public string Place { get; set; } = null!;
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string DiplomaName { get; set; } = null!;
        public string Detail { get; set; } = null!;
        public string Remark { get; set; } = null!;
        public int DevelopmentRecordGroupId { get; set; }
        public int StaffId { get; set; }
        public int FiscalYear { get; set; }
        public int? HrdepartmentId { get; set; }
        public string HrdepartmentName { get; set; } = null!;
        public int WorkAttendanceTimeRangeEnum { get; set; }
        public bool IsInHouseTraining { get; set; }
        public TimeSpan? TimeStart { get; set; }
        public TimeSpan? TimeEnd { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ExceptionDateValue { get; set; } = null!;
        public bool AllowExceptionDate { get; set; }
        public bool NeedTimeStamp { get; set; }
        public string Topic { get; set; } = null!;
        public decimal? Cost { get; set; }
        public int? EndWorkAttendanceTimeRangeEnum { get; set; }

        public virtual DevelopmentRecordGroup DevelopmentRecordGroup { get; set; } = null!;
        public virtual Staff Staff { get; set; } = null!;
        public virtual ICollection<DevelopmentRecordCancellation> DevelopmentRecordCancellations { get; set; }
        public virtual ICollection<DevelopmentRecordFollowUpForm> DevelopmentRecordFollowUpForms { get; set; }
        public virtual ICollection<PostDevelopmentRecordEvaluationForm> PostDevelopmentRecordEvaluationForms { get; set; }
    }
}
