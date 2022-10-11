using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class OrderItem
    {
        public OrderItem()
        {
            ApproveOrderItemTransforms = new HashSet<ApproveOrderItemTransform>();
            OrderCheckItemTransforms = new HashSet<OrderCheckItemTransform>();
            OrderItemPlanReferenceItems = new HashSet<OrderItemPlanReferenceItem>();
        }

        public int? SupplierId { get; set; }
        public int? OrderFormId { get; set; }
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

        public virtual OrderForm? OrderForm { get; set; }
        public virtual Supplier? Supplier { get; set; }
        public virtual ICollection<ApproveOrderItemTransform> ApproveOrderItemTransforms { get; set; }
        public virtual ICollection<OrderCheckItemTransform> OrderCheckItemTransforms { get; set; }
        public virtual ICollection<OrderItemPlanReferenceItem> OrderItemPlanReferenceItems { get; set; }
    }
}
