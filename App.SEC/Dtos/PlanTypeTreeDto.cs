using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Dtos
{
    public class PlanTypeTreeDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public bool Active { get; set; }
        public int? ParentPlanTypeId { get; set; }
        public int? ReferenceOldId { get; set; }
        public decimal Weight { get; set; }
        public List<PlanTypeTreeDto>? PlanType { get; set; }
    }
}
