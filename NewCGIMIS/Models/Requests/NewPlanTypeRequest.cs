using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.NewCGIMIS.Models.Requests
{
    public class NewPlanTypeRequest
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public bool Active { get; set; }
        public int? ParentPlanTypeId { get; set; }
    }
}
