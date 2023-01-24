using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class FormRequest
    {
        public int Id { get; set; }
        public bool? Active { get; set; }
        public int FiscalYear { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public DateTime WriteDate { get; set; }
        public string WriteAt { get; set; } = null!;
        public string Inform { get; set; } = null!;
        public string Enclosure { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Purpose { get; set; }
        public int? PlanCoreId { get; set; }
        public DateTime? Datetime { get; set; }
        public int? FormRequestAcceptId { get; set; }
    }
}
