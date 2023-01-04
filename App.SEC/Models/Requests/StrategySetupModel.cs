using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Requests
{
    public class StrategySetupModel
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public int? FiscalYear { get; set; }
        public bool Active { get; set; }
        public int? ParentStrategyId { get; set; }
        //public string? Messsage { get; set; }
    }
}
