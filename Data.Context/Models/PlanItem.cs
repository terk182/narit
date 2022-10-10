using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class PlanItem
    {
        public PlanItem()
        {
            BudgetTransferInwardPlanItems = new HashSet<BudgetTransfer>();
            BudgetTransferOutwardPlanItems = new HashSet<BudgetTransfer>();
            CheckViewUsedPlanItems = new HashSet<CheckViewUsedPlanItem>();
            DirectExpenses = new HashSet<DirectExpense>();
            GeneralExpenses = new HashSet<GeneralExpense>();
            MonthlyForecastAdjustments = new HashSet<MonthlyForecastAdjustment>();
            MonthlyForecasts = new HashSet<MonthlyForecast>();
            PlanItemActionLogs = new HashSet<PlanItemActionLog>();
            RequestViewUsedPlanItemChangedPlanItems = new HashSet<RequestViewUsedPlanItem>();
            RequestViewUsedPlanItemPlanItems = new HashSet<RequestViewUsedPlanItem>();
            SummaryStatementCaches = new HashSet<SummaryStatementCache>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int PlanActivityId { get; set; }
        public string? Unit { get; set; }
        public int? CostTypeId { get; set; }
        public int? PlanItemTypeId { get; set; }
        public int? BudgetTypeId { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public decimal UndefineReserveBudget { get; set; }
        public decimal ProtectBudget { get; set; }
        public DateTime? UndefineReserveDate { get; set; }
        public int? UndefineReserveByStaffId { get; set; }
        public string UndefineReserveByStaffName { get; set; } = null!;
        public string UndefineReserveRemark { get; set; } = null!;
        public string UndefineReserveForecastValue { get; set; } = null!;
        public decimal UndefineReserveReturnBudget { get; set; }
        public DateTime? UndefineReserveReturnDate { get; set; }
        public decimal ReservedBudget { get; set; }
        public decimal ReceivedBudget1 { get; set; }
        public decimal ReceivedBudget2 { get; set; }
        public decimal ReceivedBudget3 { get; set; }
        public decimal ReceivedBudget4 { get; set; }
        public DateTime? ReceivedBudgetDate1 { get; set; }
        public DateTime? ReceivedBudgetDate2 { get; set; }
        public DateTime? ReceivedBudgetDate3 { get; set; }
        public DateTime? ReceivedBudgetDate4 { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsNotControlByReceivedBudget { get; set; }
        public string Remark { get; set; } = null!;

        public virtual BudgetType? BudgetType { get; set; }
        public virtual CostType? CostType { get; set; }
        public virtual PlanActivity PlanActivity { get; set; } = null!;
        public virtual PlanItemType? PlanItemType { get; set; }
        public virtual ICollection<BudgetTransfer> BudgetTransferInwardPlanItems { get; set; }
        public virtual ICollection<BudgetTransfer> BudgetTransferOutwardPlanItems { get; set; }
        public virtual ICollection<CheckViewUsedPlanItem> CheckViewUsedPlanItems { get; set; }
        public virtual ICollection<DirectExpense> DirectExpenses { get; set; }
        public virtual ICollection<GeneralExpense> GeneralExpenses { get; set; }
        public virtual ICollection<MonthlyForecastAdjustment> MonthlyForecastAdjustments { get; set; }
        public virtual ICollection<MonthlyForecast> MonthlyForecasts { get; set; }
        public virtual ICollection<PlanItemActionLog> PlanItemActionLogs { get; set; }
        public virtual ICollection<RequestViewUsedPlanItem> RequestViewUsedPlanItemChangedPlanItems { get; set; }
        public virtual ICollection<RequestViewUsedPlanItem> RequestViewUsedPlanItemPlanItems { get; set; }
        public virtual ICollection<SummaryStatementCache> SummaryStatementCaches { get; set; }
    }
}
