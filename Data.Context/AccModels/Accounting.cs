using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class Accounting
    {
        public int Id { get; set; }
        public byte[] CreateDate { get; set; } = null!;
        public string? SubjournalNo { get; set; }
        public string? RefDocNo { get; set; }
        public DateTime? RefDocDate { get; set; }
        public string? Description { get; set; }
        public int? Debit { get; set; }
        public int? Credit { get; set; }
        public byte? Status { get; set; }
        public decimal? Quantity { get; set; }
        public int? JournalId { get; set; }
        public int? SubjournalId { get; set; }
        public int? ContactId { get; set; }
        public int? FundTypeId { get; set; }
        public string? DocCreator { get; set; }
        public int? DocApprover { get; set; }

        public virtual FundsType? FundType { get; set; }
        public virtual Journal? Journal { get; set; }
        public virtual SubJournal? Subjournal { get; set; }
    }
}
