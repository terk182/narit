using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class GovernmentDisbursementGoal
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public bool Active { get; set; }
        public decimal TargetValueAccQ1 { get; set; }
        public decimal TargetValueAccQ2 { get; set; }
        public decimal TargetValueAccQ3 { get; set; }
        public decimal TargetValueAccQ4 { get; set; }
        public int ExpenseTypeEnum { get; set; }
    }
}
