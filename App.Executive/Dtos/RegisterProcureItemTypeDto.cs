using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.FIN.Dtos
{
    public class RegisterProcureItemTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int EnduranceTypeEnum { get; set; }
        public int? ParentRegisterProcureItemTypeId { get; set; }
        public string TypeCode { get; set; } = null!;
        public int? UsefulLife { get; set; }
    }
}
