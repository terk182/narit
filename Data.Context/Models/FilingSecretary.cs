using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class FilingSecretary
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public int StaffId { get; set; }
        public int BossId { get; set; }
        public int MaxSecretLevelEnum { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}
