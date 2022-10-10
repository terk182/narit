using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class GeFormActionLog
    {
        public GeFormActionLog()
        {
            PlanFiles = new HashSet<PlanFile>();
        }

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
        public int GeneralExpenseMemoFormId { get; set; }
        public string SignedHashText { get; set; } = null!;
        public string VerifyData { get; set; } = null!;
        public string SignedHashValue { get; set; } = null!;
        public int CipherKeyPairId { get; set; }
        public string Jwtpayload { get; set; } = null!;
        public string Detail { get; set; } = null!;

        public virtual GeneralExpenseMemoForm GeneralExpenseMemoForm { get; set; } = null!;
        public virtual ICollection<PlanFile> PlanFiles { get; set; }
    }
}
