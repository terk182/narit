using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.FIN.Models.Requests
{
    public class ViewRequestFormListRequest
    {
        public int FiscalYear { get; set; }
        public string? DocumentNumber { get; set; }
        public decimal budgetValue { get; set; }
        public int perspective { get; set; }
        public int PlanTypeId { get; set; }
        public int DepartmentId { get; set; }
    }
}
