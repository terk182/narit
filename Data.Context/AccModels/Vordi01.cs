using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Vordi01
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fcorderh { get; set; } = null!;
        public string Fcorderi { get; set; } = null!;
        public string Fcvordh01 { get; set; } = null!;
        public string Fcrcvedi { get; set; } = null!;
        public DateTime? Ftcreated { get; set; }
        public string Fcrenewal { get; set; } = null!;
        public string Fcrecstat { get; set; } = null!;
        public string Fcsendstat { get; set; } = null!;
        public string Fcseq { get; set; } = null!;
        public string Fcpdcode { get; set; } = null!;
        public string Fcumcode { get; set; } = null!;
        public string Fcpackstyl { get; set; } = null!;
        public decimal Fnqty { get; set; }
        public decimal Fnprice { get; set; }
        public DateTime? Fddelivery { get; set; }
        public string Fcshipmode { get; set; } = null!;
        public string Fcdestcity { get; set; } = null!;
        public string Fcpdname { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public string Fcpdmap { get; set; } = null!;
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
    }
}
