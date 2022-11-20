using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.FIN.Models.Requests
{
    public class PlanFormFinancialStatusReportRequest
    {
        public int FiscalYear { get; set; }
        public int pTypeId { get; set; }
        public int reqDepId { get; set; }
        public string? documentNumber { get; set; }
        public string? name { get; set; }
        public int month { get; set; }
        public int state { get; set; }
    }
}
