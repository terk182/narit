﻿using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Stock2
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcplant { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fcwhouse { get; set; } = null!;
        public string Fcprod { get; set; } = null!;
        public string Fclot { get; set; } = null!;
        public decimal Fnqty { get; set; }
        public decimal Fnstqtystd { get; set; }
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public string Fcskid { get; set; } = null!;
        public decimal Fnunqcqty { get; set; }
        public decimal Fnavgcost { get; set; }
        public decimal Fnallocqty { get; set; }
        public decimal Fnppqty { get; set; }
        public string Fcgag { get; set; } = null!;
        public string Fcstore { get; set; } = null!;
        public DateTime? Ftxfer { get; set; }
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
    }
}