using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class JobPosition
    {
        public JobPosition()
        {
            CompetencyTopicExpectScores = new HashSet<CompetencyTopicExpectScore>();
            InverseParentJobPosition = new HashSet<JobPosition>();
            JobDescriptions = new HashSet<JobDescription>();
            JobPositionKeyCompetencyDetails = new HashSet<JobPositionKeyCompetencyDetail>();
            JobQualifications = new HashSet<JobQualification>();
            JobResponsibilities = new HashSet<JobResponsibility>();
            JobResponsibilityGroups = new HashSet<JobResponsibilityGroup>();
            staff = new HashSet<Staff>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public string Summary { get; set; } = null!;
        public string JobScope { get; set; } = null!;
        public string? EducationFieldName { get; set; }
        public string? Certification { get; set; }
        public string? Experience { get; set; }
        public int StartAge { get; set; }
        public int EndAge { get; set; }
        public string OtherJobResponsibility { get; set; } = null!;
        public int? ParentJobPositionId { get; set; }
        public int? JobPositionTypeId { get; set; }
        public int? EducationLevelId { get; set; }
        public int? JobPositionGroupId { get; set; }
        public bool IsMale { get; set; }
        public bool IsFemale { get; set; }
        public int? HrdepartmentId { get; set; }

        public virtual EducationLevel? EducationLevel { get; set; }
        public virtual Hrdepartment? Hrdepartment { get; set; }
        public virtual JobPositionGroup? JobPositionGroup { get; set; }
        public virtual JobPositionType? JobPositionType { get; set; }
        public virtual JobPosition? ParentJobPosition { get; set; }
        public virtual ICollection<CompetencyTopicExpectScore> CompetencyTopicExpectScores { get; set; }
        public virtual ICollection<JobPosition> InverseParentJobPosition { get; set; }
        public virtual ICollection<JobDescription> JobDescriptions { get; set; }
        public virtual ICollection<JobPositionKeyCompetencyDetail> JobPositionKeyCompetencyDetails { get; set; }
        public virtual ICollection<JobQualification> JobQualifications { get; set; }
        public virtual ICollection<JobResponsibility> JobResponsibilities { get; set; }
        public virtual ICollection<JobResponsibilityGroup> JobResponsibilityGroups { get; set; }
        public virtual ICollection<Staff> staff { get; set; }
    }
}
