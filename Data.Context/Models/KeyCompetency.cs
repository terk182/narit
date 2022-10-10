using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class KeyCompetency
    {
        public KeyCompetency()
        {
            JobPositionKeyCompetencyDetails = new HashSet<JobPositionKeyCompetencyDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int CompetencyTypeEnum { get; set; }

        public virtual ICollection<JobPositionKeyCompetencyDetail> JobPositionKeyCompetencyDetails { get; set; }
    }
}
