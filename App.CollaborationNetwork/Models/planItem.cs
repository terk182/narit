using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.EIS.Models
{
    public class planItem
    {
        public string? LabelOverall_Q1R { get; set; }
        public string? LabelRegular_Q1R { get; set; }
        public string? LabelInvest_Q1R { get; set; }

        public string? LabelOverall_Q2R { get; set; }
        public string? LabelRegular_Q2R { get; set; }
        public string? LabelInvest_Q2R { get; set; }

        public string? LabelOverall_Q3R { get; set; }
        public string? LabelRegular_Q3R { get; set; }
        public string? LabelInvest_Q3R { get; set; }

        public string? LabelOverall_Q4R { get; set; }
        public string? LabelRegular_Q4R { get; set; }
        public string? LabelInvest_Q4R { get; set; }

        public string? LabelOverall_Q1 { get; set; }
        public string? LabelOverall_Q2 { get; set; }
        public string? LabelOverall_Q3 { get; set; }
        public string? LabelOverall_Q4 { get; set; }
        List<Tuple<decimal, decimal, decimal, decimal>>? GovGoalColumnDataList { get; set; }
        List<Tuple<decimal, decimal, decimal, decimal>>? GovGoalLineDataList { get; set; }
        List<object>? GovBudgetRegularList { get; set; }
        List<object>? ResultBudgetRegularList { get; set; }
        List<object>? InProcessRegularList { get; set; }

        List<object>? GovBudgetInvestList { get; set; }
        List<object>? ResultBudgetInvestList { get; set; }
        List<object>? InProcessInvestList { get; set; }
        List<Tuple<decimal, decimal, decimal, decimal>>? FinancialByExpenseTypeList { get; set; }
    }
    
}
