using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Dtos
{
    public class BudgetTransferFormDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public string? Remark { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string? DocumentNumber { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public DateTime StatementCalculationDate { get; set; }
        public DateTime? WriteDate { get; set; }
        public string? Inform { get; set; }
        public string? Enclosures { get; set; }
        public string? Purpose { get; set; }
        public string? RequesterName { get; set; }
        public DateTime? RequesterSignDate { get; set; }
        public string? UnitChiefName { get; set; } 
        public DateTime? UnitChiefSignDate { get; set; }
        public string? BudgetCheckerName { get; set; }
        public DateTime? BudgetCheckerSignDate { get; set; }
        public string? Approver { get; set; }
        public DateTime? ApproverSignDate { get; set; }
        public string? StatementName { get; set; }
        public string? SeniorUnitChiefName { get; set; } 
        public string? FinanceName { get; set; } 
        public DateTime? SeniorUnitChiefSignDate { get; set; }
        public DateTime? FinanceSignDate { get; set; }
        public int RequestDepartmentId { get; set; }
        public int? UnitChiefStaffId { get; set; }
        public int? ApproverStaffId { get; set; }
        public int PlanFormApprovalStatusEnum { get; set; }
        public int BudgetTransferTypeEnum { get; set; }
        public decimal TransferBudget { get; set; }
    }
}
