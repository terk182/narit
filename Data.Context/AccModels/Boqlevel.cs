using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Boqlevel
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fcreftype { get; set; } = null!;
        public string Fcrefhead { get; set; } = null!;
        public string Fcrefitem { get; set; } = null!;
        public string Fcmainjobh { get; set; } = null!;
        public string Fcsubjobh { get; set; } = null!;
        public string Fcparent { get; set; } = null!;
        public decimal Fnlevel { get; set; }
        public string Fccreateby { get; set; } = null!;
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public string Fcu1status { get; set; } = null!;
        public string Fcu2status { get; set; } = null!;
        public string Fcdtype1 { get; set; } = null!;
        public string Fcdtype2 { get; set; } = null!;
        public decimal Fnu1cnt { get; set; }
        public decimal Fnu2cnt { get; set; }
        public string? Fmerrmsg { get; set; }
        public string Fclid { get; set; } = null!;
        public DateTime? Ftsrcupd { get; set; }
        public string Fcsrcupd { get; set; } = null!;
    }
}
