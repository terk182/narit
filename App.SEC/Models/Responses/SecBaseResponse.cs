﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Responses
{
    public class SecBaseResponse
    {
        public bool Success { get; set; }
        public string? Errors { get; set; }
        public string? Messsage { get; set; }
    }
}
