using System;
using System.Collections.Generic;
using System.Text;

namespace Auth.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Roles { get; set; }
        public string Token { get; set; }
    }
}
