﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalD.Templates.ApiResponses
{
    public class LoginResponse
    {
        public string success { get; set; }
        public string consumerkey { get; set; }
        public string consumersecret { get; set; }
    }

    public class LoginResponseRootObject
    {
        public LoginResponse response { get; set; }
    }
}