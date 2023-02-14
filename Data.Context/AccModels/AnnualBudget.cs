using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class AnnualBudget
    {
        public AnnualBudget()
        {
            SubAnnualBudgets = new HashSet<SubAnnualBudget>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<SubAnnualBudget> SubAnnualBudgets { get; set; }
    }
}
