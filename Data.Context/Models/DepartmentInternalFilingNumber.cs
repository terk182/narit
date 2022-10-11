using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class DepartmentInternalFilingNumber
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public int HrdepartmentId { get; set; }
        public string HrdepartmentName { get; set; } = null!;
        public string PrefixNumber { get; set; } = null!;
    }
}
