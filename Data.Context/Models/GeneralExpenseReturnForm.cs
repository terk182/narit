using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class GeneralExpenseReturnForm
    {
        public GeneralExpenseReturnForm()
        {
            GeneralExpenseReturnItems = new HashSet<GeneralExpenseReturnItem>();
            GeneralExpenses = new HashSet<GeneralExpense>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public string Remark { get; set; } = null!;
        public DateTime StatementCalculationDate { get; set; }
        public string StatementName { get; set; } = null!;
        public int GeneralExpenseMemoFormId { get; set; }

        public virtual GeneralExpenseMemoForm GeneralExpenseMemoForm { get; set; } = null!;
        public virtual ICollection<GeneralExpenseReturnItem> GeneralExpenseReturnItems { get; set; }
        public virtual ICollection<GeneralExpense> GeneralExpenses { get; set; }
    }
}
