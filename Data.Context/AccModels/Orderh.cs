using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Orderh
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fcudate { get; set; } = null!;
        public string Fcutime { get; set; } = null!;
        public string Fclupdapp { get; set; } = null!;
        public string Fcrftype { get; set; } = null!;
        public string Fcreftype { get; set; } = null!;
        public string Fccorp { get; set; } = null!;
        public string Fcbranch { get; set; } = null!;
        public string Fcdept { get; set; } = null!;
        public string Fcsect { get; set; } = null!;
        public string Fcjob { get; set; } = null!;
        public string Fcstat { get; set; } = null!;
        public string Fcstep { get; set; } = null!;
        public DateTime Fddate { get; set; }
        public DateTime? Fdduedate { get; set; }
        public DateTime? Fdrecedate { get; set; }
        public string Fcbook { get; set; } = null!;
        public string Fccode { get; set; } = null!;
        public string Fcrefno { get; set; } = null!;
        public decimal Fndiscamt1 { get; set; }
        public decimal Fndiscamt2 { get; set; }
        public decimal Fndiscamti { get; set; }
        public decimal Fndiscpcn1 { get; set; }
        public decimal Fndiscpcn2 { get; set; }
        public decimal Fndiscpcn3 { get; set; }
        public decimal Fnamt { get; set; }
        public decimal Fnamt2 { get; set; }
        public string Fcvatisout { get; set; } = null!;
        public string Fcvattype { get; set; } = null!;
        public decimal Fnvatrate { get; set; }
        public decimal Fnvatamt { get; set; }
        public string Fccoor { get; set; } = null!;
        public string Fcempl { get; set; } = null!;
        public string Fcemzone { get; set; } = null!;
        public string Fciscash { get; set; } = null!;
        public decimal Fncredterm { get; set; }
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public string Fccancelby { get; set; } = null!;
        public string Fcacstep { get; set; } = null!;
        public string? Fmmemdata { get; set; }
        public string Fchasret { get; set; } = null!;
        public string Fcvatdue { get; set; } = null!;
        public string Fcrecvman { get; set; } = null!;
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public string Fcstep2 { get; set; } = null!;
        public string Fcproj { get; set; } = null!;
        public string Fcdiscstr { get; set; } = null!;
        public string Fccurrency { get; set; } = null!;
        public decimal Fnamtke { get; set; }
        public decimal Fnvatamtke { get; set; }
        public decimal Fndiscamtk { get; set; }
        public decimal Fnxrate { get; set; }
        public string Fcfrwhouse { get; set; } = null!;
        public string Fctowhouse { get; set; } = null!;
        public string Fcapproveb { get; set; } = null!;
        public string Fcdelicoor { get; set; } = null!;
        public DateTime? Fdapprove { get; set; }
        public string Fcmstep { get; set; } = null!;
        public string Fcsubbr { get; set; } = null!;
        public string Fcplant { get; set; } = null!;
        public DateTime? Ftlastupd { get; set; }
        public string Fcpriority { get; set; } = null!;
        public string Fchaschain { get; set; } = null!;
        public string Fcxferstep { get; set; } = null!;
        public DateTime? Ftxfer { get; set; }
        public string? Fmmemdata2 { get; set; }
        public string? Fmmemdata3 { get; set; }
        public string? Fmmemdata4 { get; set; }
        public string Fcshowpled { get; set; } = null!;
        public string Fcstepx1 { get; set; } = null!;
        public string? Fmmemdata5 { get; set; }
        public string Fctradetrm { get; set; } = null!;
        public DateTime? Ftlastedit { get; set; }
        public string Fcreasonrq { get; set; } = null!;
        public string Fcpayterm { get; set; } = null!;
        public DateTime? Fdreqdate { get; set; }
        public string Fcreqmen { get; set; } = null!;
        public string Fccreateap { get; set; } = null!;
        public string Fcreqpersn { get; set; } = null!;
        public decimal Fndayassur { get; set; }
        public string Fcispdpart { get; set; } = null!;
        public string Fcperson { get; set; } = null!;
        public string Fclinkapp1 { get; set; } = null!;
        public string Fclinkstp1 { get; set; } = null!;
        public string Fclinkapp2 { get; set; } = null!;
        public string Fclinkstp2 { get; set; } = null!;
        public string Fccounter { get; set; } = null!;
        public string Fcpdbrand { get; set; } = null!;
        public string Fcrngtime { get; set; } = null!;
        public string Fctrantype { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public string Fcrecomenb { get; set; } = null!;
        public DateTime? Fdrecomenb { get; set; }
        public string? Fmmemdata6 { get; set; }
        public string? Fmmemdata7 { get; set; }
        public string? Fmmemdata8 { get; set; }
        public string? Fmmemdata9 { get; set; }
        public string? Fmmemdataa { get; set; }
        public string Fcrecalby { get; set; } = null!;
        public DateTime? Ftlasrecal { get; set; }
        public string Fccartype { get; set; } = null!;
        public string Fcdocstep { get; set; } = null!;
        public string Fcdocaprvb { get; set; } = null!;
        public DateTime? Fddocaprv { get; set; }
        public string Fccrstep { get; set; } = null!;
        public string Fccraprvb { get; set; } = null!;
        public DateTime? Fdcraprv { get; set; }
        public string Fcu1status { get; set; } = null!;
        public string Fcu2status { get; set; } = null!;
        public string Fclid { get; set; } = null!;
        public string Fcdeliby { get; set; } = null!;
        public string Fccvehicle { get; set; } = null!;
        public string Fcthrdpty { get; set; } = null!;
        public string Fcroutedel { get; set; } = null!;
        public string Fcdtype1 { get; set; } = null!;
        public decimal Fnu1cnt { get; set; }
        public string Fcdtype2 { get; set; } = null!;
        public decimal Fnu2cnt { get; set; }
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
        public string Fcdocflowi { get; set; } = null!;
        public string? Fmdocflow { get; set; }
        public string Fcboicard { get; set; } = null!;
        public string Fcboigroup { get; set; } = null!;
        public string Fccontactn { get; set; } = null!;
        public DateTime? Ftsrcupd { get; set; }
        public string Fcsrcupd { get; set; } = null!;
        public string Fcgid { get; set; } = null!;
    }
}
