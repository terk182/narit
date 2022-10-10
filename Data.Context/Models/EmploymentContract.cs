using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class EmploymentContract
    {
        public EmploymentContract()
        {
            ContractEndEvaluationForms = new HashSet<ContractEndEvaluationForm>();
            Hrfiles = new HashSet<Hrfile>();
            ProbationEvaluationForms = new HashSet<ProbationEvaluationForm>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime? SentMailDate { get; set; }
        public DateTime? SentMailToHrdate { get; set; }
        public bool IsRenew { get; set; }
        public int StaffId { get; set; }
        public bool IsProbation { get; set; }

        public virtual Staff Staff { get; set; } = null!;
        public virtual ICollection<ContractEndEvaluationForm> ContractEndEvaluationForms { get; set; }
        public virtual ICollection<Hrfile> Hrfiles { get; set; }
        public virtual ICollection<ProbationEvaluationForm> ProbationEvaluationForms { get; set; }
    }
}
