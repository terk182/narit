using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class RegisterItemDisposedForm
    {
        public RegisterItemDisposedForm()
        {
            RegisterDurableItems = new HashSet<RegisterDurableItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public DateTime? WriteDate { get; set; }
        public string Purpose { get; set; } = null!;

        public virtual ICollection<RegisterDurableItem> RegisterDurableItems { get; set; }
    }
}
