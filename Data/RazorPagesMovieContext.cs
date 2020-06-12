using Microsoft.EntityFrameworkCore;

namespace MediaWebApp.Data
{
   public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext (
            DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MediaWebApp.Models.Movie> Movie { get; set; }
    }
}