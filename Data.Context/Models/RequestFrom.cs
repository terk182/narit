﻿using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class RequestFrom
    {
        public RequestFrom()
        {
            RequestFormApproves = new HashSet<RequestFormApprove>();
            RequestFormComments = new HashSet<RequestFormComment>();
            RequestFormExaminerForBudgets = new HashSet<RequestFormExaminerForBudget>();
            RequestFormItems = new HashSet<RequestFormItem>();
            RequestFormSchedules = new HashSet<RequestFormSchedule>();
        }

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
        public DateTime? DepartureDate { get; set; }
        public DateTime? PracticalDate { get; set; }
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

        public virtual ICollection<RequestFormApprove> RequestFormApproves { get; set; }
        public virtual ICollection<RequestFormComment> RequestFormComments { get; set; }
        public virtual ICollection<RequestFormExaminerForBudget> RequestFormExaminerForBudgets { get; set; }
        public virtual ICollection<RequestFormItem> RequestFormItems { get; set; }
        public virtual ICollection<RequestFormSchedule> RequestFormSchedules { get; set; }
    }
}
