using narit_mis_api.AccModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.FIN.Models.Responses
{
    public class ViewPaymentRecordListResponse
    {

        public int no { get; set; }
        public string? description { get; set; }
        public string? docNum { get; set; }
        public DateTime date { get; set; }
        public decimal amout { get; set; }
        public string? paymentVoucherNumber { get; set; }

    }
}
