using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.EIS.Models
{
    public class MonthListSum
    {
          public  int Month_num { get; set; } 
           public decimal netBudgetByFYear { get; set; }
           public decimal netBudget { get; set; }
           public decimal paidBudgetAcc { get; set; }
          public string? inProcessBudgetAcc { get; set; } 
    }
}
