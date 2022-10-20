using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models
{
    public class PlanPersonDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int PositionTypeEnum { get; set; }
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int? StaffId { get; set; }
        public string PositionName { get; set; } = null!;
        public int? ReferenceOldId { get; set; }
        public int? DepartmentId { get; set; }
    }
}
