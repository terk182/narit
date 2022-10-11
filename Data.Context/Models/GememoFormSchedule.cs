using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class GememoFormSchedule
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public DateTime DateStart { get; set; }
        public string TimeStart { get; set; } = null!;
        public DateTime? DateEnd { get; set; }
        public string TimeEnd { get; set; } = null!;
        public string Remark { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public int GeneralExpenseMemoFormId { get; set; }

        public virtual GeneralExpenseMemoForm GeneralExpenseMemoForm { get; set; } = null!;
    }
}
