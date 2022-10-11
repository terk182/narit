using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class AspnetRole
    {
        public AspnetRole()
        {
            RolesGroups = new HashSet<RolesGroup>();
            Users = new HashSet<AspnetUser>();
        }

        public Guid ApplicationId { get; set; }
        public Guid RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public string LoweredRoleName { get; set; } = null!;
        public string? Description { get; set; }

        public virtual AspnetApplication Application { get; set; } = null!;

        public virtual ICollection<RolesGroup> RolesGroups { get; set; }
        public virtual ICollection<AspnetUser> Users { get; set; }
    }
}
