using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace identityMVC.Models
{
    public class Context :DbContext
    {
        public Context():base("myConn")
        { 

        }
        public virtual DbSet<User> Users { get; set; }

    }
}