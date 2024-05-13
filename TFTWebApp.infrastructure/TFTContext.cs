using Microsoft.EntityFrameworkCore;
using TFTWebApp.Core.Models;

namespace TFTWebApp.infrastructure
{
    //Database context
    public class TFTContext : DbContext
    {
        public TFTContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Champion> Champions { get; set; }
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<Stats> ChampionStats { get; set; }
        
        public DbSet<Trait> Traits { get; set; }

        public DbSet<Variables> Variables { get; set; }


    }
}
