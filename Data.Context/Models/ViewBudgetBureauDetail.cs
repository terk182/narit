using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class ViewBudgetBureauDetail
    {
        public int Id { get; set; }
        public bool? Active { get; set; }
        public string? Code { get; set; }
        public int? FiscalYear { get; set; }
        public string Name { get; set; } = null!;
        public int? Remark { get; set; }
        public byte[]? CreateDate { get; set; }
        public int? BudgetBureauPlansId { get; set; }
        public int? BudgetBureauStrategiesId { get; set; }
        public string BudgetBureauPlansName { get; set; } = null!;
        public string BudgetBureauStrategiesName { get; set; } = null!;
    }
}
