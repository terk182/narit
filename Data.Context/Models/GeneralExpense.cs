using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class GeneralExpense
    {
        public GeneralExpense()
        {
            AdditionalSettleItems = new HashSet<AdditionalSettleItem>();
            GeneralExpenseCancelItems = new HashSet<GeneralExpenseCancelItem>();
            GeneralExpensePersonalBorrowItems = new HashSet<GeneralExpensePersonalBorrowItem>();
            GeneralExpenseReturnItems = new HashSet<GeneralExpenseReturnItem>();
            SettleDirectPaymentItems = new HashSet<SettleDirectPaymentItem>();
            SettleReceiptItems = new HashSet<SettleReceiptItem>();
            SettlementItems = new HashSet<SettlementItem>();
            WithdrawalItems = new HashSet<WithdrawalItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public decimal TotalBudget { get; set; }
        public int PlanItemId { get; set; }
        public DateTime? RequestDate { get; set; }
        public string Remark { get; set; } = null!;
        public int ApprovalStatusEnum { get; set; }
        public int PlanTypeId { get; set; }
        public string PlanTypeName { get; set; } = null!;
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
        public int? GeneralExpenseMemoFormId { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime? FinishSettleFormWriteDate { get; set; }
        public bool IsBorrow { get; set; }
        public string FundTypeName { get; set; } = null!;
        public int FundTypeId { get; set; }
        public int? GeneralExpenseCancelFormId { get; set; }
        public decimal CancelBudgetOld { get; set; }
        public DateTime? FinishTransformDate { get; set; }
        public decimal ReturnBudgetOld { get; set; }
        public int? GeneralExpenseReturnFormId { get; set; }
        public decimal ReturnBudgetYearEndRequest { get; set; }
        public int? OutsideDutyGroupId { get; set; }
        public int? DevelopmentRecordGroupId { get; set; }
        public decimal PlanItemFinRemainBudget { get; set; }
        public string PlanCoreName { get; set; } = null!;
        public string PlanActivityName { get; set; } = null!;
        public int PlanCoreId { get; set; }
        public int PlanActivityId { get; set; }
        public bool IsPostApprovedAdded { get; set; }
        public int? GedataGroupId { get; set; }
        public decimal PlanCoreRemainBudget { get; set; }
        public bool IsDirectPayment { get; set; }
        public bool IsHrpayment { get; set; }
        public decimal? RequestReserveBudget { get; set; }

        public virtual GedataGroup? GedataGroup { get; set; }
        public virtual GeneralExpenseCancelForm? GeneralExpenseCancelForm { get; set; }
        public virtual GeneralExpenseMemoForm? GeneralExpenseMemoForm { get; set; }
        public virtual GeneralExpenseReturnForm? GeneralExpenseReturnForm { get; set; }
        public virtual PlanItem PlanItem { get; set; } = null!;
        public virtual ICollection<AdditionalSettleItem> AdditionalSettleItems { get; set; }
        public virtual ICollection<GeneralExpenseCancelItem> GeneralExpenseCancelItems { get; set; }
        public virtual ICollection<GeneralExpensePersonalBorrowItem> GeneralExpensePersonalBorrowItems { get; set; }
        public virtual ICollection<GeneralExpenseReturnItem> GeneralExpenseReturnItems { get; set; }
        public virtual ICollection<SettleDirectPaymentItem> SettleDirectPaymentItems { get; set; }
        public virtual ICollection<SettleReceiptItem> SettleReceiptItems { get; set; }
        public virtual ICollection<SettlementItem> SettlementItems { get; set; }
        public virtual ICollection<WithdrawalItem> WithdrawalItems { get; set; }
    }
}
