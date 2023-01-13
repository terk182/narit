﻿using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class TaxType
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public byte[] CreateDate { get; set; } = null!;
        public int Active { get; set; }
        public string? Detail { get; set; }
    }
}
