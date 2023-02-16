using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.EDU.Responses
{
    public class loginResponse
    {
        public string? expiresIn { get; set; }
        public string? token { get; set; }
        public Data? data { get; set; }
    }
    public class Data
    {
        public int ID { get; set; }
        public string? UserName { get; set; }
        public int isActive { get; set; }
        public int isPDPA { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public int UserTypeID { get; set; }
        public object? CreatedAt { get; set; }
        public object? UpdatedAt { get; set; }
        public object? DeletedAt { get; set; }
    }

   
}
