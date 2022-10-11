using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class ChildTuitionFeeRequestForm
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateByStaffId { get; set; }
        public DateTime? WriteDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public string RequesterName { get; set; } = null!;
        public int RequesterStaffId { get; set; }
        public string RequesterDepartmentName { get; set; } = null!;
        public int RequesterDepartmentId { get; set; }
        public string RequesterPosition { get; set; } = null!;
        public string SpouseName { get; set; } = null!;
        public string SpouseOccupation { get; set; } = null!;
        public int SpouseOccupationTypeEnum { get; set; }
        public string SpousePosition { get; set; } = null!;
        public string SpouseWorkplace { get; set; } = null!;
        public string ChildName { get; set; } = null!;
        public DateTime? ChildDateOfBirth { get; set; }
        public int ChildOrderNumber { get; set; }
        public string School { get; set; } = null!;
        public string SchoolLocation { get; set; } = null!;
        public string Grade { get; set; } = null!;
        public decimal RequestBudget { get; set; }
        public decimal TotalBudget { get; set; }
        public bool IsFullScholarship { get; set; }
        public string AttachmentTypeEnumListValue { get; set; } = null!;
        public string AgreementTypeEnumListValue { get; set; } = null!;
        public string Approver { get; set; } = null!;
        public string ApproverPosition { get; set; } = null!;
        public string ApproverOpinion { get; set; } = null!;
        public int ApprovalStatusEnum { get; set; }
        public DateTime? ApproverSignDate { get; set; }
    }
}
