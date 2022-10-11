using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class DirectExpense
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public decimal? TotalBudget { get; set; }
        public DateTime? RequestDate { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public int PlanTypeId { get; set; }
        public string PlanTypeName { get; set; } = null!;
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
        public DateTime? ApprovedDate { get; set; }
        public string FundTypeName { get; set; } = null!;
        public int FundTypeId { get; set; }
        public int PlanItemId { get; set; }
        public int? SupplierId { get; set; }
        public string RecieverName { get; set; } = null!;
        public int? DirectExpenseMemoFormId { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public DateTime? DocumentDate { get; set; }
        public int? PlanStatementDirectionEnum { get; set; }

        public virtual DirectExpenseMemoForm? DirectExpenseMemoForm { get; set; }
        public virtual PlanItem PlanItem { get; set; } = null!;
    }
}
