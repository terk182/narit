using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Requests
{
    public class RequestFormBorrowingMoneyRequest
    {
        public int Id { get; set; }
        public int? RequestFormId { get; set; }
        public string DocNo { get; set; } = null!;
        public DateTime? DateTime { get; set; }
        public int? StaffId { get; set; }
        public string? StaffName { get; set; }
        public decimal? RequestLoan { get; set; }

    }
}
