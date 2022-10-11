using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class RolesGroup
    {
        public RolesGroup()
        {
            AspnetRolesRoles = new HashSet<AspnetRole>();
            StaffSecurities = new HashSet<StaffSecurity>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }

        public virtual ICollection<AspnetRole> AspnetRolesRoles { get; set; }
        public virtual ICollection<StaffSecurity> StaffSecurities { get; set; }
    }
}
