using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class SubProjectResponsiblePerson
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public int SubProjectId { get; set; }
        public bool Active { get; set; }
        public string Position { get; set; } = null!;
    }
}
