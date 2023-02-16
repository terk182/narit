using narit_mis_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.NewCGIMIS.Responses
{
    public class NewBaseResponse
    {
        public bool Success { get; set; }
        public string? Errors { get; set; }
        public string? Messsage { get; set; }
        public object? Data { get; set; }
    }
}
