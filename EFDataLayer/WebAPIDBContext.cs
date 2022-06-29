using EFDataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFDataLayer
{
    public class WebAPIDBContext : DbContext
    {
        public WebAPIDBContext()
        { }
        public WebAPIDBContext(DbContextOptions options)
        : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Student> Students { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=KELLGGNLPTP1078\SQLEXPRESS;Database=WebAPIWithEF;Trusted_Connection=True;");
        }
    }
}
