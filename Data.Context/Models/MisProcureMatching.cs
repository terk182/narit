using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class MisProcureMatching
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public int MisId { get; set; }
        public string? MisName { get; set; }
        public int RegisterProcureItemTypesId { get; set; }
        public string? RegisterProcureItemTypesName { get; set; }
        public int Year { get; set; }
        public string? Type { get; set; }
        public string? MisUid { get; set; }
        public string? RegisterProcureItemTypesUid { get; set; }
    }
}
