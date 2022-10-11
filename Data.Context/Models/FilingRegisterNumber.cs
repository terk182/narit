using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class FilingRegisterNumber
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public DateTime? DateUsed { get; set; }
        public int? FilingDocumentId { get; set; }
        public int FilingRegisterBookId { get; set; }
        public string CreatorName { get; set; } = null!;
        public int CreatorId { get; set; }
        public string UsedByStaffName { get; set; } = null!;
        public int UsedByStaffId { get; set; }
        public bool IsCancel { get; set; }
        public double RegisterNumberIndex { get; set; }
        public DateTime RegisterDate { get; set; }
        public int CreatorDepartmentId { get; set; }
        public string CreatorDepartmentName { get; set; } = null!;
        public string CreatorHostName { get; set; } = null!;
        public string CreatorIp { get; set; } = null!;
        public string RegisterNumberValue { get; set; } = null!;
        public int Year { get; set; }
        public string ReservedByStaff { get; set; } = null!;
        public string ReservedByDepartment { get; set; } = null!;
        public string ReservedReason { get; set; } = null!;
        public int? ReservedByDepartmentId { get; set; }
        public string CancelReason { get; set; } = null!;
        public bool IsCircular { get; set; }

        public virtual FilingDocument? FilingDocument { get; set; }
        public virtual FilingRegisterBook FilingRegisterBook { get; set; } = null!;
    }
}
