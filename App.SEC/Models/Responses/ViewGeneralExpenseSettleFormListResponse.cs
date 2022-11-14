using App.SEC.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Responses
{
    public class ViewGeneralExpenseSettleFormListResponse : SecBaseResponse
    {
        public List<GeneralExpenseSettleFormDto>? data { get; set; }    
    }
    public class GeneralExpenseSettleFormDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
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
        public int ApprovalStatusEnum { get; set; }
        public string? DepartmentNameOld { get; set; }
        public int DepartmentId { get; set; }
        public string? PlanTypeNameOld { get; set; } 
        public int PlanTypeId { get; set; }
        public string? PlanCoreNameOld { get; set; }
        public int PlanCoreId { get; set; }
        public string? BudgetTypeName { get; set; }
        public int BudgetTypeId { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string? DocumentNumber { get; set; }
        public int? StatementPayMethodEnum { get; set; }
        public int StatementPayStatusEnum { get; set; }
        public DateTime? PayDate { get; set; }
        public decimal? NetPayValue { get; set; }
        public string? PaymentDocumentNumber { get; set; } 
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public string? PlanCoreCode { get; set; }
        public int GeneralExpenseMemoFormId { get; set; }
        public DateTime StatementCalculationDate { get; set; }
        public int PlanActivityIdOld { get; set; }
        public string? FundTypeName { get; set; } 
        public int FundTypeId { get; set; }
        public string? PaymentRemark { get; set; }
        public string? StatementName { get; set; }
        public string? StatementNameAsCash { get; set; } 
        public int? UnitChiefStaffId { get; set; }
        public int? ApproverStaffId { get; set; }
        public int PlanFormApprovalStatusEnum { get; set; }
        public string? RelatedRegulation { get; set; } 
        public string? OperationSummary { get; set; }
        public string? SuppliesOfficerName { get; set; }
        public string? SuppliesOfficerPosition { get; set; }
        public DateTime? SuppliesOfficerSignDate { get; set; }
        public string? RefWithdrawalFormText { get; set; } 
        public string? OtherRequest { get; set; } = null!;
        public string? PlanItemDetailListByBorrowerValue { get; set; }
        public bool IsSent { get; set; }
        public int? RequesterStaffId { get; set; }
        public string? OtherReqDocNumber { get; set; }
        public DateTime? OtherReqWriteDate { get; set; }
        public decimal SettleAmount { get; set; }
        public decimal UsedBudget { get; set; }
        public decimal TotalSettleDirectPaymentUsedBudget { get; set; }
        public decimal TotalSettleDirectPaymentBudget { get; set; }
        public decimal TotalSettleDirectPaymentReturnBudget { get; set; }
        public decimal TotalAdditionalSettleItemUsedBudget { get; set; }
        public decimal TotalAdditionalSettleItemBudget { get; set; }
        public decimal TotalAdditionalSettleItemReturnBudget { get; set; }

        public decimal TotalWithdrawnBudget { get; set; }


        public decimal SettleAmountAfterReceipt { get; set; }
    }
}
