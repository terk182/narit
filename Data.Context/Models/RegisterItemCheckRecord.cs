using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class RegisterItemCheckRecord
    {
        public RegisterItemCheckRecord()
        {
            ProcureFiles = new HashSet<ProcureFile>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int RegisterItemCheckFormId { get; set; }
        public int DurableItemStatus { get; set; }
        public string Remark { get; set; } = null!;
        public int HrdepartmentId { get; set; }
        public int RegisterDurableItemId { get; set; }
        public string DepartmentName { get; set; } = null!;

        public virtual RegisterDurableItem RegisterDurableItem { get; set; } = null!;
        public virtual RegisterItemCheckForm RegisterItemCheckForm { get; set; } = null!;
        public virtual ICollection<ProcureFile> ProcureFiles { get; set; }
    }
}
