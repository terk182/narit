using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Requests
{
    public class GeneralExpenseExtendFormRequest
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public DateTime? WriteDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public string RequesterName { get; set; } = null!;
        public string RequesterPosition { get; set; } = null!;
        public string UnitChiefName { get; set; } = null!;
        public string UnitChiefPosition { get; set; } = null!;
        public string DepartmentName { get; set; } = null!;
        public int DepartmentId { get; set; }
        public decimal TotalBudget { get; set; }
        public string RefDocumentNumber { get; set; } = null!;
        public DateTime? RefDocumentWriteDate { get; set; }
        public string Purpose { get; set; } = null!;
        public string PlanDetail { get; set; } = null!;
        public string OperationSummary { get; set; } = null!;
        public int ExtendDay { get; set; }
        public int GeneralExpenseMemoFormId { get; set; }
        public string ContactNumber { get; set; } = null!;

    }
}
