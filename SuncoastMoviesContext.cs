
using Microsoft.EntityFrameworkCore;

namespace SuncoastMovies
{
    public class SuncoastMoviesContext : DbContext
    {

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Actor> Actors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseNpgsql("server=localhost;database=SuncoastMovies");

        }

    }
}