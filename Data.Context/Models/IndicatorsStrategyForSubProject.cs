using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class IndicatorsStrategyForSubProject
    {
        public int Id { get; set; }
        public int SubProjectId { get; set; }
        public int StrategyId { get; set; }
        public int IndicatorStrategyId { get; set; }
        public bool Active { get; set; }
    }
}
