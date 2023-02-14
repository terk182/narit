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


        public List<SubProject>? SubProject { get; set; }
        public List<ProjectActivity>? ProjectActivity { get; set; }
    }
}
