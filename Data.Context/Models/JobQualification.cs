using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class JobQualification
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public bool IsMale { get; set; }
        public bool IsFemale { get; set; }
        public string EducationFieldName { get; set; } = null!;
        public string Certification { get; set; } = null!;
        public string Experience { get; set; } = null!;
        public string JobScope { get; set; } = null!;
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public int JobPositionId { get; set; }
        public int JobPositionLevelId { get; set; }
        public int? EducationLevelId { get; set; }

        public virtual EducationLevel? EducationLevel { get; set; }
        public virtual JobPosition JobPosition { get; set; } = null!;
        public virtual JobPositionLevel JobPositionLevel { get; set; } = null!;
    }
}
