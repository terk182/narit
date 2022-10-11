using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class JobPositionGroup
    {
        public JobPositionGroup()
        {
            JobPositions = new HashSet<JobPosition>();
            PerformanceYearlyEvaluationWeights = new HashSet<PerformanceYearlyEvaluationWeight>();
            staff = new HashSet<Staff>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }

        public virtual ICollection<JobPosition> JobPositions { get; set; }
        public virtual ICollection<PerformanceYearlyEvaluationWeight> PerformanceYearlyEvaluationWeights { get; set; }
        public virtual ICollection<Staff> staff { get; set; }
    }
}
