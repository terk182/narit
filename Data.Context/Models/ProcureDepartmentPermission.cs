using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class ProcureDepartmentPermission
    {
        public int Id { get; set; }
        public Guid AspnetUsersUserId { get; set; }

        public virtual AspnetUser AspnetUsersUser { get; set; } = null!;
    }
}
