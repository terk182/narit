using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class FinancialReimbursementItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public int PlanTypeId { get; set; }
        public string PlanTypeName { get; set; } = null!;
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
        public int PlanCoreId { get; set; }
        public string PlanCoreName { get; set; } = null!;
        public int PlanActivityId { get; set; }
        public string PlanActivityName { get; set; } = null!;
        public int PlanItemId { get; set; }
        public string PlanItemName { get; set; } = null!;
        public decimal PlanItemRemainBudget { get; set; }
        public decimal TotalBudget { get; set; }
        public decimal RequestBudget { get; set; }
        public bool IsLateAdded { get; set; }
        public int? OutsideDutyGroupId { get; set; }
        public int? DevelopmentRecordGroupId { get; set; }
        public int? LateAddedGroupId { get; set; }
        public int FinancialReimbursementFormId { get; set; }
        public int? GeneralExpenseId { get; set; }
        public string PlanCoreCode { get; set; } = null!;
        public string PlanTypeCode { get; set; } = null!;
        public string PlanActivityCode { get; set; } = null!;
        public string BudgetTypeName { get; set; } = null!;
        public int? BudgetTypeId { get; set; }
        public int RangeNumber { get; set; }
        public decimal PlanCoreRemainBudget { get; set; }
        public int? GedataGroupId { get; set; }
        public bool IsEventOrganize { get; set; }
        public bool IsDirectPayment { get; set; }
        public bool IsHrpayment { get; set; }
        public string GedocumentNumber { get; set; } = null!;

        public virtual FinancialReimbursementForm FinancialReimbursementForm { get; set; } = null!;
    }
}
