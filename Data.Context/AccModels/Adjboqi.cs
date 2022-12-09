using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Adjboqi
    {
        public string Fcskid { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fcadjboqh { get; set; } = null!;
        public string Fcestboqh { get; set; } = null!;
        public string Fcmainjobh { get; set; } = null!;
        public decimal Fnmainqty { get; set; }
        public string Fcmainum { get; set; } = null!;
        public string Fcseq { get; set; } = null!;
        public decimal Fntotprod { get; set; }
        public decimal Fntotlabor { get; set; }
        public decimal Fnprpdamt { get; set; }
        public decimal Fnprlbamt { get; set; }
        public decimal Fnpopdamt { get; set; }
        public decimal Fnpolbamt { get; set; }
        public decimal Fninvpdamt { get; set; }
        public decimal Fninvlbamt { get; set; }
        public string Fcsubjobh { get; set; } = null!;
        public decimal Fnsjobqty { get; set; }
        public string Fcsjobum { get; set; } = null!;
        public decimal Fnsjobprod { get; set; }
        public decimal Fnsjoblbor { get; set; }
        public string Fcdataser { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fcdept { get; set; } = null!;
        public string Fcsect { get; set; } = null!;
        public string Fcproj { get; set; } = null!;
        public string Fcjob { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public string Fcboicard { get; set; } = null!;
        public string Fcboigroup { get; set; } = null!;
        public DateTime? Ftsrcupd { get; set; }
        public string Fcsrcupd { get; set; } = null!;
    }
}
