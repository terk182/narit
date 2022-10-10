using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class FundType
    {
        public FundType()
        {
            InverseParentFundType = new HashSet<FundType>();
            PlanCores = new HashSet<PlanCore>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public bool Active { get; set; }
        public int? ReferenceOldId { get; set; }
        public int? ParentFundTypeId { get; set; }

        public virtual FundType? ParentFundType { get; set; }
        public virtual ICollection<FundType> InverseParentFundType { get; set; }
        public virtual ICollection<PlanCore> PlanCores { get; set; }
    }
}
