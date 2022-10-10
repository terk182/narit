using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class ApproveOrderItemTransform
    {
        public int Id { get; set; }
        public decimal? Amount { get; set; }
        public bool Active { get; set; }
        public int TransformTypeEnum { get; set; }
        public int ApproveItemId { get; set; }
        public int OrderItemId { get; set; }

        public virtual ApproveItem ApproveItem { get; set; } = null!;
        public virtual OrderItem OrderItem { get; set; } = null!;
    }
}
