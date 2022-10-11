using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class CollaborateStaff
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public int? HrdepartmentId { get; set; }
        public int? JobPositionTypeId { get; set; }
        public int? JobPositionLevelId { get; set; }
        public string JobPositionName { get; set; } = null!;
        public string HrdepartmentName { get; set; } = null!;
        public int StaffId { get; set; }
        public int CollaborateReportId { get; set; }

        public virtual CollaborateReport CollaborateReport { get; set; } = null!;
    }
}
