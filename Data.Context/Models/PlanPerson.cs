using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class PlanPerson
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int PositionTypeEnum { get; set; }
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int? StaffId { get; set; }
        public string PositionName { get; set; } = null!;
        public int? ReferenceOldId { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department? Department { get; set; }
    }
}
