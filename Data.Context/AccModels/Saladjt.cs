using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Saladjt
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fchsalary { get; set; } = null!;
        public string Fcempl { get; set; } = null!;
        public string Fcempltype { get; set; } = null!;
        public string Fctype { get; set; } = null!;
        public string Fcstat { get; set; } = null!;
        public string Fcyr { get; set; } = null!;
        public string Fcmth { get; set; } = null!;
        public string Fcpyperiod { get; set; } = null!;
        public DateTime Fddate { get; set; }
        public string Fcsaladj { get; set; } = null!;
        public decimal Fnsalrate { get; set; }
        public decimal Fnqty { get; set; }
        public decimal Fnamt { get; set; }
        public string Fcremark { get; set; } = null!;
        public string Fcbasetype { get; set; } = null!;
        public string Fcseq { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public string Fcincrule { get; set; } = null!;
        public string Fcpaytimes { get; set; } = null!;
        public string Fcdetaxcon { get; set; } = null!;
        public string Fciscaltax { get; set; } = null!;
        public string Fciscalsoc { get; set; } = null!;
        public string Fciscalfun { get; set; } = null!;
        public string Fccreateap { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
    }
}
