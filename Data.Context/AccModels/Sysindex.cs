using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Sysindex
    {
        public string Fcgroup { get; set; } = null!;
        public string Fcdbffile { get; set; } = null!;
        public string Fcname { get; set; } = null!;
        public string Fcname2 { get; set; } = null!;
        public string Fctagname { get; set; } = null!;
        public string Fcdbserver { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccdxfile { get; set; } = null!;
        public string? Fmindexkey { get; set; }
        public string? Fmindexfor { get; set; }
        public decimal Fnisunique { get; set; }
        public decimal Fncandidat { get; set; }
        public decimal Fnlastrecc { get; set; }
        public decimal Fnwarnrati { get; set; }
        public decimal Fnwarnaddr { get; set; }
        public decimal Fnbakdeleo { get; set; }
        public decimal Fnbakratio { get; set; }
        public string Fcselected { get; set; } = null!;
        public decimal Fnuserseti { get; set; }
        public string Fcskid { get; set; } = null!;
        public string Fcfchr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime? Ftlastupd { get; set; }
        public DateTime Ftdatetime { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
    }
}
