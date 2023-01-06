using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Vbsnpd
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fcbakyrhis { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcprod { get; set; } = null!;
        public string Fctype { get; set; } = null!;
        public decimal Fnpppack { get; set; }
        public decimal Fnpptray { get; set; }
        public decimal Fnppbarrel { get; set; }
        public string Fcsubplant { get; set; } = null!;
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public DateTime? Ftlastupd { get; set; }
        public int Fimillisec { get; set; }
        public string Fcproctype { get; set; } = null!;
        public string Fcpacktype { get; set; } = null!;
        public string Fccoor { get; set; } = null!;
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fcpackc { get; set; } = null!;
        public string Fcpackf { get; set; } = null!;
        public decimal Fnpppackp { get; set; }
        public decimal Fnpppackc { get; set; }
        public decimal Fnpppackf { get; set; }
        public string? Fmboxp { get; set; }
        public string? Fmboxc { get; set; }
        public string? Fmboxf { get; set; }
        public decimal Fnplatedt { get; set; }
        public decimal Fnplatedc { get; set; }
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public string Fclid { get; set; } = null!;
    }
}
