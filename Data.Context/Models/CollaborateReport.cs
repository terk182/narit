using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class CollaborateReport
    {
        public CollaborateReport()
        {
            AccommodationVisitings = new HashSet<AccommodationVisiting>();
            AgreementVisitings = new HashSet<AgreementVisiting>();
            Agreements = new HashSet<Agreement>();
            CoReportRefFilingDocuments = new HashSet<CoReportRefFilingDocument>();
            CoReportRefGeMomoForms = new HashSet<CoReportRefGeMomoForm>();
            CollaborateStaffs = new HashSet<CollaborateStaff>();
            CollaborationNetworkFiles = new HashSet<CollaborationNetworkFile>();
            ContactPersonVisitings = new HashSet<ContactPersonVisiting>();
            Itineraries = new HashSet<Itinerary>();
            OrganizationVisitings = new HashSet<OrganizationVisiting>();
        }

        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Detail { get; set; } = null!;
        public int FiscalYear { get; set; }
        public DateTime? WriteDate { get; set; }
        public string Inform { get; set; } = null!;
        public int ApprovalStatusEnum { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public string? StaffName { get; set; }
        public int? StaffId { get; set; }
        public int? CreatorStaffId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? OrganizationId { get; set; }
        public string Objective { get; set; } = null!;
        public string Other { get; set; } = null!;
        public string Expectation { get; set; } = null!;

        public virtual Organization? Organization { get; set; }
        public virtual ICollection<AccommodationVisiting> AccommodationVisitings { get; set; }
        public virtual ICollection<AgreementVisiting> AgreementVisitings { get; set; }
        public virtual ICollection<Agreement> Agreements { get; set; }
        public virtual ICollection<CoReportRefFilingDocument> CoReportRefFilingDocuments { get; set; }
        public virtual ICollection<CoReportRefGeMomoForm> CoReportRefGeMomoForms { get; set; }
        public virtual ICollection<CollaborateStaff> CollaborateStaffs { get; set; }
        public virtual ICollection<CollaborationNetworkFile> CollaborationNetworkFiles { get; set; }
        public virtual ICollection<ContactPersonVisiting> ContactPersonVisitings { get; set; }
        public virtual ICollection<Itinerary> Itineraries { get; set; }
        public virtual ICollection<OrganizationVisiting> OrganizationVisitings { get; set; }
    }
}
