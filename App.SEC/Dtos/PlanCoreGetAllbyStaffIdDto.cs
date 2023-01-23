using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Dtos
{
    public class PlanCoreGetAllbyStaffIdDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        //public int DepartmentId { get; set; }
        public int PlanTypeId { get; set; }
        public string PlanTypeName { get; set; } = null!;
    }
}
