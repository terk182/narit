using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Promoti
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fcpromoth { get; set; } = null!;
        public string Fctype { get; set; } = null!;
        public string Fcstat { get; set; } = null!;
        public DateTime? Ftbegdate { get; set; }
        public DateTime? Ftenddate { get; set; }
        public string Fclist { get; set; } = null!;
        public string Fcseq { get; set; } = null!;
        public string Fcitemtype { get; set; } = null!;
        public string Fcpdgrp { get; set; } = null!;
        public string Fcformulas { get; set; } = null!;
        public string Fcprod { get; set; } = null!;
        public string Fcum { get; set; } = null!;
        public decimal Fnqty { get; set; }
        public decimal Fnumqty { get; set; }
        public decimal Fnprice { get; set; }
        public decimal Fnpriceke { get; set; }
        public string Fccurrency { get; set; } = null!;
        public string Fcdiscstr { get; set; } = null!;
        public decimal Fndiscamt { get; set; }
        public decimal Fnpoint1 { get; set; }
        public decimal Fnpoint2 { get; set; }
        public decimal Fnpoint3 { get; set; }
        public string? Fmmemdata { get; set; }
        public string Fccreateby { get; set; } = null!;
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public DateTime? Ftsrcupd { get; set; }
        public string Fcsrcupd { get; set; } = null!;
    }
}
