using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class BudgetType
    {
        public BudgetType()
        {
            RequestFroms = new HashSet<RequestFrom>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public bool? Active { get; set; }
        public byte[]? DateTime { get; set; }

        public virtual ICollection<RequestFrom> RequestFroms { get; set; }
    }
}
