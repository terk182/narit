using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Responses
{
    public class FundTypeRespone
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int FiscalYear { get; set; }
        public bool Active { get; set; }
        public int? ReferenceOldId { get; set; }
        public int? ParentFundTypeId { get; set; }
        public List<FundTypeRespone>? fundTypeRespone { get; set; }
    }
}
