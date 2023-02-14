using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class RequestForm
    {
        public RequestForm()
        {
            RequestFormApproves = new HashSet<RequestFormApprove>();
            RequestFormItems = new HashSet<RequestFormItem>();
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

        public virtual RequestBudget RequestBudget { get; set; } = null!;
        public virtual ICollection<RequestFormApprove> RequestFormApproves { get; set; }
        public virtual ICollection<RequestFormItem> RequestFormItems { get; set; }
    }
}
