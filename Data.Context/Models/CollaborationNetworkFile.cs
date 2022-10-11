using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class CollaborationNetworkFile
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int Size { get; set; }
        public string Path { get; set; } = null!;
        public DateTime UploadDate { get; set; }
        public int? UploadUserId { get; set; }
        public string Type { get; set; } = null!;
        public int? OrganizationId { get; set; }
        public int? CollaborateReportId { get; set; }
        public int CollaborationFileTypeEnum { get; set; }

        public virtual CollaborateReport? CollaborateReport { get; set; }
        public virtual Organization? Organization { get; set; }
    }
}
