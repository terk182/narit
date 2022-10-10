using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class AgreementItem
    {
        public AgreementItem()
        {
            AgreementApproveItemTransforms = new HashSet<AgreementApproveItemTransform>();
            AgreementItemPlanReferenceItems = new HashSet<AgreementItemPlanReferenceItem>();
            RequestAgreementItemTransforms = new HashSet<RequestAgreementItemTransform>();
        }

        public int? AgreementFormId { get; set; }
        public int? AgreementMemorandumId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal? Amount { get; set; }
        public decimal? PricePerPiece { get; set; }
        public string Unit { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int VatMethodEnum { get; set; }
        public decimal? Discount { get; set; }
        public DateTime? Date { get; set; }
        public int ProcureTypeEnum { get; set; }

        public virtual AgreementForm? AgreementForm { get; set; }
        public virtual AgreementMemorandum? AgreementMemorandum { get; set; }
        public virtual ICollection<AgreementApproveItemTransform> AgreementApproveItemTransforms { get; set; }
        public virtual ICollection<AgreementItemPlanReferenceItem> AgreementItemPlanReferenceItems { get; set; }
        public virtual ICollection<RequestAgreementItemTransform> RequestAgreementItemTransforms { get; set; }
    }
}
