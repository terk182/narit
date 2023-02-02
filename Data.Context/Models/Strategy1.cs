using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class Strategy1
    {
        public Strategy1()
        {
            InverseParentStrategy = new HashSet<Strategy1>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? ParentStrategyId { get; set; }
        public int? ReferenceOldId { get; set; }

        public virtual Strategy1? ParentStrategy { get; set; }
        public virtual ICollection<Strategy1> InverseParentStrategy { get; set; }
    }
}
