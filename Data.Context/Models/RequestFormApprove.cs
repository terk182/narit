using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class RequestFormApprove
    {
        public int Id { get; set; }
        public string DocNo { get; set; } = null!;
        public int RequestFormId { get; set; }
        public string? Name { get; set; }
        public int? JobPositionId { get; set; }
        public int? DepartmentId { get; set; }
        public DateTime? DatetimeApprove { get; set; }

        public virtual RequestFrom RequestFrom { get; set; } = null!;
    }
}
