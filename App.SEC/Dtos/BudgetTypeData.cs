using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Dtos
{
    public class BudgetTypeData
    {

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int? ParentBudgetTypeId { get; set; }
        public int? ReferenceOldId { get; set; }
        public int ExpenseTypeEnum { get; set; }
        public int GovExpenseTypeEnum { get; set; }
        public int? FundSourceId { get; set; }
        public List<BudgetTypeData>? BudgetType { get; set; }
    }
}
