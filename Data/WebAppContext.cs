using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;
using WebApp.Models.Entities.BiancoENero;

namespace WebApp.Data
{
    public class WebAppContext : DbContext
    {
        public WebAppContext (DbContextOptions<WebAppContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<WebApp.Models.Autore> Autore { get; set; }

        public DbSet<WebApp.Models.Opera> Opera { get; set; }

        public DbSet<WebApp.Models.Personaggio> Personaggio { get; set; }

        public DbSet<WebApp.Models.Recensione> Recensione { get; set; }

        public DbSet<WebApp.Models.Entities.BiancoENero.Vino> Vino { get; set; }

        public DbSet<WebApp.Models.Entities.BiancoENero.Zona> Zona { get; set; }

        public DbSet<WebApp.Models.Entities.BiancoENero.Provenienza> Provenienza { get; set; }
    }
}
