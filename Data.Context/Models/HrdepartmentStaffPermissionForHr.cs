using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class HrdepartmentStaffPermissionForHr
    {
        public int Id { get; set; }
        public string StaffFullName { get; set; } = null!;
        public bool Active { get; set; }
        public int StaffId { get; set; }
        public int HrdepartmentId { get; set; }
        public string HrdepartmentName { get; set; } = null!;
    }
}
