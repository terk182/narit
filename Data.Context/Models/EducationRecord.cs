using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class EducationRecord
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int? YearStart { get; set; }
        public int? YearEnd { get; set; }
        public string AcademyName { get; set; } = null!;
        public string MajorSubjectName { get; set; } = null!;
        public string MinorSubjectName { get; set; } = null!;
        public int StaffId { get; set; }
        public int? EducationLevelId { get; set; }
        public bool IsTopLevel { get; set; }

        public virtual EducationLevel? EducationLevel { get; set; }
        public virtual Staff Staff { get; set; } = null!;
    }
}
