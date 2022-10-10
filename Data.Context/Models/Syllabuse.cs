using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class Syllabuse
    {
        public Syllabuse()
        {
            DevelopmentRecordGroups = new HashSet<DevelopmentRecordGroup>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public string InstituteName { get; set; } = null!;
        public string Instructor { get; set; } = null!;
        public string DevelopmentType { get; set; } = null!;
        public string Place { get; set; } = null!;
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string DiplomaName { get; set; } = null!;
        public string Detail { get; set; } = null!;
        public string Remark { get; set; } = null!;
        public int FiscalYear { get; set; }
        public int WorkAttendanceTimeRangeEnum { get; set; }
        public bool IsInHouseTraining { get; set; }
        public string Topic { get; set; } = null!;
        public bool NeedTimeStamp { get; set; }

        public virtual ICollection<DevelopmentRecordGroup> DevelopmentRecordGroups { get; set; }
    }
}
