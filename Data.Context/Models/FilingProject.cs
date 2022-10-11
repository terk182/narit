using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class FilingProject
    {
        public FilingProject()
        {
            FilingDocProjectRelations = new HashSet<FilingDocProjectRelation>();
            InverseParentFilingProject = new HashSet<FilingProject>();
        }

        public int Id { get; set; }
        public bool Active { get; set; }
        public string Detail { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int PermissionLevelEnum { get; set; }
        public string StaffGroupValue { get; set; } = null!;
        public string DepGroupValue { get; set; } = null!;
        public int? ParentFilingProjectId { get; set; }

        public virtual FilingProject? ParentFilingProject { get; set; }
        public virtual ICollection<FilingDocProjectRelation> FilingDocProjectRelations { get; set; }
        public virtual ICollection<FilingProject> InverseParentFilingProject { get; set; }
    }
}
