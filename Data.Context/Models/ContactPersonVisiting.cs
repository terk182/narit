using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class ContactPersonVisiting
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string? Remark { get; set; }
        public string Name { get; set; } = null!;
        public int? ContactPersonId { get; set; }
        public int? CollaborateReportId { get; set; }

        public virtual CollaborateReport? CollaborateReport { get; set; }
        public virtual ContactPerson? ContactPerson { get; set; }
    }
}
