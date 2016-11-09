using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchedBot.Models.Account
{
    public class CreateUserViewModel
    {
        [Required]
        public String FirstName { get; set; }
        [Required]
        public String LastName { get; set; }
        [Required]
        public String StreetAddress { get; set; }
        [Required]
        public String City { get; set; }
        [Required]
        public String State { get; set; }
        [Required]
        public String ZipCode { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public String Password { get; set; }
        [Required]
        public String PasswordConfirm { get; set; }
    }
}