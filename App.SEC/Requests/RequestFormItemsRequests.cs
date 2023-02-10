﻿using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Requests
{
    public class RequestFormItemsRequests
    {
        public int? Id { get; set; }
        public string DocNo { get; set; } = null!;
        public int? RequestFormId { get; set; }
        public string? Name { get; set; }
        public string? Descriptions { get; set; }
        public bool? Active { get; set; }
        public decimal? Price { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? Unit { get; set; }
        public decimal? TotalUnit { get; set; }
        public string? Remark { get; set; }
        public int? LbActivityId { get; set; }

    }
}