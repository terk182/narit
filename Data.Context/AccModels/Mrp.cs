using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Mrp
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcplant { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fcgvpolicy { get; set; } = null!;
        public DateTime? Fddate { get; set; }
        public string Fccoor { get; set; } = null!;
        public string Fcprod { get; set; } = null!;
        public decimal Fnqty { get; set; }
        public decimal Fnbalance { get; set; }
        public string Fcrefcode { get; set; } = null!;
        public string Fcreftype { get; set; } = null!;
        public string Fciotype { get; set; } = null!;
        public string Fcmainprod { get; set; } = null!;
        public DateTime? Fdfinish { get; set; }
        public string Fcmps { get; set; } = null!;
        public string Fcmprod { get; set; } = null!;
        public string Fcmsgcode { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public string Fcshift { get; set; } = null!;
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
    }
}
