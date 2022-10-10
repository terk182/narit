using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class TempYearlyEvaluation5859Score
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public double Total58Score { get; set; }
        public double Total59Score { get; set; }
        public int StaffId { get; set; }
        public double Total60Score { get; set; }

        public virtual Staff Staff { get; set; } = null!;
    }
}
