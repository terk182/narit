using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class ResponsiblePerson
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int StaffId { get; set; }
        public int PlanPersonResponsibilityEnum { get; set; }
        public int? PlanCoreId { get; set; }
        public int? PlanActivityId { get; set; }
        public int? HrdepartmentId { get; set; }
        public string HrdepartmentName { get; set; } = null!;

        public virtual PlanActivity? PlanActivity { get; set; }
        public virtual PlanCore? PlanCore { get; set; }
    }
}
