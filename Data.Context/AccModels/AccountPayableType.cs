using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class AccountPayableType
    {
        public int Id { get; set; }
        public string? AccountPayableTypeCode { get; set; }
        public int Index { get; set; }
        public string? Name { get; set; }
        public int Active { get; set; }
        public byte[] CreateDate { get; set; } = null!;
        public int? AccountTypeId { get; set; }
        public string? Detail { get; set; }

        public virtual AccountType? AccountType { get; set; }
    }
}
