using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class FinancialReimbursementForm
    {
        public FinancialReimbursementForm()
        {
            FinancialReimbursementItems = new HashSet<FinancialReimbursementItem>();
            FrFormActionLogs = new HashSet<FrFormActionLog>();
            GeneralExpenseMemoForms = new HashSet<GeneralExpenseMemoForm>();
        }

        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public string Inform { get; set; } = null!;
        public string RequestDepartmentName { get; set; } = null!;
        public int RequestDepartmentId { get; set; }
        public DateTime? WriteDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public int StaffId { get; set; }
        public string StaffName { get; set; } = null!;
        public string StaffPosition { get; set; } = null!;
        public string StaffDepartment { get; set; } = null!;
        public string Payee { get; set; } = null!;
        public int? PayeeStaffId { get; set; }
        public DateTime? PayeeSignDate { get; set; }
        public string Payer { get; set; } = null!;
        public int? PayerStaffId { get; set; }
        public DateTime? PayerSignDate { get; set; }
        public string RequesterName { get; set; } = null!;
        public DateTime? RequesterSignDate { get; set; }
        public string UnitChiefName { get; set; } = null!;
        public DateTime? UnitChiefSignDate { get; set; }
        public string BudgetCheckerName { get; set; } = null!;
        public DateTime? BudgetCheckerSignDate { get; set; }
        public string Approver { get; set; } = null!;
        public DateTime? ApproverSignDate { get; set; }
        public string SuppliesOfficerName { get; set; } = null!;
        public DateTime? SuppliesOfficerSignDate { get; set; }
        public string RefDocumentNumber { get; set; } = null!;
        public DateTime? RefDocumentDate { get; set; }
        public decimal RefTotalBudget { get; set; }
        public string OtherRequest { get; set; } = null!;
        public string Remark { get; set; } = null!;
        public int ApprovalStatusEnum { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public int? GeneralExpenseMemoFormId { get; set; }
        public string RelatedRegulation { get; set; } = null!;
        public string RefStatementName { get; set; } = null!;
        public string OperationSummary { get; set; } = null!;
        public int? UnitChiefStaffId { get; set; }
        public int? ApproverStaffId { get; set; }
        public int PlanFormApprovalStatusEnum { get; set; }

        public virtual GeneralExpenseMemoForm? GeneralExpenseMemoForm { get; set; }
        public virtual ICollection<FinancialReimbursementItem> FinancialReimbursementItems { get; set; }
        public virtual ICollection<FrFormActionLog> FrFormActionLogs { get; set; }

        public virtual ICollection<GeneralExpenseMemoForm> GeneralExpenseMemoForms { get; set; }
    }
}
