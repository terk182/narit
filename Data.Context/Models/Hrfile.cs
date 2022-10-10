using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class Hrfile
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int Size { get; set; }
        public string Path { get; set; } = null!;
        public DateTime UploadDate { get; set; }
        public int? UploadUserId { get; set; }
        public string Type { get; set; } = null!;
        public int? LeaveId { get; set; }
        public int? DevelopmentRecordGroupId { get; set; }
        public int? OutsideDutyGroupId { get; set; }
        public int? MedicalReimbursementId { get; set; }
        public int? EmploymentContractId { get; set; }

        public virtual DevelopmentRecordGroup? DevelopmentRecordGroup { get; set; }
        public virtual EmploymentContract? EmploymentContract { get; set; }
        public virtual Leaf? Leave { get; set; }
        public virtual MedicalReimbursement? MedicalReimbursement { get; set; }
        public virtual OutsideDutyGroup? OutsideDutyGroup { get; set; }
    }
}
