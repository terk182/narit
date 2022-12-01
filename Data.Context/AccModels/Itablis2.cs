﻿using System;
using System.Collections.Generic;

namespace narit_mis_api.AccModels
{
    public partial class Itablis2
    {
        public string Fcname { get; set; } = null!;
        public string Fcidtype { get; set; } = null!;
        public DateTime Ftdatetime { get; set; }
        public int Fimilisec { get; set; }
        public int Finmilisec { get; set; }
        public string Fcconnid { get; set; } = null!;
        public string Fcfchr { get; set; } = null!;
        public string Fcseltag { get; set; } = null!;
        public string Fcskid { get; set; } = null!;
        public string Fcliving { get; set; } = null!;
        public DateTime? Ftlastupd { get; set; }
        public DateTime? Ftlastedit { get; set; }
        public string Fccreateap { get; set; } = null!;
        public string Fcu1acc { get; set; } = null!;
        public string Fcdataimp { get; set; } = null!;
        public string Fccreateby { get; set; } = null!;
        public string Fccorrectb { get; set; } = null!;
    }
}