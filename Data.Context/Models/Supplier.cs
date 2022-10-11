using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            ApproveItems = new HashSet<ApproveItem>();
            CheckForms = new HashSet<CheckForm>();
            CheckItems = new HashSet<CheckItem>();
            OrderContracts = new HashSet<OrderContract>();
            OrderForms = new HashSet<OrderForm>();
            OrderItems = new HashSet<OrderItem>();
            Quotations = new HashSet<Quotation>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? ContactPerson { get; set; }
        public string? AddressNumber { get; set; }
        public string? RoadName { get; set; }
        public string? MooBaan { get; set; }
        public string? TamBon { get; set; }
        public string? AmPhur { get; set; }
        public string? Province { get; set; }
        public bool Active { get; set; }
        public string? PostCode { get; set; }
        public string? CommercialRegistrationId { get; set; }
        public string? TaxRegistrationId { get; set; }
        public string? CertificateOfPartnershipId { get; set; }
        public DateTime? CertificateOfPartnershipDate { get; set; }
        public string? TelephoneNumber { get; set; }
        public string? FaxNumber { get; set; }
        public int? SupplierTypeId { get; set; }
        public bool IsJuristicPerson { get; set; }

        public virtual SupplierType? SupplierType { get; set; }
        public virtual ICollection<ApproveItem> ApproveItems { get; set; }
        public virtual ICollection<CheckForm> CheckForms { get; set; }
        public virtual ICollection<CheckItem> CheckItems { get; set; }
        public virtual ICollection<OrderContract> OrderContracts { get; set; }
        public virtual ICollection<OrderForm> OrderForms { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<Quotation> Quotations { get; set; }
    }
}
