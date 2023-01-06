using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class ChartMinor
    {
        public ChartMinor()
        {
            ChartSubMinors = new HashSet<ChartSubMinor>();
        }

        public int Id { get; set; }
        public string? ChartMinorCode { get; set; }
        public int Index { get; set; }
        public string? Name { get; set; }
        public int Active { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ChartSubMajorId { get; set; }
        public string? Detail { get; set; }

        public virtual ChartSubMajor? ChartSubMajor { get; set; }
        public virtual ICollection<ChartSubMinor> ChartSubMinors { get; set; }
    }
}
