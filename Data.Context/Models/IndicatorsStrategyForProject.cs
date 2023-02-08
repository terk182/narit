using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class IndicatorsStrategyForProject
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? ProjectId { get; set; }
        public int? MeasureId { get; set; }
        public int Amonut { get; set; }
        public string Unit { get; set; } = null!;
        public bool Active { get; set; }
    }
}
