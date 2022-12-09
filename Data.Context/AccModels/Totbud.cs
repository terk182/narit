using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Totbud
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fcdept { get; set; } = null!;
        public string Fcsect { get; set; } = null!;
        public string Fcjob { get; set; } = null!;
        public string Fcproj { get; set; } = null!;
        public string Fcsubbr { get; set; } = null!;
        public string Fcacchart { get; set; } = null!;
        public string Fctype { get; set; } = null!;
        public string Fcyear { get; set; } = null!;
        public decimal Fntotal { get; set; }
        public decimal Fnallocamt { get; set; }
        public decimal Fnportion { get; set; }
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public decimal Fnamt1 { get; set; }
        public decimal Fnamt2 { get; set; }
        public decimal Fnamt3 { get; set; }
        public decimal Fnamt4 { get; set; }
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public string Fcboicard { get; set; } = null!;
        public string Fcboigroup { get; set; } = null!;
        public DateTime? Ftsrcupd { get; set; }
        public string Fcsrcupd { get; set; } = null!;
    }
}
