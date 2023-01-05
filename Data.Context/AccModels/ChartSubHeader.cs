using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class ChartSubHeader
    {
        public ChartSubHeader()
        {
            ChartMajors = new HashSet<ChartMajor>();
        }

        public int Id { get; set; }
        public string? ChartSubHeaderCode { get; set; }
        public int Index { get; set; }
        public string? Name { get; set; }
        public int Active { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ChartHeaderId { get; set; }
        public string? Detail { get; set; }

        public virtual ChartHeader? ChartHeader { get; set; }
        public virtual ICollection<ChartMajor> ChartMajors { get; set; }
    }
}
