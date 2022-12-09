using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.EIS.Models.Responses
{
    public class EisBaseResponse
    {
        public bool Success { get; set; }
        public string? Errors { get; set; }
        public string? Messsage { get; set; }
    }
}
