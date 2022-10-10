using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class NameTitle
    {
        public NameTitle()
        {
            RelativePeople = new HashSet<RelativePerson>();
            staff = new HashSet<Staff>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public string? EnglishName { get; set; }

        public virtual ICollection<RelativePerson> RelativePeople { get; set; }
        public virtual ICollection<Staff> staff { get; set; }
    }
}
