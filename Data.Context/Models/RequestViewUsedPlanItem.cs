using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class RequestViewUsedPlanItem
    {
        public RequestViewUsedPlanItem()
        {
            CheckViewUsedPlanItems = new HashSet<CheckViewUsedPlanItem>();
            InverseBaseRequestViewUsedPlanItem = new HashSet<RequestViewUsedPlanItem>();
            ProcureSettleReceiptItemPlanViews = new HashSet<ProcureSettleReceiptItemPlanView>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal? Amount { get; set; }
        public decimal? PricePerPiece { get; set; }
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsApproved { get; set; }
        public string Unit { get; set; } = null!;
        public int RequestItemId { get; set; }
        public int VatMethodEnum { get; set; }
        public int PlanItemId { get; set; }
        public int? PlanItemTypeId { get; set; }
        public string MultiplierUnit { get; set; } = null!;
        public decimal? MutiplyAmount { get; set; }
        public bool IsFinishedTransform { get; set; }
        public int RequestFormId { get; set; }
        public DateTime? RequestDate { get; set; }
        public string RequestFormDocumentNumber { get; set; } = null!;
        public string Requester { get; set; } = null!;
        public decimal? NoSupplierAmount { get; set; }
        public DateTime? FinishedTransformDate { get; set; }
        public int RequestFormPlanViewId { get; set; }
        public bool IsLateAdded { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public decimal? ApprovePricePerPiece { get; set; }
        public int? ApproveFormId { get; set; }
        public string ApproveFormDocumentNumber { get; set; } = null!;
        public bool IsImmediatelyReturnBudget { get; set; }
        public string ApproveFormStatementName { get; set; } = null!;
        public DateTime? ReturnBudgetDate { get; set; }
        public int? BaseRequestViewUsedPlanItemId { get; set; }
        public string ApproveRemark { get; set; } = null!;
        public DateTime? ChangedPlanItemDate { get; set; }
        public int? ChangedPlanItemId { get; set; }
        public string ChangedPlanItemRemark { get; set; } = null!;
        public DateTime? ApproveFormCreatedDate { get; set; }
        public DateTime? ApproveFormWriteDate { get; set; }
        public DateTime? WithInDate { get; set; }

        public virtual RequestViewUsedPlanItem? BaseRequestViewUsedPlanItem { get; set; }
        public virtual PlanItem? ChangedPlanItem { get; set; }
        public virtual PlanItem PlanItem { get; set; } = null!;
        public virtual PlanItemType? PlanItemType { get; set; }
        public virtual RequestFormPlanView RequestFormPlanView { get; set; } = null!;
        public virtual ICollection<CheckViewUsedPlanItem> CheckViewUsedPlanItems { get; set; }
        public virtual ICollection<RequestViewUsedPlanItem> InverseBaseRequestViewUsedPlanItem { get; set; }
        public virtual ICollection<ProcureSettleReceiptItemPlanView> ProcureSettleReceiptItemPlanViews { get; set; }
    }
}
