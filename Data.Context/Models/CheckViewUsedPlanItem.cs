using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class CheckViewUsedPlanItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal? Amount { get; set; }
        public decimal? PricePerPiece { get; set; }
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsApproved { get; set; }
        public string Unit { get; set; } = null!;
        public int CheckItemId { get; set; }
        public int VatMethodEnum { get; set; }
        public int PlanItemId { get; set; }
        public int? PlanItemTypeId { get; set; }
        public string MultiplierUnit { get; set; } = null!;
        public decimal? MutiplyAmount { get; set; }
        public int RequestViewUsedPlanItemId { get; set; }
        public int CheckFormId { get; set; }
        public DateTime? CheckDate { get; set; }
        public string CheckFormDocumentNumber { get; set; } = null!;
        public string SupplierName { get; set; } = null!;
        public string OrderDucumentNumber { get; set; } = null!;
        public DateTime? OrderDate { get; set; }
        public string CheckChairman { get; set; } = null!;
        public string CheckFirstComittee { get; set; } = null!;
        public string CheckSecondComittee { get; set; } = null!;
        public int OrderFormId { get; set; }
        public int CheckFormPlanViewId { get; set; }
        public int? ProcureLoaningItemId { get; set; }
        public decimal? Discount { get; set; }
        public decimal? NetPayValue { get; set; }
        public decimal? ChangedAmount { get; set; }
        public int? ProcureLoaningSettleItemId { get; set; }
        public decimal? ProcureLoaningWithdrawnMoney { get; set; }
        public bool IsByBudgetControl { get; set; }
        public bool IsFinalCheckByBudgetControl { get; set; }
        public int? ProcureSettleReceiptItemPlanViewId { get; set; }

        public virtual CheckFormPlanView CheckFormPlanView { get; set; } = null!;
        public virtual PlanItem PlanItem { get; set; } = null!;
        public virtual PlanItemType? PlanItemType { get; set; }
        public virtual ProcureSettleReceiptItemPlanView? ProcureSettleReceiptItemPlanView { get; set; }
        public virtual RequestViewUsedPlanItem RequestViewUsedPlanItem { get; set; } = null!;
    }
}
