using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Requests
{
    public class StrategicIndicatorRequest
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public bool Active { get; set; }
        public int? ParentStrategicIndicatorId { get; set; }
        public string Unit { get; set; } = null!;
        public decimal Amount { get; set; }
        public decimal Weight { get; set; }
        public int? StrategyId { get; set; }
        public int? ParentStrategyId { get; set; }
    }
}
