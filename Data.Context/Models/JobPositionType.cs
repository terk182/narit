using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class JobPositionType
    {
        public JobPositionType()
        {
            JobPositions = new HashSet<JobPosition>();
            staff = new HashSet<Staff>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int JobPositionWageTypeEnum { get; set; }

        public virtual ICollection<JobPosition> JobPositions { get; set; }
        public virtual ICollection<Staff> staff { get; set; }
    }
}
