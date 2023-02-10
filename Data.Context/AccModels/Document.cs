using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class Document
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int DocumentTypeId { get; set; }
        public string Characters { get; set; } = null!;
        public string SpecialCharacters { get; set; } = null!;
        public int Year { get; set; }
        public int Month { get; set; }
        public int? Number { get; set; }
        public int? JournalId { get; set; }
        public int? SubJournalId { get; set; }
        public int Copies { get; set; }
        public int Active { get; set; }

        public virtual DocumentType DocumentType { get; set; } = null!;
        public virtual Journal? Journal { get; set; }
        public virtual SubJournal? SubJournal { get; set; }
    }
}
