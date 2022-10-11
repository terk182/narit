using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class MonthlyForecast
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Amount { get; set; }
        public bool Active { get; set; }
        public decimal BudgetPerPiece { get; set; }
        public int FiscalYear { get; set; }
        public int Month { get; set; }
        public int PlanItemId { get; set; }

        public virtual PlanItem PlanItem { get; set; } = null!;
    }
}
