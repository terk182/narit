using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class FilingPostscript
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
    }
}
