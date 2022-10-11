using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class FingerPrintDbconnector
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public string ConnectionString { get; set; } = null!;
        public DateTime LastReadDate { get; set; }
        public string Remark { get; set; } = null!;
        public DateTime PreviousReadDate { get; set; }
        public bool IsSqlConnection { get; set; }
        public DateTime LastSourceCheckTimeRead { get; set; }
        public DateTime PreviousSourceCheckTimeRead { get; set; }
    }
}
