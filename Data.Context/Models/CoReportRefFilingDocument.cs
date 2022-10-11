using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class CoReportRefFilingDocument
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public int FilingDocumentId { get; set; }
        public string FirstRegisterNumber { get; set; } = null!;
        public DateTime? RegisterDate { get; set; }
        public int CollaborateReportId { get; set; }

        public virtual CollaborateReport CollaborateReport { get; set; } = null!;
    }
}
