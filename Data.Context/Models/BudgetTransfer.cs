using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class BudgetTransfer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public decimal TransferBudget { get; set; }
        public int? OutwardPlanItemId { get; set; }
        public int? InwardPlanItemId { get; set; }
        public string Remark { get; set; } = null!;
        public int ApprovalStatusEnum { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string OutwardDepartmentName { get; set; } = null!;
        public int? OutwardDepartmentId { get; set; }
        public string OutwardPlanTypeName { get; set; } = null!;
        public int? OutwardPlanTypeId { get; set; }
        public string OutwardPlanCoreName { get; set; } = null!;
        public int? OutwardPlanCoreId { get; set; }
        public string OutwardPlanActivityName { get; set; } = null!;
        public int? OutwardPlanActivityId { get; set; }
        public string InwardDepartmentName { get; set; } = null!;
        public int? InwardDepartmentId { get; set; }
        public string InwardPlanTypeName { get; set; } = null!;
        public int? InwardPlanTypeId { get; set; }
        public string InwardPlanCoreName { get; set; } = null!;
        public int? InwardPlanCoreId { get; set; }
        public string InwardPlanActivityName { get; set; } = null!;
        public int? InwardPlanActivityId { get; set; }
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
        public decimal OutwardPlanItemNetBudget { get; set; }
        public decimal OutwardPlanItemRemainBudget { get; set; }
        public decimal InwardPlanItemNetBudget { get; set; }
        public decimal InwardPlanItemRemainBudget { get; set; }
        public string StatementName { get; set; } = null!;
        public decimal OutwardPlanCoreNetBudget { get; set; }
        public decimal OutwardPlanCoreRemainBudget { get; set; }
        public decimal InwardPlanCoreNetBudget { get; set; }
        public decimal InwardPlanCoreRemainBudget { get; set; }
        public int? BudgetTransferFormId { get; set; }
        public decimal InwardAmount { get; set; }
        public decimal OutwardAmount { get; set; }
        public string InwardMonthlyForecastValue { get; set; } = null!;
        public string OutwardMonthlyForecastValue { get; set; } = null!;
        public string InwardMonthlyForecastChangedValue { get; set; } = null!;
        public string OutwardMonthlyForecastChangedValue { get; set; } = null!;
        public bool IsLateYear { get; set; }

        public virtual BudgetTransferForm? BudgetTransferForm { get; set; }
        public virtual PlanItem? InwardPlanItem { get; set; }
        public virtual PlanItem? OutwardPlanItem { get; set; }
    }
}
