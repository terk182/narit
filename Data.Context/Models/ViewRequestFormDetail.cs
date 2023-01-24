using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class ViewRequestFormDetail
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public string Code { get; set; } = null!;
        public int PlanTypeId { get; set; }
        public string Expr1 { get; set; } = null!;
        public int DepartmentId { get; set; }
        public int? ReferenceOldId { get; set; }
        public string Expr2 { get; set; } = null!;
        public string Detail { get; set; } = null!;
        public string Objective { get; set; } = null!;
        public string Benefit { get; set; } = null!;
        public int PlanCategoryEnum { get; set; }
        public int ContinuousStatusEnum { get; set; }
        public int? FundTypeId { get; set; }
    }
}
