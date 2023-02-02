using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class Department1
    {
        public Department1()
        {
            InverseParentDepartment = new HashSet<Department1>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public bool Active { get; set; }
        public int? ParentDepartmentId { get; set; }
        public int? ReferenceOldId { get; set; }
        public int? BudgetLimit { get; set; }

        public virtual Department1? ParentDepartment { get; set; }
        public virtual ICollection<Department1> InverseParentDepartment { get; set; }
    }
}
