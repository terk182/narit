using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.FIN.Models.Requests
{
    public class ViewPaymentRecordListRequest
    {
        public int fYear { get; set; }
        public int planTypeId { get; set; }
        public string? docNumber { get; set; }
        public string? PlanStatementTypeRBL { get; set; }
        public string? PaymentStatusRBL { get; set; }
        public int StatementPayStatus { get; set; }
    }
}
