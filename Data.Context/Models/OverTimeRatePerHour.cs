using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class OverTimeRatePerHour
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public double BaseRate { get; set; }
        public int StaffId { get; set; }

        public virtual Staff Staff { get; set; } = null!;
    }
}
