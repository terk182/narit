using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class ApproveMemorandum
    {
        public ApproveMemorandum()
        {
            ApproveItems = new HashSet<ApproveItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? WriteDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public bool Active { get; set; }
        public string Inform { get; set; } = null!;
        public int FiscalYear { get; set; }
        public int ProcureTypeEnum { get; set; }
        public int ProcureTransformStatusEnum { get; set; }
        public string Purpose { get; set; } = null!;
        public string RequestFormNumber { get; set; } = null!;
        public DateTime? RequestFormDate { get; set; }
        public int RequestFormId { get; set; }
        public int PlanCoreId { get; set; }
        public int PlanTypeId { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
        public string CheckChairman { get; set; } = null!;
        public string CheckFirstComittee { get; set; } = null!;
        public string CheckSecondComittee { get; set; } = null!;
        public string PlanTypeName { get; set; } = null!;
        public string PlanCoreName { get; set; } = null!;
        public string BudgetChecker { get; set; } = null!;
        public string SuppliesUnitChief { get; set; } = null!;
        public string PlanTypeCode { get; set; } = null!;
        public string DepartmentCode { get; set; } = null!;
        public string BudgetTypeCode { get; set; } = null!;
        public string BudgetTypeName { get; set; } = null!;
        public int AgreementMemorandumId { get; set; }
        public string AgreementMemorandumNumber { get; set; } = null!;
        public int FundTypeId { get; set; }
        public string FundTypeName { get; set; } = null!;
        public string CheckThirdComittee { get; set; } = null!;
        public string CheckFourthComittee { get; set; } = null!;
        public string CheckFifthComittee { get; set; } = null!;
        public string CheckSecretaryComittee { get; set; } = null!;
        public int ProcureMethodEnum { get; set; }
        public string CheckSecretaryAndComittee { get; set; } = null!;
        public string ProcureViceChairman { get; set; } = null!;
        public string CheckOfficer { get; set; } = null!;
        public string CheckViceChairman { get; set; } = null!;
        public string SuppliesOfficer { get; set; } = null!;
        public string CheckSixthComittee { get; set; } = null!;
        public string CheckSeventhComittee { get; set; } = null!;
        public string CheckEighthComittee { get; set; } = null!;
        public string CheckNinthComittee { get; set; } = null!;

        public virtual ICollection<ApproveItem> ApproveItems { get; set; }
    }
}
