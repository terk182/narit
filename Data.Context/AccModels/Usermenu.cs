using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Usermenu
    {
        public string Fcskid { get; set; } = null!;
        public string Fcsystem { get; set; } = null!;
        public string Fcprskid { get; set; } = null!;
        public string Fcsysobj { get; set; } = null!;
        public string Fcemplr { get; set; } = null!;
        public string Fctype { get; set; } = null!;
        public string Fccode { get; set; } = null!;
        public string Fcprompt1 { get; set; } = null!;
        public string Fcprompt2 { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime? Ftlastupd { get; set; }
        public DateTime Ftdatetime { get; set; }
        public string Fcappskid { get; set; } = null!;
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
    }
}
