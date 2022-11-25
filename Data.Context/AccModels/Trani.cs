using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Trani
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcplant { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public DateTime Fddate { get; set; }
        public string Fcstep { get; set; } = null!;
        public string Fcstat { get; set; } = null!;
        public string Fctxid { get; set; } = null!;
        public string Fcsubtxid { get; set; } = null!;
        public string Fcreftype { get; set; } = null!;
        public string Fcrefh { get; set; } = null!;
        public string Fcrefi { get; set; } = null!;
        public string Fccoor { get; set; } = null!;
        public string Fcprod { get; set; } = null!;
        public string Fcmainprod { get; set; } = null!;
        public string Fcgvpolicy { get; set; } = null!;
        public string Fcwhouse { get; set; } = null!;
        public string Fcstore { get; set; } = null!;
        public string Fcgag { get; set; } = null!;
        public string Fclot { get; set; } = null!;
        public string Fciotype { get; set; } = null!;
        public decimal Fnplanqty { get; set; }
        public decimal Fnactqty { get; set; }
        public decimal Fnallocqty { get; set; }
        public string Fcshift { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
    }
}
