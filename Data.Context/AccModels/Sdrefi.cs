using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Sdrefi
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fcstat { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fcgvpolicy { get; set; } = null!;
        public string Fcsdrefh { get; set; } = null!;
        public string Fcsdtype { get; set; } = null!;
        public string Fciotype { get; set; } = null!;
        public string Fcprodtype { get; set; } = null!;
        public string Fcprod { get; set; } = null!;
        public string Fcum { get; set; } = null!;
        public string Fcumstd { get; set; } = null!;
        public decimal Fnumqty { get; set; }
        public decimal Fnqty { get; set; }
        public string Fcstum { get; set; } = null!;
        public string Fcstumstd { get; set; } = null!;
        public decimal Fnstumqty { get; set; }
        public decimal Fnstqty { get; set; }
        public string Fcseq { get; set; } = null!;
        public string Fclot { get; set; } = null!;
        public string? Fmremark { get; set; }
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public DateTime? Ftsrcupd { get; set; }
        public string Fcsrcupd { get; set; } = null!;
    }
}
