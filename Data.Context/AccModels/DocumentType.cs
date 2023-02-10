using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class DocumentType
    {
        public DocumentType()
        {
            Documents = new HashSet<Document>();
        }

        public int Id { get; set; }
        public string? Code { get; set; }
        public string? NameTh { get; set; }
        public string? NameEn { get; set; }

        public virtual ICollection<Document> Documents { get; set; }
    }
}
