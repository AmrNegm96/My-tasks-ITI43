using Microsoft.EntityFrameworkCore;

namespace chrisDay2.Models
{
    //db name - server name - authentication
    public class ItiEntities : DbContext
    {
        public ItiEntities() : base()/*kona ben7ot hena el connection string*/
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Depratment> Departements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=CaiDB;Integrated Security=True;Encrypt=false");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
