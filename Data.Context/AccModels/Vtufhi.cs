﻿using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Vtufhi
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fctabname { get; set; } = null!;
        public string Fcfldname { get; set; } = null!;
        public string Fctabskid { get; set; } = null!;
        public DateTime? Ftvalue { get; set; }
        public string Fcvalue { get; set; } = null!;
        public string? Fmremark { get; set; }
        public string Fccreateby { get; set; } = null!;
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
    }
}