using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class JobPositionKeyCompetencyDetail
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int JobPositionId { get; set; }
        public int KeyCompetencyId { get; set; }
        public int? JobPositionLevelId { get; set; }

        public virtual JobPosition JobPosition { get; set; } = null!;
        public virtual JobPositionLevel? JobPositionLevel { get; set; }
        public virtual KeyCompetency KeyCompetency { get; set; } = null!;
    }
}
