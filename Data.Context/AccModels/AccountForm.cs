using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class AccountForm
    {
        public AccountForm()
        {
            JournalForms = new HashSet<JournalForm>();
        }

        public int Id { get; set; }
        public string? AccountFromCode { get; set; }
        public int Index { get; set; }
        public string? Name { get; set; }
        public int Active { get; set; }
        public byte[] CreateDate { get; set; } = null!;
        public string? Detail { get; set; }
        public int? PrintForm { get; set; }

        public virtual ICollection<JournalForm> JournalForms { get; set; }
    }
}
