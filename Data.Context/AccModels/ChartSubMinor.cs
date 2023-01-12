using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class ChartSubMinor
    {
        public ChartSubMinor()
        {
            DebtorTypes = new HashSet<DebtorType>();
        }

        public int Id { get; set; }
        public string? ChartSubMinorCode { get; set; }
        public int Index { get; set; }
        public string? Name { get; set; }
        public int Active { get; set; }
        public byte[] CreateDate { get; set; } = null!;
        public int? ChartMinorId { get; set; }
        public string? Detail { get; set; }
        public int? AccTypeId { get; set; }
        public string? Balance { get; set; }

        public virtual AccountType? AccType { get; set; }
        public virtual ChartMinor? ChartMinor { get; set; }
        public virtual ICollection<DebtorType> DebtorTypes { get; set; }
    }
}
