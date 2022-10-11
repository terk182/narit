using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class GeExtendFormActionLog
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
        public int GeneralExpenseExtendFormId { get; set; }

        public virtual GeneralExpenseExtendForm GeneralExpenseExtendForm { get; set; } = null!;
    }
}
