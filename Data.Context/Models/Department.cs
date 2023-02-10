using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class Department
    {
        public Department()
        {
            RequestBudgets = new HashSet<RequestBudget>();
        }

        public int Id { get; set; }
        public string? Year { get; set; }
        public string? Name { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<RequestBudget> RequestBudgets { get; set; }
    }
}
