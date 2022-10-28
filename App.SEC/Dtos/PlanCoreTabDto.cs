using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Dtos
{
    public class PlanCoreTabDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public bool? IsApproved { get; set; }
        public int FiscalYear { get; set; }
        public string? Department { get; set; }
        public string? PlanType { get; set; }
        public string? ParentPlanType { get; set; }
        public int FundTypeId { get; set; }
        public string? FundTypeName { get; set; }
        public decimal TotalBudget { get; set; }
        public decimal NetBudget { get; set; }
        public decimal UsedBudget { get; set; }
        public decimal RemainBudget { get; set; }
    }
}
