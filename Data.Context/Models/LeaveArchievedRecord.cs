using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class LeaveArchievedRecord
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int LeaveTypeId { get; set; }
        public int StaffId { get; set; }
        public string RemainLeaveDayValue { get; set; } = null!;
        public string? RemainLeaveDayFy2559value { get; set; }
        public string RemainLeaveDayFy2560value { get; set; } = null!;

        public virtual LeaveType LeaveType { get; set; } = null!;
        public virtual Staff Staff { get; set; } = null!;
    }
}
