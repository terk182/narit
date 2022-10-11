using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class StaffCipherKeyPair
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int StaffId { get; set; }
        public string EncryptedKeyPair { get; set; } = null!;
        public string Jwtheader { get; set; } = null!;
        public string X509PublicCertificate { get; set; } = null!;
        public string Cad { get; set; } = null!;
    }
}
