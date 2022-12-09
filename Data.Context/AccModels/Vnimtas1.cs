using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Vnimtas1
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcasset { get; set; } = null!;
        public DateTime Fddate { get; set; }
        public string Fcdesc { get; set; } = null!;
        public decimal Fnqty { get; set; }
        public decimal Fnprice { get; set; }
        public string Fciscal { get; set; } = null!;
        public string Fcsupp { get; set; } = null!;
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public DateTime? Ftlastupd { get; set; }
        public string Fcdescum { get; set; } = null!;
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public DateTime? Ftsrcupd { get; set; }
        public string Fcsrcupd { get; set; } = null!;
    }
}
