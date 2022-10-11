using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class TemporaryEmployeeRequestForm
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public DateTime? WriteDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public string RequesterName { get; set; } = null!;
        public int RequesterStaffId { get; set; }
        public string RequesterDepartmentName { get; set; } = null!;
        public int RequesterDepartmentId { get; set; }
        public string RequesterPosition { get; set; } = null!;
        public string EmployeeName { get; set; } = null!;
        public string EmployeePosition { get; set; } = null!;
        public string ProjectName { get; set; } = null!;
        public int ObjectiveTypeEnum { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Remark { get; set; } = null!;
        public int FiscalYear { get; set; }
        public decimal Salary { get; set; }
        public int? OutwardPlanItemId { get; set; }
        public string OutwardDepartmentName { get; set; } = null!;
        public int? OutwardDepartmentId { get; set; }
        public string OutwardPlanTypeName { get; set; } = null!;
        public int? OutwardPlanTypeId { get; set; }
        public string OutwardPlanCoreName { get; set; } = null!;
        public int? OutwardPlanCoreId { get; set; }
        public string OutwardPlanActivityName { get; set; } = null!;
        public int? OutwardPlanActivityId { get; set; }
        public decimal OutwardPlanItemNetBudget { get; set; }
        public decimal OutwardPlanItemRemainBudget { get; set; }
        public decimal OutwardPlanCoreNetBudget { get; set; }
        public decimal OutwardPlanCoreRemainBudget { get; set; }
        public string OutwardPlanCoreCode { get; set; } = null!;
        public string OutwardPlanItemName { get; set; } = null!;
        public string OutwardBudgetTypeName { get; set; } = null!;
        public string AttachmentTypeEnumListValue { get; set; } = null!;
    }
}
