using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.FIN.Models.Responses
{
    public class ViewProcureSettleMemoFormListForApprovalResponses
    {
        public DateTime? WriteDate { get; set; }
        public string? DocumentNumber { get; set; }
        public string? StatementName { get; set; }
        public string DepartmentName { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public int FundTypeId { get; set; }
        //public DateTime date { get; set; }
        //public string? id { get; set; }
        //public string? project { get; set; }
        //public string? agency { get; set; }
        //public bool? status { get; set; }
        //public double? payBack { get; set; }
        //public string? print { get; set; } 

    }
}
