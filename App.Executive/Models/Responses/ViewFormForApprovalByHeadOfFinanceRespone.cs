using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.FIN.Models.Responses
{
    public class ViewFormForApprovalByHeadOfFinanceRespone
    {
        public int no { get; set; }
        public string? type { get; set; }
        public DateTime date { get; set; }
        public string? docType { get; set; }
        public string? detail { get; set; }
        public double ? price { get; set; }
        public bool? status { get; set; }
    }
}
