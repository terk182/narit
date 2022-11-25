using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Prcvi
    {
        public string Fcskid { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcdataser { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fcrefpytyp { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fcprcvh { get; set; } = null!;
        public DateTime Fddate { get; set; }
        public string Fccoor { get; set; } = null!;
        public string Fcchildglr { get; set; } = null!;
        public string Fclayh { get; set; } = null!;
        public decimal Fnpayamt { get; set; }
        public decimal Fnpayamtke { get; set; }
        public decimal Fnxrate { get; set; }
        public string Fcseq { get; set; } = null!;
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public string Fcutime { get; set; } = null!;
        public decimal Fnvatamtke { get; set; }
        public decimal Fnvatamt { get; set; }
        public string Fcrefpay { get; set; } = null!;
        public decimal Fnbillamt { get; set; }
        public decimal Fnbillvamt { get; set; }
        public string Fcstep { get; set; } = null!;
        public decimal Fnretenamt { get; set; }
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fclayh2 { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public DateTime? Ftsrcupd { get; set; }
        public string Fcsrcupd { get; set; } = null!;
    }
}
