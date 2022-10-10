using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class CheckForm
    {
        public CheckForm()
        {
            CheckFormActionLogs = new HashSet<CheckFormActionLog>();
            CheckItemPlanReferenceItems = new HashSet<CheckItemPlanReferenceItem>();
            CheckItems = new HashSet<CheckItem>();
            ProcureFiles = new HashSet<ProcureFile>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string DocumentNumber { get; set; } = null!;
        public DateTime? WriteDate { get; set; }
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int ProcureTypeEnum { get; set; }
        public string OrderDocumentNumber { get; set; } = null!;
        public DateTime? OrderDate { get; set; }
        public string DepartmentName { get; set; } = null!;
        public int? SupplierId { get; set; }
        public int CountTime { get; set; }
        public string PlanTypeCode { get; set; } = null!;
        public string DepartmentCode { get; set; } = null!;
        public string BudgetTypeCode { get; set; } = null!;
        public string PlanTypeName { get; set; } = null!;
        public string PlanCoreName { get; set; } = null!;
        public string BudgetTypeName { get; set; } = null!;
        public string SupplierName { get; set; } = null!;
        public string DeliveryRequestFormNumber { get; set; } = null!;
        public DateTime? DeliveryRequestFormDate { get; set; }
        public string DeliveryFormNumber { get; set; } = null!;
        public DateTime? DeliveryFormDate { get; set; }
        public decimal? LateDeliveryFineRate { get; set; }
        public int LateDeliveryDay { get; set; }
        public string CheckChairman { get; set; } = null!;
        public string CheckFirstComittee { get; set; } = null!;
        public string CheckSecondComittee { get; set; } = null!;
        public string SuppliesUnitChief { get; set; } = null!;
        public DateTime? SuppliesUnitChiefSignDate { get; set; }
        public string BudgetChecker { get; set; } = null!;
        public DateTime? BudgetCheckerSignDate { get; set; }
        public int ProcureTransformStatusEnum { get; set; }
        public int OrderFormId { get; set; }
        public int PlanTypeId { get; set; }
        public int DepartmentId { get; set; }
        public int PlanCoreId { get; set; }
        public decimal? LateDeliveryFineValue { get; set; }
        public int FundTypeId { get; set; }
        public string FundTypeName { get; set; } = null!;
        public string RequestFormNumber { get; set; } = null!;
        public int RequestFormId { get; set; }
        public DateTime? RequestFormDate { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public bool IsSinglePassCheck { get; set; }
        public string CountTimeText { get; set; } = null!;
        public string CheckThirdComittee { get; set; } = null!;
        public string CheckFourthComittee { get; set; } = null!;
        public string CheckFifthComittee { get; set; } = null!;
        public string CheckSecretaryComittee { get; set; } = null!;
        public int ProcureMethodEnum { get; set; }
        public string PlanActivityName { get; set; } = null!;
        public string PlanItemName { get; set; } = null!;
        public bool IsPaymentHold { get; set; }
        public string CheckViceChairman { get; set; } = null!;
        public string CheckOfficer { get; set; } = null!;
        public string CheckSecretaryAndComittee { get; set; } = null!;
        public string SuppliesOfficer { get; set; } = null!;
        public bool? IsShowCountTimeOnPrint { get; set; }
        public string DeliveryFormManualText { get; set; } = null!;
        public DateTime? SuppliesOfficerSignDate { get; set; }
        public DateTime? ComitteeCheckDate { get; set; }
        public DateTime? CheckReportWriteDate { get; set; }
        public string RefDocumentNumber { get; set; } = null!;
        public DateTime? RefDocumentDate { get; set; }
        public string CheckReportSupplierName { get; set; } = null!;
        public string CheckReportProcureTypeMethodName { get; set; } = null!;
        public string CheckReportPlanCoreName { get; set; } = null!;
        public int CheckReportAmount { get; set; }
        public decimal CheckReportTotalBill { get; set; }
        public decimal CheckReportLateDeliveryFineValue { get; set; }
        public bool IsByBudgetControl { get; set; }
        public bool IsFinalCheckByBudgetControl { get; set; }
        public bool HasFine { get; set; }
        public bool? IsResultCheckedCorrect { get; set; }
        public string ItemName { get; set; } = null!;
        public string CheckSixthComittee { get; set; } = null!;
        public string CheckSeventhComittee { get; set; } = null!;
        public string CheckEighthComittee { get; set; } = null!;
        public string CheckNinthComittee { get; set; } = null!;

        public virtual Supplier? Supplier { get; set; }
        public virtual ICollection<CheckFormActionLog> CheckFormActionLogs { get; set; }
        public virtual ICollection<CheckItemPlanReferenceItem> CheckItemPlanReferenceItems { get; set; }
        public virtual ICollection<CheckItem> CheckItems { get; set; }
        public virtual ICollection<ProcureFile> ProcureFiles { get; set; }
    }
}
