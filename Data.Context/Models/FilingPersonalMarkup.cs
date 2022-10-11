using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class FilingPersonalMarkup
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public bool IsImportant { get; set; }
        public int FilingDocumentId { get; set; }
        public int StaffId { get; set; }

        public virtual FilingDocument FilingDocument { get; set; } = null!;
    }
}
