﻿using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Orderix5
    {
        public string Fcskid { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcdataser { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fcreftype { get; set; } = null!;
        public string Fcrefitem { get; set; } = null!;
        public DateTime Fddate { get; set; }
        public string Fcprod { get; set; } = null!;
        public decimal Fnqty { get; set; }
        public decimal Fnumqty { get; set; }
        public string Fcum { get; set; } = null!;
        public decimal Fnstqty { get; set; }
        public decimal Fnstumqty { get; set; }
        public string Fcstum { get; set; } = null!;
        public decimal Fnprice { get; set; }
        public decimal Fnpriceke { get; set; }
        public DateTime? Fddelivery { get; set; }
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public string Fcseltag { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fcrevision { get; set; } = null!;
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fcproforma { get; set; } = null!;
        public string Fccreateap { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public DateTime? Ftsrcupd { get; set; }
        public string Fcsrcupd { get; set; } = null!;
    }
}