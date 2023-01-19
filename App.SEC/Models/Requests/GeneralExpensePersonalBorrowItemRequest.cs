using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Requests
{
    public class GeneralExpensePersonalBorrowItemRequest
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public decimal BorrowBudget { get; set; }
        public int GeneralExpensePersonalBorrowFormId { get; set; }
        public int GeneralExpenseId { get; set; }
    }
}
