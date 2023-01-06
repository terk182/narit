using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Machine
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fcplant { get; set; } = null!;
        public string Fcsect { get; set; } = null!;
        public string Fccode { get; set; } = null!;
        public string Fcname { get; set; } = null!;
        public string Fcname2 { get; set; } = null!;
        public decimal Fncapacity { get; set; }
        public decimal Fnstrict { get; set; }
        public decimal Fnlotsize { get; set; }
        public decimal Fnbatchsiz { get; set; }
        public decimal FnltQue { get; set; }
        public decimal FnltSetup { get; set; }
        public decimal FnltProc { get; set; }
        public decimal FnltTear { get; set; }
        public decimal FnltWait { get; set; }
        public decimal FnltMove { get; set; }
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public string Fcfchr { get; set; } = null!;
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public decimal Fncolor { get; set; }
        public string Fcmanflag { get; set; } = null!;
        public string Fcaddapvby { get; set; } = null!;
        public string Fcedtapvby { get; set; } = null!;
        public string Fcdelapvby { get; set; } = null!;
        public string Fcisused { get; set; } = null!;
        public string Fclid { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
    }
}
