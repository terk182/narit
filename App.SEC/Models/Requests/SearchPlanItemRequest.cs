using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Requests
{
    public class SearchPlanItemRequest
    {
        public int fiscalYear { get; set; }
        public int departmentId { get; set; }
        public int planTypeId { get; set; }
        public int fundTypeId { get; set; }
        public string? planCode { get; set; }
        public string? planName { get; set; }
        public string? code { get; set; }
        public string? name { get; set; }
    }
}
