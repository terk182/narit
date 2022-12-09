using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Itablis1
    {
        public string Fcname { get; set; } = null!;
        public string Fcidtype { get; set; } = null!;
        public int Fiskidlen { get; set; }
        public string Fcstatus { get; set; } = null!;
        public double Fimaxskidv { get; set; }
        public int Fiskidv { get; set; }
        public int Finskidv { get; set; }
        public int Fireccount { get; set; }
        public int Firecc01 { get; set; }
        public string Fcfchr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime? Ftlastupd { get; set; }
        public DateTime Ftdatetime { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
    }
}
