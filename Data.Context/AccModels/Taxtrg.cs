﻿using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Taxtrg
    {
        public string Fcskid { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fcyear { get; set; } = null!;
        public string Fctaxtype { get; set; } = null!;
        public string Fcacchart { get; set; } = null!;
        public string Fcexcept { get; set; } = null!;
        public decimal Fnamt { get; set; }
        public decimal Fnpcn { get; set; }
        public string Fcpcnwhich { get; set; } = null!;
        public decimal Fnmaxamt { get; set; }
        public decimal Fnminamt { get; set; }
        public decimal Fnmaxpcn { get; set; }
        public decimal Fnminpcn { get; set; }
        public string Fcamttype { get; set; } = null!;
        public string Fcwarntype { get; set; } = null!;
        public string Fcdataser { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public decimal Fimillisec { get; set; }
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
        public string Fccorrectb { get; set; } = null!;
        public string Fclid { get; set; } = null!;
        public string Fcu1status { get; set; } = null!;
        public string Fcdtype1 { get; set; } = null!;
        public decimal Fnu1cnt { get; set; }
        public string Fcu2status { get; set; } = null!;
        public string Fcdtype2 { get; set; } = null!;
        public decimal Fnu2cnt { get; set; }
        public string Fcu3status { get; set; } = null!;
        public string Fcdtype3 { get; set; } = null!;
        public decimal Fnu3cnt { get; set; }
        public string Fcu4status { get; set; } = null!;
        public string Fcdtype4 { get; set; } = null!;
        public decimal Fnu4cnt { get; set; }
        public string Fcu5status { get; set; } = null!;
        public string Fcdtype5 { get; set; } = null!;
        public decimal Fnu5cnt { get; set; }
        public string Fcu6status { get; set; } = null!;
        public string Fcdtype6 { get; set; } = null!;
        public decimal Fnu6cnt { get; set; }
        public string Fcu7status { get; set; } = null!;
        public string Fcdtype7 { get; set; } = null!;
        public decimal Fnu7cnt { get; set; }
        public string Fcu8status { get; set; } = null!;
        public string Fcdtype8 { get; set; } = null!;
        public decimal Fnu8cnt { get; set; }
        public string Fcu9status { get; set; } = null!;
        public string Fcdtype9 { get; set; } = null!;
        public decimal Fnu9cnt { get; set; }
        public DateTime? Ftsrcupd { get; set; }
        public string Fcsrcupd { get; set; } = null!;
        public string Fcgid { get; set; } = null!;
    }
}
