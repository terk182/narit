using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class ContactBank
    {
        public int Id { get; set; }
        public int? ContactId { get; set; }
        public int? BankId { get; set; }
        public string? BankBranch { get; set; }
        public string? AccountName { get; set; }
        public int? AccountNumber { get; set; }
    }
}
