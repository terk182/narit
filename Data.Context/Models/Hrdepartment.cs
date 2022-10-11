using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class Hrdepartment
    {
        public Hrdepartment()
        {
            InverseParentHrdepartment = new HashSet<Hrdepartment>();
            JobPositions = new HashSet<JobPosition>();
            staff = new HashSet<Staff>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? ReferenceOldId { get; set; }
        public int? ParentHrdepartmentId { get; set; }
        public int? DefaultStoreLocationId { get; set; }

        public virtual Hrdepartment? ParentHrdepartment { get; set; }
        public virtual ICollection<Hrdepartment> InverseParentHrdepartment { get; set; }
        public virtual ICollection<JobPosition> JobPositions { get; set; }
        public virtual ICollection<Staff> staff { get; set; }
    }
}
