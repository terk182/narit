using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class SubProject
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int ProjectId { get; set; }
        public int? DepartmentId { get; set; }
        public string Detail { get; set; } = null!;
        public string Objective { get; set; } = null!;
        public string TargetIdListValue { get; set; } = null!;
        public string OtherTarget { get; set; } = null!;
        public string MonthStart { get; set; } = null!;
        public string MonthEnd { get; set; } = null!;
        public int MonthSum { get; set; }
        public string Output { get; set; } = null!;
        public string Outcome { get; set; } = null!;
        public string Benefit { get; set; } = null!;
        public int CreateByStaffId { get; set; }
        public DateTime CreateDate { get; set; }
        public int Code { get; set; }
        public bool Active { get; set; }
        public double? Weight { get; set; }
    }
}
