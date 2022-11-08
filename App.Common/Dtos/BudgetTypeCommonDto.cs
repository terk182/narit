using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Common.Dtos
{
    public class BudgetTypeCommonDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int? ParentBudgetTypeId { get; set; }
        public int? ReferenceOldId { get; set; }
        public int ExpenseTypeEnum { get; set; }
        public int GovExpenseTypeEnum { get; set; }
        public decimal TotalBudgetCache { get; set; }
        public decimal TotalBudget { get; set; }
        public decimal NetBudgetCache { get; set; }

        public decimal UsedBudgetCache { get; set; }

        public decimal RemainBudgetCache { get; set; }

        public  List<BudgetTypeCommonDto>? ParentBudgetType { get; set; }
    }
}
