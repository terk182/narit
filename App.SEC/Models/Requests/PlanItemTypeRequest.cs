using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Requests
{
    public class PlanItemTypeRequest
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int FiscalYear { get; set; }
        public int? ParentPlanItemTypeId { get; set; }
        public int? ReferenceOldId { get; set; }
    }
}
