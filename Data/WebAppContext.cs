using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class WebAppContext : DbContext
    {
        public WebAppContext (DbContextOptions<WebAppContext> options)
            : base(options)
        {
        }

        public DbSet<WebApp.Models.Autore> Autore { get; set; }

        public DbSet<WebApp.Models.Opera> Opera { get; set; }

        public DbSet<WebApp.Models.Personaggio> Personaggio { get; set; }

        public DbSet<WebApp.Models.Recensione> Recensione { get; set; }
    }
}
