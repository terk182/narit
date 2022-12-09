using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.FIN.Models.Responses
{
    public class DocumentFormResponse : FinBaseResponse
    {
        public List<DocumentFormData>? data { get; set; }
    }
    public class DocumentFormData 
    {

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public DateTime? WriteDate { get; set; }
        public string Inform { get; set; } = null!;
        public string Enclosures { get; set; } = null!;
        public string Purpose { get; set; } = null!;
        public string RequesterName { get; set; } = null!;
        public DateTime? RequesterSignDate { get; set; }
        public string UnitChiefName { get; set; } = null!;
        public DateTime? UnitChiefSignDate { get; set; }
        public string BudgetCheckerName { get; set; } = null!;
        public DateTime? BudgetCheckerSignDate { get; set; }
        public string Approver { get; set; } = null!;
        public DateTime? ApproverSignDate { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public string DepartmentName { get; set; } = null!;
        public int DepartmentId { get; set; }
        public string PlanTypeName { get; set; } = null!;
        public int PlanTypeId { get; set; }
        public string PlanCoreName { get; set; } = null!;
        public int PlanCoreId { get; set; }
        public string BudgetTypeName { get; set; } = null!;
        public int BudgetTypeId { get; set; }
        public decimal PlanCoreRemainBudget { get; set; }
        public string PlanCoreCode { get; set; } = null!;
        public DateTime? ApprovedDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public int StatementPayStatusEnum { get; set; }
        public decimal? NetPayValue { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public bool IsBorrow { get; set; }
        public bool IsTemporaryInvolve { get; set; }
        public DateTime StatementCalculationDate { get; set; }
        public int PlanActivityIdOld { get; set; }
        public string FundTypeName { get; set; } = null!;
        public int FundTypeId { get; set; }
        public string StatementName { get; set; } = null!;
        public int? RealInvolvePlanItemId { get; set; }
        public int? UsedToInvolvePlanItemId { get; set; }
        public string ReserveByStaffName { get; set; } = null!;
        public string ReserveRemark { get; set; } = null!;
        public string ReserveForecastValue { get; set; } = null!;
        public int? ReserveByStaffId { get; set; }
        public DateTime? ReserveDate { get; set; }
        public bool IsReserve { get; set; }
        public int? DevelopmentRecordGroupId { get; set; }
        public int? OutsideDutyGroupId { get; set; }
        public int? ReserveDepartmentId { get; set; }
        public string ReserveDepartmentName { get; set; } = null!;
        public string SuppliesOfficerName { get; set; } = null!;
        public string HrofficerName { get; set; } = null!;
        public DateTime? SuppliesOfficerSignDate { get; set; }
        public DateTime? HrofficerSignDate { get; set; }
        public string RequesterDepartmentName { get; set; } = null!;
        public string RequesterPositionName { get; set; } = null!;
        public string ProcureRequest { get; set; } = null!;
        public string FirstProcureComittee { get; set; } = null!;
        public string FirstCheckComittee { get; set; } = null!;
        public string OtherRequest { get; set; } = null!;
        public string FirstBorrower { get; set; } = null!;
        public string SecondBorrower { get; set; } = null!;
        public string ThirdBorrower { get; set; } = null!;
        public decimal FirstBorrowAmount { get; set; }
        public decimal SecondBorrowAmount { get; set; }
        public decimal ThirdBorrowAmount { get; set; }
        public string FirstBorrowerPosition { get; set; } = null!;
        public string ThirdBorrowerPosition { get; set; } = null!;
        public string SecondBorrowerPosition { get; set; } = null!;
        public string FirstBorrowerDepartment { get; set; } = null!;
        public string SecondBorrowerDepartment { get; set; } = null!;
        public string ThirdBorrowerDepartment { get; set; } = null!;
        public string FourthBorrower { get; set; } = null!;
        public decimal FourthBorrowAmount { get; set; }
        public string FourthBorrowerPosition { get; set; } = null!;
        public string FourthBorrowerDepartment { get; set; } = null!;
        public string FifthBorrower { get; set; } = null!;
        public decimal FifthBorrowAmount { get; set; }
        public string FifthBorrowerPosition { get; set; } = null!;
        public string FifthBorrowerDepartment { get; set; } = null!;
        public int RequestDepartmentId { get; set; }
        public string RequestDepartmentName { get; set; } = null!;
        public int SettleDay { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? StartCountingDate { get; set; }
        public int? UnitChiefStaffId { get; set; }
        public int? ApproverStaffId { get; set; }
        public int PlanFormApprovalStatusEnum { get; set; }
        public bool IsHidden { get; set; }
        public string ScheduleTitle { get; set; } = null!;
        public string RelatedRegulation { get; set; } = null!;
        public int? ApproverSignatureId { get; set; }
        public int? UnitChiefSignatureId { get; set; }
        public int? SuppliesOfficerSignatureId { get; set; }
        public int? ProjectManagerSignatureId { get; set; }
        public int? BudgetCheckerSignatureId { get; set; }
        public int? SuppliesOfficerStaffId { get; set; }
        public int? ProjectManagerStaffId { get; set; }
        public int? RequesterStaffId { get; set; }
        public int? BudgetCheckerStaffId { get; set; }
        public int? RequesterSignatureId { get; set; }
        public string ProjectManager { get; set; } = null!;
        public DateTime? ProjectManagerSignDate { get; set; }
        public int? HrofficerStaffId { get; set; }
        public int? HrofficerSignatureId { get; set; }
        public int? ProjectManager1SignatureId { get; set; }
        public string ProjectManager1 { get; set; } = null!;
        public DateTime? ProjectManager1SignDate { get; set; }
        public int? ProjectManager1StaffId { get; set; }
        public int? ProjectManager2SignatureId { get; set; }
        public string ProjectManager2 { get; set; } = null!;
        public DateTime? ProjectManager2SignDate { get; set; }
        public int? ProjectManager2StaffId { get; set; }
        public int? ProjectManager3SignatureId { get; set; }
        public string ProjectManager3 { get; set; } = null!;
        public DateTime? ProjectManager3SignDate { get; set; }
        public int? ProjectManager3StaffId { get; set; }
        public int? ProjectManager4SignatureId { get; set; }
        public string ProjectManager4 { get; set; } = null!;
        public DateTime? ProjectManager4SignDate { get; set; }
        public int? ProjectManager4StaffId { get; set; }
        public string UnitChiefPosition { get; set; } = null!;
        public string BudgetCheckerPosition { get; set; } = null!;
        public string ApproverPosition { get; set; } = null!;
        public string SuppliesOfficerPosition { get; set; } = null!;
        public string HrofficerPosition { get; set; } = null!;
        public string ProjectManager1Position { get; set; } = null!;
        public string ProjectManager2Position { get; set; } = null!;
        public string ProjectManager3Position { get; set; } = null!;
        public string ProjectManager4Position { get; set; } = null!;
        public bool IsApproveInstead { get; set; }
        public string DocCheckerName { get; set; } = null!;
        public string DocCheckerPosition { get; set; } = null!;
        public DateTime? DocCheckerSignDate { get; set; }
        public int? DocCheckerStaffId { get; set; }
        public int? DocCheckerSignatureId { get; set; }
        public bool IsSent { get; set; }
        public string FirstBorrowerPositionTypeName { get; set; } = null!;
        public string SecondBorrowerPositionTypeName { get; set; } = null!;
        public string ThirdBorrowerPositionTypeName { get; set; } = null!;
        public string FourthBorrowerPositionTypeName { get; set; } = null!;
        public string FifthBorrowerPositionTypeName { get; set; } = null!;
        //public decimal TotalBudget { get; set; }

    }
}
