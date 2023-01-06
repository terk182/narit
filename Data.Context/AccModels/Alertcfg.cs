using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Alertcfg
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fcemplr { get; set; } = null!;
        public string Fctype { get; set; } = null!;
        public string? Fmconfig { get; set; }
        public string? Fmconfig2 { get; set; }
        public string? Fmconfig3 { get; set; }
        public string? Fmconfig4 { get; set; }
        public string? Fmconfig5 { get; set; }
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
    }
}
