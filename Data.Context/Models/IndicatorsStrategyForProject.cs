﻿using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class IndicatorsStrategyForProject
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int StrategyId { get; set; }
        public int IndicatorStrategyId { get; set; }
        public bool Active { get; set; }
    }
}