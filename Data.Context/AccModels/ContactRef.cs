using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class ContactRef
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public string? DeliveryAddress { get; set; }
        public string? DeliverySubdistrict { get; set; }
        public string? DeliveryDistrict { get; set; }
        public string? DeliveryProvince { get; set; }
        public int? DeliveryPostcode { get; set; }
    }
}
