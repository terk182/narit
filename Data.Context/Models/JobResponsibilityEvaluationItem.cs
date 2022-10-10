using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class JobResponsibilityEvaluationItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public string Detail { get; set; } = null!;
        public double ExpectScore { get; set; }
        public double Score { get; set; }
        public double ScoreLevel1 { get; set; }
        public double ScoreLevel2 { get; set; }
        public double ScoreLevel3 { get; set; }
        public double ScoreLevel4 { get; set; }
        public double ScoreLevel5 { get; set; }
        public double Weight { get; set; }
        public int? JobResponsibilityId { get; set; }
        public int JobResponsibilityEvaluationFormId { get; set; }
        public int JobResponsibilityExpectScoreId { get; set; }

        public virtual JobResponsibilityEvaluationForm JobResponsibilityEvaluationForm { get; set; } = null!;
        public virtual JobResponsibilityExpectScore JobResponsibilityExpectScore { get; set; } = null!;
    }
}
