using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Taskqueu
    {
        public string Fcskid { get; set; } = null!;
        public string Fcstatus { get; set; } = null!;
        public string Fcreqjob { get; set; } = null!;
        public string Fcqueue { get; set; } = null!;
        public string Fcrowid { get; set; } = null!;
        public string Fcstring { get; set; } = null!;
        public string? Fmreqpara { get; set; }
        public string Fcseltag { get; set; } = null!;
        public DateTime? Ftlastupd { get; set; }
        public DateTime Ftdatetime { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fctabskid { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public DateTime? Ftsrcupd { get; set; }
        public string Fcsrcupd { get; set; } = null!;
    }
}
