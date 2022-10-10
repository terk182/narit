using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class FilingGeneralOrder
    {
        public FilingGeneralOrder()
        {
            FilingDocuments = new HashSet<FilingDocument>();
            Messages = new HashSet<Message>();
        }

        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<FilingDocument> FilingDocuments { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
