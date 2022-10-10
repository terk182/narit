using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class AgreementForm
    {
        public AgreementForm()
        {
            AgreementItemPlanReferenceItems = new HashSet<AgreementItemPlanReferenceItem>();
            AgreementItems = new HashSet<AgreementItem>();
            ProcureFiles = new HashSet<ProcureFile>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? WriteDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public bool Active { get; set; }
        public string Inform { get; set; } = null!;
        public string DepartmentName { get; set; } = null!;
        public string Requirement { get; set; } = null!;
        public int RequestFormId { get; set; }
        public string RequestFormNumber { get; set; } = null!;
        public DateTime? RequestFormDate { get; set; }
        public int ProcureMethodEnum { get; set; }
        public string Purpose { get; set; } = null!;
        public string CheckChairman { get; set; } = null!;
        public string CheckFirstComittee { get; set; } = null!;
        public string CheckSecondComittee { get; set; } = null!;
        public string SuppliesOfficer { get; set; } = null!;
        public DateTime? SuppliesOfficerSignDate { get; set; }
        public string SuppliesUnitChief { get; set; } = null!;
        public DateTime? SuppliesUnitChiefSignDate { get; set; }
        public string Approver { get; set; } = null!;
        public DateTime? ApproverSignDate { get; set; }
        public int ProcureTypeEnum { get; set; }
        public int FiscalYear { get; set; }
        public int DepartmentId { get; set; }
        public int PlanTypeId { get; set; }
        public int PlanCoreId { get; set; }
        public int ProcureTransformStatusEnum { get; set; }
        public string PlanTypeName { get; set; } = null!;
        public string PlanCoreName { get; set; } = null!;
        public string BudgetChecker { get; set; } = null!;
        public int FundTypeId { get; set; }
        public string FundTypeName { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public string OtherProcureMethodName { get; set; } = null!;
        public string CheckThirdComittee { get; set; } = null!;
        public string CheckFourthComittee { get; set; } = null!;
        public string CheckFifthComittee { get; set; } = null!;
        public string CheckSecretaryComittee { get; set; } = null!;
        public string ProcureThirdComittee { get; set; } = null!;
        public string ProcureFourthComittee { get; set; } = null!;
        public string ProcureFifthComittee { get; set; } = null!;
        public string ProcureSecretaryComittee { get; set; } = null!;
        public string ProcureChairman { get; set; } = null!;
        public string ProcureFirstComittee { get; set; } = null!;
        public string ProcureSecondComittee { get; set; } = null!;
        public string CheckSecretaryAndComittee { get; set; } = null!;
        public string ProcureSecretaryAndComittee { get; set; } = null!;
        public string ProcureViceChairman { get; set; } = null!;
        public string CheckViceChairman { get; set; } = null!;
        public string CheckSixthComittee { get; set; } = null!;
        public string CheckSeventhComittee { get; set; } = null!;
        public string CheckEighthComittee { get; set; } = null!;
        public string CheckNinthComittee { get; set; } = null!;

        public virtual ICollection<AgreementItemPlanReferenceItem> AgreementItemPlanReferenceItems { get; set; }
        public virtual ICollection<AgreementItem> AgreementItems { get; set; }
        public virtual ICollection<ProcureFile> ProcureFiles { get; set; }
    }
}
