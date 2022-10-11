using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class AuthorizeForm
    {
        public AuthorizeForm()
        {
            AuFormActionLogs = new HashSet<AuFormActionLog>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? WriteDate { get; set; }
        public DateTime? RequestFormWriteDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public string RequestFormDocumentNumber { get; set; } = null!;
        public bool Active { get; set; }
        public string Inform { get; set; } = null!;
        public int FiscalYear { get; set; }
        public int ProcureTypeEnum { get; set; }
        public string Purpose { get; set; } = null!;
        public string SuppliesOfficer { get; set; } = null!;
        public DateTime? SuppliesOfficerSignDate { get; set; }
        public string SuppliesUnitChief { get; set; } = null!;
        public DateTime? SuppliesUnitChiefSignDate { get; set; }
        public string DepartmentName { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public int ProcureMethodEnum { get; set; }
        public string CheckChairman { get; set; } = null!;
        public string CheckFirstComittee { get; set; } = null!;
        public string CheckSecondComittee { get; set; } = null!;
        public string CheckerComittee { get; set; } = null!;
        public string CheckSecretaryComittee { get; set; } = null!;
        public string CheckChairmanPosition { get; set; } = null!;
        public string CheckFirstComitteePosition { get; set; } = null!;
        public string CheckSecondComitteePosition { get; set; } = null!;
        public string CheckerComitteePosition { get; set; } = null!;
        public string CheckSecretaryComitteePosition { get; set; } = null!;
        public string Objective { get; set; } = null!;
        public int RequestAmount { get; set; }
        public decimal? MedianPrice { get; set; }
        public string ProcureChairman { get; set; } = null!;
        public string ProcureFirstComittee { get; set; } = null!;
        public string ProcureSecondComittee { get; set; } = null!;
        public string ProcureThirdComittee { get; set; } = null!;
        public string ProcureSecretaryComittee { get; set; } = null!;
        public string ProcureChairmanPosition { get; set; } = null!;
        public string ProcureFirstComitteePosition { get; set; } = null!;
        public string ProcureSecondComitteePosition { get; set; } = null!;
        public string ProcureThirdComitteePosition { get; set; } = null!;
        public string ProcureSecretaryComitteePosition { get; set; } = null!;
        public int MedianPriceTypeEnum { get; set; }
        public string OtherMedianPriceType { get; set; } = null!;
        public int? WithInDay { get; set; }
        public string BorrowerName { get; set; } = null!;
        public string BorrowerPosition { get; set; } = null!;
        public decimal? BorrowAmount { get; set; }
        public int RequestFormId { get; set; }
        public decimal TotalBill { get; set; }
        public string ProcureBorrowItem { get; set; } = null!;
        public bool IsConsiderationByLowestPrice { get; set; }
        public bool IsConsiderationByPerformancePerPrice { get; set; }
        public string ContractControlNumber { get; set; } = null!;
        public string CheckFourthComittee { get; set; } = null!;
        public string CheckFifthComittee { get; set; } = null!;
        public string CheckThirdComittee { get; set; } = null!;
        public string ProcureFourthComittee { get; set; } = null!;
        public string ProcureFifthComittee { get; set; } = null!;
        public string CheckFourthComitteePosition { get; set; } = null!;
        public string CheckThirdComitteePosition { get; set; } = null!;
        public string CheckFifthComitteePosition { get; set; } = null!;
        public string ProcureFourthComitteePosition { get; set; } = null!;
        public string ProcureFifthComitteePosition { get; set; } = null!;
        public string CheckSixthComittee { get; set; } = null!;
        public string CheckSeventhComittee { get; set; } = null!;
        public string CheckEighthComittee { get; set; } = null!;
        public string CheckNinthComittee { get; set; } = null!;
        public string CheckSixthComitteePosition { get; set; } = null!;
        public string CheckSeventhComitteePosition { get; set; } = null!;
        public string CheckEighthComitteePosition { get; set; } = null!;
        public string CheckNinthComitteePosition { get; set; } = null!;
        public string BorrowReason { get; set; } = null!;
        public int BorrowEnum { get; set; }

        public virtual RequestForm RequestForm { get; set; } = null!;
        public virtual ICollection<AuFormActionLog> AuFormActionLogs { get; set; }
    }
}
