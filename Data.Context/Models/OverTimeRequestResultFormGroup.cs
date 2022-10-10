using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class OverTimeRequestResultFormGroup
    {
        public OverTimeRequestResultFormGroup()
        {
            OverTimeRequestForms = new HashSet<OverTimeRequestForm>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public DateTime? WriteDate { get; set; }
        public string Inform { get; set; } = null!;
        public string WriteAt { get; set; } = null!;
        public string Approver { get; set; } = null!;
        public DateTime? ApproverSignDate { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ApproverPosition { get; set; } = null!;
        public string DocumentNumber { get; set; } = null!;
        public string ApproverOpinion { get; set; } = null!;
        public int? ApproverId { get; set; }
        public int OverTimeRequestFormGroupId { get; set; }
        public decimal? TotalBudget { get; set; }

        public virtual OverTimeRequestFormGroup OverTimeRequestFormGroup { get; set; } = null!;
        public virtual ICollection<OverTimeRequestForm> OverTimeRequestForms { get; set; }
    }
}
