using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    //public class AppDbContext : DbContext
    // Senza identity usare DbContext
    // Usare IdentityUser per le tabelle di default di identity.
    // Creare una classe di estensione per aggiungere campi alla tabella user: IdentityUserExtended
    public class AppDbContext : IdentityDbContext<IdentityUserExtended>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {
        }

        public DbSet<Pie> Pies { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

    }
}
