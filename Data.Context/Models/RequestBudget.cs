using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class RequestBudget
    {
        public RequestBudget()
        {
            RequestFroms = new HashSet<RequestFrom>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Inform { get; set; }
        public string? Descriptions { get; set; }
        public bool? Active { get; set; }
        public DateTime? WriteDate { get; set; }
        public DateTime? CalculationDate { get; set; }
        public string? StatmentName { get; set; }
        public string? RelatedRegulation { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateByStaffId { get; set; }
        public string? FilePath { get; set; }
        public int? DepartmentId { get; set; }
        public decimal? TotalBudget { get; set; }

        public virtual Department? Department { get; set; }
        public virtual ICollection<RequestFrom> RequestFroms { get; set; }
    }
}
