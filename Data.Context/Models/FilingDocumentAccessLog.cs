using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class FilingDocumentAccessLog
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public DateTime AccessDate { get; set; }
        public string AccessIp { get; set; } = null!;
        public string AccessHostName { get; set; } = null!;
        public int AccessStaffId { get; set; }
        public DateTime? LeaveDate { get; set; }
        public int FilingDocumentId { get; set; }

        public virtual FilingDocument FilingDocument { get; set; } = null!;
    }
}
