using Microsoft.EntityFrameworkCore;
using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Context
{
    public class SitioWebClubContext : DbContext
    {

        public SitioWebClubContext(DbContextOptions<SitioWebClubContext> options)
: base(options)
        {
        }

        public DbSet<Club> Clubs { get; set; }
        public DbSet<Socio> Socios { get; set; }
        public DbSet<Plan> Planes { get; set; }
        public DbSet<Actividad> Actividades { get; set; }


        












    }
}
