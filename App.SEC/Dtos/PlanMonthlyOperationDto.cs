using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Dtos
{
    public class PlanMonthlyOperationDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
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
        public decimal Weight { get; set; }
        public int PlanActivityId { get; set; }
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
        public int? ParentPlanMonthlyOperationId { get; set; }
    }
}
