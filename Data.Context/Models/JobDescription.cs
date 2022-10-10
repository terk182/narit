using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class JobDescription
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public string Summary { get; set; } = null!;
        public string JobScope { get; set; } = null!;
        public int? JobPositionId { get; set; }
        public int? JobPositionLevelId { get; set; }
        public int? StaffId { get; set; }

        public virtual JobPosition? JobPosition { get; set; }
        public virtual JobPositionLevel? JobPositionLevel { get; set; }
        public virtual Staff? Staff { get; set; }
    }
}
