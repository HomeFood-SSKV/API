using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Common.JwtParser
{
 

    public class JwtClaim
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        //public string Password { get; set; }
        public string Token { get; set; }
    }
}
