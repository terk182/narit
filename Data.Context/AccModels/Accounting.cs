using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class Accounting
    {
        public int Id { get; set; }
        public byte[] CreateDate { get; set; } = null!;
        public int? DescId { get; set; }
        public int? PaymentId { get; set; }
        public string? RefNo { get; set; }
        public string? VoucherNo { get; set; }
        public int? BillId { get; set; }
        public DateTime? BillDate { get; set; }
        public byte? Status { get; set; }
        public string? Quantity { get; set; }
        public string? AccountBook { get; set; }
        public int? Debit { get; set; }
        public int? Credit { get; set; }
    }
}
