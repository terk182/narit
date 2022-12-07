using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class StaffSecurity
    {
        public StaffSecurity()
        {
            RolesGroups = new HashSet<RolesGroup>();
        }

        public int Id { get; set; }
        public bool Active { get; set; }
        public int StaffId { get; set; }
        public Guid? AspnetUsersUserId { get; set; }
        public string? Name { get; set; }
        public bool IsFinancialDepPowerUser { get; set; }
        public bool IsPlanDepPowerUser { get; set; }
        public bool IsProcureDepPowerUser { get; set; }
        public bool IsHrdepPowerUser { get; set; }
        public bool IsFilingDepPowerUser { get; set; }
        public bool IsPdpa { get; set; }

        public virtual AspnetUser? AspnetUsersUser { get; set; }

        public virtual ICollection<RolesGroup> RolesGroups { get; set; }
    }
}
