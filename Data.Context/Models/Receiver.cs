using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class Receiver
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public int StaffId { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public bool IsRejected { get; set; }
        public int? HrdepartmentId { get; set; }
        public string HrdepartmentName { get; set; } = null!;
        public int MessageId { get; set; }
        public DateTime? RoleActionDate { get; set; }
        public string RoleActionOpinion { get; set; } = null!;
        public string RoleActionStaffPosition { get; set; } = null!;
        public DateTime? RoleActionShowDate { get; set; }
        public string RoleActionDetail { get; set; } = null!;
        public string ReceivedIp { get; set; } = null!;
        public string ReceivedHostName { get; set; } = null!;
        public string RoleActionIp { get; set; } = null!;
        public string RoleActionHostName { get; set; } = null!;
        public bool IsReadable { get; set; }
        public int? ReceiverSignatureId { get; set; }
        public string RoleName { get; set; } = null!;
        public int FilingDocumentId { get; set; }
        public bool IsCc { get; set; }

        public virtual FilingDocument FilingDocument { get; set; } = null!;
        public virtual Message Message { get; set; } = null!;
    }
}
