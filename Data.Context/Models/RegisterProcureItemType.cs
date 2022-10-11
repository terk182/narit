using System;
using System.Collections.Generic;

namespace narit_mis_api.Models
{
    public partial class RegisterProcureItemType
    {
        public RegisterProcureItemType()
        {
            InverseParentRegisterProcureItemType = new HashSet<RegisterProcureItemType>();
            RegisterDurableItems = new HashSet<RegisterDurableItem>();
            RegisterProcureItems = new HashSet<RegisterProcureItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int EnduranceTypeEnum { get; set; }
        public int? ParentRegisterProcureItemTypeId { get; set; }
        public string TypeCode { get; set; } = null!;
        public int? UsefulLife { get; set; }

        public virtual RegisterProcureItemType? ParentRegisterProcureItemType { get; set; }
        public virtual ICollection<RegisterProcureItemType> InverseParentRegisterProcureItemType { get; set; }
        public virtual ICollection<RegisterDurableItem> RegisterDurableItems { get; set; }
        public virtual ICollection<RegisterProcureItem> RegisterProcureItems { get; set; }
    }
}
