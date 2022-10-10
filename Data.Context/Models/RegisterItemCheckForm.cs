using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class RegisterItemCheckForm
    {
        public RegisterItemCheckForm()
        {
            RegisterItemCheckRecords = new HashSet<RegisterItemCheckRecord>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public DateTime? WriteDate { get; set; }
        public int FiscalYear { get; set; }
        public string Purpose { get; set; } = null!;
        public string CheckChairman { get; set; } = null!;

        public virtual ICollection<RegisterItemCheckRecord> RegisterItemCheckRecords { get; set; }
    }
}
