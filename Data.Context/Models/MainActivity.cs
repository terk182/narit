﻿using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class MainActivity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int MainProjectId { get; set; }
    }
}
