using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class FundSource
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public bool Active { get; set; }
        public int? ReferenceOldId { get; set; }
        public int? ParentFundSourceId { get; set; }
    }
}
