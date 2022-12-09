using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.EIS.Dtos
{
    public class BillingLocationDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public string Detail { get; set; } = null!;
        public int BillingLocationTypeEnum { get; set; }
        public string MeterId { get; set; } = null!;
        public string MeterSize { get; set; } = null!;
        public string UserCode { get; set; } = null!;
        public decimal Multiplier { get; set; }
        public string Location { get; set; } = null!;
        public string ServiceProviderCode { get; set; } = null!;
        public string UserType { get; set; } = null!;
        public int? ParentBillingLocationId { get; set; }
    }
}
