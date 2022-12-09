using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Cp
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcplant { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fcstep { get; set; } = null!;
        public string Fcstat { get; set; } = null!;
        public string Fcgvpolicy { get; set; } = null!;
        public string Fcplanmoop { get; set; } = null!;
        public string Fcmop { get; set; } = null!;
        public string Fcwkctrh { get; set; } = null!;
        public string Fcmachine { get; set; } = null!;
        public decimal Fnqty { get; set; }
        public DateTime Fddate { get; set; }
        public string Fcshift { get; set; } = null!;
        public string Fccoor { get; set; } = null!;
        public string Fcprod { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public decimal FnltProc { get; set; }
        public decimal FnltSetup { get; set; }
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public string Fcmanflag { get; set; } = null!;
        public string Fcaddapvby { get; set; } = null!;
        public string Fcedtapvby { get; set; } = null!;
        public string Fcdelapvby { get; set; } = null!;
        public string Fcisused { get; set; } = null!;
        public string Fclid { get; set; } = null!;
    }
}
