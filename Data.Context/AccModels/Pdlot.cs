using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Pdlot
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fcwhouse { get; set; } = null!;
        public string Fcprod { get; set; } = null!;
        public string Fccode { get; set; } = null!;
        public DateTime Fdrecdate { get; set; }
        public DateTime Fdmfgdate { get; set; }
        public DateTime Fdexpdate { get; set; }
        public decimal Fnqty { get; set; }
        public string Fcum { get; set; } = null!;
        public decimal Fncost { get; set; }
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcstep { get; set; } = null!;
        public decimal Fnumqty { get; set; }
        public DateTime? Ftsrcupd { get; set; }
        public string Fcsrcupd { get; set; } = null!;
    }
}
