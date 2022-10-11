using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class PlanCoreStaffPermission
    {
        public int Id { get; set; }
        public string StaffFullName { get; set; } = null!;
        public bool Active { get; set; }
        public int StaffId { get; set; }
        public int PlanCoreId { get; set; }
        public string PlanCoreName { get; set; } = null!;
        public int FiscalYear { get; set; }
    }
}
