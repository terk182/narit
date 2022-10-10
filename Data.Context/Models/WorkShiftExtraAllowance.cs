using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class WorkShiftExtraAllowance
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public decimal AmountPerShift { get; set; }
        public int WorkShiftDataId { get; set; }

        public virtual WorkShiftData WorkShiftData { get; set; } = null!;
    }
}
