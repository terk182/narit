using App.SEC.Dtos;
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Requests
{
    public class ViewMonthlyForecastAdjustmentListRequest
    {
        public int fYear { get; set; }
        public  int planTypeId { get; set; }

        public int planCoreId { get; set; }

        public int approveState { get; set; }

    }
}
