using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class Race
    {
        public Race()
        {
            RelativePeople = new HashSet<RelativePerson>();
            staff = new HashSet<Staff>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }

        public virtual ICollection<RelativePerson> RelativePeople { get; set; }
        public virtual ICollection<Staff> staff { get; set; }
    }
}
