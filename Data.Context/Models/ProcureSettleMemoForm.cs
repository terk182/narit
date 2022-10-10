using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class ProcureSettleMemoForm
    {
        public ProcureSettleMemoForm()
        {
            ProcureLoaningSettleItems = new HashSet<ProcureLoaningSettleItem>();
            ProcureSeFormActionLogs = new HashSet<ProcureSeFormActionLog>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public DateTime? WriteDate { get; set; }
        public string Inform { get; set; } = null!;
        public string Enclosures { get; set; } = null!;
        public string Purpose { get; set; } = null!;
        public string RequesterName { get; set; } = null!;
        public DateTime? RequesterSignDate { get; set; }
        public string BudgetCheckerName { get; set; } = null!;
        public DateTime? BudgetCheckerSignDate { get; set; }
        public string Approver { get; set; } = null!;
        public DateTime? ApproverSignDate { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public string DepartmentName { get; set; } = null!;
        public int DepartmentId { get; set; }
        public string PlanTypeName { get; set; } = null!;
        public int PlanTypeId { get; set; }
        public string PlanCoreName { get; set; } = null!;
        public int PlanCoreId { get; set; }
        public string PlanCoreCode { get; set; } = null!;
        public DateTime? ApprovedDate { get; set; }
        public int ProcureLoaningMemoFormId { get; set; }
        public string SuppliesUnitChiefName { get; set; } = null!;
        public DateTime? SuppliesUnitChiefSignDate { get; set; }
        public DateTime? ApproveFormDate { get; set; }
        public string ApproveFormNumber { get; set; } = null!;
        public string DocumentNumber { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public DateTime StatementCalculationDate { get; set; }
        public int PlanActivityIdOld { get; set; }
        public string FundTypeName { get; set; } = null!;
        public int FundTypeId { get; set; }
        public string StatementName { get; set; } = null!;
        public int StatementPayStatusEnum { get; set; }
        public int PlanFormApprovalStatusEnum { get; set; }
        public string OperationSummary { get; set; } = null!;
        public string RelatedRegulation { get; set; } = null!;
        public string OtherRequest { get; set; } = null!;
        public string SummaryStatementByPlanItem { get; set; } = null!;

        public virtual ProcureLoaningMemoForm ProcureLoaningMemoForm { get; set; } = null!;
        public virtual ICollection<ProcureLoaningSettleItem> ProcureLoaningSettleItems { get; set; }
        public virtual ICollection<ProcureSeFormActionLog> ProcureSeFormActionLogs { get; set; }
    }
}
