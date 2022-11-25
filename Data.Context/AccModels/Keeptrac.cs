using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Keeptrac
    {
        public string Fcdataser { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fcuser { get; set; } = null!;
        public string Fcappskid { get; set; } = null!;
        public string Fctype { get; set; } = null!;
        public string? Fmmenuname { get; set; }
        public DateTime Fddate { get; set; }
        public string Fcbegtime { get; set; } = null!;
        public string Fcendtime { get; set; } = null!;
        public decimal Fninsno { get; set; }
        public decimal Fncancelno { get; set; }
        public decimal Fneditno { get; set; }
        public decimal Fndelno { get; set; }
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public string Fcskid { get; set; } = null!;
        public string? Fmdesc { get; set; }
        public string Fccomname { get; set; } = null!;
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public string Fcsystask { get; set; } = null!;
        public string? Fmmenunam2 { get; set; }
    }
}
