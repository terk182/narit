using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Glrefct
    {
        public string Fcudate { get; set; } = null!;
        public string Fcdataser { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
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
        public string Fcacstep { get; set; } = null!;
        public string Fcglhead { get; set; } = null!;
        public string Fcglheadca { get; set; } = null!;
        public DateTime Fddate { get; set; }
        public DateTime? Fdrecedate { get; set; }
        public DateTime? Fdduedate { get; set; }
        public DateTime? Fdlaydate { get; set; }
        public DateTime? Fddebtdate { get; set; }
        public string Fcdebtcode { get; set; } = null!;
        public string Fcbook { get; set; } = null!;
        public string Fccode { get; set; } = null!;
        public string Fcrefno { get; set; } = null!;
        public decimal Fndiscamti { get; set; }
        public decimal Fndiscamt1 { get; set; }
        public decimal Fndiscamt2 { get; set; }
        public decimal Fndiscamta { get; set; }
        public decimal Fndiscpcn1 { get; set; }
        public decimal Fndiscpcn2 { get; set; }
        public decimal Fndiscpcn3 { get; set; }
        public decimal Fnamt { get; set; }
        public decimal Fnpayamt { get; set; }
        public decimal Fnspayamt { get; set; }
        public decimal Fnbefoamt { get; set; }
        public string Fcvatisout { get; set; } = null!;
        public string Fcvattype { get; set; } = null!;
        public decimal Fnvatrate { get; set; }
        public decimal Fnvatamt { get; set; }
        public decimal Fnamt2 { get; set; }
        public decimal Fnamtnovat { get; set; }
        public string Fccoor { get; set; } = null!;
        public string Fcempl { get; set; } = null!;
        public decimal Fncredterm { get; set; }
        public string Fciscash { get; set; } = null!;
        public string Fchasret { get; set; } = null!;
        public string Fcvatdue { get; set; } = null!;
        public decimal Fndebtzero { get; set; }
        public string Fclayh { get; set; } = null!;
        public string Fclayseq { get; set; } = null!;
        public string Fcfrwhouse { get; set; } = null!;
        public string Fctowhouse { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
        public string Fccancelby { get; set; } = null!;
        public string? Fmmemdata { get; set; }
        public string Fcseq { get; set; } = null!;
        public string Fcpromote { get; set; } = null!;
        public string Fcvatcoor { get; set; } = null!;
        public string Fcrecvman { get; set; } = null!;
        public string Fcstepx1 { get; set; } = null!;
        public string Fcstepx2 { get; set; } = null!;
        public string Fccreatety { get; set; } = null!;
        public string Fceafterr { get; set; } = null!;
        public string Fcatstep { get; set; } = null!;
        public decimal Fnvatport { get; set; }
        public decimal Fnvatporta { get; set; }
        public string Fcmachine { get; set; } = null!;
        public string Fcperiods { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public string Fcutime { get; set; } = null!;
        public string Fccashier { get; set; } = null!;
        public string Fctxqcbran { get; set; } = null!;
        public string Fctxqcwhou { get; set; } = null!;
        public string Fctxqcbook { get; set; } = null!;
        public string Fctxqcglre { get; set; } = null!;
        public string Fctxbranch { get; set; } = null!;
        public string Fctxwhouse { get; set; } = null!;
        public string Fctxbook { get; set; } = null!;
        public string Fcapproveb { get; set; } = null!;
        public DateTime? Fdfullfill { get; set; }
        public string Fcproj { get; set; } = null!;
        public string Fcdiscstr { get; set; } = null!;
        public string Fccurrency { get; set; } = null!;
        public decimal Fnxrate { get; set; }
        public decimal Fnamtke { get; set; }
        public decimal Fnvatamtke { get; set; }
        public decimal Fnpayamtke { get; set; }
        public decimal Fndiscamtk { get; set; }
        public decimal Fnbpayinv { get; set; }
        public string Fcvatseq { get; set; } = null!;
        public string Fctimestam { get; set; } = null!;
        public string Fctranwhy { get; set; } = null!;
        public string Fcdelicoor { get; set; } = null!;
        public string Fcsubbr { get; set; } = null!;
        public string Fcmorderh { get; set; } = null!;
        public string Fcplant { get; set; } = null!;
        public DateTime? Ftlastupd { get; set; }
        public string Fcxferstep { get; set; } = null!;
        public DateTime? Ftxfer { get; set; }
        public decimal Fnstockupd { get; set; }
        public string Fcdocowner { get; set; } = null!;
        public string Fcrefdo { get; set; } = null!;
        public string Fcinvia { get; set; } = null!;
        public string Fcoutvia { get; set; } = null!;
        public string Fcvldctrl { get; set; } = null!;
        public string Fcpcontrac { get; set; } = null!;
        public string Fcqcmo { get; set; } = null!;
        public string Fcqcmobk { get; set; } = null!;
        public string Fchaschain { get; set; } = null!;
        public string? Fmmemdata2 { get; set; }
        public string? Fmmemdata3 { get; set; }
        public string? Fmmemdata4 { get; set; }
        public string Fcshowpled { get; set; } = null!;
        public decimal Fnppayamt { get; set; }
        public decimal Fnppayamtk { get; set; }
        public DateTime? Fdvatdate { get; set; }
        public decimal Fnlocked { get; set; }
        public decimal Fnretenamt { get; set; }
        public string? Fmmemdata5 { get; set; }
        public string Fctxid { get; set; } = null!;
        public string Fcsubtxid { get; set; } = null!;
        public string Fctradetrm { get; set; } = null!;
        public string Fcdeliempl { get; set; } = null!;
        public string Fclaymethd { get; set; } = null!;
        public string Fcconsign { get; set; } = null!;
        public string Fcstepd { get; set; } = null!;
        public DateTime? Ftreceive { get; set; }
        public string Fclid { get; set; } = null!;
        public DateTime? Ftlastedit { get; set; }
        public decimal Fndepamt { get; set; }
        public decimal Fndepamtke { get; set; }
        public decimal Fnbefdep { get; set; }
        public decimal Fnbefdepke { get; set; }
        public decimal Fnu1cnt { get; set; }
        public decimal Fnu2cnt { get; set; }
        public string? Fmerrmsg { get; set; }
        public string Fccreateap { get; set; } = null!;
        public decimal Fnexpamt { get; set; }
        public string Fcperson { get; set; } = null!;
        public string Fclinkapp1 { get; set; } = null!;
        public string Fclinkstp1 { get; set; } = null!;
        public string Fclinkapp2 { get; set; } = null!;
        public string Fclinkstp2 { get; set; } = null!;
        public string Fccounter { get; set; } = null!;
        public string Fcpdbrand { get; set; } = null!;
        public decimal Fncrxrate { get; set; }
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public DateTime? Fdapprove { get; set; }
        public string Fcpayterm { get; set; } = null!;
        public string Fcu1status { get; set; } = null!;
        public string Fcu2status { get; set; } = null!;
        public string Fcdtype1 { get; set; } = null!;
        public string Fcdtype2 { get; set; } = null!;
        public string? Fmmemdata6 { get; set; }
        public string? Fmmemdata7 { get; set; }
        public string? Fmmemdata8 { get; set; }
        public string? Fmmemdata9 { get; set; }
        public string? Fmmemdataa { get; set; }
        public string Fcchkdt { get; set; } = null!;
        public string Fcrecalby { get; set; } = null!;
        public DateTime? Ftlasrecal { get; set; }
        public string Fcmnmglh { get; set; } = null!;
        public string Fcmnmglhca { get; set; } = null!;
        public decimal Fnaftdep { get; set; }
        public decimal Fnaftdepke { get; set; }
        public string Fcglref { get; set; } = null!;
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
        public string Fcboigroup { get; set; } = null!;
        public DateTime? Ftsrcupd { get; set; }
        public string Fcsrcupd { get; set; } = null!;
        public string Fcgid { get; set; } = null!;
    }
}
