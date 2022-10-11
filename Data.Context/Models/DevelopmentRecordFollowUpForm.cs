using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class DevelopmentRecordFollowUpForm
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int DevelopmentRecordId { get; set; }
        public string StaffDepartmentName { get; set; } = null!;
        public string StaffPositionName { get; set; } = null!;
        public int Issue1Score { get; set; }
        public int Issue2Score { get; set; }
        public int Issue3Score { get; set; }
        public int Issue4Score { get; set; }
        public int Issue5Score { get; set; }
        public bool CanApplyKnowledge { get; set; }
        public string CanApplyKnowledgeReason { get; set; } = null!;
        public bool CanKnowledgeHelp { get; set; }
        public string CanKnowledgeHelpReason { get; set; } = null!;
        public string ExampleOfImplemented { get; set; } = null!;
        public string ImpactOfApplyKnowledge { get; set; } = null!;
        public int RecorderStaffId { get; set; }
        public DateTime RecordDate { get; set; }
        public string RecorderName { get; set; } = null!;
        public int HrdepartmentId { get; set; }
        public int ApprovalStatusEnum { get; set; }

        public virtual DevelopmentRecord DevelopmentRecord { get; set; } = null!;
    }
}
