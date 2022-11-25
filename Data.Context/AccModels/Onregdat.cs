using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Onregdat
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fctype { get; set; } = null!;
        public string Fcregstr01 { get; set; } = null!;
        public string Fcregstr02 { get; set; } = null!;
        public string Fcregstr03 { get; set; } = null!;
        public string Fcregstr04 { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
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
        public string? Fmdata01 { get; set; }
        public string? Fmdata02 { get; set; }
        public string? Fmdata03 { get; set; }
        public string? Fmdata04 { get; set; }
        public string? Fmdata05 { get; set; }
        public string Fccorrectb { get; set; } = null!;
    }
}
