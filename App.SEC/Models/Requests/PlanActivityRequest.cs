using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Requests
{
    public class PlanActivityRequest
    {
        public int Id { get; set; }
        public int PlanCoreId { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public string Code { get; set; } = null!;
        public int? ReferenceOldId { get; set; }
        public string Detail { get; set; } = null!;
        public bool IsFinished { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public string OperationPeriod { get; set; } = null!;
        public bool? IsFollowUp { get; set; }
        public int DepartmentId { get; set; }
        public decimal Weight { get; set; }
    }
}
