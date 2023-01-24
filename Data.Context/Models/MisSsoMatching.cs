using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class MisSsoMatching
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public int MisId { get; set; }
        public string? MisName { get; set; }
        public int SsoId { get; set; }
        public string? SsoName { get; set; }
        public int Year { get; set; }
        public string? Type { get; set; }
    }
}
