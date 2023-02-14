using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class SubAnnualBudget
    {
        public SubAnnualBudget()
        {
            Transections = new HashSet<Transection>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int AnnualBudgetId { get; set; }

        public virtual AnnualBudget AnnualBudget { get; set; } = null!;
        public virtual ICollection<Transection> Transections { get; set; }
    }
}
