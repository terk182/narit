using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class Accommodation
    {
        public Accommodation()
        {
            AccommodationVisitings = new HashSet<AccommodationVisiting>();
        }

        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Distance { get; set; } = null!;
        public string Price { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Remark { get; set; } = null!;
        public DateTime LatestUpdate { get; set; }
        public int? OrganizationId { get; set; }

        public virtual Organization? Organization { get; set; }
        public virtual ICollection<AccommodationVisiting> AccommodationVisitings { get; set; }
    }
}
