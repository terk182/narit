using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class StrategiesFisicalYear
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? ParentStrategyBudgetId { get; set; }
        public int? ReferenceOldId { get; set; }
    }
}
