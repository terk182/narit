using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class FilingHrdepartmentPermission
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = null!;
        public int HrdepartmentId { get; set; }
        public int FilingRegisterBookId { get; set; }

        public virtual FilingRegisterBook FilingRegisterBook { get; set; } = null!;
    }
}
