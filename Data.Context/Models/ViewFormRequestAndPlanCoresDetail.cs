using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class ViewFormRequestAndPlanCoresDetail
    {
        public int Id { get; set; }
        public int? PlanCoreId { get; set; }
        public int FiscalYear { get; set; }
        public bool? Active { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public string Inform { get; set; } = null!;
        public string Enclosure { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int? FormRequestAcceptId { get; set; }
        public int DepartmentId { get; set; }
    }
}
