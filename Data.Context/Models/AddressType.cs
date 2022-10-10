using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class AddressType
    {
        public AddressType()
        {
            Addresses = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
