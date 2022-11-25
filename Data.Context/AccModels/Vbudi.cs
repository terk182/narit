using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Vbudi
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fcstat { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fcvbudh { get; set; } = null!;
        public string Fcproj { get; set; } = null!;
        public string Fcjob { get; set; } = null!;
        public string Fcdept { get; set; } = null!;
        public string Fcsect { get; set; } = null!;
        public string Fcacchart { get; set; } = null!;
        public decimal Fnamt { get; set; }
        public decimal Fnpramt { get; set; }
        public decimal Fnpoamt { get; set; }
        public decimal Fninvamt { get; set; }
        public string? Fmremark { get; set; }
        public string Fcseq { get; set; } = null!;
        public decimal Fnretamt { get; set; }
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fcstep { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public string Fcsectbud { get; set; } = null!;
        public string Fcbudgrp { get; set; } = null!;
        public DateTime? Ftsrcupd { get; set; }
        public string Fcsrcupd { get; set; } = null!;
    }
}
