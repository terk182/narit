using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Tres5log
    {
        public string Fccorp { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fctable { get; set; } = null!;
        public string Fcoperatio { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string? Fmbakdesc { get; set; }
        public string? Fmqcdesc { get; set; }
        public string Fccause { get; set; } = null!;
        public string? Fmcausemsg { get; set; }
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
