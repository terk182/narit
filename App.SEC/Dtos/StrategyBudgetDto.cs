using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Dtos
{
    public class StrategyBudgetDto
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public int? FiscalYear { get; set; }
        public bool Active { get; set; }
        public int? ParentStrategyBudgetId { get; set; }
    }
}
