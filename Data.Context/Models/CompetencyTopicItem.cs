using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class CompetencyTopicItem
    {
        public CompetencyTopicItem()
        {
            CompetencyEvaluationItems = new HashSet<CompetencyEvaluationItem>();
            CompetencyTopicExpectScores = new HashSet<CompetencyTopicExpectScore>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int CompetencyTopicTypeEnum { get; set; }
        public string Detail { get; set; } = null!;
        public string Level0Definitinition { get; set; } = null!;
        public string Level1Definitinition { get; set; } = null!;
        public string Level2Definitinition { get; set; } = null!;
        public string Level3Definitinition { get; set; } = null!;
        public string Level4Definitinition { get; set; } = null!;
        public string Level5Definitinition { get; set; } = null!;

        public virtual ICollection<CompetencyEvaluationItem> CompetencyEvaluationItems { get; set; }
        public virtual ICollection<CompetencyTopicExpectScore> CompetencyTopicExpectScores { get; set; }
    }
}
