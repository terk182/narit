using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class CompetencyEvaluationForm
    {
        public CompetencyEvaluationForm()
        {
            CompetencyEvaluationItems = new HashSet<CompetencyEvaluationItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int StaffId { get; set; }
        public string StaffDepartmentName { get; set; } = null!;
        public string StaffPositionName { get; set; } = null!;
        public int RecorderStaffId { get; set; }
        public string RecorderName { get; set; } = null!;
        public DateTime RecordDate { get; set; }
        public int ForYear { get; set; }
        public string RecorderPositionName { get; set; } = null!;
        public int ApprovalStatusEnum { get; set; }
        public int FirstEvaluatorStaffId { get; set; }
        public int SecondEvaluatorStaffId { get; set; }
        public string FirstEvaluator { get; set; } = null!;
        public string FirstEvaluatorOpinion { get; set; } = null!;
        public string SecondEvaluator { get; set; } = null!;
        public string SecondEvaluatorOpinion { get; set; } = null!;
        public string Opinion { get; set; } = null!;
        public string FirstEvaluatorPositionName { get; set; } = null!;
        public string SecondEvaluatorPositionName { get; set; } = null!;
        public int CreateByStaffId { get; set; }

        public virtual Staff Staff { get; set; } = null!;
        public virtual ICollection<CompetencyEvaluationItem> CompetencyEvaluationItems { get; set; }
    }
}
