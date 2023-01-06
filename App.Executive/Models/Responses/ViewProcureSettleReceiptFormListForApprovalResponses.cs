using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.FIN.Models.Responses
{
    public class ViewProcureSettleReceiptFormListForApprovalResponses
    {
        public int no { get; set; }
        public DateTime date { get; set; }
        public string? id { get; set; }
        public string? detail { get; set; }
        public string? project { get; set; }
        public double? payBack { get; set; }
        public bool? status { get; set; }
        public string? print { get; set; }


    }
}
