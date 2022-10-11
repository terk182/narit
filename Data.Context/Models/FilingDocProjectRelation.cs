using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class FilingDocProjectRelation
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public int FilingDocumentId { get; set; }
        public int FilingProjectId { get; set; }
        public DateTime TagDate { get; set; }
        public int TagStaffId { get; set; }
        public DateTime? DeleteDate { get; set; }
        public int? DeleteStaffId { get; set; }

        public virtual FilingDocument FilingDocument { get; set; } = null!;
        public virtual FilingProject FilingProject { get; set; } = null!;
    }
}
