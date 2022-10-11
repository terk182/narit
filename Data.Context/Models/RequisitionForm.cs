using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class RequisitionForm
    {
        public RequisitionForm()
        {
            RequisitionItemPlanReferenceItems = new HashSet<RequisitionItemPlanReferenceItem>();
            RequisitionItems = new HashSet<RequisitionItem>();
        }

        public int Id { get; set; }
        public DateTime? WriteDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public int ProcureTypeEnum { get; set; }
        public string Purpose { get; set; } = null!;
        public string DepartmentName { get; set; } = null!;
        public int ProcureTransformStatusEnum { get; set; }
        public int ProcureMethodEnum { get; set; }

        public virtual ICollection<RequisitionItemPlanReferenceItem> RequisitionItemPlanReferenceItems { get; set; }
        public virtual ICollection<RequisitionItem> RequisitionItems { get; set; }
    }
}
