using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class ApproveItem
    {
        public ApproveItem()
        {
            AgreementApproveItemTransforms = new HashSet<AgreementApproveItemTransform>();
            ApproveItemPlanReferenceItems = new HashSet<ApproveItemPlanReferenceItem>();
            ApproveOrderItemTransforms = new HashSet<ApproveOrderItemTransform>();
            ProcureLoaningItems = new HashSet<ProcureLoaningItem>();
            RequestApproveItemTransforms = new HashSet<RequestApproveItemTransform>();
        }

        public int? ApproveFormId { get; set; }
        public int? ApproveMemorandumId { get; set; }
        public int? SupplierId { get; set; }
        public decimal? RequestPricePerPiece { get; set; }
        public int RequestItemId { get; set; }
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
        public string QuotationNumber { get; set; } = null!;
        public DateTime? QuotationDate { get; set; }
        public bool IsLoaning { get; set; }
        public bool IsLateAdded { get; set; }
        public int? RequestViewUsedPlanItemId { get; set; }
        public int LateAddedStepEnum { get; set; }
        public bool IsImmediatelyReturnBudget { get; set; }
        public string Remark { get; set; } = null!;
        public int? DeliveryDay { get; set; }

        public virtual ApproveForm? ApproveForm { get; set; }
        public virtual ApproveMemorandum? ApproveMemorandum { get; set; }
        public virtual Supplier? Supplier { get; set; }
        public virtual ICollection<AgreementApproveItemTransform> AgreementApproveItemTransforms { get; set; }
        public virtual ICollection<ApproveItemPlanReferenceItem> ApproveItemPlanReferenceItems { get; set; }
        public virtual ICollection<ApproveOrderItemTransform> ApproveOrderItemTransforms { get; set; }
        public virtual ICollection<ProcureLoaningItem> ProcureLoaningItems { get; set; }
        public virtual ICollection<RequestApproveItemTransform> RequestApproveItemTransforms { get; set; }
    }
}
