using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Dtos
{

    public class PlanActivityDetail
    {
        public int FiscalYear { get; set; }
        public string? product { get; set; }
        public string? PlanName { get; set; }
        public string? Department { get; set; }
        public string? BudgetType { get; set; }
        public string? ProjectName { get; set; }
        public string? ProjectCode { get; set; }
        public string? StrategiesName { get; set; }
    }
    public class projectDetailDto
    {
        public int FiscalYear { get; set; }
        public string? StrategiesName { get; set; }
        public string? PlanName { get; set; }
        public string? Department { get; set; }
        public string? ProjectName { get; set; }
        public List<Team>? ResponsiblePeople { get; set; }

        public List<Budgetmode>? Budgetmode { get; set; }
    }
    public class projectDetailAddBugetDto : ViewPlanForActivityByPlanTypeBudgetTypeTable
    {
        public int? FiscalYear_main { get; set; }
        public string? StrategiesName { get; set; }
        public string? PlanName { get; set; }
        public string? Department { get; set; }
        public string? ProjectName { get; set; }
        public List<Team>? ResponsiblePeople { get; set; }

        public List<Budgetmode>? Budgetmode { get; set; }

        public List<ViewPlanForActivityByPlanTypeBudgetTypeTable>? BudgetDetail { get; set; }
    }

    public class Team
    {
        public int no { get; set; }
        public string? HrdepartmentName { get; set; }

        public string? Position { get; set; }
        public string? Name { get; set; }
    }
    public class Budgetmode
    {
        public int BudgetTypeId { get; set; }
        public string? list { get; set; }
        public decimal? Budget { get; set; }
    }
}


