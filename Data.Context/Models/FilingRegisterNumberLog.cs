using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class FilingRegisterNumberLog
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public int FilingRegisterBookId { get; set; }
        public int FilingDocumentId { get; set; }
        public DateTime DateOfChanged { get; set; }
        public int FilingRegisterNumberId { get; set; }
    }
}
