using Microsoft.EntityFrameworkCore;

namespace Mission06_Bangerter.Models
{
    public class NewMovieContext : DbContext
    {
        public NewMovieContext(DbContextOptions<NewMovieContext> options) : base(options)
        {
        }

        public DbSet<NewMovies> Movies { get; set; }
    }
}
