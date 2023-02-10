using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Requests
{
    public class RequestBudgetRequests
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Inform { get; set; }
        public string? Descriptions { get; set; }
        public bool Active { get; set; }
        public DateTime WriteDate { get; set; }
        public DateTime? CalculationDate { get; set; }
        public string? StatmentName { get; set; }
        public string? RelatedRegulation { get; set; }
        public string? CreateByStaffId { get; set; }
        public string? FilePath { get; set; }
        public int? DepartmentId { get; set; }
        public decimal? TotalBudget { get; set; }

    }
}
