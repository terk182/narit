using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class ProjectResponsiblePerson
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public int ProjectId { get; set; }
        public bool Active { get; set; }
    }
}
