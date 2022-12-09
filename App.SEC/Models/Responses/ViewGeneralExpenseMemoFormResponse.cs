using App.SEC.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Responses
{
    public class ViewGeneralExpenseMemoFormResponse : SecBaseResponse
    {
        public List<GeneralExpenseMemoDto>? data { get; set; }   
    }
    public class GeneralExpenseMemoDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public DateTime? WriteDate { get; set; }
        public string? Inform { get; set; }
        public string? Enclosures { get; set; }
        public string? Purpose { get; set; }
        public string? RequesterName { get; set; }
        public DateTime? RequesterSignDate { get; set; }
        public string? UnitChiefName { get; set; }
        public DateTime? UnitChiefSignDate { get; set; }
        public string? BudgetCheckerName { get; set; }
        public DateTime? BudgetCheckerSignDate { get; set; }
        public string? Approver { get; set; }
        public DateTime? ApproverSignDate { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public string? DepartmentName { get; set; }
        public int DepartmentId { get; set; }
        public string? PlanTypeName { get; set; }
        public int PlanTypeId { get; set; }
        public string? PlanCoreName { get; set; }
        public int PlanCoreId { get; set; }
        public string? BudgetTypeName { get; set; }
        public int BudgetTypeId { get; set; }
        public decimal PlanCoreRemainBudget { get; set; }
        public string? PlanCoreCode { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string? DocumentNumber { get; set; }
        public int StatementPayStatusEnum { get; set; }
        public decimal? NetPayValue { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public bool IsBorrow { get; set; }
        public bool IsTemporaryInvolve { get; set; }
        public DateTime StatementCalculationDate { get; set; }
        public int PlanActivityIdOld { get; set; }
        public string? FundTypeName { get; set; }
        public int FundTypeId { get; set; }
        public string? StatementName { get; set; }
        public int? RealInvolvePlanItemId { get; set; }
        public int? UsedToInvolvePlanItemId { get; set; }
        public string? ReserveByStaffName { get; set; }
        public string? ReserveRemark { get; set; }
        public string? ReserveForecastValue { get; set; }
        public int? ReserveByStaffId { get; set; }
        public DateTime? ReserveDate { get; set; }
        public bool IsReserve { get; set; }
        public int? DevelopmentRecordGroupId { get; set; }
        public int? OutsideDutyGroupId { get; set; }
        public int? ReserveDepartmentId { get; set; }
        public string? ReserveDepartmentName { get; set; }
        public string? SuppliesOfficerName { get; set; }
        public string? HrofficerName { get; set; }
        public DateTime? SuppliesOfficerSignDate { get; set; }
        public DateTime? HrofficerSignDate { get; set; }
        public string? RequesterDepartmentName { get; set; }
        public string? RequesterPositionName { get; set; }
        public string? ProcureRequest { get; set; }
        public string? FirstProcureComittee { get; set; }
        public string? FirstCheckComittee { get; set; }
        public string? OtherRequest { get; set; }
        public string? FirstBorrower { get; set; }
        public string? SecondBorrower { get; set; }
        public string? ThirdBorrower { get; set; }
        public decimal FirstBorrowAmount { get; set; }
        public decimal SecondBorrowAmount { get; set; }
        public decimal ThirdBorrowAmount { get; set; }
        public string? FirstBorrowerPosition { get; set; }
        public string? ThirdBorrowerPosition { get; set; }
        public string? SecondBorrowerPosition { get; set; }
        public string? FirstBorrowerDepartment { get; set; }
        public string? SecondBorrowerDepartment { get; set; }
        public string? ThirdBorrowerDepartment { get; set; }
        public string? FourthBorrower { get; set; }
        public decimal FourthBorrowAmount { get; set; }
        public string? FourthBorrowerPosition { get; set; }
        public string? FourthBorrowerDepartment { get; set; }
        public string? FifthBorrower { get; set; }
        public decimal FifthBorrowAmount { get; set; }
        public string? FifthBorrowerPosition { get; set; }
        public string? FifthBorrowerDepartment { get; set; }
        public int RequestDepartmentId { get; set; }
        public string? RequestDepartmentName { get; set; }
        public int SettleDay { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? StartCountingDate { get; set; }
        public int? UnitChiefStaffId { get; set; }
        public int? ApproverStaffId { get; set; }
        public int PlanFormApprovalStatusEnum { get; set; }
        public bool IsHidden { get; set; }
        public string? ScheduleTitle { get; set; }
        public string? RelatedRegulation { get; set; }
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
        public string? ProjectManager { get; set; }
        public DateTime? ProjectManagerSignDate { get; set; }
        public int? HrofficerStaffId { get; set; }
        public int? HrofficerSignatureId { get; set; }
        public int? ProjectManager1SignatureId { get; set; }
        public string? ProjectManager1 { get; set; }
        public DateTime? ProjectManager1SignDate { get; set; }
        public int? ProjectManager1StaffId { get; set; }
        public int? ProjectManager2SignatureId { get; set; }
        public string? ProjectManager2 { get; set; }
        public DateTime? ProjectManager2SignDate { get; set; }
        public int? ProjectManager2StaffId { get; set; }
        public int? ProjectManager3SignatureId { get; set; }
        public string? ProjectManager3 { get; set; }
        public DateTime? ProjectManager3SignDate { get; set; }
        public int? ProjectManager3StaffId { get; set; }
        public int? ProjectManager4SignatureId { get; set; }
        public string? ProjectManager4 { get; set; }
        public DateTime? ProjectManager4SignDate { get; set; }
        public int? ProjectManager4StaffId { get; set; }
        public string? UnitChiefPosition { get; set; }
        public string? BudgetCheckerPosition { get; set; }
        public string? ApproverPosition { get; set; }
        public string? SuppliesOfficerPosition { get; set; }
        public string? HrofficerPosition { get; set; }
        public string? ProjectManager1Position { get; set; }
        public string? ProjectManager2Position { get; set; }
        public string? ProjectManager3Position { get; set; }
        public string? ProjectManager4Position { get; set; }
        public bool IsApproveInstead { get; set; }
        public string? DocCheckerName { get; set; }
        public string? DocCheckerPosition { get; set; }
        public DateTime? DocCheckerSignDate { get; set; }
        public int? DocCheckerStaffId { get; set; }
        public int? DocCheckerSignatureId { get; set; }
        public bool IsSent { get; set; }
        public string? FirstBorrowerPositionTypeName { get; set; }
        public string? SecondBorrowerPositionTypeName { get; set; }
        public string? ThirdBorrowerPositionTypeName { get; set; }
        public string? FourthBorrowerPositionTypeName { get; set; }
        public string? FifthBorrowerPositionTypeName { get; set; }
    }
}
