using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class PersonalAbility
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public string Score { get; set; } = null!;
        public string Remark { get; set; } = null!;
        public int StaffId { get; set; }

        public virtual Staff Staff { get; set; } = null!;
    }
}
