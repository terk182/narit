using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Requests
{
    public class RequestBudgetRequests
    {
        public int Id { get; set; }
        public int? DocYear { get; set; }
        public string DocNo { get; set; } = null!;
        public string? DocStatus { get; set; }
        public bool? Active { get; set; }
        public string? Name { get; set; }
        public string? Inform { get; set; }
        public string? Descriptions { get; set; }
        public DateTime? WriteDate { get; set; }
        public DateTime? DateTime { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? CalculationDate { get; set; }
        public string? StatmentName { get; set; }
        public string? RelatedRegulation { get; set; }
        public string? CreateByStaffId { get; set; }
        public string? FilePath { get; set; }
        public int? DepartmentId { get; set; }
        public decimal? TotalBudget { get; set; }
        public string? AnotherAction { get; set; }
        public string? Procurement { get; set; }
        public int? InspectorId { get; set; }
        public string? InspectorName { get; set; }
        public string? ProcurementByStaff { get; set; }
    }
    public class RequestFormRequests
    {
        public int Id { get; set; }
        public string DocNo { get; set; } = null!;
        public int RequestBudgetId { get; set; }
        public int? BudgetTypeId { get; set; }
        public int? ProjectId { get; set; }
        public int? ProjectActivityId { get; set; }
        public bool? Active { get; set; }
        public string? Name { get; set; }
        public string? Descriptions { get; set; }
        public string? Objective { get; set; }
        public DateTime? StartDepartureDate { get; set; }
        public DateTime? EndDepartureDate { get; set; }
        public DateTime? StartPracticalDate { get; set; }
        public DateTime? EndPracticalDate { get; set; }
        public DateTime? DateTime { get; set; }
        public bool? WorkingInCountry { get; set; }
        public string? Location { get; set; }
        public string? Place { get; set; }
        public string? Country { get; set; }
        public string? Remark { get; set; }
        public string? PersonRemark { get; set; }
        public string? MakeBy { get; set; }
        public string? Lecturer { get; set; }
        public string? SkillType { get; set; }
        public string? Reward { get; set; }
    }
    public class RequestFormItemsRequests
    {
        public int Id { get; set; }
        public string DocNo { get; set; } = null!;
        public int RequestFormId { get; set; }
        public int? LbActivityId { get; set; }
        public string? Name { get; set; }
        public string? Descriptions { get; set; }
        public bool? Active { get; set; }
        public decimal? Price { get; set; }
        public decimal? TotalBudget { get; set; }
        public string? Unit { get; set; }
        public string? Remark { get; set; }
    }
    public class RequestFormApproveRequests
    {
        public int Id { get; set; }
        public string DocNo { get; set; } = null!;
        public int RequestFormId { get; set; }
        public bool? Active { get; set; }
        public int? JobPositionId { get; set; }
        public int? DepartmentId { get; set; }
        public string? StaffId { get; set; }
        public string? StaffName { get; set; }
        public bool? StatusApprove { get; set; }
        public DateTime? DatetimeApprove { get; set; }

    }
    public class RequestFormCommentRequests
    {
        public int Id { get; set; }
        public string DocNo { get; set; } = null!;
        public int RequestBudgetId { get; set; }
        public DateTime? DateTime { get; set; }
        public int? StaffId { get; set; }
        public string? StaffName { get; set; }
        public string? Comment { get; set; }
        public string? Descriptions { get; set; }
        public bool? Active { get; set; }
        public string? Status { get; set; }
    }
    public class RequestFormBorrowingMoneyRequests
    {
        public int Id { get; set; }
        public string DocNo { get; set; } = null!;
        public int RequestBudgetId { get; set; }
        public DateTime? DateTime { get; set; }
        public int? StaffId { get; set; }
        public string? StaffName { get; set; }
        public decimal? RequestLoan { get; set; }
        public bool? Active { get; set; }

    }
    public class RequestFormExaminerForBudgetRequests
    {
        public int Id { get; set; }
        public string DocNo { get; set; } = null!;
        public int RequestBudgetId { get; set; }
        public string? Name { get; set; }
        public string? Descriptions { get; set; }
        public bool? Active { get; set; }
        public string? ExaminerRole { get; set; }
        public int? JobPositionId { get; set; }
        public int? DepartmentId { get; set; }
        public int? RebudgetId { get; set; }
        public int? StaffId { get; set; }
        public string? StaffName { get; set; }
    }
    public class RequestFormScheduleRequests
    {
        public int Id { get; set; }
        public string DocNo { get; set; } = null!;
        public int RequestBudgetId { get; set; }
        public bool? Active { get; set; }
        public string? Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public string? Remark { get; set; }
    }
}
