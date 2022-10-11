using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class OrganizationVisiting
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Remark { get; set; }
        public bool Active { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int FiscalYear { get; set; }
        public int? OrganizationId { get; set; }
        public int? CollaborateReportId { get; set; }

        public virtual CollaborateReport? CollaborateReport { get; set; }
        public virtual Organization? Organization { get; set; }
    }
}
