using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Taxcond
    {
        public string Fcdataser { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public decimal Fnpctexp { get; set; }
        public decimal Fnmaxexp { get; set; }
        public decimal Fnowndedu { get; set; }
        public decimal Fncoupdedu { get; set; }
        public decimal Fnsondedu { get; set; }
        public decimal Fnmaxson { get; set; }
        public decimal Fnsschdedu { get; set; }
        public decimal Fnmaxssch { get; set; }
        public decimal Fnmaxinsur { get; set; }
        public decimal Fnmaxfund { get; set; }
        public decimal Fnpctfund { get; set; }
        public decimal Fnmaxlend { get; set; }
        public decimal Fnpctsoc { get; set; }
        public decimal Fnpctdonat { get; set; }
        public decimal Fnmax2csoc { get; set; }
        public decimal Fnmin2csoc { get; set; }
        public decimal Fnminsocam { get; set; }
        public string Fcseltag { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimillisec { get; set; }
        public string Fceafterr { get; set; } = null!;
        public decimal Fnmaxfundc { get; set; }
        public decimal Fnpctfundc { get; set; }
        public decimal Fnparededu { get; set; }
        public decimal Fnpctrmf { get; set; }
        public decimal Fnmaxrmf { get; set; }
        public decimal Fnpctltf { get; set; }
        public decimal Fnmaxltf { get; set; }
        public decimal Fnpctspedu { get; set; }
        public decimal Fnmaxinsu2 { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public decimal Fnrepay { get; set; }
        public decimal Fnpvteach { get; set; }
        public decimal Fnrmfpct { get; set; }
        public decimal Fnrmfamt { get; set; }
        public decimal Fnltfpct { get; set; }
        public decimal Fnltfamt { get; set; }
        public decimal Fncinsuram { get; set; }
        public decimal Fnmaxsocam { get; set; }
        public decimal Fnfund2 { get; set; }
        public decimal Fnmaxfund2 { get; set; }
        public decimal Fnmaxfundp { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public DateTime? Ftlastupd { get; set; }
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
