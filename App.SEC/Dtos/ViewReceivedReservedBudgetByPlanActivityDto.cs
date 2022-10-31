using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Dtos
{
    public class ViewReceivedReservedBudgetByPlanActivityDto
    {   public PlanActivityDetail? detail { get; set; }
        public List<ViewPlanForActivityByPlanTypeBudgetTypeTable>? data { get; set; }
    }
}
