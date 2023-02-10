using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class Strategic
    {
        public int Id { get; set; }
        public string? StrategicCode { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int? FiscalYear { get; set; }
        public int? EndFiscalYear { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? Remark { get; set; }
    }
}
