using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.FIN.Models.Responses
{
    public class ViewRequestFormListResponse : FinBaseResponse
    {
        public List<RequestFormDto>? data { get; set; }
    }
    public class RequestFormDto 
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? WriteDate { get; set; }
        public string? WriteAt { get; set; } 
        public string? Purpose { get; set; } 
        public bool Active { get; set; }
        public string? Inform { get; set; }
        public string? DocumentNumber { get; set; }
        public int FiscalYear { get; set; }
        public int ProcureTypeEnum { get; set; }
        public int ProcureMethodEnum { get; set; }
        public string? DepartmentName { get; set; }
        public string? PlanTypeName { get; set; }
        public string? Enclosure { get; set; } 
        public string? OtherProcureMethodName { get; set; }
        public string? PlanCoreName { get; set; }
        public string BudgetTypeName { get; set; } = null!;
        public string ProcureChairman { get; set; } = null!;
        public string ProcureFirstComittee { get; set; } = null!;
        public string ProcureSecondComittee { get; set; } = null!;
        public string CheckChairman { get; set; } = null!;
        public string CheckFirstComittee { get; set; } = null!;
        public string CheckSecondComittee { get; set; } = null!;
        public string Requester { get; set; } = null!;
        public DateTime? RequesterSignDate { get; set; }
        public string UnitChief { get; set; } = null!;
        public DateTime? UnitChiefSignDate { get; set; }
        public string BudgetChecker { get; set; } = null!;
        public DateTime BudgetCheckerSignDate { get; set; }
        public string SuppliesOfficer { get; set; } = null!;
        public string SuppliesUnitChief { get; set; } = null!;
        public string? SuppliesUnitChiefSignDate { get; set; }
        public int PlanCoreId { get; set; }
        public int PlanTypeId { get; set; }
        public int DepartmentId { get; set; }
        public int ProcureApprovalStatusEnum { get; set; }
        public int ProcureTransformStatusEnum { get; set; }
        public int? WithInDay { get; set; }
        public int FundTypeId { get; set; }
        public string FundTypeName { get; set; } = null!;
        public int PlanActivityIdOld { get; set; }
        public string PlanActivityName { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public DateTime? WithInDate { get; set; }
        public string StatementName { get; set; } = null!;
        public string CheckThirdComittee { get; set; } = null!;
        public string CheckFourthComittee { get; set; } = null!;
        public string CheckFifthComittee { get; set; } = null!;
        public string CheckSecretaryComittee { get; set; } = null!;
        public string ProcureThirdComittee { get; set; } = null!;
        public string ProcureFourthComittee { get; set; } = null!;
        public string ProcureFifthComittee { get; set; } = null!;
        public string ProcureSecretaryComittee { get; set; } = null!;
        public bool IsForeign { get; set; }
        public bool IsUrgent { get; set; }
        public int BudgetTypeEnum { get; set; }
        public string Topic { get; set; } = null!;
        public string ProcureViceChairman { get; set; } = null!;
        public string CheckViceChairman { get; set; } = null!;
        public string CheckSecretaryAndComittee { get; set; } = null!;
        public string ProcureSecretaryAndComittee { get; set; } = null!;
        public string RequesterPosition { get; set; } = null!;
        public string UnitChiefPosition { get; set; } = null!;
        public decimal? MedianPrice { get; set; }
        public int RequestDepartmentId { get; set; }
        public string RequestDepartmentName { get; set; } = null!;
        public bool IsContinuousProject { get; set; }
        public string CheckSixthComittee { get; set; } = null!;
        public string CheckSeventhComittee { get; set; } = null!;
        public string CheckEighthComittee { get; set; }
        public string CheckNinthComittee { get; set; } 
        public int ProcureFormApprovalStatusEnum { get; set; }
        public int? RequesterStaffId { get; set; }
        public int? DocCheckerStaffId { get; set; }
        public int? UnitChiefStaffId { get; set; }
        public int? ProjectManagerStaffId { get; set; }
        public int? BudgetCheckerStaffId { get; set; }
        public int? SuppliesUnitChiefStaffId { get; set; }
        public bool IsSent { get; set; }
        public DateTime? ProjectManagerSignDate { get; set; }
        public string ProjectManager { get; set; }
        public string ProjectManagerPosition { get; set; }
        public int? UnitChiefSignatureId { get; set; }
        public int? ProjectManagerSignatureId { get; set; }
        public int? RequesterSignatureId { get; set; }
        public int? BudgetCheckerSignatureId { get; set; }
        public int? SuppliesUnitChiefSignatureId { get; set; }
        public string BudgetCheckerPosition { get; set; } 
        public string SuppliesOfficerPosition { get; set; } 

 
    }

}
