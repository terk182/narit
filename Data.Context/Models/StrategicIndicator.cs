using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class StrategicIndicator
    {
        public StrategicIndicator()
        {
            InverseParentStrategicIndicator = new HashSet<StrategicIndicator>();
            PerformanceIndicators = new HashSet<PerformanceIndicator>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public bool Active { get; set; }
        public int? ParentStrategicIndicatorId { get; set; }
        public string Unit { get; set; } = null!;
        public decimal Amount { get; set; }
        public decimal Weight { get; set; }

        public virtual StrategicIndicator? ParentStrategicIndicator { get; set; }
        public virtual ICollection<StrategicIndicator> InverseParentStrategicIndicator { get; set; }
        public virtual ICollection<PerformanceIndicator> PerformanceIndicators { get; set; }
    }
}
