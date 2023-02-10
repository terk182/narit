using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Requests
{
    public class RequestFormExaminerForBudgetRequests
    {
        public int Id { get; set; }
        public string DocNo { get; set; } = null!;
        public int? RequestFormId { get; set; }
        public string? Name { get; set; }
        public string? Descriptions { get; set; }
        public bool? Active { get; set; }
        public string? ExaminerRole { get; set; }
        public int? JobPositionId { get; set; }
        public int? DepartmentId { get; set; }
        public int? RebudgetId { get; set; }
    }
}
