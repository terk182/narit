﻿using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Logipat
    {
        public string Fcskid { get; set; } = null!;
        public string Fcpatern { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public string Fcconnid { get; set; } = null!;
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
