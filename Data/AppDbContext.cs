using CaliTrack.Models;
using Microsoft.EntityFrameworkCore;

namespace CaliTrack.Data 
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        public DbSet<ExerciseCategory> ExerciseCategories { get; set; }

    }
}
