using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Requests
{
    public class BudgetBureauStrategiesRequests
    {
        public int Id { get; set; }
        public bool? Active { get; set; }
        public string? Code { get; set; }
        public int? FiscalYear { get; set; }
        public string Name { get; set; } = null!;
        public string? Remark { get; set; }
        public DateTime? CreateDate { get; set; }

    }
}
