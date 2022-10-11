using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class MonthlyForecastAdjustment
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public string MonthlyForecastChangedValue { get; set; } = null!;
        public string MonthlyForecastAtDateValue { get; set; } = null!;
        public string Remark { get; set; } = null!;
        public int ApprovalStatusEnum { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public int? ApproveByStaffId { get; set; }
        public int PlanItemId { get; set; }
        public int PlanCoreId { get; set; }
        public int PlanTypeId { get; set; }
        public string PlanTypeName { get; set; } = null!;
        public string PlanCoreName { get; set; } = null!;
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
        public string LotNumber { get; set; } = null!;
        public decimal NetBudgetAtDate { get; set; }
        public string TotalPaidBudgetAtDateValue { get; set; } = null!;

        public virtual PlanItem PlanItem { get; set; } = null!;
    }
}
