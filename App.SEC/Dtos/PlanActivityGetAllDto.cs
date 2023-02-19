using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Dtos
{
    public class PlanActivityGetAllDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Unit { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalBudgetCache { get; set; }

        public decimal NetBudgetCache { get; set; }

        public decimal UsedBudgetCache { get; set; }

        public decimal RemainBudgetCache { get; set; }
    }
}
