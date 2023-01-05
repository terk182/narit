using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.FIN.Models.Responses
{
    public class ViewProcureLoaningMemoFormListForApprovalResponses
    {
        public DateTime date { get; set; }
        public int id { get; set; }
        public string? requester { get; set; }  
        public string? agency { get; set; }
        public bool? status { get; set; }
        public double? price { get; set; }
        public DateTime transferDate { get; set; }
        public string? print { get; set; }
    } 
}
