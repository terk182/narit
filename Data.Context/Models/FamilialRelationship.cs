using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class FamilialRelationship
    {
        public FamilialRelationship()
        {
            RelativePeople = new HashSet<RelativePerson>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FamilyRelationTypeEnum { get; set; }

        public virtual ICollection<RelativePerson> RelativePeople { get; set; }
    }
}
