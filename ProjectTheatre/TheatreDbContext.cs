using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ProjectTheatre
{
   public class TheatreDbContext : DbContext
    {
        public TheatreDbContext():base("DbConnectionString")
        {
        }
        public DbSet<Theatre> Theatres { get; set; }
        public DbSet<Roli> Rolies { get; set; }
        public DbSet<Register> Registers { get; set; }
        public DbSet<Password> passwords { get; set; }
    }
}
