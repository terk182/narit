using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class ChartMajor
    {
        public ChartMajor()
        {
            ChartSubMajors = new HashSet<ChartSubMajor>();
        }

        public int Id { get; set; }
        public string? ChartMajorCode { get; set; }
        public int Index { get; set; }
        public string? Name { get; set; }
        public int Active { get; set; }
        public byte[] CreateDate { get; set; } = null!;
        public int? ChartSubHeaderId { get; set; }
        public string? Detail { get; set; }
        public int? AccTypeId { get; set; }

        public virtual AccountType? AccType { get; set; }
        public virtual ChartSubHeader? ChartSubHeader { get; set; }
        public virtual ICollection<ChartSubMajor> ChartSubMajors { get; set; }
    }
}
