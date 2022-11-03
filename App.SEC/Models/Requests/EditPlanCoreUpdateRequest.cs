using App.SEC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Requests
{
    public class EditPlanCoreUpdateRequest
    {
       public  PlanCoreListDto? PlanCore { get; set; }
       public List<Team>? ResponsiblePeople { get; set; }

       public List<PerformanceIndicatorDetail>? PerformanceIndicatorDetail { get; set; }
    }
}
