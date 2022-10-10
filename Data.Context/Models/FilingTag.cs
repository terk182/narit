using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class FilingTag
    {
        public FilingTag()
        {
            FilingDocTagRelations = new HashSet<FilingDocTagRelation>();
            InverseParentFilingTag = new HashSet<FilingTag>();
        }

        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public string Detail { get; set; } = null!;
        public int PermissionLevelEnum { get; set; }
        public string StaffGroupValue { get; set; } = null!;
        public string DepGroupValue { get; set; } = null!;
        public int? ParentFilingTagId { get; set; }

        public virtual FilingTag? ParentFilingTag { get; set; }
        public virtual ICollection<FilingDocTagRelation> FilingDocTagRelations { get; set; }
        public virtual ICollection<FilingTag> InverseParentFilingTag { get; set; }
    }
}
