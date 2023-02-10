using App.Common.Models.Responses;
using narit_acc_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.GL.Responses
{
    public class ReportChartResponse
    {
        public List<Accounting>? data { get; set; }
        public decimal? SumCredit { get; set; }
        public decimal? SumDebit { get; set; }
        public decimal? SumQuantity { get; set; }

        public string? AllDay { get; set; }




    }
}
