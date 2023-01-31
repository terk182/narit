using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class DebtorType
    {
        public int Id { get; set; }
        public string? DebtorTypeCode { get; set; }
        public string? Name { get; set; }
        public int Active { get; set; }
        public byte[] CreateDate { get; set; } = null!;
        public string? Detail { get; set; }
        public int? ChartMinorId { get; set; }
        public int? Credit { get; set; }
        public int? Debit { get; set; }

        public virtual ChartMinor? ChartMinor { get; set; }
    }
}
