using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class Transection
    {
        public int Id { get; set; }
        public byte[] CreateDate { get; set; } = null!;
        public string? Detail { get; set; }
        public int? Quantity { get; set; }
        public int? PaymentTypeId { get; set; }
        public int? DebtorTypeId { get; set; }
        public int? TransectionTypeId { get; set; }
        public string RefNo { get; set; } = null!;
        public string? DebtorCode { get; set; }
        public string? DetailName { get; set; }
        public DateTime? DetailDate { get; set; }
        public int? Credit { get; set; }
        public int? Debit { get; set; }
        public string? Status { get; set; }

        public virtual ChartMinor? CreditNavigation { get; set; }
        public virtual ChartMinor? DebitNavigation { get; set; }
    }
}
