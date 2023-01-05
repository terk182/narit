using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class ChartSubMinor
    {
        public int Id { get; set; }
        public string? ChartSubMinorCode { get; set; }
        public int Index { get; set; }
        public string? Name { get; set; }
        public int Active { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ChartMinorId { get; set; }
        public string? Detail { get; set; }

        public virtual ChartMinor? ChartMinor { get; set; }
    }
}
