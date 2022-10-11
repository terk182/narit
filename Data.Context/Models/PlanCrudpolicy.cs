using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class PlanCrudpolicy
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public bool CanCreatePlanCore { get; set; }
        public bool CanUpdatePlanCore { get; set; }
        public bool CanDeletePlanCore { get; set; }
        public bool CanCreatePlanActivity { get; set; }
        public bool CanDeletePlanActivity { get; set; }
        public bool CanUpdatePlanActivity { get; set; }
        public bool CanCreatePlanItem { get; set; }
        public bool CanUpdatePlanItem { get; set; }
        public bool CanDeletePlanItem { get; set; }
        public int FiscalYear { get; set; }
        public bool BypassAuthenticateCrudplanCore { get; set; }
        public bool BypassAuthenticateCrudplanActivity { get; set; }
        public bool BypassAuthenticateCrudplanItem { get; set; }
        public int PerformanceIndicatorResultDay { get; set; }
        public int PlanActivityOperationPeriodResultDay { get; set; }
    }
}
