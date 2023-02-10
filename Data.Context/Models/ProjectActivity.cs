using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class ProjectActivity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Code { get; set; }
        public int? DepartmentId { get; set; }
        public int ProjectId { get; set; }
        public bool Active { get; set; }
        public int ProjectStatus { get; set; }
    }
}
