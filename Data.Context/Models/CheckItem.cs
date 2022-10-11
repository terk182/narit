using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class CheckItem
    {
        public CheckItem()
        {
            CheckItemPlanReferenceItems = new HashSet<CheckItemPlanReferenceItem>();
            CheckRequisitionItemTransforms = new HashSet<CheckRequisitionItemTransform>();
            OrderCheckItemTransforms = new HashSet<OrderCheckItemTransform>();
            RegisterProcureItems = new HashSet<RegisterProcureItem>();
        }

        public int? SupplierId { get; set; }
        public int? CheckFormId { get; set; }
        public decimal? OrderAmount { get; set; }
        public decimal? DeliveryAmount { get; set; }
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
        public decimal? RemainOrderAmount { get; set; }
        public bool IsByBudgetControl { get; set; }
        public bool IsFinalCheckByBudgetControl { get; set; }

        public virtual CheckForm? CheckForm { get; set; }
        public virtual Supplier? Supplier { get; set; }
        public virtual ICollection<CheckItemPlanReferenceItem> CheckItemPlanReferenceItems { get; set; }
        public virtual ICollection<CheckRequisitionItemTransform> CheckRequisitionItemTransforms { get; set; }
        public virtual ICollection<OrderCheckItemTransform> OrderCheckItemTransforms { get; set; }
        public virtual ICollection<RegisterProcureItem> RegisterProcureItems { get; set; }
    }
}
