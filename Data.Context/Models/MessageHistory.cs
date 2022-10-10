using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class MessageHistory
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public string Detail { get; set; } = null!;
        public string Remark { get; set; } = null!;
        public DateTime SentDate { get; set; }
        public int? SenderStaffId { get; set; }
        public string SenderStaffName { get; set; } = null!;
        public int? SenderHrdepartmentId { get; set; }
        public string SenderHrdepartmentName { get; set; } = null!;
        public int FilingDocumentId { get; set; }
        public int FilingRoleInRouteEnum { get; set; }
        public int FilingRoutePassMethodEnum { get; set; }
        public int FilingRouteChangePolicyEnum { get; set; }
        public string SenderIp { get; set; } = null!;
        public string SenderHostName { get; set; } = null!;
        public int? FromMessageId { get; set; }
        public string ToMessagesIdValue { get; set; } = null!;
        public int MessageId { get; set; }
        public string FilingFileValue { get; set; } = null!;
        public DateTime EditDate { get; set; }
        public string EditorIp { get; set; } = null!;
        public string EditorHostName { get; set; } = null!;
        public int EditorStaffId { get; set; }
        public string ReceiverValue { get; set; } = null!;
        public string FilingDocMessageReferrerValue { get; set; } = null!;

        public virtual Message Message { get; set; } = null!;
    }
}
