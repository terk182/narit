using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class WorkHistory
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime? StartWorkingDate { get; set; }
        public string PositionName { get; set; } = null!;
        public string Organization { get; set; } = null!;
        public string WorkPlace { get; set; } = null!;
        public DateTime? ToWorkingDate { get; set; }
        public string Remark { get; set; } = null!;
        public string DepartmentName { get; set; } = null!;
        public int StaffId { get; set; }
        public int? JobPositionLevelId { get; set; }
        public int? JobPositionGroupId { get; set; }
        public int? JobPositionId { get; set; }
        public int JobChangingTypeEnum { get; set; }
        public string JobPositionGroup { get; set; } = null!;
        public string JobPositionLevel { get; set; } = null!;
        public bool IsCurrentOrg { get; set; }

        public virtual Staff Staff { get; set; } = null!;
    }
}
