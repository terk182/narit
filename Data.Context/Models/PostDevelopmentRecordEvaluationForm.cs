using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class PostDevelopmentRecordEvaluationForm
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public string StaffDepartmentName { get; set; } = null!;
        public string StaffPositionName { get; set; } = null!;
        public int DevelopmentRecordId { get; set; }
        public string Organizer { get; set; } = null!;
        public string Abtract { get; set; } = null!;
        public string SuggestionForApplying { get; set; } = null!;
        public string OtherReason { get; set; } = null!;
        public string FirstInstructorName { get; set; } = null!;
        public string FirstInstructorInstitution { get; set; } = null!;
        public string SecondInstructorName { get; set; } = null!;
        public string SecondInstructorInstitution { get; set; } = null!;
        public string ThirdInstructorName { get; set; } = null!;
        public string ThirdInstructorInstitution { get; set; } = null!;
        public string SuggestionForNextDevelopment { get; set; } = null!;
        public string RecorderName { get; set; } = null!;
        public DateTime RecordDate { get; set; }
        public int HrdepartmentId { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public int GotKnowledgeLevel { get; set; }
        public int GotBenefitLevel { get; set; }
        public bool IsRelatedToWork { get; set; }
        public bool IsUnrelatedToWork { get; set; }
        public bool HasKnowledgeAndBenefit { get; set; }
        public bool IsDebateAndSharing { get; set; }
        public bool IsGoodInstructor { get; set; }
        public bool IsIrrelevantContent { get; set; }
        public int FirstInstructorAbilityLevel { get; set; }
        public int SecondInstructorAbilityLevel { get; set; }
        public int ThirdInstructorAbilityLevel { get; set; }
        public int RecorderStaffId { get; set; }
        public double Cost { get; set; }

        public virtual DevelopmentRecord DevelopmentRecord { get; set; } = null!;
    }
}
