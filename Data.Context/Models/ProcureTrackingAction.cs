using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class ProcureTrackingAction
    {
        public ProcureTrackingAction()
        {
            OperationFiles = new HashSet<OperationFile>();
            ProcureTrackingRefForms = new HashSet<ProcureTrackingRefForm>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int ProcureTrackingGroupId { get; set; }
        public int ProcureTrackingStepEnum { get; set; }
        public int ProcureTrackingStepGroupEnum { get; set; }
        public DateTime ActionDate { get; set; }
        public string Remark { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public int ProcureTrackingPersonInChargeEnum { get; set; }
        public string Detail { get; set; } = null!;
        public bool HasProblem { get; set; }
        public int ProcureTrackingMethodEnum { get; set; }
        public int ProcureMethodEnum { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsPause { get; set; }
        public DateTime? EndPauseDate { get; set; }
        public DateTime? StartPauseDate { get; set; }
        public DateTime? SpecificEndDate { get; set; }
        public int ProcureFormTypeEnum { get; set; }
        public int? ProcureFormId { get; set; }
        public string ProcureFormDocNumber { get; set; } = null!;

        public virtual ProcureTrackingGroup ProcureTrackingGroup { get; set; } = null!;
        public virtual ICollection<OperationFile> OperationFiles { get; set; }
        public virtual ICollection<ProcureTrackingRefForm> ProcureTrackingRefForms { get; set; }
    }
}
