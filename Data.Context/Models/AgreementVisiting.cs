using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class AgreementVisiting
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public string? Remark { get; set; }
        public int? AgreementId { get; set; }
        public int? CollaborateReportId { get; set; }

        public virtual Agreement? Agreement { get; set; }
        public virtual CollaborateReport? CollaborateReport { get; set; }
    }
}
