using LAP.Authentication;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LAP.Models
{


    public class Context : IdentityDbContext<ApplicationUser>
    {
        public Context() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=.; initial catalog=MVC_DB;integrated security = true; Trust Server Certificate=true;");
        }


        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Course> Course { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<CrsResult> CrsResults { get; set; }


    }


}