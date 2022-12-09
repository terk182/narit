using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Emplr
    {
        public string Fcskid { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fclogin { get; set; } = null!;
        public string Fcpw { get; set; } = null!;
        public string Fchpw { get; set; } = null!;
        public string Fchhpw { get; set; } = null!;
        public string Fcrcode { get; set; } = null!;
        public string Fcusertem { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public string Fcseltag { get; set; } = null!;
        public decimal Fnstatus { get; set; }
        public string? Fcscrnlang { get; set; }
        public string? Fcmenulang { get; set; }
        public string? Fcrepolang { get; set; }
        public string? Fcfiellang { get; set; }
        public string? Fcyearmode { get; set; }
        public string? Fcpthaicod { get; set; }
        public string Fccapmode { get; set; } = null!;
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public decimal Fnmisspass { get; set; }
        public DateTime? Fdlstchgpa { get; set; }
        public DateTime? Fdlstlogin { get; set; }
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
    }
}
