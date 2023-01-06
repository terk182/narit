using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Alertmsg
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fcsystem { get; set; } = null!;
        public string Fccode { get; set; } = null!;
        public string Fcdocflowi { get; set; } = null!;
        public string Fcmasterh { get; set; } = null!;
        public string? Fmbfenter { get; set; }
        public string? Fmbfsave { get; set; }
        public string Fcmsg2user { get; set; } = null!;
        public string? Fmloginmsg { get; set; }
        public string? Fmmailto { get; set; }
        public string? Fmsmsto { get; set; }
        public string Fccreateby { get; set; } = null!;
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime? Ftaletdt { get; set; }
        public DateTime? Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
    }
}
