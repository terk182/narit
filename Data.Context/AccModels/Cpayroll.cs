using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Cpayroll
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public decimal Fndayinyr { get; set; }
        public decimal Fndayinmth { get; set; }
        public decimal Fnhrinday { get; set; }
        public string Fcpayname { get; set; } = null!;
        public string Fcpayname2 { get; set; } = null!;
        public string Fcpaypost { get; set; } = null!;
        public string Fcpaypost2 { get; set; } = null!;
        public decimal Fnpyperiod { get; set; }
        public string Fccaltmeth { get; set; } = null!;
        public string Fccalsoc { get; set; } = null!;
        public string Fcsocno { get; set; } = null!;
        public string Fcsocbrseq { get; set; } = null!;
        public decimal Fnbegtime1 { get; set; }
        public decimal Fnendtime1 { get; set; }
        public decimal Fnbegtime2 { get; set; }
        public decimal Fnendtime2 { get; set; }
        public string Fcbankcorp { get; set; } = null!;
        public string Fctradereg { get; set; } = null!;
        public decimal Fnmxbusilv { get; set; }
        public decimal Fnmxsicklv { get; set; }
        public decimal Fnmxvacalv { get; set; }
        public decimal Fnmxcasulv { get; set; }
        public decimal Fnsalmanlv { get; set; }
        public decimal Fnwcallast { get; set; }
        public decimal Fnscallast { get; set; }
        public decimal Fnhlycal { get; set; }
        public decimal Fndaypay1 { get; set; }
        public decimal Fndaypay2 { get; set; }
        public decimal Fndaypay3 { get; set; }
        public decimal Fndaypay4 { get; set; }
        public decimal Fnhourpay1 { get; set; }
        public decimal Fnhourpay2 { get; set; }
        public decimal Fnhourpay3 { get; set; }
        public decimal Fnhourpay4 { get; set; }
        public string Fceafterr { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public string Fcqcbankac { get; set; } = null!;
        public string? Fmmemdata { get; set; }
        public string Fcsignpks1 { get; set; } = null!;
        public string Fcpostpks1 { get; set; } = null!;
        public string Fcsignpks2 { get; set; } = null!;
        public string Fcpostpks2 { get; set; } = null!;
        public string Fcdstaxcon { get; set; } = null!;
        public string Fcfracnet { get; set; } = null!;
        public string Fcfractax { get; set; } = null!;
        public string Fcfracsoc { get; set; } = null!;
        public string Fcfracfun { get; set; } = null!;
        public string Fcfracfun2 { get; set; } = null!;
        public decimal Fntaxdeci { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fcmanflag { get; set; } = null!;
        public string Fcaddapvby { get; set; } = null!;
        public string Fcedtapvby { get; set; } = null!;
        public string Fcdelapvby { get; set; } = null!;
        public string Fcisused { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public string Fclid { get; set; } = null!;
    }
}
