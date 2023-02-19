using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class DepartmentsGroup
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string? GroupName { get; set; }
        public int DepartmentsId { get; set; }
        public int Seq { get; set; }
        public int Year { get; set; }
        public string? Type { get; set; }
    }
}
