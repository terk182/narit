using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class ChartAcc
    {
        public int ChartHeaderId { get; set; }
        public string? ChartHeaderName { get; set; }
        public int? ChartHeaderAccTypeId { get; set; }
        public int ChartHeaderIndex { get; set; }
        public int ChartSubHeaderId { get; set; }
        public string? ChartSubHeaderName { get; set; }
        public int? ChartSubHeaderAccTypeId { get; set; }
        public int ChartSubHeaderIndex { get; set; }
        public int ChartMajorId { get; set; }
        public string? ChartMajorName { get; set; }
        public int? ChartMajorAccTypeId { get; set; }
        public int ChartMajorIndex { get; set; }
        public int ChartSubMajorId { get; set; }
        public string? ChartSubMajorName { get; set; }
        public int? ChartSubMajorAccTypeId { get; set; }
        public int ChartSubMajorIndex { get; set; }
        public int ChartMinorId { get; set; }
        public string? ChartMinorName { get; set; }
        public int? ChartMinorAccTypeId { get; set; }
        public int ChartMinorIndex { get; set; }
        public int ChartSubMinorId { get; set; }
        public string? ChartSubMinorName { get; set; }
        public int? ChartSubMinorAccTypeId { get; set; }
        public int ChartSubMinorIndex { get; set; }
    }
}
