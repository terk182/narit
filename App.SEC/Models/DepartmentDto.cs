using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models
{
    public class DepartmentDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public bool Active { get; set; }
        public int? ParentDepartmentId { get; set; }
        public int? ReferenceOldId { get; set; }
        
        public List<DepartmentDto>? Department { get; set; }
        public  List<DepartmentDto>? InverseParentDepartment { get; set; }
        public  List<PlanActivityDto>? PlanActivities { get; set; }
        public  List<PlanCoreDto>? PlanCores { get; set; }
        public  List<PlanPersonDto>? PlanPeople { get; set; }

    }


}
