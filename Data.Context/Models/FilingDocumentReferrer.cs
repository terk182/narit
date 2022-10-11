using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class FilingDocumentReferrer
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public int? ReferFilingDocumentId { get; set; }
        public int FilingDocumentId { get; set; }
        public string RegisterNumber { get; set; } = null!;

        public virtual FilingDocument FilingDocument { get; set; } = null!;
        public virtual FilingDocument? ReferFilingDocument { get; set; }
    }
}
