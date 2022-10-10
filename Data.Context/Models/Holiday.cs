using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class Holiday
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Remark { get; set; } = null!;
        public int FiscalYear { get; set; }
    }
}
