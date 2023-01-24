using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Dtos
{
    public class PlanCoreDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public string Code { get; set; } = null!;
        public bool Active { get; set; }
        public int DepartmentId { get; set; }
        public int PlanTypeId { get; set; }
        public int? ReferenceOldId { get; set; }
        public string Detail { get; set; } = null!;
        public string Objective { get; set; } = null!;
        public string Benefit { get; set; } = null!;
        public int PlanCategoryEnum { get; set; }
        public int ContinuousStatusEnum { get; set; }
        //public int? FundTypeId { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public int? PrinciplePlanTagId { get; set; }
        public decimal Weight { get; set; }
        public bool IsApproved { get; set; }
        public int CodeNumber { get; set; }
        public int? ProjectDuration { get; set; }
        public int? MonthStart { get; set; }
        public int? MonthEnd { get; set; }
        public string TargetIdListValue { get; set; } = null!;
        public string OtherTarget { get; set; } = null!;
        public int ExpenseTypeEnum { get; set; }
        public string Output { get; set; } = null!;
        public string Outcome { get; set; } = null!;
        public int FundSourceEnum { get; set; }
        public int FundCategoryEnum { get; set; }
        public int? FundSourceId { get; set; }
        public int? ParentPlanCoreId { get; set; }
        public int? MissionId { get; set; }
        public int? StrategyId { get; set; }
    }
}
