using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class WithdrawalForm
    {
        public WithdrawalForm()
        {
            WdFormActionLogs = new HashSet<WdFormActionLog>();
            WithdrawalItems = new HashSet<WithdrawalItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int GeneralExpenseMemoFormId { get; set; }
        public int StatementPayMethodEnum { get; set; }
        public DateTime? WithdrawnDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public string Remark { get; set; } = null!;
        public DateTime StatementCalculationDate { get; set; }
        public string StatementName { get; set; } = null!;
        public string Payee { get; set; } = null!;
        public int? PayeeStaffId { get; set; }
        public string PayeeHrDepartmentName { get; set; } = null!;
        public int? PayeeHrdepartmentId { get; set; }
        public string Borrower { get; set; } = null!;
        public int? BorrowerStaffId { get; set; }
        public string BorrowerHrDepartmentName { get; set; } = null!;
        public int? BorrowerHrdepartmentId { get; set; }
        public bool IsExtraAdded { get; set; }
        public string BorrowerPosition { get; set; } = null!;

        public virtual GeneralExpenseMemoForm GeneralExpenseMemoForm { get; set; } = null!;
        public virtual ICollection<WdFormActionLog> WdFormActionLogs { get; set; }
        public virtual ICollection<WithdrawalItem> WithdrawalItems { get; set; }
    }
}
