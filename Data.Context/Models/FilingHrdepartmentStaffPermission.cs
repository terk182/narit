using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class FilingHrdepartmentStaffPermission
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public int StaffId { get; set; }
        public string StaffFullName { get; set; } = null!;
        public int HrdepartmentId { get; set; }
        public string HrdepartmentName { get; set; } = null!;
        public bool IsReceiver { get; set; }
    }
}
