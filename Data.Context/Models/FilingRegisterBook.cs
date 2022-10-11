using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class FilingRegisterBook
    {
        public FilingRegisterBook()
        {
            FilingHrdepartmentPermissions = new HashSet<FilingHrdepartmentPermission>();
            FilingRegisterNumbers = new HashSet<FilingRegisterNumber>();
            InverseParentFilingRegisterBook = new HashSet<FilingRegisterBook>();
        }

        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public string Detail { get; set; } = null!;
        public int? ReferenceOldId { get; set; }
        public int? ParentFilingRegisterBookId { get; set; }
        public string Prefix { get; set; } = null!;
        public double InitialNumberIndex { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsRestrict { get; set; }
        public int FilingTypeEnum { get; set; }

        public virtual FilingRegisterBook? ParentFilingRegisterBook { get; set; }
        public virtual ICollection<FilingHrdepartmentPermission> FilingHrdepartmentPermissions { get; set; }
        public virtual ICollection<FilingRegisterNumber> FilingRegisterNumbers { get; set; }
        public virtual ICollection<FilingRegisterBook> InverseParentFilingRegisterBook { get; set; }
    }
}
