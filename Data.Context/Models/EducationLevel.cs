using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class EducationLevel
    {
        public EducationLevel()
        {
            EducationRecords = new HashSet<EducationRecord>();
            JobPositions = new HashSet<JobPosition>();
            JobQualifications = new HashSet<JobQualification>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }

        public virtual ICollection<EducationRecord> EducationRecords { get; set; }
        public virtual ICollection<JobPosition> JobPositions { get; set; }
        public virtual ICollection<JobQualification> JobQualifications { get; set; }
    }
}
