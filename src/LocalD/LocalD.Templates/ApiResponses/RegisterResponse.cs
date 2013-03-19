using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalD.Templates.ApiResponses
{
    public class RegisterResponse
    {
        public string success { get; set; }
    }

    public class RegisterResponseRootObject
    {
        public RegisterResponse response { get; set; }
    }

}
