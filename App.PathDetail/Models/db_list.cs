using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.PathDetail.Models
{
    public class db_list
    {
      
            public string? table { get; set; }
            public List<Datum>? data { get; set; }
        
        public class Datum
        {
            public string? field { get; set; }
            public string? type { get; set; }
        }

       
    }
}
