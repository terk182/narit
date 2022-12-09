using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Ptrust
    {
        public string Fcpost { get; set; } = null!;
        public string Fcsysobj { get; set; } = null!;
        public decimal Fnrigsetri { get; set; }
        public decimal Fnenterrig { get; set; }
        public decimal Fnshowrig { get; set; }
        public decimal Fnexitrig { get; set; }
        public decimal Fnpwreqrig { get; set; }
        public decimal Fninsertri { get; set; }
        public decimal Fneditrig { get; set; }
        public decimal Fndelerig { get; set; }
        public decimal Fncancelri { get; set; }
        public decimal Fnprintrig { get; set; }
        public decimal Fnviewrig { get; set; }
        public decimal Fnfilerig { get; set; }
        public string Fcskid { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public DateTime? Ftlastupd { get; set; }
        public DateTime Ftdatetime { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
    }
}
