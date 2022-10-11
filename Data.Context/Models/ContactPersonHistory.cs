using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class ContactPersonHistory
    {
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
        public DateTime LatestUpdate { get; set; }
        public string? Remark { get; set; }
        public int ContactPersonId { get; set; }

        public virtual ContactPerson ContactPerson { get; set; } = null!;
    }
}
