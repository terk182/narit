using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class GovtStrategic
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public bool Active { get; set; }
        public int MaingovtId { get; set; }
    }
}
