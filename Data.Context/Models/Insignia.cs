using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class Insignia
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int Year { get; set; }
        public string BookNumber { get; set; } = null!;
        public string SectionNumber { get; set; } = null!;
        public string PageNumber { get; set; } = null!;
        public string SequenceNumber { get; set; } = null!;
        public int InsigniaRankId { get; set; }
        public int StaffId { get; set; }

        public virtual InsigniaRank InsigniaRank { get; set; } = null!;
        public virtual Staff Staff { get; set; } = null!;
    }
}
