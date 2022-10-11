using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class CheckFormPlanView
    {
        public CheckFormPlanView()
        {
            CheckViewUsedPlanItems = new HashSet<CheckViewUsedPlanItem>();
            RequestFormPlanViews = new HashSet<RequestFormPlanView>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? DocumentNumber { get; set; }
        public DateTime? WriteDate { get; set; }
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int ProcureTypeEnum { get; set; }
        public string OrderDocumentNumber { get; set; } = null!;
        public DateTime? OrderDate { get; set; }
        public string SupplierName { get; set; } = null!;
        public int? RequestFormPlanViewId { get; set; }
        public int PlanActivityIdOld { get; set; }
        public int CheckFormId { get; set; }
        public int? StatementPayMethodEnum { get; set; }
        public int StatementPayStatusEnum { get; set; }
        public DateTime? PayDate { get; set; }
        public decimal? NetPayValue { get; set; }
        public string PaymentDocumentNumber { get; set; } = null!;
        public int PlanTypeId { get; set; }
        public int DepartmentId { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public DateTime StatementCalculationDate { get; set; }
        public string PaymentRemark { get; set; } = null!;
        public int? ProcureSettleFormId { get; set; }
        public int? ProcureLoaningWithdrawalFormPlanViewId { get; set; }
        public string StatementName { get; set; } = null!;
        public int? ProcureLoaningCancelFormId { get; set; }
        public int? ProcureLoaningReturnFormId { get; set; }
        public DateTime? BudgetCheckerSignDate { get; set; }

        public virtual ProcureLoaningWithdrawalFormPlanView? ProcureLoaningWithdrawalFormPlanView { get; set; }
        public virtual RequestFormPlanView? RequestFormPlanView { get; set; }
        public virtual ICollection<CheckViewUsedPlanItem> CheckViewUsedPlanItems { get; set; }

        public virtual ICollection<RequestFormPlanView> RequestFormPlanViews { get; set; }
    }
}
