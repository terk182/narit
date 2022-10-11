using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class AgreementItemPlanReferenceItem
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
        public int AgreementItemId { get; set; }
        public int RequestFormRefId { get; set; }
        public int AgreementFormId { get; set; }

        public virtual AgreementForm AgreementForm { get; set; } = null!;
        public virtual AgreementItem AgreementItem { get; set; } = null!;
    }
}
