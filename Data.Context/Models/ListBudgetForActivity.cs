using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class ListBudgetForActivity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? ProjectId { get; set; }
        public int? ProjectActivitiyId { get; set; }
        public int? SubAnnualBudgetId { get; set; }
        public string Detail { get; set; } = null!;
        public string Unit { get; set; } = null!;
        public decimal TotalUnit { get; set; }
        public decimal TotalBudget { get; set; }
        public bool Active { get; set; }
    }
}
