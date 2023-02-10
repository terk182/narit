using narit_acc_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.GL.Requests
{
    public class ReportChartRequest
    {
        public int? SelectDate { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
       // public int? ChartMinorId { get; set; }
        public List<ArrChartMinorRequest>? ChartMinorId { get; set; }
        public string? Column { get; set; }
        public string? OrderBy { get; set; }


    }
}
