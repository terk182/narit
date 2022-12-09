using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.FIN.Models.Requests
{
    public class SupplierRequest
    {
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
    }
}
