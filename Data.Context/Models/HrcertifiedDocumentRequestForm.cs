using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class HrcertifiedDocumentRequestForm
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public string RequesterName { get; set; } = null!;
        public string DocumentNumber { get; set; } = null!;
        public int RequesterStaffId { get; set; }
        public string RequesterDepartmentName { get; set; } = null!;
        public int RequesterDepartmentId { get; set; }
        public string RequesterPosition { get; set; } = null!;
        public string Other { get; set; } = null!;
        public string Purpose { get; set; } = null!;
        public DateTime? TakenDate { get; set; }
        public DateTime? WriteDate { get; set; }
        public int CreateByStaffId { get; set; }
        public DateTime CreateDate { get; set; }
        public string HrcertifiedDocTypeEnumListValue { get; set; } = null!;
        public string Approver { get; set; } = null!;
        public DateTime? ApproverSignDate { get; set; }
        public int ApprovalStatusEnum { get; set; }
        public string ApproverPosition { get; set; } = null!;
        public string ApproverOpinion { get; set; } = null!;
        public string Receiver { get; set; } = null!;
    }
}
