using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Dtos
{
    public class ViewPlanActivityOperationPeriodByPlanCoreDto
    {

        public List<Team>? Persons { get; set; }
        public projectDetailAddBugetDto? Detail { get; set; }
        public List<PlanMonthlyOperationDto>? data { get; set; }

    }
}
