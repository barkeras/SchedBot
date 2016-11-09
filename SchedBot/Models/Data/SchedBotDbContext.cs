using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchedBot.Models.Data
{
    public class SchedBotDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}