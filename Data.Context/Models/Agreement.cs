using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class Agreement
    {
        public Agreement()
        {
            AgreementVisitings = new HashSet<AgreementVisiting>();
        }

        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public string DocumentNumber { get; set; } = null!;
        public int Year { get; set; }
        public DateTime? OpenIssueDate { get; set; }
        public DateTime? CloseIssueDate { get; set; }
        public string Detail { get; set; } = null!;
        public int Issue { get; set; }
        public string SignatoryName { get; set; } = null!;
        public DateTime? SigningDate { get; set; }
        public string Remark { get; set; } = null!;
        public int? OrganizationId { get; set; }
        public int? CollaborateReportId { get; set; }
        public int? FilingDocumentId { get; set; }
        public string FirstRegisterNumber { get; set; } = null!;
        public DateTime? RegisterDate { get; set; }

        public virtual CollaborateReport? CollaborateReport { get; set; }
        public virtual Organization? Organization { get; set; }
        public virtual ICollection<AgreementVisiting> AgreementVisitings { get; set; }
    }
}
