using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class ChartDetail
    {
        public int ChartHeaderId { get; set; }
        public string? ChartHeaderName { get; set; }
        public int ChartMajorId { get; set; }
        public string? ChartMajorName { get; set; }
        public int ChartMinorId { get; set; }
        public string? ChartMinorName { get; set; }
        public int ChartSubId { get; set; }
        public string? ChartSubName { get; set; }
    }
}
