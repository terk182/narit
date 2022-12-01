﻿using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Vscmntct
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fcchildtyp { get; set; } = null!;
        public string Fcchildh { get; set; } = null!;
        public string Fcchildi { get; set; } = null!;
        public string Fcmasterty { get; set; } = null!;
        public string Fcmasterh { get; set; } = null!;
        public string Fcmasteri { get; set; } = null!;
        public decimal Fnqty { get; set; }
        public decimal Fnumqty { get; set; }
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public string Fcskid { get; set; } = null!;
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public DateTime? Ftsrcupd { get; set; }
        public string Fcsrcupd { get; set; } = null!;
    }
}