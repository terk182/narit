using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class DirectExpenseMemoForm
    {
        public DirectExpenseMemoForm()
        {
            DeFormActionLogs = new HashSet<DeFormActionLog>();
            DirectExpenses = new HashSet<DirectExpense>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public DateTime? WriteDate { get; set; }
        public string Purpose { get; set; } = null!;
        public string RequesterName { get; set; } = null!;
        public int ApprovalStatusEnum { get; set; }
        public string DepartmentName { get; set; } = null!;
        public int DepartmentId { get; set; }
        public string PlanTypeName { get; set; } = null!;
        public int PlanTypeId { get; set; }
        public string PlanCoreName { get; set; } = null!;
        public int PlanCoreId { get; set; }
        public string BudgetTypeName { get; set; } = null!;
        public int BudgetTypeId { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public int? StatementPayMethodEnum { get; set; }
        public int StatementPayStatusEnum { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public bool IsTemporaryInvolve { get; set; }
        public DateTime StatementCalculationDate { get; set; }
        public string FundTypeName { get; set; } = null!;
        public int FundTypeId { get; set; }
        public int PlanActivityIdOld { get; set; }
        public string Remark { get; set; } = null!;
        public string RecieverName { get; set; } = null!;
        public decimal? PlanCoreRemainBudget { get; set; }
        public decimal? PlanCoreNetBudget { get; set; }
        public int? RealInvolvePlanItemId { get; set; }
        public int? UsedToInvolvePlanItemId { get; set; }
        public int? SupplierId { get; set; }
        public int? PlanStatementDirectionEnum { get; set; }

        public virtual ICollection<DeFormActionLog> DeFormActionLogs { get; set; }
        public virtual ICollection<DirectExpense> DirectExpenses { get; set; }
    }
}
