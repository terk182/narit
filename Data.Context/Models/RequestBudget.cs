using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class RequestBudget
    {
        public RequestBudget()
        {
            RequestFormBorrowingMoneys = new HashSet<RequestFormBorrowingMoney>();
            RequestFormComments = new HashSet<RequestFormComment>();
            RequestFormExaminerForBudgets = new HashSet<RequestFormExaminerForBudget>();
            RequestFormSchedules = new HashSet<RequestFormSchedule>();
            RequestForms = new HashSet<RequestForm>();
        }

        public int Id { get; set; }
        public int? DocYear { get; set; }
        public string DocNo { get; set; } = null!;
        public string? DocStatus { get; set; }
        public int? BudgetTypeCode { get; set; }
        public bool? Active { get; set; }
        public string? Name { get; set; }
        public string? Inform { get; set; }
        public string? Descriptions { get; set; }
        public DateTime? WriteDate { get; set; }
        public DateTime? DateTime { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? CalculationDate { get; set; }
        public string? StatmentName { get; set; }
        public string? RelatedRegulation { get; set; }
        public string? CreateByStaffId { get; set; }
        public string? FilePath { get; set; }
        public int? DepartmentId { get; set; }
        public decimal? TotalBudget { get; set; }
        public string? AnotherAction { get; set; }
        public string? Procurement { get; set; }
        public int? InspectorId { get; set; }
        public string? InspectorName { get; set; }
        public string? ProcurementByStaff { get; set; }

        public virtual ICollection<RequestFormBorrowingMoney> RequestFormBorrowingMoneys { get; set; }
        public virtual ICollection<RequestFormComment> RequestFormComments { get; set; }
        public virtual ICollection<RequestFormExaminerForBudget> RequestFormExaminerForBudgets { get; set; }
        public virtual ICollection<RequestFormSchedule> RequestFormSchedules { get; set; }
        public virtual ICollection<RequestForm> RequestForms { get; set; }
    }
}
