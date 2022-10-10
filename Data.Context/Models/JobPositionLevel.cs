using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class JobPositionLevel
    {
        public JobPositionLevel()
        {
            CompetencyTopicExpectScores = new HashSet<CompetencyTopicExpectScore>();
            JobDescriptions = new HashSet<JobDescription>();
            JobPositionKeyCompetencyDetails = new HashSet<JobPositionKeyCompetencyDetail>();
            JobQualifications = new HashSet<JobQualification>();
            JobResponsibilities = new HashSet<JobResponsibility>();
            JobResponsibilityExpectScores = new HashSet<JobResponsibilityExpectScore>();
            PerformanceYearlyEvaluationWeights = new HashSet<PerformanceYearlyEvaluationWeight>();
            staff = new HashSet<Staff>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }

        public virtual ICollection<CompetencyTopicExpectScore> CompetencyTopicExpectScores { get; set; }
        public virtual ICollection<JobDescription> JobDescriptions { get; set; }
        public virtual ICollection<JobPositionKeyCompetencyDetail> JobPositionKeyCompetencyDetails { get; set; }
        public virtual ICollection<JobQualification> JobQualifications { get; set; }
        public virtual ICollection<JobResponsibility> JobResponsibilities { get; set; }
        public virtual ICollection<JobResponsibilityExpectScore> JobResponsibilityExpectScores { get; set; }
        public virtual ICollection<PerformanceYearlyEvaluationWeight> PerformanceYearlyEvaluationWeights { get; set; }
        public virtual ICollection<Staff> staff { get; set; }
    }
}
