using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Requests
{
    public class DepartmentRequest
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public bool Active { get; set; }
        public int? ParentDepartmentId { get; set; }
        public int? ReferenceOldId { get; set; }
        public int? BudgetLimit { get; set; }
    }
}
