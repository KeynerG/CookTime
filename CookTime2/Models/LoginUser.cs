using System;
using System.Collections.Generic;
using System.Text;

namespace CookTime2.Models
{
    class LoginUser
    {
        public string email { set; get; }
        public string password { set; get; }
        public string username { set; get; }

        public LoginUser(string email, string password, string username)
        {
            this.email = email;
            this.password = password;
            this.username = username;
        }
    }
}
