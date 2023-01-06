﻿using App.SEC.Models;
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Dtos
{
    public class StrategySetupDto
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public int? FiscalYear { get; set; }
        public bool Active { get; set; }
        public int? ParentStrategyId { get; set; }
        public List<StrategySetupDto>? Strategy { get; set; }
        public List<StrategySetupDto>? InverseParentStrategy { get; set; }
    }
}
