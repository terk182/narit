using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class OperationFile
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int Size { get; set; }
        public string Path { get; set; } = null!;
        public DateTime UploadDate { get; set; }
        public int? UploadUserId { get; set; }
        public string Type { get; set; } = null!;
        public int? ProcureTrackingActionId { get; set; }

        public virtual ProcureTrackingAction? ProcureTrackingAction { get; set; }
    }
}
