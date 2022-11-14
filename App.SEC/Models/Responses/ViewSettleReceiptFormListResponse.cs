using App.SEC.Responses;
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Responses
{
    public class ViewSettleReceiptFormListResponse : SecBaseResponse
    {
        public List<SettleReceiptFormDto>? data { get; set; }   
    }
    public class SettleReceiptFormDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int GeneralExpenseMemoFormId { get; set; }
        public DateTime? WriteDate { get; set; }
        public string? Inform { get; set; } 
        public string? Purpose { get; set; }
        public string? DocumentNumber { get; set; } 
        public string? RequesterName { get; set; }
        public DateTime? RequesterSignDate { get; set; }
        public string? BudgetCheckerName { get; set; }
        public DateTime? BudgetCheckerSignDate { get; set; }
        public int? StatementPayMethodEnum { get; set; }
        public int StatementPayStatusEnum { get; set; }
        public DateTime? PayDate { get; set; }
        public decimal? NetPayValue { get; set; }
        public string? PaymentDocumentNumber { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public DateTime StatementCalculationDate { get; set; }
        public string? PaymentRemark { get; set; } 
        public string? StatementName { get; set; }
        public int PlanFormApprovalStatusEnum { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime? UnitChiefSignDate { get; set; }
        public string? UnitChiefName { get; set; }
        public bool IsSent { get; set; }
        public int? UnitChiefStaffId { get; set; }
        public int BankAccountEnum { get; set; }
        public int? RequesterSignatureId { get; set; }
        public int? RequesterStaffId { get; set; }
        public int? BudgetCheckerStaffId { get; set; }
        public int? BudgetCheckerSignatureId { get; set; }
        public int? UnitChiefSignatureId { get; set; }
        public string? AccountantName { get; set; } 
        public DateTime? AccountantSignDate { get; set; }
        public int? AccountantStaffId { get; set; }
        public int? AccountantSignatureId { get; set; }
        public decimal SettleAmount { get; set; }
        public decimal UsedBudget { get; set; }



    }
}
