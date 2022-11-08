using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Dtos
{

    public class calBudgetDetail
    {
        public List<Budgetmode>? budgetmodes { get; set; }
        public  ViewPlanForActivityByPlanTypeBudgetTypeTable? Budget { get;set;}
    }
    public class ViewPlanForActivityByPlanTypeBudgetTypeTable
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int FiscalYear { get; set; }


        public decimal TotalBudgetCache { get; set; }

        public decimal NetBudgetCache { get; set; }

        public decimal UsedBudgetCache { get; set; }

        public decimal RemainBudgetCache { get; set; }

        public decimal TotalBudget { get; set; }

        public decimal EntireTotalBudget { get; set; }

        public decimal NetBudget { get; set; }

        public decimal EntireNetBudget { get; set; }

        public decimal InProcessBudget { get; set; }
        public decimal CheckViewUsedBudget { get; set; }
        public decimal UsedBudget { get; set; }
        public decimal Amount { get; set; }
        public decimal BudgetPerPiece { get; set; }
        public string? Unit { get; set; }
        public int? BudgetTypeId { get; set; }
        public int? PlanTypeId { get; set; }
        public List<ViewPlanForActivityByPlanTypeBudgetTypeTable>? subdata { get; set; }
    }
    public class planItemCal
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int FiscalYear { get; set; }


        public decimal TotalBudgetCache { get; set; }

        public decimal NetBudgetCache { get; set; }

        public decimal UsedBudgetCache { get; set; }

        public decimal RemainBudgetCache { get; set; }
    }
}
