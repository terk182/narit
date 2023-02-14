using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class FundsType
    {
        public FundsType()
        {
            Accountings = new HashSet<Accounting>();
            Transections = new HashSet<Transection>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Accounting> Accountings { get; set; }
        public virtual ICollection<Transection> Transections { get; set; }
    }
}
