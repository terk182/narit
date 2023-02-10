using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class RequestFormBorrowingMoney
    {
        public int Id { get; set; }
        public int? RequestFormId { get; set; }
        public string DocNo { get; set; } = null!;
        public DateTime? DateTime { get; set; }
        public int? StaffId { get; set; }
        public string? StaffName { get; set; }
        public decimal? RequestLoan { get; set; }

        public virtual RequestFrom? RequestFrom { get; set; }
    }
}
