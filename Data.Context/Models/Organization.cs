using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class Organization
    {
        public Organization()
        {
            Accommodations = new HashSet<Accommodation>();
            Agreements = new HashSet<Agreement>();
            CollaborateReports = new HashSet<CollaborateReport>();
            CollaborationNetworkFiles = new HashSet<CollaborationNetworkFile>();
            ContactPeople = new HashSet<ContactPerson>();
            OrganizationVisitings = new HashSet<OrganizationVisiting>();
        }

        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public string Detail { get; set; } = null!;
        public string Mission { get; set; } = null!;
        public string Vision { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Province { get; set; } = null!;
        public string PostCode { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string WorkingHour { get; set; } = null!;
        public string Website { get; set; } = null!;
        public string Map { get; set; } = null!;
        public int CountryId { get; set; }

        public virtual Country Country { get; set; } = null!;
        public virtual ICollection<Accommodation> Accommodations { get; set; }
        public virtual ICollection<Agreement> Agreements { get; set; }
        public virtual ICollection<CollaborateReport> CollaborateReports { get; set; }
        public virtual ICollection<CollaborationNetworkFile> CollaborationNetworkFiles { get; set; }
        public virtual ICollection<ContactPerson> ContactPeople { get; set; }
        public virtual ICollection<OrganizationVisiting> OrganizationVisitings { get; set; }
    }
}
