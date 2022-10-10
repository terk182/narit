using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class RequisitionItem
    {
        public RequisitionItem()
        {
            CheckRequisitionItemTransforms = new HashSet<CheckRequisitionItemTransform>();
            RequisitionItemPlanReferenceItems = new HashSet<RequisitionItemPlanReferenceItem>();
        }

        public int? RequisitionFormId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal? Amount { get; set; }
        public decimal? PricePerPiece { get; set; }
        public string Unit { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int VatMethodEnum { get; set; }
        public decimal? Discount { get; set; }
        public DateTime? Date { get; set; }
        public int ProcureTypeEnum { get; set; }

        public virtual RequisitionForm? RequisitionForm { get; set; }
        public virtual ICollection<CheckRequisitionItemTransform> CheckRequisitionItemTransforms { get; set; }
        public virtual ICollection<RequisitionItemPlanReferenceItem> RequisitionItemPlanReferenceItems { get; set; }
    }
}
