using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.GL.Requests
{
    public class CreditorRequest
    {
        public int? Id { get; set; }
        public int Active { get; set; }

        public string Name { get; set; } 
        public int TaxCode { get; set; }
        public string Address { get; set; }

        public string? SubDistrict { get; set; }
        public string? District { get; set; }
        public string? Province { get; set; }
        public int? Postcode { get; set; }

        public string? ContactName { get; set; }
        public string? Phone { get; set; }
        public string? Branch { get; set; }
        public int? CreditorTypeId { get; set; }
        public DateTime? ContactDate { get; set; }
        public int BusinessTypeId { get; set; }
        public int? BankAccontNo { get; set; }
        public int BankId { get; set; }
        public int? CertificateOfPartnershipId { get; set; }
        public DateTime? CertificateOfPartnershipDate { get; set; }

    }
}
