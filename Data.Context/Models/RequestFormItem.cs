using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class RequestFormItem
    {
        public int Id { get; set; }
        public string DocNo { get; set; } = null!;
        public int RequestBudgetId { get; set; }
        public int? LbActivityId { get; set; }
        public string? Name { get; set; }
        public string? Descriptions { get; set; }
        public bool? Active { get; set; }
        public decimal? Price { get; set; }
        public decimal? TotalBudget { get; set; }
        public string? Unit { get; set; }
        public string? Remark { get; set; }

        public virtual RequestBudget RequestBudget { get; set; } = null!;
    }
}
