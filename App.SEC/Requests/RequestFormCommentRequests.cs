using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Requests
{
    public class RequestFormCommentRequests
    {
        public int Id { get; set; }
        public int? RequestFormId { get; set; }
        public string DocNo { get; set; }
        public DateTime? DateTime { get; set; }
        public string? StaffId { get; set; }
        public string? StaffName { get; set; }
        public string? Comment { get; set; }
        public string? Descriptions { get; set; }

    }
}
