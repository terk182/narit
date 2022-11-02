using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Requests
{
    public class PlanCoreApproveStatusReportRequest
    {
        public int fiscalYear { get; set; }
        public int depId { get; set; }
        public int planTypeId { get; set; }
        public string? projectName { get; set; }
        public int? status { get; set; }
    }
}
