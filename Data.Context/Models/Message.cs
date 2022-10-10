using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class Message
    {
        public Message()
        {
            FilingDocMessageReferrers = new HashSet<FilingDocMessageReferrer>();
            FilingFiles = new HashSet<FilingFile>();
            InverseFromMessage = new HashSet<Message>();
            MessageHistories = new HashSet<MessageHistory>();
            Receivers = new HashSet<Receiver>();
        }

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
        public int? FilingGeneralOrderId { get; set; }

        public virtual FilingDocument FilingDocument { get; set; } = null!;
        public virtual FilingGeneralOrder? FilingGeneralOrder { get; set; }
        public virtual Message? FromMessage { get; set; }
        public virtual ICollection<FilingDocMessageReferrer> FilingDocMessageReferrers { get; set; }
        public virtual ICollection<FilingFile> FilingFiles { get; set; }
        public virtual ICollection<Message> InverseFromMessage { get; set; }
        public virtual ICollection<MessageHistory> MessageHistories { get; set; }
        public virtual ICollection<Receiver> Receivers { get; set; }
    }
}
