﻿using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Vcmmpdei
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fcbakyrhis { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fcvcmmpdeh { get; set; } = null!;
        public string Fcprod { get; set; } = null!;
        public string Fcseq { get; set; } = null!;
        public decimal Fnprice { get; set; }
        public string Fccommstr { get; set; } = null!;
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public int Fimillisec { get; set; }
        public DateTime Ftdatetime { get; set; }
        public string Fccreateby { get; set; } = null!;
        public DateTime? Ftlastupd { get; set; }
        public string Fcupdateby { get; set; } = null!;
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public DateTime? Ftsrcupd { get; set; }
        public string Fcsrcupd { get; set; } = null!;
    }
}