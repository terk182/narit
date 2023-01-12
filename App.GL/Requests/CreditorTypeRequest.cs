using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.GL.Requests
{
    public class CreditorTypeRequest
    {
        public int? Id { get; set; } 
        public string? TypeCode { get; set; } 
        public int Active { get; set; }
        public int Index { get; set; }
        public int AccountTypeID { get; set; }
        public string? Name { get; set; }
        public string? Detail { get; set; }
    }
}
