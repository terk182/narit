using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class PlanMonthlyOperationChangeLog
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public string DetailJanuary { get; set; } = null!;
        public string DetailFebruary { get; set; } = null!;
        public string DetailMarch { get; set; } = null!;
        public string DetailApril { get; set; } = null!;
        public string DetailMay { get; set; } = null!;
        public string DetailJune { get; set; } = null!;
        public string DetailJuly { get; set; } = null!;
        public string DetailAugust { get; set; } = null!;
        public string DetailSeptember { get; set; } = null!;
        public string DetailOctober { get; set; } = null!;
        public string DetailNovember { get; set; } = null!;
        public string DetailDecember { get; set; } = null!;
        public int? ParentPlanMonthlyOperationId { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public string MonthlyOperationResultAtDateValue { get; set; } = null!;
        public int PlanMonthlyOperationId { get; set; }
        public decimal Weight { get; set; }

        public virtual PlanMonthlyOperation PlanMonthlyOperation { get; set; } = null!;
    }
}
