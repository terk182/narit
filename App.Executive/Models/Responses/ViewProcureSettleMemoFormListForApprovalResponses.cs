using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.FIN.Models.Responses
{
    public class ViewProcureSettleMemoFormListForApprovalResponses
    {

       

        public DateTime date { get; set; }
        public string? id { get; set; }
        public string? project { get; set; }
        public string? agency { get; set; }
        public bool? status { get; set; }
        public double? payBack { get; set; }
        public string? print { get; set; } 

    }
}
