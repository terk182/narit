using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.SEC.Models.Requests
{
    public class PrinciplePlanTagsRequest
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public decimal Weight { get; set; }
        public int? ParentPrinciplePlanTagId { get; set; }
    }
}
