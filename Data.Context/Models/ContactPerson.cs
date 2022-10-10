using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class ContactPerson
    {
        public ContactPerson()
        {
            ContactPersonHistories = new HashSet<ContactPersonHistory>();
            ContactPersonVisitings = new HashSet<ContactPersonVisiting>();
        }

        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public string TitleName { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Nickname { get; set; } = null!;
        public int GenderEnum { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string? Email { get; set; }
        public string Department { get; set; } = null!;
        public string Position { get; set; } = null!;
        public string? Remark { get; set; }
        public DateTime LatestUpdate { get; set; }
        public int? OrganizationId { get; set; }

        public virtual Organization? Organization { get; set; }
        public virtual ICollection<ContactPersonHistory> ContactPersonHistories { get; set; }
        public virtual ICollection<ContactPersonVisiting> ContactPersonVisitings { get; set; }
    }
}
