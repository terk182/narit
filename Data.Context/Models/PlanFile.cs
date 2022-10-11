using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class PlanFile
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int Size { get; set; }
        public string Path { get; set; } = null!;
        public DateTime UploadDate { get; set; }
        public int? UploadUserId { get; set; }
        public string Type { get; set; } = null!;
        public int? GeneralExpenseMemoFormId { get; set; }
        public int? PlanMonthlyOperationId { get; set; }
        public int Month { get; set; }
        public int? GeFormActionLogId { get; set; }
        public int SpecificPlanFileTypeEnum { get; set; }
        public int? GeneralExpensePersonalBorrowFormId { get; set; }
        public int? SettleReceiptFormId { get; set; }

        public virtual GeFormActionLog? GeFormActionLog { get; set; }
        public virtual GeneralExpenseMemoForm? GeneralExpenseMemoForm { get; set; }
        public virtual GeneralExpensePersonalBorrowForm? GeneralExpensePersonalBorrowForm { get; set; }
        public virtual PlanMonthlyOperation? PlanMonthlyOperation { get; set; }
        public virtual SettleReceiptForm? SettleReceiptForm { get; set; }
    }
}
