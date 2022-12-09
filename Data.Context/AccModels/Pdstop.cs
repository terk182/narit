using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Pdstop
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcpdsth { get; set; } = null!;
        public string Fcopseq { get; set; } = null!;
        public string Fcsubop { get; set; } = null!;
        public string Fcmop { get; set; } = null!;
        public string Fcwkctrh { get; set; } = null!;
        public string Fcdesc { get; set; } = null!;
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public string Fcqcmemo { get; set; } = null!;
        public string Fcproctype { get; set; } = null!;
        public decimal FnltQue { get; set; }
        public decimal FnltSetup { get; set; }
        public decimal FnltProc { get; set; }
        public decimal FnltTear { get; set; }
        public decimal FnltWait { get; set; }
        public decimal FnltMove { get; set; }
        public string Fcptype { get; set; } = null!;
        public decimal Fnstdtime { get; set; }
        public decimal Fnwastetim { get; set; }
        public decimal Fnbatchsiz { get; set; }
        public string Fccritical { get; set; } = null!;
        public string Fciscommen { get; set; } = null!;
        public decimal Fnwipcost1 { get; set; }
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
    }
}
