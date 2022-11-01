using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Dtos
{

    public class PerformanceIndicatorData
    {
        
        public List<Team>? ResponsiblePeople { get; set; }
        public ViewPlanForActivityByPlanTypeBudgetTypeTable? BugetDetail { get; set; }
        public List<Budgetmode>? budgetmodes { get; set; }
        public List<PerformanceIndicatorDetail>? PerformanceIndicatorDetail { get; set; }
    }
    public class PerformanceIndicatorDetail
    {
        public string? Name {get; set;}
        public List<PerformanceIndicatorDto>? data { get; set; }
    }
    public class PerformanceIndicatorDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public bool Active { get; set; }
        public decimal TargetValueQ1 { get; set; }
        public string TargetUnit { get; set; } = null!;
        public string Detail { get; set; } = null!;
        public int? PlanActivityId { get; set; }
        public decimal TargetValueQ2 { get; set; }
        public decimal TargetValueQ3 { get; set; }
        public decimal TargetValueQ4 { get; set; }
        public int? PlanCoreId { get; set; }
        public int? StrategicIndicatorId { get; set; }
        public decimal ResultQ1 { get; set; }
        public decimal ResultQ2 { get; set; }
        public decimal ResultQ3 { get; set; }
        public decimal ResultQ4 { get; set; }
        public string DetailQ1 { get; set; } = null!;
        public string DetailQ2 { get; set; } = null!;
        public string DetailQ3 { get; set; } = null!;
        public string DetailQ4 { get; set; } = null!;
        public string SupportFactorQ1 { get; set; } = null!;
        public string SupportFactorQ2 { get; set; } = null!;
        public string SupportFactorQ3 { get; set; } = null!;
        public string SupportFactorQ4 { get; set; } = null!;
        public string ObstacleQ1 { get; set; } = null!;
        public string ObstacleQ2 { get; set; } = null!;
        public string ObstacleQ3 { get; set; } = null!;
        public string ObstacleQ4 { get; set; } = null!;
        public int? ParentPerformanceIndicatorId { get; set; }
        public decimal January { get; set; }
        public decimal February { get; set; }
        public decimal March { get; set; }
        public decimal April { get; set; }
        public decimal May { get; set; }
        public decimal June { get; set; }
        public decimal July { get; set; }
        public decimal August { get; set; }
        public decimal September { get; set; }
        public decimal October { get; set; }
        public decimal November { get; set; }
        public decimal December { get; set; }
        public decimal ResultJanuary { get; set; }
        public decimal ResultFebruary { get; set; }
        public decimal ResultMarch { get; set; }
        public decimal ResultApril { get; set; }
        public decimal ResultMay { get; set; }
        public decimal ResultJune { get; set; }
        public decimal ResultJuly { get; set; }
        public decimal ResultAugust { get; set; }
        public decimal ResultSeptember { get; set; }
        public decimal ResultOctober { get; set; }
        public decimal ResultNovember { get; set; }
        public decimal ResultDecember { get; set; }
        public string SupportFactorJanuary { get; set; } = null!;
        public string SupportFactorFebruary { get; set; } = null!;
        public string SupportFactorMarch { get; set; } = null!;
        public string SupportFactorApril { get; set; } = null!;
        public string SupportFactorMay { get; set; } = null!;
        public string SupportFactorJune { get; set; } = null!;
        public string SupportFactorJuly { get; set; } = null!;
        public string SupportFactorAugust { get; set; } = null!;
        public string SupportFactorSeptember { get; set; } = null!;
        public string SupportFactorOctober { get; set; } = null!;
        public string SupportFactorNovember { get; set; } = null!;
        public string SupportFactorDecember { get; set; } = null!;
        public string DetailJanuary { get; set; } = null!;
        public string DetailFebruary { get; set; } = null!;
        public string DetailMarch { get; set; } = null!;
        public string DetailApril { get; set; } = null!;
        public string DetailMay { get; set; } = null!;
        public string DetailJune { get; set; } = null!;
        public string DetailJuly { get; set; } = null!;
        public string DetailAugust { get; set; } = null!;
        public string DetailSeptember { get; set; } = null!;
        public string DetailOctober { get; set; } = null!;
        public string DetailNovember { get; set; } = null!;
        public string DetailDecember { get; set; } = null!;
        public string ObstacleJanuary { get; set; } = null!;
        public string ObstacleFebruary { get; set; } = null!;
        public string ObstacleMarch { get; set; } = null!;
        public string ObstacleApril { get; set; } = null!;
        public string ObstacleMay { get; set; } = null!;
        public string ObstacleJune { get; set; } = null!;
        public string ObstacleJuly { get; set; } = null!;
        public string ObstacleAugust { get; set; } = null!;
        public string ObstacleSeptember { get; set; } = null!;
        public string ObstacleOctober { get; set; } = null!;
        public string ObstacleNovember { get; set; } = null!;
        public string ObstacleDecember { get; set; } = null!;

    }
}
