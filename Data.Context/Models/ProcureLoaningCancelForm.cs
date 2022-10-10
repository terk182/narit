using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class ProcureLoaningCancelForm
    {
        public ProcureLoaningCancelForm()
        {
            ProcureLoaningItems = new HashSet<ProcureLoaningItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public DateTime? CancelDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public string Remark { get; set; } = null!;
        public DateTime StatementCalculationDate { get; set; }
        public string StatementName { get; set; } = null!;
        public int ProcureLoaningMemoFormId { get; set; }

        public virtual ProcureLoaningMemoForm ProcureLoaningMemoForm { get; set; } = null!;
        public virtual ICollection<ProcureLoaningItem> ProcureLoaningItems { get; set; }
    }
}
