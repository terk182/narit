using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class FilingDocMessageReferrer
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public int MessageId { get; set; }
        public int? FilingDocumentId { get; set; }

        public virtual FilingDocument? FilingDocument { get; set; }
        public virtual Message Message { get; set; } = null!;
    }
}
