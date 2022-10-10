using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class AccommodationVisiting
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string? Remark { get; set; }
        public string Name { get; set; } = null!;
        public int? AccommodationId { get; set; }
        public int? CollaborateReportId { get; set; }
        public int Night { get; set; }
        public decimal TotalPrice { get; set; }

        public virtual Accommodation? Accommodation { get; set; }
        public virtual CollaborateReport? CollaborateReport { get; set; }
    }
}
