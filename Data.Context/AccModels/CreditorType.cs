﻿using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class CreditorType
    {
        public int Id { get; set; }
        public string? CreditorTypeCode { get; set; }
        public string? Name { get; set; }
        public int Active { get; set; }
        public byte[] CreateDate { get; set; } = null!;
        public string? Detail { get; set; }
    }
}
