using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.PathDetail.Models
{
    public class SiteMap
    {
        public string? guid { get; set; }
        public string? path { get; set; }
        public string? tag { get; set; }
        public string? th_name { get; set; }
        public string? en_name { get; set; }
        public List<Datum>? list { get; set; }


    }

    public class Datum
    {
        public string? guid { get; set; }

        public string? tag { get; set; }
        public string? path { get; set; }
        public string? th_name { get; set; }
        public string? en_name { get; set; }

    }



}
