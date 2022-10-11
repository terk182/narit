using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class GeneralExpensePersonalBorrowItem
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public decimal BorrowBudget { get; set; }
        public int GeneralExpensePersonalBorrowFormId { get; set; }
        public int GeneralExpenseId { get; set; }

        public virtual GeneralExpense GeneralExpense { get; set; } = null!;
        public virtual GeneralExpensePersonalBorrowForm GeneralExpensePersonalBorrowForm { get; set; } = null!;
    }
}
