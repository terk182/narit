using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class ContactAcc
    {
        public int Id { get; set; }
        public int? ContactId { get; set; }
        public int? PaymentDueTypeId { get; set; }
        public int? CreditorTypeId { get; set; }
        public int? DebtorTypeId { get; set; }
        public int? CreditLimit { get; set; }
    }
}
