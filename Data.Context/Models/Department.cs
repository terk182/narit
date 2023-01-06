using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class Department
    {
        public Department()
        {
            InverseParentDepartment = new HashSet<Department>();
            PlanActivities = new HashSet<PlanActivity>();
            PlanCores = new HashSet<PlanCore>();
            PlanPeople = new HashSet<PlanPerson>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public bool Active { get; set; }
        public int? ParentDepartmentId { get; set; }
        public int? ReferenceOldId { get; set; }
        public int? BudgetLimit { get; set; }

        public virtual Department? ParentDepartment { get; set; }
        public virtual ICollection<Department> InverseParentDepartment { get; set; }
        public virtual ICollection<PlanActivity> PlanActivities { get; set; }
        public virtual ICollection<PlanCore> PlanCores { get; set; }
        public virtual ICollection<PlanPerson> PlanPeople { get; set; }
    }
}
