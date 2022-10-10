using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class StaffPositionInHrdepartment
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int HrdepartmentId { get; set; }
        public int StaffId { get; set; }
        public int PositionInHrdepartmentEnum { get; set; }
    }
}
