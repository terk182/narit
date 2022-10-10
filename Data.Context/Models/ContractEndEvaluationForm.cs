using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class ContractEndEvaluationForm
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime? StaffBirthday { get; set; }
        public string StaffAgeText { get; set; } = null!;
        public string StaffDepartmentName { get; set; } = null!;
        public string StaffPositionName { get; set; } = null!;
        public string StaffPositionNumber { get; set; } = null!;
        public DateTime? StaffStartWorkingDate { get; set; }
        public int EmploymentContractId { get; set; }
        public DateTime? FirstContractStartDate { get; set; }
        public DateTime? FirstContractEndDate { get; set; }
        public DateTime? SecondContractStartDate { get; set; }
        public DateTime? SecondContractEndDate { get; set; }
        public DateTime? ThirdContractStartDate { get; set; }
        public DateTime? ThirdContractEndDate { get; set; }
        public string Issue11 { get; set; } = null!;
        public int Issue11Weight { get; set; }
        public int Issue11Score { get; set; }
        public string Issue11Opinion { get; set; } = null!;
        public string Issue12 { get; set; } = null!;
        public int Issue12Weight { get; set; }
        public int Issue12Score { get; set; }
        public string Issue12Opinion { get; set; } = null!;
        public string Issue13 { get; set; } = null!;
        public int Issue13Weight { get; set; }
        public int Issue13Score { get; set; }
        public string Issue13Opinion { get; set; } = null!;
        public string Issue21 { get; set; } = null!;
        public int Issue21Weight { get; set; }
        public int Issue21Score { get; set; }
        public string Issue21Opinion { get; set; } = null!;
        public string Issue22 { get; set; } = null!;
        public int Issue22Weight { get; set; }
        public int Issue22Score { get; set; }
        public string Issue22Opinion { get; set; } = null!;
        public string Issue31 { get; set; } = null!;
        public int Issue31Weight { get; set; }
        public int Issue31Score { get; set; }
        public string Issue31Opinion { get; set; } = null!;
        public string Issue41 { get; set; } = null!;
        public int Issue41Weight { get; set; }
        public int Issue41Score { get; set; }
        public string Issue41Opinion { get; set; } = null!;
        public string Issue51 { get; set; } = null!;
        public int Issue51Weight { get; set; }
        public int Issue51Score { get; set; }
        public string Issue51Opinion { get; set; } = null!;
        public string Issue61 { get; set; } = null!;
        public int Issue61Weight { get; set; }
        public int Issue61Score { get; set; }
        public string Issue61Opinion { get; set; } = null!;
        public string Issue71 { get; set; } = null!;
        public int Issue71Weight { get; set; }
        public int Issue71Score { get; set; }
        public string Issue71Opinion { get; set; } = null!;
        public string Issue81 { get; set; } = null!;
        public int Issue81Weight { get; set; }
        public int Issue81Score { get; set; }
        public string Issue81Opinion { get; set; } = null!;
        public string Issue91 { get; set; } = null!;
        public int Issue91Weight { get; set; }
        public int Issue91Score { get; set; }
        public string Issue91Opinion { get; set; } = null!;
        public string RecorderName { get; set; } = null!;
        public int RecorderStaffId { get; set; }
        public DateTime? RecorderSignDate { get; set; }
        public DateTime RecordDate { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public int HrdepartmentId { get; set; }
        public double FirstYearEvaluationScore { get; set; }
        public double SecondYearEvaluationScore { get; set; }
        public string RecorderPositionName { get; set; } = null!;
        public int? FirstEvaluatorStaffId { get; set; }
        public int? SecondEvaluatorStaffId { get; set; }
        public string FirstEvaluator { get; set; } = null!;
        public string FirstEvaluatorOpinion { get; set; } = null!;
        public string SecondEvaluator { get; set; } = null!;
        public string SecondEvaluatorOpinion { get; set; } = null!;
        public int CountContract { get; set; }
        public int CreateByStaffId { get; set; }
        public bool? FirstEvaluatorIsPass { get; set; }
        public bool? SecondEvaluatorIsPass { get; set; }
        public string FirstEvaluatorPosition { get; set; } = null!;
        public string SecondEvaluatorPosition { get; set; } = null!;
        public DateTime? FirstEvaluatorSignDate { get; set; }
        public DateTime? SecondEvaluatorSignDate { get; set; }

        public virtual EmploymentContract EmploymentContract { get; set; } = null!;
    }
}
