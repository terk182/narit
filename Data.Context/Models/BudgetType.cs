using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class BudgetType
    {
        public BudgetType()
        {
            RequestForms = new HashSet<RequestForm>();
        }

        public int Id { get; set; }
        public int CodeBudgetTypeId { get; set; }
        public string? Name { get; set; }
        public bool? Active { get; set; }
        public DateTime? DateTime { get; set; }

        public virtual ICollection<RequestForm> RequestForms { get; set; }
    }
}
