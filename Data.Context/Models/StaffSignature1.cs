using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class StaffSignature1
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public byte[]? Signature { get; set; }
        public int StaffId { get; set; }
    }
}
