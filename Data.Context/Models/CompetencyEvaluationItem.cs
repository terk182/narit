using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class CompetencyEvaluationItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public string Detail { get; set; } = null!;
        public double Score { get; set; }
        public double ExpectScore { get; set; }
        public int CompetencyTopicItemId { get; set; }
        public int CompetencyEvaluationFormId { get; set; }

        public virtual CompetencyEvaluationForm CompetencyEvaluationForm { get; set; } = null!;
        public virtual CompetencyTopicItem CompetencyTopicItem { get; set; } = null!;
    }
}
