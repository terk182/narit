using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class BudgetTransferForm
    {
        public BudgetTransferForm()
        {
            BtFormActionLogs = new HashSet<BtFormActionLog>();
            BudgetTransfers = new HashSet<BudgetTransfer>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public string Remark { get; set; } = null!;
        public int ApprovalStatusEnum { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public DateTime StatementCalculationDate { get; set; }
        public DateTime? WriteDate { get; set; }
        public string Inform { get; set; } = null!;
        public string Enclosures { get; set; } = null!;
        public string Purpose { get; set; } = null!;
        public string RequesterName { get; set; } = null!;
        public DateTime? RequesterSignDate { get; set; }
        public string UnitChiefName { get; set; } = null!;
        public DateTime? UnitChiefSignDate { get; set; }
        public string BudgetCheckerName { get; set; } = null!;
        public DateTime? BudgetCheckerSignDate { get; set; }
        public string Approver { get; set; } = null!;
        public DateTime? ApproverSignDate { get; set; }
        public string StatementName { get; set; } = null!;
        public string SeniorUnitChiefName { get; set; } = null!;
        public string FinanceName { get; set; } = null!;
        public DateTime? SeniorUnitChiefSignDate { get; set; }
        public DateTime? FinanceSignDate { get; set; }
        public int RequestDepartmentId { get; set; }
        public int? UnitChiefStaffId { get; set; }
        public int? ApproverStaffId { get; set; }
        public int PlanFormApprovalStatusEnum { get; set; }
        public int BudgetTransferTypeEnum { get; set; }

        public virtual ICollection<BtFormActionLog> BtFormActionLogs { get; set; }
        public virtual ICollection<BudgetTransfer> BudgetTransfers { get; set; }
    }
}
