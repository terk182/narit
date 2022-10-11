using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class OutsideDutyReportReceipt
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public string Detail { get; set; } = null!;
        public decimal Amount { get; set; }
        public string Remark { get; set; } = null!;
        public int OutsideDutyReportFormId { get; set; }

        public virtual OutsideDutyReportForm OutsideDutyReportForm { get; set; } = null!;
    }
}
