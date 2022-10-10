using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class GprocurementRss
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public string Title { get; set; } = null!;
        public string ProjectId { get; set; } = null!;
        public DateTime? PubDate { get; set; }
        public string TemplateType { get; set; } = null!;
        public string AnounceType { get; set; } = null!;
        public string Link { get; set; } = null!;
        public DateTime ReadDate { get; set; }
        public string MethodId { get; set; } = null!;
    }
}
