using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class FilingOpinion
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
    }
}
