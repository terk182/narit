using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class FilingFileAccessLog
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public DateTime AccessDate { get; set; }
        public string AccessIp { get; set; } = null!;
        public string AccessHostName { get; set; } = null!;
        public int AccessStaffId { get; set; }
        public int FilingFileId { get; set; }
        public string UrlReferrer { get; set; } = null!;
        public string Url { get; set; } = null!;

        public virtual FilingFile FilingFile { get; set; } = null!;
    }
}
