using LAP.Authentication;
using LAP.HUBS;
using LAP.Models;
using LAP.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LAP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int counter;
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddSignalR();
            builder.Services.AddCors();

            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });

            // Add services to the container. 

            // Here for adding the Controller with its view  ==>
            builder.Services.AddControllersWithViews();


            ////Here to register all the services===> 
            //// Register the Interfaces -->
            builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            builder.Services.AddTransient<IcourseRepository, courseRepository>();
            builder.Services.AddSingleton<IinstructorRepository, instructorRepository>();
            //// Context Server Register ==> 

            ///// Add the Context to connect to database and inject the context 
            builder.Services.AddDbContext<Context>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("Sql")));

            // THis server to make the createRoles methods work ==>
            builder.Services.AddScoped<RolesCreation>();


            /////////////////////////////////
            ///Register the User Identity -->                                                    //// Here I should specific which store will work in .. the default is theIdentity  dbContext
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<Context>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();
            app.UseCors();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSession();

            app.MapHub<Add_Instructor_Hub>("/add-instructor");
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Account}/{action=Login}/{id?}");

            app.Run();
        }
    }
}
