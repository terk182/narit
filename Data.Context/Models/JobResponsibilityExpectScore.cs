using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class JobResponsibilityExpectScore
    {
        public JobResponsibilityExpectScore()
        {
            JobResponsibilityEvaluationItems = new HashSet<JobResponsibilityEvaluationItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public double Score { get; set; }
        public double Weight { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime StartDate { get; set; }
        public int JobResponsibilityId { get; set; }
        public int? JobPositionLevelId { get; set; }
        public double ScoreLevel1 { get; set; }
        public double ScoreLevel2 { get; set; }
        public double ScoreLevel3 { get; set; }
        public double ScoreLevel4 { get; set; }
        public double ScoreLevel5 { get; set; }
        public double SuggestionScore { get; set; }
        public int StaffId { get; set; }

        public virtual JobPositionLevel? JobPositionLevel { get; set; }
        public virtual JobResponsibility JobResponsibility { get; set; } = null!;
        public virtual Staff Staff { get; set; } = null!;
        public virtual ICollection<JobResponsibilityEvaluationItem> JobResponsibilityEvaluationItems { get; set; }
    }
}
