using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Responses
{
    public class PlanCoreApproveStatusReportResponse
    {
        public int Id { get; set; } 
        public bool Approved { get; set; }

        public string? Name { get; set; }

        public decimal? budget { get; set; }

        public string?  ResponsiblePerson { get; set; }
        public decimal Weight_organization { get; set; }
        public decimal Weight_plan { get; set; }
        public decimal Weight_departmant { get; set; }
        public string? PlanType { get; set; }

        public string? departmant { get; set; }
    }
}
