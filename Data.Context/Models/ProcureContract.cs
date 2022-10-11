using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class ProcureContract
    {
        public ProcureContract()
        {
            ProcureContractInstallments = new HashSet<ProcureContractInstallment>();
            ProcureFiles = new HashSet<ProcureFile>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? WriteDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public bool Active { get; set; }
        public int? OrderFormId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string Remark { get; set; } = null!;
        public int FiscalYear { get; set; }
        public int? ReminderDay { get; set; }
        public int? GuaranteeYear { get; set; }
        public int? GuaranteeMonth { get; set; }
        public int? GuaranteeDay { get; set; }
        public DateTime? GuaranteeEndDate { get; set; }

        public virtual OrderForm? OrderForm { get; set; }
        public virtual ICollection<ProcureContractInstallment> ProcureContractInstallments { get; set; }
        public virtual ICollection<ProcureFile> ProcureFiles { get; set; }
    }
}
