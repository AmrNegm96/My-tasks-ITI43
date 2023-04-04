using Microsoft.EntityFrameworkCore;

namespace lec1.Models
{
    public class SCCaiContext : DbContext
    {
        public SCCaiContext(DbContextOptions<SCCaiContext> options  ):base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
