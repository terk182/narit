using System;
using System.Collections.Generic;

namespace narit_acc_api.Models
{
    public partial class PersonType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int ContactTypeId { get; set; }
    }
}
