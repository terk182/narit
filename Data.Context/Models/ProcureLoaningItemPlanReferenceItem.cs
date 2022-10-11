using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class ProcureLoaningItemPlanReferenceItem
    {
        public int Id { get; set; }
        public int? PlanItemId { get; set; }
        public bool Active { get; set; }
        public decimal Amount { get; set; }
        public int PlanActivityId { get; set; }
        public int DepartmentId { get; set; }
        public int FiscalYear { get; set; }
        public int? BudgetTypeId { get; set; }
        public int PlanTypeId { get; set; }
        public int PlanCoreId { get; set; }
        public int? CostTypeId { get; set; }
        public int? PlanItemTypeId { get; set; }
        public int RequestItemRefId { get; set; }
        public int RequestFormRefId { get; set; }
        public int ProcureLoaningItemId { get; set; }
        public int ProcureLoaningMemoFormId { get; set; }

        public virtual ProcureLoaningItem ProcureLoaningItem { get; set; } = null!;
        public virtual ProcureLoaningMemoForm ProcureLoaningMemoForm { get; set; } = null!;
    }
}
