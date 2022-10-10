using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class PerformanceYearlyEvaluationWeight
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int Section11QuantityWeight { get; set; }
        public int Section12QualityWeight { get; set; }
        public int Section21ResponsibilityWeight { get; set; }
        public int Section22PlanningWeight { get; set; }
        public int Section23TeamworkWeight { get; set; }
        public int Section24CautiouslyWeight { get; set; }
        public int Section25ManagementWeight { get; set; }
        public int Section26SolveAndDecisionWeight { get; set; }
        public int Section27LeadershipWeight { get; set; }
        public int Section28DisciplineWeight { get; set; }
        public int Section29MoralWeight { get; set; }
        public int Section210SelfControlWeight { get; set; }
        public int JobPositionLevelId { get; set; }
        public int JobPositionGroupId { get; set; }

        public virtual JobPositionGroup JobPositionGroup { get; set; } = null!;
        public virtual JobPositionLevel JobPositionLevel { get; set; } = null!;
    }
}
