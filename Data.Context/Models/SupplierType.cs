﻿using System;
using System.Collections.Generic;

namespace Narit_API.Models
{
    public partial class SupplierType
    {
        public SupplierType()
        {
            Suppliers = new HashSet<Supplier>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }

        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
