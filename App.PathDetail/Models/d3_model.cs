using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.PathDetail.Models
{
    public class d3_model
    {
        public string? name { get; set; }
        public List<Child>? children { get; set; }
        public class Child
        {
            public string? name { get; set; }
            public List<Child>? children { get; set; }
            public string? type { get; set; }
        }

    }
}
