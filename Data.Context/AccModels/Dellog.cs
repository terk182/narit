using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Dellog
    {
        public string Fctabname { get; set; } = null!;
        public string Fctabskid { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fctype { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fccreateap { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public string Fclid { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fcreftype { get; set; } = null!;
        public string Fcbook { get; set; } = null!;
        public string Fccode { get; set; } = null!;
    }
}
