﻿using App.Common.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Authenticator.Models.Responses
{
    public class AuthenticatorBaseResponse : CommonBaseResponse
    {
        public Guid userid { get; set; }
       // public userdetail userdetail { get; set; }
    }
    //public class userdetail { 
    //public Guid userid { get; set; }
    // public string username { get; set; }

    //}
}
