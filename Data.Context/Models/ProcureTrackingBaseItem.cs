using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class ProcureTrackingBaseItem
    {
        public ProcureTrackingBaseItem()
        {
            ProcureTrackingGroups = new HashSet<ProcureTrackingGroup>();
            ProcureTrackingItems = new HashSet<ProcureTrackingItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int PlanItemId { get; set; }
        public int PlanActivityId { get; set; }
        public int PlanCoreId { get; set; }
        public int DepartmentId { get; set; }
        public int BudgetTypeId { get; set; }
        public string PlanActivityName { get; set; } = null!;
        public string PlanCoreName { get; set; } = null!;
        public string DepartmentName { get; set; } = null!;
        public decimal Amount { get; set; }
        public decimal PricePerPiece { get; set; }
        public string Unit { get; set; } = null!;
        public int ProcureTrackingMethodEnum { get; set; }
        public string Remark { get; set; } = null!;
        public int MonthRequire { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public int ProcureMethodEnum { get; set; }
        public bool HasTor { get; set; }
        public bool IsNonBudget { get; set; }
        public string BudgetTypeName { get; set; } = null!;
        public bool IsForeign { get; set; }
        public int PlanTypeId { get; set; }
        public string PlanTypeName { get; set; } = null!;
        public int ControlGroupNumber { get; set; }
        public int ControlItemNumber { get; set; }

        public virtual ICollection<ProcureTrackingGroup> ProcureTrackingGroups { get; set; }
        public virtual ICollection<ProcureTrackingItem> ProcureTrackingItems { get; set; }
    }
}
