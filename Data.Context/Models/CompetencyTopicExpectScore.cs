using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class CompetencyTopicExpectScore
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int CompetencyTopicItemId { get; set; }
        public double Score { get; set; }
        public int JobPositionId { get; set; }
        public int JobPositionLevelId { get; set; }

        public virtual CompetencyTopicItem CompetencyTopicItem { get; set; } = null!;
        public virtual JobPosition JobPosition { get; set; } = null!;
        public virtual JobPositionLevel JobPositionLevel { get; set; } = null!;
    }
}
