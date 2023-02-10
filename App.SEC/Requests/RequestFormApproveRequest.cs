using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Requests
{
    public class RequestFormApproveRequest
    {
        public int Id { get; set; }
        public string DocNo { get; set; } = null!;
        public int RequestFormId { get; set; }
        public int? JobPositionId { get; set; }
        public int? DepartmentId { get; set; }
        public int? StaffId { get; set; }
        public string? StaffName { get; set; }
        public bool? StatusApprove { get; set; }
        public DateTime? DatetimeApprove { get; set; }
    }
}
