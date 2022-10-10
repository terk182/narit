using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class ProcureLoaningWithdrawalFormPlanView
    {
        public ProcureLoaningWithdrawalFormPlanView()
        {
            CheckFormPlanViews = new HashSet<CheckFormPlanView>();
            ProcureSettleReceiptFormPlanViews = new HashSet<ProcureSettleReceiptFormPlanView>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int ProcureLoaningFormId { get; set; }
        public string StatementName { get; set; } = null!;
        public string CredentialNumber { get; set; } = null!;
        public DateTime? ProceedDate { get; set; }
        public DateTime StatementCalculationDate { get; set; }
        public decimal? MoneyAmount { get; set; }
        public bool IsApproved { get; set; }
        public int RequestFormPlanViewId { get; set; }
        public int StatementStatusEnum { get; set; }
        public int? StatementPayMethodEnum { get; set; }
        public int StatementPayStatusEnum { get; set; }
        public DateTime? PayDate { get; set; }
        public decimal? NetPayValue { get; set; }
        public string PaymentDocumentNumber { get; set; } = null!;
        public bool IsFinishedTransform { get; set; }
        public string PaymentRemark { get; set; } = null!;
        public bool IsBorrow { get; set; }
        public int? ProcureLoaningWithdrawalFormId { get; set; }
        public string WithdrawalItemsDataListValue { get; set; } = null!;
        public string? WithdrawalItemsDataListValue2 { get; set; }
        public string ChangedPlanItemWithdrawalItemsDataListValue2 { get; set; } = null!;

        public virtual RequestFormPlanView RequestFormPlanView { get; set; } = null!;
        public virtual ICollection<CheckFormPlanView> CheckFormPlanViews { get; set; }
        public virtual ICollection<ProcureSettleReceiptFormPlanView> ProcureSettleReceiptFormPlanViews { get; set; }
    }
}
