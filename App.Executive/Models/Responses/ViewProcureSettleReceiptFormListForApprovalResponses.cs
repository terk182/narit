using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.FIN.Models.Responses
{
    public class ViewProcureSettleReceiptFormListForApprovalResponses
    {
        public int Id { get; set; }
        public DateTime? WriteDate { get; set; }
        public string? DocumentNumber { get; set; }
        public string? Name { get; set; }
        public string? StatementName { get; set; }
        public decimal? NetPayValue { get; set; }


    }
}
