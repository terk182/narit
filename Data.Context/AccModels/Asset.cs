using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Asset
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fcbakyrhis { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fcsect { get; set; } = null!;
        public string Fcstat { get; set; } = null!;
        public string Fcexist { get; set; } = null!;
        public string Fcacchart { get; set; } = null!;
        public string Fccode { get; set; } = null!;
        public string Fcqcacchar { get; set; } = null!;
        public string Fcname { get; set; } = null!;
        public string Fcname2 { get; set; } = null!;
        public string Fcremark { get; set; } = null!;
        public string Fcinstruct { get; set; } = null!;
        public decimal Fngrosspri { get; set; }
        public decimal Fnaccprice { get; set; }
        public decimal Fnmktprice { get; set; }
        public decimal Fnbuyprice { get; set; }
        public DateTime? Fdbuydate { get; set; }
        public DateTime? Fdstartdat { get; set; }
        public string Fcmethod { get; set; } = null!;
        public string Fcsumof { get; set; } = null!;
        public string Fcvchof { get; set; } = null!;
        public decimal Fnshipcost { get; set; }
        public decimal Fnimplcost { get; set; }
        public decimal Fnmisccost { get; set; }
        public string Fcwarranno { get; set; } = null!;
        public string Fcorderno { get; set; } = null!;
        public string Fcpayrefno { get; set; } = null!;
        public string Fcinsureco { get; set; } = null!;
        public string Fcinsureno { get; set; } = null!;
        public decimal Fninsumthp { get; set; }
        public decimal Fninsureli { get; set; }
        public DateTime? Fdendinsur { get; set; }
        public DateTime? Fdsaledate { get; set; }
        public decimal Fnsalepric { get; set; }
        public string Fcsaleref { get; set; } = null!;
        public decimal Fndeprrate { get; set; }
        public decimal Fndeprrest { get; set; }
        public decimal Fnaccmdepr { get; set; }
        public decimal Fnpreyrval { get; set; }
        public decimal Fnpreyrdep { get; set; }
        public string Fcmthdepra { get; set; } = null!;
        public string Fcaccdepra { get; set; } = null!;
        public string Fcactype { get; set; } = null!;
        public string Fcacgroup { get; set; } = null!;
        public string Fcbuyfrom { get; set; } = null!;
        public string Fcserialno { get; set; } = null!;
        public string Fcmodel { get; set; } = null!;
        public string Fcbrand { get; set; } = null!;
        public decimal Fnlifeyr { get; set; }
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public string Fcfchr { get; set; } = null!;
        public string Fcasgrp { get; set; } = null!;
        public string Fcjob { get; set; } = null!;
        public DateTime? Fdendcal { get; set; }
        public string Fcaschain { get; set; } = null!;
        public string? Fmpicname { get; set; }
        public string Fctouton { get; set; } = null!;
        public string Fcmainass { get; set; } = null!;
        public string Fclocation { get; set; } = null!;
        public string Fcsubbr { get; set; } = null!;
        public string Fcplant { get; set; } = null!;
        public DateTime? Ftlastupd { get; set; }
        public decimal Fndpr0pcn { get; set; }
        public string Fciscal { get; set; } = null!;
        public string Fcbarcode { get; set; } = null!;
        public string Fccarid { get; set; } = null!;
        public string Fcloca1 { get; set; } = null!;
        public string Fcremark2 { get; set; } = null!;
        public string Fcrefprod { get; set; } = null!;
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fcresttype { get; set; } = null!;
        public string Fcu1status { get; set; } = null!;
        public string Fcu2status { get; set; } = null!;
        public string Fcdtype1 { get; set; } = null!;
        public string Fcdtype2 { get; set; } = null!;
        public decimal Fnu1cnt { get; set; }
        public decimal Fnu2cnt { get; set; }
        public string? Fmerrmsg { get; set; }
        public string Fclid { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public string Fcoccempl { get; set; } = null!;
        public string Fcmanflag { get; set; } = null!;
        public string Fcaddapvby { get; set; } = null!;
        public string Fcedtapvby { get; set; } = null!;
        public string Fcdelapvby { get; set; } = null!;
        public string Fcisused { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public string Fcu3status { get; set; } = null!;
        public string Fcdtype3 { get; set; } = null!;
        public decimal Fnu3cnt { get; set; }
        public string Fcu4status { get; set; } = null!;
        public string Fcdtype4 { get; set; } = null!;
        public decimal Fnu4cnt { get; set; }
        public string Fcu5status { get; set; } = null!;
        public string Fcdtype5 { get; set; } = null!;
        public decimal Fnu5cnt { get; set; }
        public string Fcu6status { get; set; } = null!;
        public string Fcdtype6 { get; set; } = null!;
        public decimal Fnu6cnt { get; set; }
        public string Fcu7status { get; set; } = null!;
        public string Fcdtype7 { get; set; } = null!;
        public decimal Fnu7cnt { get; set; }
        public string Fcu8status { get; set; } = null!;
        public string Fcdtype8 { get; set; } = null!;
        public decimal Fnu8cnt { get; set; }
        public string Fcu9status { get; set; } = null!;
        public string Fcdtype9 { get; set; } = null!;
        public decimal Fnu9cnt { get; set; }
        public string Fcboicard { get; set; } = null!;
        public DateTime? Ftsrcupd { get; set; }
        public string Fcsrcupd { get; set; } = null!;
        public string Fcgid { get; set; } = null!;
    }
}
