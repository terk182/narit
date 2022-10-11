using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class FilingDocument
    {
        public FilingDocument()
        {
            FilingDocMessageReferrers = new HashSet<FilingDocMessageReferrer>();
            FilingDocProjectRelations = new HashSet<FilingDocProjectRelation>();
            FilingDocTagRelations = new HashSet<FilingDocTagRelation>();
            FilingDocWarehouseRelations = new HashSet<FilingDocWarehouseRelation>();
            FilingDocumentAccessLogs = new HashSet<FilingDocumentAccessLog>();
            FilingDocumentHistories = new HashSet<FilingDocumentHistory>();
            FilingDocumentReferrerFilingDocuments = new HashSet<FilingDocumentReferrer>();
            FilingDocumentReferrerReferFilingDocuments = new HashSet<FilingDocumentReferrer>();
            FilingFileFilingDocuments = new HashSet<FilingFile>();
            FilingFileMainFilingDocuments = new HashSet<FilingFile>();
            FilingPersonalMarkups = new HashSet<FilingPersonalMarkup>();
            FilingRegisterNumbers = new HashSet<FilingRegisterNumber>();
            Messages = new HashSet<Message>();
            Receivers = new HashSet<Receiver>();
        }

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
        public int? CreatorStaffId { get; set; }
        public string CreatorStaffName { get; set; } = null!;
        public string HrdepartmentName { get; set; } = null!;
        public int? HrdepartmentId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsCancel { get; set; }
        public string PostscriptText { get; set; } = null!;
        public string PostscriptStaffName { get; set; } = null!;
        public string PostscriptStaffPosition { get; set; } = null!;
        public int? CreatorSignatureId { get; set; }
        public string CreatorIp { get; set; } = null!;
        public string CreatorHostName { get; set; } = null!;
        public int? LastSaveByStaffId { get; set; }
        public DateTime LastSaveDate { get; set; }
        public string LastSaveIp { get; set; } = null!;
        public string LastSaveHostName { get; set; } = null!;
        public bool IsPrivate { get; set; }
        public string ReferTo { get; set; } = null!;
        public bool IsOnlineForm { get; set; }
        public DateTime? OpenIssueDate { get; set; }
        public DateTime? CloseIssueDate { get; set; }
        public int OpenIssueByStaffId { get; set; }
        public int? FilingGeneralOrderId { get; set; }
        public string OrderDetail { get; set; } = null!;
        public DateTime? OrderDate { get; set; }
        public string RespondsibleHrdepName { get; set; } = null!;
        public string CoordinateHrdepName { get; set; } = null!;
        public string ResponsibleStaff { get; set; } = null!;
        public string ResponsibleStaffPosition { get; set; } = null!;
        public int? RespondsibleHrdepId { get; set; }
        public int? CoordinateHrdepId { get; set; }
        public int? ResponsibleStaffId { get; set; }
        public string SecondResponsibleStaff { get; set; } = null!;
        public string SecondResponsibleStaffPosition { get; set; } = null!;
        public string ThirdResponsibleStaff { get; set; } = null!;
        public string ThirdResponsibleStaffPosition { get; set; } = null!;
        public int? SecondResponsibleStaffId { get; set; }
        public int? ThirdResponsibleStaffId { get; set; }
        public string Moucountry { get; set; } = null!;
        public string FirstResponsibleStaff { get; set; } = null!;
        public string FirstResponsibleStaffPosition { get; set; } = null!;
        public int? FirstResponsibleStaffId { get; set; }
        public bool IsLocked { get; set; }
        public bool IsApproveInstead { get; set; }

        public virtual FilingGeneralOrder? FilingGeneralOrder { get; set; }
        public virtual ICollection<FilingDocMessageReferrer> FilingDocMessageReferrers { get; set; }
        public virtual ICollection<FilingDocProjectRelation> FilingDocProjectRelations { get; set; }
        public virtual ICollection<FilingDocTagRelation> FilingDocTagRelations { get; set; }
        public virtual ICollection<FilingDocWarehouseRelation> FilingDocWarehouseRelations { get; set; }
        public virtual ICollection<FilingDocumentAccessLog> FilingDocumentAccessLogs { get; set; }
        public virtual ICollection<FilingDocumentHistory> FilingDocumentHistories { get; set; }
        public virtual ICollection<FilingDocumentReferrer> FilingDocumentReferrerFilingDocuments { get; set; }
        public virtual ICollection<FilingDocumentReferrer> FilingDocumentReferrerReferFilingDocuments { get; set; }
        public virtual ICollection<FilingFile> FilingFileFilingDocuments { get; set; }
        public virtual ICollection<FilingFile> FilingFileMainFilingDocuments { get; set; }
        public virtual ICollection<FilingPersonalMarkup> FilingPersonalMarkups { get; set; }
        public virtual ICollection<FilingRegisterNumber> FilingRegisterNumbers { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<Receiver> Receivers { get; set; }
    }
}
