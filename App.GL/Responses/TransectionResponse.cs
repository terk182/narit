using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.GL.Responses
{
    public class TransectionResponse
    {
        public int Id { get; set; }
        public byte[] CreateDate { get; set; } = null!;
        public string? Detail { get; set; }
        public int? Quantity { get; set; }
        public int? PaymentTypeId { get; set; }
        public int? DebtorTypeId { get; set; }
        public int? TransectionTypeId { get; set; }
        public string? TransectionTypeName { get; set; }
        public string RefNo { get; set; } = null!;
        public string? DebtorCode { get; set; }
        public string? DetailName { get; set; }
        public DateTime? DetailDate { get; set; }
        public int? Credit { get; set; }
        public string? CreditName { get; set; }
        public int? Debit { get; set; }
        public string? DebitName { get; set; }
        public string? Status { get; set; }
        public int? JournalId { get; set; }
        public int? SubJournalId { get; set; }
        public string? SubJournalName { get; set; }



    }
}
