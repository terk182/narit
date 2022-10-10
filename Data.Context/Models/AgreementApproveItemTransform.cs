using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class AgreementApproveItemTransform
    {
        public int Id { get; set; }
        public decimal? Amount { get; set; }
        public bool Active { get; set; }
        public int TransformTypeEnum { get; set; }
        public int AgreementItemId { get; set; }
        public int ApproveItemId { get; set; }

        public virtual AgreementItem AgreementItem { get; set; } = null!;
        public virtual ApproveItem ApproveItem { get; set; } = null!;
    }
}
