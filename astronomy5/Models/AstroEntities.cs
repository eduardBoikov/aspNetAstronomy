using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace astronomy5.Models
{
    public class AstronomyEntities : DbContext
    {
        public DbSet<Lidaparati> Aparati { get; set; }
        public DbSet<Misijas> Misijas { get; set; }
        public DbSet<Planetas> Planetas { get; set; }
        public DbSet<Pavadoni> Pavadoni { get; set; }
    }
}