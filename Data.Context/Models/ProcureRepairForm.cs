using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class ProcureRepairForm
    {
        public ProcureRepairForm()
        {
            ProcureRepairFormActionLogs = new HashSet<ProcureRepairFormActionLog>();
        }

        public int Id { get; set; }
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public string Name { get; set; } = null!;
        public string DocumentNumber { get; set; } = null!;
        public DateTime? WriteDate { get; set; }
        public decimal Amount { get; set; }
        public string Unit { get; set; } = null!;
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
        public string Fault { get; set; } = null!;
        public int? PlanItemId { get; set; }
        public string PlanItemName { get; set; } = null!;
        public int? PlanCoreId { get; set; }
        public string PlanCoreName { get; set; } = null!;
        public int? PlanActivityId { get; set; }
        public string PlanActivityName { get; set; } = null!;
        public int? BudgetTypeId { get; set; }
        public string BudgetTypeName { get; set; } = null!;
        public int? PlanTypeId { get; set; }
        public string PlanTypeName { get; set; } = null!;
        public string RequesterName { get; set; } = null!;
        public DateTime? RequesterSignDate { get; set; }
        public string RequesterPosition { get; set; } = null!;
        public string CheckerName { get; set; } = null!;
        public DateTime? CheckerSignDate { get; set; }
        public string CheckerPosition { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public int RegisterDurableItemId { get; set; }
        public string CheckChairman { get; set; } = null!;
        public string CheckFirstComittee { get; set; } = null!;
        public string CheckSecondComittee { get; set; } = null!;
        public int ProcureApprovalStatusEnum { get; set; }
        public string RepairWarrantyDocumentNumber { get; set; } = null!;
        public DateTime? RepairWarrantyWriteDate { get; set; }
        public string RepairWarrantyDetail { get; set; } = null!;
        public int? RepairWarrantyYear { get; set; }
        public int? RepairWarrantyMonth { get; set; }
        public int? RepairWarrantyDay { get; set; }
        public DateTime? RepairWarrantyEndDate { get; set; }

        public virtual RegisterDurableItem RegisterDurableItem { get; set; } = null!;
        public virtual ICollection<ProcureRepairFormActionLog> ProcureRepairFormActionLogs { get; set; }
    }
}
