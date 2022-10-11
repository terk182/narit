using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class PlanActivity
    {
        public PlanActivity()
        {
            PerformanceIndicators = new HashSet<PerformanceIndicator>();
            PlanActivityActionLogs = new HashSet<PlanActivityActionLog>();
            PlanItems = new HashSet<PlanItem>();
            PlanMonthlyOperations = new HashSet<PlanMonthlyOperation>();
            ResponsiblePeople = new HashSet<ResponsiblePerson>();
        }

        public int Id { get; set; }
        public int PlanCoreId { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public string Code { get; set; } = null!;
        public int? ReferenceOldId { get; set; }
        public string Detail { get; set; } = null!;
        public bool IsFinished { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public string OperationPeriod { get; set; } = null!;
        public bool? IsFollowUp { get; set; }
        public int DepartmentId { get; set; }
        public decimal Weight { get; set; }

        public virtual Department Department { get; set; } = null!;
        public virtual PlanCore PlanCore { get; set; } = null!;
        public virtual ICollection<PerformanceIndicator> PerformanceIndicators { get; set; }
        public virtual ICollection<PlanActivityActionLog> PlanActivityActionLogs { get; set; }
        public virtual ICollection<PlanItem> PlanItems { get; set; }
        public virtual ICollection<PlanMonthlyOperation> PlanMonthlyOperations { get; set; }
        public virtual ICollection<ResponsiblePerson> ResponsiblePeople { get; set; }
    }
}
