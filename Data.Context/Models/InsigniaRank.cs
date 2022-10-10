using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class InsigniaRank
    {
        public InsigniaRank()
        {
            Insignia = new HashSet<Insignia>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }

        public virtual ICollection<Insignia> Insignia { get; set; }
    }
}
