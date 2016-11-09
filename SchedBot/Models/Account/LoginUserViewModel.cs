using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchedBot.Models.Account
{
    public class LoginUserViewModel
    {
        public String EmailAddress { get; set; }
        public String Password { get; set; }
        public bool RememberMe { get; set; }
    }
}