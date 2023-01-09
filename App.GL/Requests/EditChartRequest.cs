﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.GL.Requests
{
    public class EditChartRequest
    {
        public int Id { get; set; }
        public int? BeforeCodeId { get; set; }
        public string? BeforeName { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? AccTypeId { get; set; }
        public string? Detail { get; set; }
    }
}
