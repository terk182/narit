using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class GeneralExpenseCancelForm
    {
        public GeneralExpenseCancelForm()
        {
            GeneralExpenseCancelItems = new HashSet<GeneralExpenseCancelItem>();
            GeneralExpenses = new HashSet<GeneralExpense>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int GeneralExpenseMemoFormId { get; set; }
        public DateTime? CancelDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public string Remark { get; set; } = null!;
        public DateTime StatementCalculationDate { get; set; }
        public string StatementName { get; set; } = null!;

        public virtual GeneralExpenseMemoForm GeneralExpenseMemoForm { get; set; } = null!;
        public virtual ICollection<GeneralExpenseCancelItem> GeneralExpenseCancelItems { get; set; }
        public virtual ICollection<GeneralExpense> GeneralExpenses { get; set; }
    }
}
