using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class Department
    {
        public int Id { get; set; }
        public string? Year { get; set; }
        public string? Name { get; set; }
        public bool? Active { get; set; }
    }
}
