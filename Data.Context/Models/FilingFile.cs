using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class FilingFile
    {
        public FilingFile()
        {
            FilingFileAccessLogs = new HashSet<FilingFileAccessLog>();
        }

        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public int Size { get; set; }
        public string Path { get; set; } = null!;
        public DateTime UploadDate { get; set; }
        public int? UploadUserId { get; set; }
        public string Type { get; set; } = null!;
        public int? FilingDocumentId { get; set; }
        public int? MessageId { get; set; }
        public int? MainFilingDocumentId { get; set; }

        public virtual FilingDocument? FilingDocument { get; set; }
        public virtual FilingDocument? MainFilingDocument { get; set; }
        public virtual Message? Message { get; set; }
        public virtual ICollection<FilingFileAccessLog> FilingFileAccessLogs { get; set; }
    }
}
