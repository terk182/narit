using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class FrFormActionLog
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int? StaffId { get; set; }
        public DateTime ActionDate { get; set; }
        public string Ip { get; set; } = null!;
        public string HostName { get; set; } = null!;
        public int ActionTypeEnum { get; set; }
        public string StaffName { get; set; } = null!;
        public string ClientName { get; set; } = null!;
        public int FinancialReimbursementFormId { get; set; }
        public string ReturnReasonValue { get; set; } = null!;
        public DateTime? ReturnDeadline { get; set; }

        public virtual FinancialReimbursementForm FinancialReimbursementForm { get; set; } = null!;
    }
}
