using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class ContactMain
    {
        public int Id { get; set; }
        public bool? Active { get; set; }
        public string? Code { get; set; }
        public string? RegistrationNumber { get; set; }
        public int? OfficeType { get; set; }
        public string? Country { get; set; }
        public int? ContactTypeId { get; set; }
        public int? ContactSubTypeId { get; set; }
        public string? ContactName { get; set; }
        public string? ContactSurname { get; set; }
        public string? ContactPrefix { get; set; }
        public string? RegisteredName { get; set; }
        public string? RegisteredAddress { get; set; }
        public string? RegisteredSubdistrict { get; set; }
        public string? RegisteredDistrict { get; set; }
        public string? RegisteredProvince { get; set; }
        public int? RegisteredPostcode { get; set; }
        public string? ContactEmail { get; set; }
        public string? ContactPhone { get; set; }
        public string? ContactWebsite { get; set; }
        public int? ContactFax { get; set; }
        public DateTime? ContactDate { get; set; }

        public virtual ContactSubtype? ContactSubType { get; set; }
    }
}
