using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchedBot.Models.Data
{
    [Table("tblUser")]
    public class User
    {
        [Key]
        public int id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String EmailAddress { get; set; }
        public String Password { get; set; }
        public String PhoneNumber { get; set; }

        //More to be inserted
    }
}