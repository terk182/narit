using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class JobResponsibilityGroup
    {
        public JobResponsibilityGroup()
        {
            JobResponsibilities = new HashSet<JobResponsibility>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public string MainJob { get; set; } = null!;
        public string JobActivity { get; set; } = null!;
        public int? JobPositionId { get; set; }

        public virtual JobPosition? JobPosition { get; set; }
        public virtual ICollection<JobResponsibility> JobResponsibilities { get; set; }
    }
}
