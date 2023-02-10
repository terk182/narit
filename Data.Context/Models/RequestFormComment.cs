using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class RequestFormComment
    {
        public int Id { get; set; }
        public int? RequestFormId { get; set; }
        public string DocNo { get; set; } = null!;
        public DateTime? DateTime { get; set; }
        public string? StaffId { get; set; }
        public string? StaffName { get; set; }
        public string? Comment { get; set; }
        public string? Descriptions { get; set; }

        public virtual RequestFrom? RequestFrom { get; set; }
    }
}
