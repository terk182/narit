using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.FIN.Models.Requests
{
    public class FinancialReserveStatementMonthlyBriefReportByBudgetTypeRequest
    {
        public int fiscalYear { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public int BudgetType { get; set; }
        public int reserveDepartmentId { get; set; }
        public string? Show { get; set; }
    }
}
