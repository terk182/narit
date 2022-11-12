using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.FIN.Models.Requests
{
    public class DocumentFormRequest
    {
        public int FiscalYear { get; set; } 
        public string? DocumentNumber { get; set; }
        public string? DocumentType { get; set; } = "all";
        public decimal BudgetValue { get; set; }
        public int? PlanTypeId { get; set; }
        public int? DepartmentId { get; set; }
        public int? staffId { get; set; }
        public string? RequesterName { get; set; }
        public string? State { get; set; }
    }
}
