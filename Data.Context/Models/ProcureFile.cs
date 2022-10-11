using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class ProcureFile
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int Size { get; set; }
        public string Path { get; set; } = null!;
        public DateTime UploadDate { get; set; }
        public int? UploadUserId { get; set; }
        public string Type { get; set; } = null!;
        public int? OrderFormId { get; set; }
        public int? ApproveFormId { get; set; }
        public int? CheckFormId { get; set; }
        public int? AgreementFormId { get; set; }
        public int? RequestFormId { get; set; }
        public int? RegisterItemCheckRecordId { get; set; }
        public int? RegisterDurableItemId { get; set; }
        public int? ProcureContractId { get; set; }
        public int SpecificProcureFileTypeEnum { get; set; }
        public int? RqFormActionLogId { get; set; }

        public virtual AgreementForm? AgreementForm { get; set; }
        public virtual ApproveForm? ApproveForm { get; set; }
        public virtual CheckForm? CheckForm { get; set; }
        public virtual OrderForm? OrderForm { get; set; }
        public virtual ProcureContract? ProcureContract { get; set; }
        public virtual RegisterDurableItem? RegisterDurableItem { get; set; }
        public virtual RegisterItemCheckRecord? RegisterItemCheckRecord { get; set; }
        public virtual RequestForm? RequestForm { get; set; }
        public virtual RqFormActionLog? RqFormActionLog { get; set; }
    }
}
