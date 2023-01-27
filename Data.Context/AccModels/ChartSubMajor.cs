using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class ChartSubMajor
    {
        public ChartSubMajor()
        {
            ChartMinorOlds = new HashSet<ChartMinorOld>();
            ChartMinors = new HashSet<ChartMinor>();
        }

        public int Id { get; set; }
        public string? ChartSubMajorCode { get; set; }
        public int Index { get; set; }
        public string? Name { get; set; }
        public int Active { get; set; }
        public byte[] CreateDate { get; set; } = null!;
        public int? ChartMajorId { get; set; }
        public string? Detail { get; set; }
        public int? AccTypeId { get; set; }

        public virtual AccountType? AccType { get; set; }
        public virtual ChartMajor? ChartMajor { get; set; }
        public virtual ICollection<ChartMinorOld> ChartMinorOlds { get; set; }
        public virtual ICollection<ChartMinor> ChartMinors { get; set; }
    }
}
