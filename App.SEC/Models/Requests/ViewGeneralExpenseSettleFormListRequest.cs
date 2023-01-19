using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Requests
{
    public class ViewGeneralExpenseSettleFormListRequest
    {
        public string?  PlanObjectType { get; set; }
        public int objId { get; set; }

        public int type { get; set; }

        public int FiscalYear { get; set; }

        public decimal budgetVal { get; set; }

        public string? documentNumber { get; set; }

        public string? stateName { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public string? refDocNum { get; set; }
        public string? borrower { get; set;}
 
    }
}
