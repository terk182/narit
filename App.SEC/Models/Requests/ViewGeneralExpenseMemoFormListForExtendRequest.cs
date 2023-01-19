using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Requests
{
    public class ViewGeneralExpenseMemoFormListForExtendRequest
    {
        public int objId { get; set; }

        public int year { get; set; }
        public decimal budgetVal { get; set; }
   
        public  string? docNumber { get; set; }
        public string? PlanObjectType { get; set; }
        public int PlanApprovalStatus { get; set;}
        public int ApprovalStatusEnum { get; set; }

    }
}
