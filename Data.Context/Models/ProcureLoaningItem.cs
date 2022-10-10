using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class ProcureLoaningItem
    {
        public ProcureLoaningItem()
        {
            ProcureLoaningItemPlanReferenceItems = new HashSet<ProcureLoaningItemPlanReferenceItem>();
            ProcureLoaningSettleItems = new HashSet<ProcureLoaningSettleItem>();
            ProcureLoaningWithdrawalItems = new HashSet<ProcureLoaningWithdrawalItem>();
            ProcureSettleReceiptItems = new HashSet<ProcureSettleReceiptItem>();
            RegisterProcureItems = new HashSet<RegisterProcureItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public string Remark { get; set; } = null!;
        public int ApprovalStatusEnum { get; set; }
        public decimal? Amount { get; set; }
        public decimal? PricePerPiece { get; set; }
        public string Unit { get; set; } = null!;
        public int VatMethodEnum { get; set; }
        public int ProcureLoaningMemoFormId { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int PlanTypeId { get; set; }
        public string PlanTypeName { get; set; } = null!;
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
        public decimal? SettleAmountOld { get; set; }
        public DateTime? SettleDateOld { get; set; }
        public int SettleApprovalStatusEnumOld { get; set; }
        public DateTime? SettleApprovedDateOld { get; set; }
        public string FundTypeName { get; set; } = null!;
        public int FundTypeId { get; set; }
        public int ApproveItemId { get; set; }
        public int? ProcureSettleMemoFormIdOld { get; set; }
        public int? PlanItemId { get; set; }
        public int PlanActivityId { get; set; }
        public int PlanCoreId { get; set; }
        public int? PlanItemTypeId { get; set; }
        public int RequestItemRefId { get; set; }
        public decimal? ChangedAmountOld { get; set; }
        public decimal? PaidPricePerPieceOld { get; set; }
        public int? ProcureLoaningReturnFormId { get; set; }
        public int? ProcureLoaningCancelFormId { get; set; }
        public decimal? ReturnBudget { get; set; }
        public decimal? CancelBudget { get; set; }
        public bool? IsBorrow { get; set; }
        public DateTime? FinishSettleFormWriteDate { get; set; }
        public DateTime? FinishTransformDate { get; set; }
        public decimal? CancelAmount { get; set; }
        public decimal? ReturnAmount { get; set; }
        public decimal? EstimateUsedAmount { get; set; }
        public decimal? EstimateUsedBudget { get; set; }

        public virtual ApproveItem ApproveItem { get; set; } = null!;
        public virtual ProcureLoaningCancelForm? ProcureLoaningCancelForm { get; set; }
        public virtual ProcureLoaningMemoForm ProcureLoaningMemoForm { get; set; } = null!;
        public virtual ProcureLoaningReturnForm? ProcureLoaningReturnForm { get; set; }
        public virtual ICollection<ProcureLoaningItemPlanReferenceItem> ProcureLoaningItemPlanReferenceItems { get; set; }
        public virtual ICollection<ProcureLoaningSettleItem> ProcureLoaningSettleItems { get; set; }
        public virtual ICollection<ProcureLoaningWithdrawalItem> ProcureLoaningWithdrawalItems { get; set; }
        public virtual ICollection<ProcureSettleReceiptItem> ProcureSettleReceiptItems { get; set; }
        public virtual ICollection<RegisterProcureItem> RegisterProcureItems { get; set; }
    }
}
