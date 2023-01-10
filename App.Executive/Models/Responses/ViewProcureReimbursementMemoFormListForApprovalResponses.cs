using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.FIN.Models.Responses
{
    public class ViewProcureReimbursementMemoFormListForApprovalResponses
    {

        public DateTime? WriteDate { get; set; }
        public int Id { get; set; }
        public string RequesterName { get; set; }
        public string DepartmentName { get; set; }
        public bool? IsBorrow { get; set; }
        public decimal? LoaningAmount { get; set; }
        public DateTime? SettleDate { get; set; }

        //public DateTime date { get; set; }
        //public string? id { get; set; }
        //public string? requester { get; set; }
        //public string? agency { get; set; }
        //public bool? status { get; set; }
        //public double? price { get; set; }
        //public DateTime transferDate { get; set; }
        //public string? print { get; set; }
    }
}
