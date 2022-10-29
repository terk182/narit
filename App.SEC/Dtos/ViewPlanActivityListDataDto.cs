using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Dtos
{
    public class ViewPlanActivityListDataDto
    {
        public List<Team>? Persons { get; set; }
        public projectDetailDto? projectDetail { get; set; }
        public  List<ViewPlanForActivityByDepartmentTable>? data { get; set; }
    }
}
