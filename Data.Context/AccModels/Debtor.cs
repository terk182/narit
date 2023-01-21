using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class Debtor
    {
        public int Id { get; set; }
<<<<<<< HEAD
        public string? DebtorCode { get; set; }
=======
>>>>>>> origin/master_acc
        public string Name { get; set; } = null!;
        public string? Address { get; set; }
        public string? SubDistrict { get; set; }
        public string? District { get; set; }
        public string? Province { get; set; }
        public int? Postcode { get; set; }
        public string? Phone { get; set; }
        public int DebtorTypeId { get; set; }
        public int? TaxCode { get; set; }
        public string? Branch { get; set; }
        public string? ContactDate { get; set; }
        public int BusinessTypeId { get; set; }
        public int? BankAccountNo { get; set; }
        public int? BankId { get; set; }
    }
}
