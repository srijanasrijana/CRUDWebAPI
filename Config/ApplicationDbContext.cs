using CRUDWebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace CRUDWebAPI.Config
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public  DbSet<Employee> Employees { get; set; } 

        public DbSet<Student> Students { get; set; }
        public DbSet<Designation> Designation { get; set; }
        public DbSet<Staff> Staff { get; set; }  
       

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //}


    }
}
