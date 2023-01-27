using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class TransectionType
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public byte[] CreateDate { get; set; } = null!;
        public string? TransectionGroup { get; set; }
        public int? ChartMinorId { get; set; }
        public string? Detail { get; set; }

        public virtual ChartMinor? ChartMinor { get; set; }
    }
}
