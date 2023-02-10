using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class RequestFormDetail
    {
        public int Id { get; set; }
        public string DocNo { get; set; } = null!;
        public int? DocYear { get; set; }
        public int? RequestFormId { get; set; }
        public bool? Active { get; set; }
        public string? Name { get; set; }
        public string? Descriptions { get; set; }
        public string? AnotherAction { get; set; }
        public string? Procurement { get; set; }
        public string? CreateBy { get; set; }
        public string? InspectorsId { get; set; }
        public string? InspectorsName { get; set; }
    }
}
