using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class StrategicIndicator
    {
        public StrategicIndicator()
        {
            InverseParentStrategicIndicator = new HashSet<StrategicIndicator>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public bool Active { get; set; }
        public int? ParentStrategicIndicatorId { get; set; }
        public string Unit { get; set; } = null!;
        public decimal Amount { get; set; }
        public decimal Weight { get; set; }
        public int? StrategyId { get; set; }
        public int? ParentStrategyId { get; set; }

        public virtual StrategicIndicator? ParentStrategicIndicator { get; set; }
        public virtual ICollection<StrategicIndicator> InverseParentStrategicIndicator { get; set; }
    }
}
