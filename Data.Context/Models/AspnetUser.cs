using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class AspnetUser
    {
        public AspnetUser()
        {
            AspnetPersonalizationPerUsers = new HashSet<AspnetPersonalizationPerUser>();
            EfilingDepartmentPermissions = new HashSet<EfilingDepartmentPermission>();
            ProcureDepartmentPermissions = new HashSet<ProcureDepartmentPermission>();
            StaffSecurities = new HashSet<StaffSecurity>();
            Roles = new HashSet<AspnetRole>();
        }

        public Guid ApplicationId { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string LoweredUserName { get; set; } = null!;
        public string? MobileAlias { get; set; }
        public bool IsAnonymous { get; set; }
        public DateTime LastActivityDate { get; set; }

        public virtual AspnetApplication Application { get; set; } = null!;
        public virtual AspnetMembership? AspnetMembership { get; set; }
        public virtual AspnetProfile? AspnetProfile { get; set; }
        public virtual ICollection<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; }
        public virtual ICollection<EfilingDepartmentPermission> EfilingDepartmentPermissions { get; set; }
        public virtual ICollection<ProcureDepartmentPermission> ProcureDepartmentPermissions { get; set; }
        public virtual ICollection<StaffSecurity> StaffSecurities { get; set; }

        public virtual ICollection<AspnetRole> Roles { get; set; }
    }
}
