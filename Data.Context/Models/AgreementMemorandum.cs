using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class AgreementMemorandum
    {
        public AgreementMemorandum()
        {
            AgreementItems = new HashSet<AgreementItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? WriteDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public bool Active { get; set; }
        public string Inform { get; set; } = null!;
        public int FiscalYear { get; set; }
        public int DepartmentId { get; set; }
        public int PlanTypeId { get; set; }
        public int PlanCoreId { get; set; }
        public string DepartmentName { get; set; } = null!;
        public int ProcureTypeEnum { get; set; }
        public string Requirement { get; set; } = null!;
        public int ProcureTransformStatusEnum { get; set; }
        public int RequestFormId { get; set; }
        public string RequestFormNumber { get; set; } = null!;
        public DateTime? RequestFormDate { get; set; }
        public int ProcureMethodEnum { get; set; }

        public virtual ICollection<AgreementItem> AgreementItems { get; set; }
    }
}
