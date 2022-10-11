using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class Address
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public int? RelativePersonId { get; set; }
        public string Number { get; set; } = null!;
        public string Soi { get; set; } = null!;
        public string Road { get; set; } = null!;
        public string Village { get; set; } = null!;
        public string Tambol { get; set; } = null!;
        public string Amphur { get; set; } = null!;
        public string Province { get; set; } = null!;
        public string PostCode { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public int? AddressTypeId { get; set; }
        public int? AddressStyleId { get; set; }
        public string Moo { get; set; } = null!;
        public int? StaffId { get; set; }
        public bool IsCurrentAddress { get; set; }
        public bool IsHouseAddress { get; set; }

        public virtual AddressStyle? AddressStyle { get; set; }
        public virtual AddressType? AddressType { get; set; }
        public virtual RelativePerson? RelativePerson { get; set; }
        public virtual Staff? Staff { get; set; }
    }
}
