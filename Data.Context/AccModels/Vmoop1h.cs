using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Vmoop1h
    {
        public string Fcudate { get; set; } = null!;
        public string Fcdataser { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcplant { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fcstat { get; set; } = null!;
        public string Fcstep { get; set; } = null!;
        public DateTime Fddate { get; set; }
        public string Fcprod { get; set; } = null!;
        public string Fcmorderh { get; set; } = null!;
        public string Fcmorderop { get; set; } = null!;
        public string Fcwkctrh { get; set; } = null!;
        public decimal Fnrcvqty { get; set; }
        public decimal Fngoodqty { get; set; }
        public decimal Fnwasteqty { get; set; }
        public decimal Fnholdqty { get; set; }
        public decimal Fnsendqty { get; set; }
        public DateTime? Ftlastupd { get; set; }
        public string Fccorrectb { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccancelby { get; set; } = null!;
        public string Fcapproveb { get; set; } = null!;
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fctimestam { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public string Fcutime { get; set; } = null!;
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fclid { get; set; } = null!;
    }
}
