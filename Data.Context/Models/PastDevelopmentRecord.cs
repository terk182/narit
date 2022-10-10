using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class PastDevelopmentRecord
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public string InstituteName { get; set; } = null!;
        public string DevelopmentType { get; set; } = null!;
        public string Place { get; set; } = null!;
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public string Detail { get; set; } = null!;
        public string Remark { get; set; } = null!;
        public int StaffId { get; set; }
        public int? Year { get; set; }

        public virtual Staff Staff { get; set; } = null!;
    }
}
