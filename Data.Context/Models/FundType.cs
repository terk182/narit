using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class FundType
    {
        public FundType()
        {
            InverseParentFundType = new HashSet<FundType>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public bool Active { get; set; }
        public int? ReferenceOldId { get; set; }
        public int? ParentFundTypeId { get; set; }

        public virtual FundType? ParentFundType { get; set; }
        public virtual ICollection<FundType> InverseParentFundType { get; set; }
    }
}
