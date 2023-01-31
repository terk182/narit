using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class SubJournal
    {
        public SubJournal()
        {
            Transections = new HashSet<Transection>();
        }

        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public int Active { get; set; }
        public byte[] CreateDate { get; set; } = null!;
        public string? Detail { get; set; }
        public int? JournalId { get; set; }
        public string? Year { get; set; }
        public string? Month { get; set; }
        public int? Number { get; set; }

        public virtual Journal? Journal { get; set; }
        public virtual ICollection<Transection> Transections { get; set; }
    }
}
