using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class ProcureLoaningWithdrawalForm
    {
        public ProcureLoaningWithdrawalForm()
        {
            ProcureLoaningWithdrawalItems = new HashSet<ProcureLoaningWithdrawalItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int StatementPayMethodEnum { get; set; }
        public DateTime? WithdrawnDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public string Remark { get; set; } = null!;
        public DateTime StatementCalculationDate { get; set; }
        public string StatementName { get; set; } = null!;
        public int ProcureLoaningMemoFormId { get; set; }
        public string Payee { get; set; } = null!;
        public int? PayeeStaffId { get; set; }
        public string PayeeHrDepartmentName { get; set; } = null!;
        public int? PayeeHrdepartmentId { get; set; }
        public string Borrower { get; set; } = null!;
        public int? BorrowerStaffId { get; set; }
        public string BorrowerHrDepartmentName { get; set; } = null!;
        public int? BorrowerHrdepartmentId { get; set; }

        public virtual ProcureLoaningMemoForm ProcureLoaningMemoForm { get; set; } = null!;
        public virtual ICollection<ProcureLoaningWithdrawalItem> ProcureLoaningWithdrawalItems { get; set; }
    }
}
