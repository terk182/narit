using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class ProbationEvaluationForm
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public string StaffDepartmentName { get; set; } = null!;
        public string StaffPositionName { get; set; } = null!;
        public string StaffPositionNumber { get; set; } = null!;
        public DateTime? StaffStartWorkingDate { get; set; }
        public DateTime? ProbationStartDate { get; set; }
        public DateTime? ProbationEndDate { get; set; }
        public int Issue11Score { get; set; }
        public string Issue11Opinion { get; set; } = null!;
        public int Issue12Score { get; set; }
        public string Issue12Opinion { get; set; } = null!;
        public int Issue13Score { get; set; }
        public string Issue13Opinion { get; set; } = null!;
        public int Issue21Score { get; set; }
        public string Issue21Opinion { get; set; } = null!;
        public int Issue31Score { get; set; }
        public string Issue31Opinion { get; set; } = null!;
        public int Issue41Score { get; set; }
        public string Issue41Opinion { get; set; } = null!;
        public int Issue51Score { get; set; }
        public string Issue51Opinion { get; set; } = null!;
        public int Issue61Score { get; set; }
        public string Issue61Opinion { get; set; } = null!;
        public int Issue71Score { get; set; }
        public string Issue71Opinion { get; set; } = null!;
        public int Issue81Score { get; set; }
        public string Issue81Opinion { get; set; } = null!;
        public int Issue91Score { get; set; }
        public string Issue91Opinion { get; set; } = null!;
        public int Issue101Score { get; set; }
        public string Issue101Opinion { get; set; } = null!;
        public string RecorderName { get; set; } = null!;
        public int RecorderStaffId { get; set; }
        public DateTime? RecorderSignDate { get; set; }
        public DateTime RecordDate { get; set; }
        public int EmploymentContractId { get; set; }
        public int HrdepartmentId { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public int CountTime { get; set; }
        public string RecorderPositionName { get; set; } = null!;
        public int FirstEvaluatorStaffId { get; set; }
        public int SecondEvaluatorStaffId { get; set; }
        public double FirstTimeScore { get; set; }
        public double SecondTimeScore { get; set; }
        public string FirstEvaluator { get; set; } = null!;
        public string FirstEvaluatorOpinion { get; set; } = null!;
        public string SecondEvaluator { get; set; } = null!;
        public string SecondEvaluatorOpinion { get; set; } = null!;
        public string StaffPositionLevelName { get; set; } = null!;
        public int CreateByStaffId { get; set; }

        public virtual EmploymentContract EmploymentContract { get; set; } = null!;
    }
}
