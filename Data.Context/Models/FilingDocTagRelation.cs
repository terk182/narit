using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class FilingDocTagRelation
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public int FilingDocumentId { get; set; }
        public int FilingTagId { get; set; }

        public virtual FilingDocument FilingDocument { get; set; } = null!;
        public virtual FilingTag FilingTag { get; set; } = null!;
    }
}
