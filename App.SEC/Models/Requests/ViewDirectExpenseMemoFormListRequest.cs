using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Requests
{
    public class ViewDirectExpenseMemoFormListRequest
    {
        public int  FiscalYear { get; set; }
        public string? DocumentNumber { get; set; }
        public string? StatementName { get; set; }
        public string? PlanObjectType { get; set; }
        public int objId { get; set; }
       



    }
}
