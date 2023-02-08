using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class ProjectCaptical
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int CapticalTypeId { get; set; }
        public bool Active { get; set; }
    }
}
