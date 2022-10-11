using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class CheckRequisitionItemTransform
    {
        public int Id { get; set; }
        public decimal? Amount { get; set; }
        public bool Active { get; set; }
        public int TransformTypeEnum { get; set; }
        public int CheckItemId { get; set; }
        public int RequisitionItemId { get; set; }

        public virtual CheckItem CheckItem { get; set; } = null!;
        public virtual RequisitionItem RequisitionItem { get; set; } = null!;
    }
}
