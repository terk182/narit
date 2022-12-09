using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class Application
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Detail { get; set; } = null!;
        public string Shortform { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string Link { get; set; } = null!;
    }
}
