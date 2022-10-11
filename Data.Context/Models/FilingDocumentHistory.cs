using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class FilingDocumentHistory
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? FilingDate { get; set; }
        public string FilingNumber { get; set; } = null!;
        public string SendFrom { get; set; } = null!;
        public string SendTo { get; set; } = null!;
        public string Attachment { get; set; } = null!;
        public string Detail { get; set; } = null!;
        public string StoreLocation { get; set; } = null!;
        public string Remark { get; set; } = null!;
        public DateTime? DueDate { get; set; }
        public int FilingTypeEnum { get; set; }
        public int FilingUrgentLevelEnum { get; set; }
        public int FilingSecretLevelEnum { get; set; }
        public int Year { get; set; }
        public string HrdepartmentName { get; set; } = null!;
        public int? HrdepartmentId { get; set; }
        public bool IsCancel { get; set; }
        public string PostscriptText { get; set; } = null!;
        public string PostscriptStaffName { get; set; } = null!;
        public string PostscriptStaffPosition { get; set; } = null!;
        public int? CreatorSignatureId { get; set; }
        public string ReferTo { get; set; } = null!;
        public DateTime EditDate { get; set; }
        public string EditorIp { get; set; } = null!;
        public string EditorHostName { get; set; } = null!;
        public int EditorStaffId { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsOnlineForm { get; set; }
        public string MainFilingFileValue { get; set; } = null!;
        public string FilingFileValue { get; set; } = null!;
        public string MessageValue { get; set; } = null!;
        public string FilingRegisterNumberValue { get; set; } = null!;
        public string FilingDocumentReferedValue { get; set; } = null!;
        public string FilingDocProjectRelationValue { get; set; } = null!;
        public string FilingDocTagRelationValue { get; set; } = null!;
        public string FilingDocWarehouseRelationValue { get; set; } = null!;
        public string ReceiverValue { get; set; } = null!;
        public string FilingDocumentReferrerValue { get; set; } = null!;
        public string FilingDocMessageReferrerValue { get; set; } = null!;
        public int FilingDocumentId { get; set; }

        public virtual FilingDocument FilingDocument { get; set; } = null!;
    }
}
