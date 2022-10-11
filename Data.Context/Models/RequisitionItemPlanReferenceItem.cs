using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class RequisitionItemPlanReferenceItem
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
        public int RequisitionItemId { get; set; }
        public int RequestFormRefId { get; set; }
        public int RequisitionFormId { get; set; }

        public virtual RequisitionForm RequisitionForm { get; set; } = null!;
        public virtual RequisitionItem RequisitionItem { get; set; } = null!;
    }
}
