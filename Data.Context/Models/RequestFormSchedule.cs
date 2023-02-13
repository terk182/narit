using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class RequestFormSchedule
    {
        public int Id { get; set; }
        public string DocNo { get; set; } = null!;
        public int RequestBudgetId { get; set; }
        public int? DocYear { get; set; }
        public bool? Active { get; set; }
        public string? Name { get; set; }
        public decimal? RequestLoan { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }

        public virtual RequestBudget RequestBudget { get; set; } = null!;
    }
}
