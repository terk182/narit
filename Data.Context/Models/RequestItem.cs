using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class RequestItem
    {
        public RequestItem()
        {
            RequestAgreementItemTransforms = new HashSet<RequestAgreementItemTransform>();
            RequestApproveItemTransforms = new HashSet<RequestApproveItemTransform>();
            RequestItemPlanReferenceItems = new HashSet<RequestItemPlanReferenceItem>();
        }

        public int RequestFormId { get; set; }
        public int PlanItemId { get; set; }
        public string PlanItemName { get; set; } = null!;
        public int PlanActivityId { get; set; }
        public string PlanActivityName { get; set; } = null!;
        public int? BudgetTypeId { get; set; }
        public int? CostTypeId { get; set; }
        public int? PlanItemTypeId { get; set; }
        public string BudgetTypeName { get; set; } = null!;
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal? Amount { get; set; }
        public decimal? PricePerPiece { get; set; }
        public string Unit { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int VatMethodEnum { get; set; }
        public decimal? Discount { get; set; }
        public DateTime? Date { get; set; }
        public int ProcureTypeEnum { get; set; }
        public string Remark { get; set; } = null!;
        public decimal? MedianPrice { get; set; }

        public virtual RequestForm RequestForm { get; set; } = null!;
        public virtual ICollection<RequestAgreementItemTransform> RequestAgreementItemTransforms { get; set; }
        public virtual ICollection<RequestApproveItemTransform> RequestApproveItemTransforms { get; set; }
        public virtual ICollection<RequestItemPlanReferenceItem> RequestItemPlanReferenceItems { get; set; }
    }
}
