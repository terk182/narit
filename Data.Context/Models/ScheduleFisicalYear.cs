using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class ScheduleFisicalYear
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public bool AddPlanCoreStatus { get; set; }
        public bool EditPlanCoreStatus { get; set; }
        public bool ApprovePlanCoreStatus { get; set; }
        public bool DisplayPlanCoreStatus { get; set; }
        public string AddPlanCoreStatusStartDate { get; set; } = null!;
        public string AddPlanCoreStatusEndDate { get; set; } = null!;
        public string EditPlanCoreStatusStartDate { get; set; } = null!;
        public string EditPlanCoreStatusEndDate { get; set; } = null!;
        public string ApprovePlanCoreStatusStartDate { get; set; } = null!;
        public string ApprovePlanCoreStatusEndDate { get; set; } = null!;
        public string DisplayPlanCoreStatusStartDate { get; set; } = null!;
        public string DisplayPlanCoreStatusEndDate { get; set; } = null!;
    }
}
