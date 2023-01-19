using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Requests
{
    public class ViewOutsideDutyReportFormListRequest
    {
        public int fYear {get; set;}
        public string? docNum {get; set;}

        public string? refDocNum { get; set; }
        public string? staffName { get; set; }

        public bool? isFinPowerUser { get; set; }
        public string? IsOutsideDutyReportRDL { get; set; }
    }
}
