using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class Country
    {
        public Country()
        {
            Organizations = new HashSet<Organization>();
        }

        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
        public int? CanvasPositionX { get; set; }
        public int? CanvasPositionY { get; set; }

        public virtual ICollection<Organization> Organizations { get; set; }
    }
}
