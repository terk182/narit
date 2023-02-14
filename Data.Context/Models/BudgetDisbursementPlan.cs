using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class BudgetDisbursementPlan
    {
        public int Id { get; set; }
        public int LbActivityId { get; set; }
        public string Month { get; set; } = null!;
        public int Amount { get; set; }
        public decimal PriceUnit { get; set; }
        public bool Active { get; set; }
    }
}
