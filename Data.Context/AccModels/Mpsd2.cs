﻿using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Mpsd2
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcplant { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fcgvpolicy { get; set; } = null!;
        public string Fcstep { get; set; } = null!;
        public string Fcstat { get; set; } = null!;
        public DateTime Fddate { get; set; }
        public string Fccoor { get; set; } = null!;
        public string Fcprod { get; set; } = null!;
        public decimal Fnqty { get; set; }
        public string Fcmplanh { get; set; } = null!;
        public string Fcmplani { get; set; } = null!;
        public string Fcmorderh { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public decimal Fnrcvqty { get; set; }
        public DateTime? Fdpdate { get; set; }
        public string Fcppdsth { get; set; } = null!;
        public string Fcpprod { get; set; } = null!;
        public decimal Fnpqty { get; set; }
        public decimal Fncontent { get; set; }
        public decimal Fnratio { get; set; }
        public string Fcmps { get; set; } = null!;
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
    }
}