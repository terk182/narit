using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class AddressStyle
    {
        public AddressStyle()
        {
            Addresses = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
