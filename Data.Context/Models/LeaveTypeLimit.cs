using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class LeaveTypeLimit
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FromYearOfWork { get; set; }
        public int ToYearOfWork { get; set; }
        public int MaxDayLimit { get; set; }
        public bool CanAccumulate { get; set; }
        public int? GrowthAccumulateDayPerYear { get; set; }
        public int LeaveTypeId { get; set; }
        public bool IsStepGrowth { get; set; }
        public bool IsCountOnHoliday { get; set; }

        public virtual LeaveType LeaveType { get; set; } = null!;
    }
}
