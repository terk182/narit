using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class PerformanceYearlyEvaluationForm
    {
        public PerformanceYearlyEvaluationForm()
        {
            PerfYearlyEvalFormActionLogs = new HashSet<PerfYearlyEvalFormActionLog>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int StaffId { get; set; }
        public string StaffDepartmentName { get; set; } = null!;
        public string StaffPositionName { get; set; } = null!;
        public int Section11QuantityWeight { get; set; }
        public double Section11QuantityScore { get; set; }
        public int Section12QualityWeight { get; set; }
        public double Section12QualityScore { get; set; }
        public int Section21ResponsibilityWeight { get; set; }
        public double Section21ResponsibilityScore { get; set; }
        public int Section22PlanningWeight { get; set; }
        public double Section22PlanningScore { get; set; }
        public int Section23TeamworkWeight { get; set; }
        public double Section23TeamworkScore { get; set; }
        public int Section24CautiouslyWeight { get; set; }
        public double Section24CautiouslyScore { get; set; }
        public int Section25ManagementWeight { get; set; }
        public double Section25ManagementScore { get; set; }
        public int Section26SolveAndDecisionWeight { get; set; }
        public double Section26SolveAndDecisionScore { get; set; }
        public int Section27LeadershipWeight { get; set; }
        public double Section27LeadershipScore { get; set; }
        public int Section28DisciplineWeight { get; set; }
        public double Section28DisciplineScore { get; set; }
        public int Section29MoralWeight { get; set; }
        public double Section29MoralScore { get; set; }
        public int Section210SelfControlWeight { get; set; }
        public double Section210SelfControlScore { get; set; }
        public int RecorderStaffId { get; set; }
        public DateTime RecordDate { get; set; }
        public string RecorderName { get; set; } = null!;
        public int ForYear { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public int HrdepartmentId { get; set; }
        public int FirstEvaluatorStaffId { get; set; }
        public int SecondEvaluatorStaffId { get; set; }
        public int JobPositionLevelId { get; set; }
        public string JobPositionLevelName { get; set; } = null!;
        public string JobPositionGroupName { get; set; } = null!;
        public int JobPositionGroupId { get; set; }
        public string FirstEvaluator { get; set; } = null!;
        public string FirstEvaluatorOpinion { get; set; } = null!;
        public string SecondEvaluator { get; set; } = null!;
        public string SecondEvaluatorOpinion { get; set; } = null!;
        public DateTime? SentMailDate { get; set; }
        public DateTime? FirstEvaluatorSentMailDate { get; set; }
        public DateTime? SecondEvaluatorSentMailDate { get; set; }
        public string FirstEvaluatorPosition { get; set; } = null!;
        public string SecondEvaluatorPosition { get; set; } = null!;
        public int CreateByStaffId { get; set; }
        public int? RecorderSignatureId { get; set; }
        public DateTime? ApproverSignDate { get; set; }
        public int ApproverStaffId { get; set; }

        public virtual Staff Staff { get; set; } = null!;
        public virtual ICollection<PerfYearlyEvalFormActionLog> PerfYearlyEvalFormActionLogs { get; set; }
    }
}
