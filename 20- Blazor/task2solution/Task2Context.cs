using Microsoft.EntityFrameworkCore;
using SharedLibrary;

namespace BlazorDay2Task
{
    public class Task2Context : DbContext
    {

        public Task2Context(DbContextOptions<Task2Context> options):base(options)
        {
            
        }

        public DbSet<Track> Tracks { get; set; }

        public DbSet<Trainee> Trainees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Track>().HasData(StaticLists.TrackList);
            modelBuilder.Entity<Trainee>().HasData(StaticLists.TraineeList);
            base.OnModelCreating(modelBuilder);
        }
    }
}
