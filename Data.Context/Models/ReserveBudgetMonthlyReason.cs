using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class ReserveBudgetMonthlyReason
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime? Date { get; set; }
        public int? GeneralExpenseMemoFormId { get; set; }
        public int? RequestFormPlanViewId { get; set; }

        public virtual GeneralExpenseMemoForm? GeneralExpenseMemoForm { get; set; }
        public virtual RequestFormPlanView? RequestFormPlanView { get; set; }
    }
}
