using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models
{
    public class aListModel
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int PlanTypeId { get; set; }
        public decimal TotalBudget { get; set; }

    }
}
