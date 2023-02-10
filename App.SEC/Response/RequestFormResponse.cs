using App.Common.Dtos;
using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Responses
{
    public class RequestFormResponse
    {
        public int Id { get; set; }
        public string DocNo { get; set; } = null!;
        public int? RequestBudgetId { get; set; }
        public int? BudgetTypeId { get; set; }
        public int? ProjectId { get; set; }
        public int? ProjectActivityId { get; set; }
        public bool? Active { get; set; }
        public string? Name { get; set; }
        public string? Descriptions { get; set; }
        public string? Objective { get; set; }
        public DateTime? DepartureDate { get; set; }
        public DateTime? PracticalDay { get; set; }
        public DateTime? DateTime { get; set; }
        public bool? WorkingIncountry { get; set; }
        public string? Location { get; set; }
        public string? Place { get; set; }
        public string? Country { get; set; }
        public string? Remark { get; set; }
        public string? PersonRemark { get; set; }
        public string? MakeBy { get; set; }
        public string? Lecturer { get; set; }
        public string? Reward { get; set; }
        public List<FormApproveResponse>? formApprove { get; set; }
        public List<FormItemsResponse>? formItems { get; set; }
        public List<FormCommentResponse>? formComment { get; set; }

    }

    public class FormItemsResponse
    {
        public int? Id { get; set; }
        public string DocNo { get; set; }
        public int? RequestFormId { get; set; }
        public string? Name { get; set; }
        public string? Descriptions { get; set; }
        public bool? Active { get; set; }
        public decimal? Price { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? Unit { get; set; }
        public decimal? TotalUnit { get; set; }
        public string? Remark { get; set; }
        public int? LbActivityId { get; set; }

    }

    public class FormApproveResponse
    {
        public int Id { get; set; }
        public string DocNo { get; set; }
        public int? RequestFormId { get; set; }
        public string? Name { get; set; }
        public int? JobPositionId { get; set; }
        public int? DepartmentId { get; set; }
        public DateTime? DatetimeApprove { get; set; }
    }

    public class FormCommentResponse
    {
        public int Id { get; set; }
        public int? RequestFormId { get; set; }
        public string DocNo { get; set; }
        public DateTime? DateTime { get; set; }
        public string? StaffId { get; set; }
        public string? StaffName { get; set; }
        public string? Comment { get; set; }
        public string? Descriptions { get; set; }
    }
}
