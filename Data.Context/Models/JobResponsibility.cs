using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class JobResponsibility
    {
        public JobResponsibility()
        {
            JobResponsibilityExpectScores = new HashSet<JobResponsibilityExpectScore>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public string MainJob { get; set; } = null!;
        public string JobActivity { get; set; } = null!;
        public string Expectation { get; set; } = null!;
        public string JobIndicator { get; set; } = null!;
        public int? JobPositionId { get; set; }
        public int? JobPositionLevelId { get; set; }
        public int? StaffId { get; set; }
        public int JobResponsibilityGroupId { get; set; }
        public double SuggestionScore { get; set; }

        public virtual JobPosition? JobPosition { get; set; }
        public virtual JobPositionLevel? JobPositionLevel { get; set; }
        public virtual JobResponsibilityGroup JobResponsibilityGroup { get; set; } = null!;
        public virtual Staff? Staff { get; set; }
        public virtual ICollection<JobResponsibilityExpectScore> JobResponsibilityExpectScores { get; set; }
    }
}
