using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class PlanDepartmentStaffPermission
    {
        public int Id { get; set; }
        public string StaffFullName { get; set; } = null!;
        public bool Active { get; set; }
        public int StaffId { get; set; }
        public int PlanDepartmentId { get; set; }
        public string PlanDepartmentName { get; set; } = null!;
    }
}
