using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Connid
    {
        public string Fcname { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fcfchr { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public string Fcseltag { get; set; } = null!;
        public string Fclogin { get; set; } = null!;
        public DateTime? Ftlogin { get; set; }
        public string Fcliving { get; set; } = null!;
        public DateTime? Ftliving { get; set; }
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fctypesign { get; set; } = null!;
        public string Fcremark { get; set; } = null!;
        public string Fcsystem { get; set; } = null!;
        public decimal Fnprocid { get; set; }
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public string Fcsystask { get; set; } = null!;
        public string Fcsesionid { get; set; } = null!;
    }
}
