using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class OrderForm
    {
        public OrderForm()
        {
            OrFormActionLogs = new HashSet<OrFormActionLog>();
            OrderContracts = new HashSet<OrderContract>();
            OrderItemPlanReferenceItems = new HashSet<OrderItemPlanReferenceItem>();
            OrderItems = new HashSet<OrderItem>();
            ProcureContracts = new HashSet<ProcureContract>();
            ProcureFiles = new HashSet<ProcureFile>();
            Quotations = new HashSet<Quotation>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? WriteDate { get; set; }
        public string Inform { get; set; } = null!;
        public string DocumentNumber { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int ProcureTypeEnum { get; set; }
        public string QuotationNumber { get; set; } = null!;
        public DateTime? QuotationDate { get; set; }
        public string DepartmentName { get; set; } = null!;
        public int? SupplierId { get; set; }
        public int DeliveryDay { get; set; }
        public int PaymentDay { get; set; }
        public string RequestFormNumber { get; set; } = null!;
        public DateTime? RequestFormDate { get; set; }
        public int RequestFormId { get; set; }
        public string DeliveryPlace { get; set; } = null!;
        public string Orderer { get; set; } = null!;
        public int ProcureTransformStatusEnum { get; set; }
        public string CheckFirstComittee { get; set; } = null!;
        public string CheckSecondComittee { get; set; } = null!;
        public string CheckChairman { get; set; } = null!;
        public string BudgetTypeName { get; set; } = null!;
        public string PlanCoreName { get; set; } = null!;
        public string PlanTypeName { get; set; } = null!;
        public string BudgetTypeCode { get; set; } = null!;
        public string DepartmentCode { get; set; } = null!;
        public string PlanTypeCode { get; set; } = null!;
        public int PlanTypeId { get; set; }
        public int DepartmentId { get; set; }
        public int PlanCoreId { get; set; }
        public int? ApproveFormId { get; set; }
        public int? ApproveMemorandumId { get; set; }
        public string BudgetChecker { get; set; } = null!;
        public string SuppliesUnitChief { get; set; } = null!;
        public string SupplierName { get; set; } = null!;
        public string ApproveFormNumber { get; set; } = null!;
        public DateTime? ApproveFormDate { get; set; }
        public int FundTypeId { get; set; }
        public string FundTypeName { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public string CheckThirdComittee { get; set; } = null!;
        public string CheckFourthComittee { get; set; } = null!;
        public string CheckFifthComittee { get; set; } = null!;
        public string CheckSecretaryComittee { get; set; } = null!;
        public int ProcureMethodEnum { get; set; }
        public string CountStartReason { get; set; } = null!;
        public DateTime? DeliveryStartDate { get; set; }
        public string SupplierAddress { get; set; } = null!;
        public string SupplierTaxNumber { get; set; } = null!;
        public string SupplierTelNumber { get; set; } = null!;
        public string SupplierFaxNumber { get; set; } = null!;
        public int? CountMethodEnum { get; set; }
        public string CheckViceChairman { get; set; } = null!;
        public string CheckOfficer { get; set; } = null!;
        public string CheckSecretaryAndComittee { get; set; } = null!;
        public string SuppliesOfficer { get; set; } = null!;
        public decimal FineRate { get; set; }
        public string Remark { get; set; } = null!;
        public int? WarrantyDay { get; set; }
        public int? WarrantyMonth { get; set; }
        public int? WarrantyYear { get; set; }
        public DateTime? DeliveryEndDate { get; set; }
        public string ProjectControlNumber { get; set; } = null!;
        public string ContractControlNumber { get; set; } = null!;
        public decimal? MedianPrice { get; set; }
        public int ConsiderateConditionEnum { get; set; }
        public string Topic { get; set; } = null!;
        public string CheckSixthComittee { get; set; } = null!;
        public string CheckSeventhComittee { get; set; } = null!;
        public string CheckEighthComittee { get; set; } = null!;
        public string CheckNinthComittee { get; set; } = null!;
        public int? CheckChairmanStaffId { get; set; }
        public int? CheckFirstComitteeStaffId { get; set; }
        public int? CheckSecondComitteeStaffId { get; set; }
        public int? CheckThirdComitteeStaffId { get; set; }
        public int? CheckFourthComitteeStaffId { get; set; }
        public int? CheckFifthComitteeStaffId { get; set; }
        public int? CheckSecretaryComitteeStaffId { get; set; }
        public int? CheckSecretaryAndComitteeStaffId { get; set; }
        public int? SuppliesOfficerStaffId { get; set; }
        public int? CheckViceChairmanStaffId { get; set; }
        public int? CheckOfficerStaffId { get; set; }
        public int? CheckSixthComitteeStaffId { get; set; }
        public int? CheckSeventhComitteeStaffId { get; set; }
        public int? CheckEighthComitteeStaffId { get; set; }
        public int? CheckNinthComitteeStaffId { get; set; }

        public virtual Supplier? Supplier { get; set; }
        public virtual ICollection<OrFormActionLog> OrFormActionLogs { get; set; }
        public virtual ICollection<OrderContract> OrderContracts { get; set; }
        public virtual ICollection<OrderItemPlanReferenceItem> OrderItemPlanReferenceItems { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<ProcureContract> ProcureContracts { get; set; }
        public virtual ICollection<ProcureFile> ProcureFiles { get; set; }
        public virtual ICollection<Quotation> Quotations { get; set; }
    }
}
