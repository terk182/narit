using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class MisAccMatching
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public int MisId { get; set; }
        public string? MisName { get; set; }
        public int AccId { get; set; }
        public string? AccName { get; set; }
        public int Year { get; set; }
        public string? Type { get; set; }
        public string? MisUid { get; set; }
        public string? AccUid { get; set; }
    }
}
