using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Acc.Contact.Requests
{
    public class ContactMainRequest
    {
        public int Id { get; set; }
        public bool? Active { get; set; }
        public string? Country { get; set; }
        public string? RegistrationNumber { get; set; }
        public int? OfficeType { get; set; }
        public int? ContactTypeId { get; set; }
        public int? ContactSubTypeId { get; set; }
        public string? ContactPrefix { get; set; }
        public string? ContactName { get; set; }
        public string? ContactSurname { get; set; }
        public string? RegisteredName { get; set; }
        public string? RegisteredAddress { get; set; }
        public string? RegisteredSubdistrict { get; set; }
        public string? RegisteredDistrict { get; set; }
        public string? RegisteredProvince { get; set; }
        public int? RegisteredPostcode { get; set; }
        public string? ContactPhone { get; set; }
        public string? ContactEmail { get; set; }

    }
}
