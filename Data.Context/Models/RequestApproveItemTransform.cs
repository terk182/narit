using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class RequestApproveItemTransform
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public bool Active { get; set; }
        public int TransformTypeEnum { get; set; }
        public int RequestItemId { get; set; }
        public int ApproveItemId { get; set; }

        public virtual ApproveItem ApproveItem { get; set; } = null!;
        public virtual RequestItem RequestItem { get; set; } = null!;
    }
}
