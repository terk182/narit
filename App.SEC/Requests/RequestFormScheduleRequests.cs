using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Requests
{
    public class RequestFormScheduleRequests
    {
        public int Id { get; set; }
        public int? RequestFormId { get; set; }
        public string DocNo { get; set; } = null!;
        public int? DocYear { get; set; }
        public bool? Active { get; set; }
        public string? Name { get; set; }
        public decimal? RequestLoan { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
    }
}
