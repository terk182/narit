using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Acc.Contact.Responses
{
    public class ContactMainResponse
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? ContactName { get; set; }
        public int? ContactTypeID { get; set; }
        public string? ContactTypeName { get; set; }

        public bool? Active { get; set; }
    }
}
