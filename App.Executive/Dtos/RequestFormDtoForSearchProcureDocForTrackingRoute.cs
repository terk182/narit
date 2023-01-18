using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.FIN.Dtos
{
    public class RequestFormDtoForSearchProcureDocForTrackingRoute
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool? Active { get; set; }
        public DateTime? WriteDate { get; set; }
        public string DocumentNumber { get; set; } = null!;
        public string DepartmentName { get; set; } = null!;
        public decimal? MedianPrice { get; set; }

    }
}
