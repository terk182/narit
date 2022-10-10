using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class GeneralExpensePersonalBorrowForm
    {
        public GeneralExpensePersonalBorrowForm()
        {
            GeBorrowFormActionLogs = new HashSet<GeBorrowFormActionLog>();
            GeneralExpensePersonalBorrowItems = new HashSet<GeneralExpensePersonalBorrowItem>();
            PlanFiles = new HashSet<PlanFile>();
            GeneralExpenseExtendForms = new HashSet<GeneralExpenseExtendForm>();
        }

        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public string Inform { get; set; } = null!;
        public DateTime? WriteDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public int StaffId { get; set; }
        public string StaffName { get; set; } = null!;
        public string StaffPosition { get; set; } = null!;
        public string StaffDepartment { get; set; } = null!;
        public string StaffContactNumber { get; set; } = null!;
        public string Purpose { get; set; } = null!;
        public string RefDocumentNumber { get; set; } = null!;
        public DateTime? RefDocumentDate { get; set; }
        public DateTime? SettleDate { get; set; }
        public decimal TotalBudget { get; set; }
        public bool IsCash { get; set; }
        public string RequesterName { get; set; } = null!;
        public string UnitChiefName { get; set; } = null!;
        public DateTime? UnitChiefSignDate { get; set; }
        public DateTime? RequesterSignDate { get; set; }
        public string ApproverName { get; set; } = null!;
        public DateTime? ApproverSignDate { get; set; }
        public string AttorneyName { get; set; } = null!;
        public DateTime? AttorneySignDate { get; set; }
        public int GeneralExpenseMemoFormId { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public string StaffPositionType { get; set; } = null!;
        public bool IsSent { get; set; }
        public int? UnitChiefStaffId { get; set; }
        public int PlanFormApprovalStatusEnum { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string FinanceCheckerName { get; set; } = null!;
        public DateTime? FinanceCheckerSignDate { get; set; }
        public int? RequesterSignatureId { get; set; }
        public int? RequesterStaffId { get; set; }
        public int? FinanceCheckerStaffId { get; set; }
        public int? FinanceCheckerSignatureId { get; set; }
        public int? UnitChiefSignatureId { get; set; }
        public int? ApproverSignatureId { get; set; }
        public int? ApproverStaffId { get; set; }

        public virtual GeneralExpenseMemoForm GeneralExpenseMemoForm { get; set; } = null!;
        public virtual ICollection<GeBorrowFormActionLog> GeBorrowFormActionLogs { get; set; }
        public virtual ICollection<GeneralExpensePersonalBorrowItem> GeneralExpensePersonalBorrowItems { get; set; }
        public virtual ICollection<PlanFile> PlanFiles { get; set; }

        public virtual ICollection<GeneralExpenseExtendForm> GeneralExpenseExtendForms { get; set; }
    }
}
