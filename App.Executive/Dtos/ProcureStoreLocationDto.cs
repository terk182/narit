using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.FIN.Dtos
{
    public class ProcureStoreLocationDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public int? ParentProcureStoreLocationId { get; set; }
        public int ProcureStoreLocationTypeEnum { get; set; }
        public string Detail { get; set; } = null!;
        public string Code { get; set; } = null!;
        public double? Area { get; set; }
        public string CanvasPosition { get; set; } = null!;
        public int? HrdepartmentId { get; set; }
        public string ImagePath { get; set; } = null!;

        //public virtual ProcureStoreLocation? ParentProcureStoreLocation { get; set; }
    }
}
