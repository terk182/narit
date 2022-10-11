using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class VwAspnetUsersInRole
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
    }
}
