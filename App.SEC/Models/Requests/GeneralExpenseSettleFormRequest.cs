using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Requests
{
    public class GeneralExpenseSettleFormRequest
    {
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
        public string UnitChiefName { get; set; } = null!;
        public DateTime? UnitChiefSignDate { get; set; }
        public string BudgetCheckerName { get; set; } = null!;
        public DateTime? BudgetCheckerSignDate { get; set; }
        public string Approver { get; set; } = null!;
        public DateTime? ApproverSignDate { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public string DepartmentNameOld { get; set; } = null!;
        public int DepartmentId { get; set; }
        public string PlanTypeNameOld { get; set; } = null!;
        public int PlanTypeId { get; set; }
        public string PlanCoreNameOld { get; set; } = null!;
        public int PlanCoreId { get; set; }
        public string BudgetTypeName { get; set; } = null!;
        public int BudgetTypeId { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public int? StatementPayMethodEnum { get; set; }
        public int StatementPayStatusEnum { get; set; }
        public DateTime? PayDate { get; set; }
        public decimal? NetPayValue { get; set; }
        public string PaymentDocumentNumber { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public string PlanCoreCode { get; set; } = null!;
        public int GeneralExpenseMemoFormId { get; set; }
        public DateTime StatementCalculationDate { get; set; }
        public int PlanActivityIdOld { get; set; }
        public string FundTypeName { get; set; } = null!;
        public int FundTypeId { get; set; }
        public string PaymentRemark { get; set; } = null!;
        public string StatementName { get; set; } = null!;
        public string StatementNameAsCash { get; set; } = null!;
        public int? UnitChiefStaffId { get; set; }
        public int? ApproverStaffId { get; set; }
        public int PlanFormApprovalStatusEnum { get; set; }
        public string RelatedRegulation { get; set; } = null!;
        public string OperationSummary { get; set; } = null!;
        public string SuppliesOfficerName { get; set; } = null!;
        public string SuppliesOfficerPosition { get; set; } = null!;
        public DateTime? SuppliesOfficerSignDate { get; set; }
        public string RefWithdrawalFormText { get; set; } = null!;
        public string OtherRequest { get; set; } = null!;
        public string PlanItemDetailListByBorrowerValue { get; set; } = null!;
        public bool IsSent { get; set; }
        public int? RequesterStaffId { get; set; }
        public string OtherReqDocNumber { get; set; } = null!;
        public DateTime? OtherReqWriteDate { get; set; }

    }
}
