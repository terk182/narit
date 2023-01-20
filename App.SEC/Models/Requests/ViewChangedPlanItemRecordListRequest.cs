using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Requests
{
    public class ViewChangedPlanItemRecordListRequest
    {
        public int PlanTypeId {get; set;}
           public int FiscalYear { get; set; }
    }
}
