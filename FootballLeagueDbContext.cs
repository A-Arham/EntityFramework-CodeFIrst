using EntityFramework.Domain; // Correct namespace
using ENtityFramework.Domain;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Data
{
    public class FootballLeagueDbContext : DbContext
    {
        public FootballLeagueDbContext(DbContextOptions<FootballLeagueDbContext> options)
            : base(options)
        {
        }

        public FootballLeagueDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Only configure if not already provided (e.g., during design-time)
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=FootballLeague_EFCore");
            }
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<League> Leagues { get; set; } // PascalCase property name
    }
}