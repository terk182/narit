using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class ApproveItemPlanReferenceItem
    {
        public int Id { get; set; }
        public int? PlanItemId { get; set; }
        public bool Active { get; set; }
        public decimal? Amount { get; set; }
        public int PlanActivityId { get; set; }
        public int DepartmentId { get; set; }
        public int FiscalYear { get; set; }
        public int? BudgetTypeId { get; set; }
        public int PlanTypeId { get; set; }
        public int PlanCoreId { get; set; }
        public int? CostTypeId { get; set; }
        public int? PlanItemTypeId { get; set; }
        public int RequestItemRefId { get; set; }
        public int ApproveItemId { get; set; }
        public int RequestFormRefId { get; set; }
        public int ApproveFormId { get; set; }

        public virtual ApproveForm ApproveForm { get; set; } = null!;
        public virtual ApproveItem ApproveItem { get; set; } = null!;
    }
}
