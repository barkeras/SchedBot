using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchedBot.Models.Account
{
    public class UserProfileViewModel
    {
        public int id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String EmailAddress { get; set; }
        public String StreetAddress { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String ZipCode { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastLogin { get; set; }
    }
}