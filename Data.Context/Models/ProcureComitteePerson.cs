using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class ProcureComitteePerson
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int FiscalYear { get; set; }
        public int StaffId { get; set; }
        public int? HrdepartmentId { get; set; }
        public int ProcureComitteeGroupId { get; set; }
        public bool IsVolunteer { get; set; }
        public bool IsChairman { get; set; }
        public string HrdepartmentName { get; set; } = null!;
        public bool IsSecretary { get; set; }

        public virtual ProcureComitteeGroup ProcureComitteeGroup { get; set; } = null!;
    }
}
