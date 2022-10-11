using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class AspnetPersonalizationPerUser
    {
        public Guid Id { get; set; }
        public Guid? PathId { get; set; }
        public Guid? UserId { get; set; }
        public byte[] PageSettings { get; set; } = null!;
        public DateTime LastUpdatedDate { get; set; }

        public virtual AspnetPath? Path { get; set; }
        public virtual AspnetUser? User { get; set; }
    }
}
