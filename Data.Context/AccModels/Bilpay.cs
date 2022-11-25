using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Bilpay
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fcmtype { get; set; } = null!;
        public string Fcmasterh { get; set; } = null!;
        public string Fcpayment { get; set; } = null!;
        public string Fcofmaster { get; set; } = null!;
        public decimal Fnamt { get; set; }
        public string Fcseq { get; set; } = null!;
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public string Fcskid { get; set; } = null!;
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public string Fcmastab { get; set; } = null!;
        public DateTime? Ftsrcupd { get; set; }
        public string Fcsrcupd { get; set; } = null!;
    }
}
