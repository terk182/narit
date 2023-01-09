using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class JournalForm
    {
        public int Id { get; set; }
        public string? JournalFormCode { get; set; }
        public int Index { get; set; }
        public string? NameTh { get; set; }
        public string? NameEng { get; set; }
        public int Active { get; set; }
        public byte[] CreateDate { get; set; } = null!;
        public string? Detail { get; set; }
        public int? AccountFormId { get; set; }

        public virtual AccountForm? AccountForm { get; set; }
    }
}
