using CodeFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstApp.Entities
{
    public class MoContext : DbContext 
    {
        public MoContext() : base("CodeFirstEntities")
        {
        }

        public DbSet<Items> Product { get; set; }
        public DbSet<TypeCategory> Type { get; set; }

    }
}