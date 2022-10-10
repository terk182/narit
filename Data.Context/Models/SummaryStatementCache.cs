using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class SummaryStatementCache
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int Month { get; set; }
        public decimal PaidBudgetAcc { get; set; }
        public decimal PaidBudget { get; set; }
        public decimal InProcessBudgetAcc { get; set; }
        public decimal ContractBudget { get; set; }
        public decimal InternalBudget { get; set; }
        public decimal NetBudget { get; set; }
        public int PlanItemId { get; set; }
        public DateTime CalDate { get; set; }
        public decimal TotalBudgetPlanView { get; set; }
        public decimal NetBudgetPlanView { get; set; }
        public decimal UsedBudgetPlanView { get; set; }
        public decimal RemainBudgetPlanView { get; set; }

        public virtual PlanItem PlanItem { get; set; } = null!;
    }
}
