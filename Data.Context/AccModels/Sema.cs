using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Sema
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcuset { get; set; } = null!;
        public string Fcseq { get; set; } = null!;
        public decimal Fnretrace { get; set; }
        public string Fcfingle { get; set; } = null!;
        public string Fcmaster { get; set; } = null!;
        public string Fcappsys { get; set; } = null!;
        public string Fcsystname { get; set; } = null!;
        public string Fcsysename { get; set; } = null!;
        public string Fccusttnam { get; set; } = null!;
        public string Fccustenam { get; set; } = null!;
        public string Fcserialno { get; set; } = null!;
        public string Fcreset { get; set; } = null!;
        public string Fcuser { get; set; } = null!;
        public string Fcctrlstr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public string Fcskid { get; set; } = null!;
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
    }
}
