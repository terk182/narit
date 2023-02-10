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
        public int? Id { get; set; }
        public string DocNo { get; set; }
        public int RequestFormId { get; set; }
        public string? Name { get; set; }
        public int? JobPositionId { get; set; }
        public int? DepartmentId { get; set; }
        public DateTime? DatetimeApprove { get; set; }

    }
}
