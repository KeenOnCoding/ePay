using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestTask.Data;
using TestTask.Data.Models;

namespace TestTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);
            using (var scope = host.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetService<ApplicationDbContext>();
                var roleManager = scope.ServiceProvider.GetService<RoleManager<IdentityRole>>();
                var userManager = scope.ServiceProvider.GetService<UserManager<User>>();

                dbContext.Database.Migrate();

                Seeder.Seed(dbContext, roleManager, userManager);
            }
            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) => WebHost.CreateDefaultBuilder(args).UseStartup<Startup>().Build();
    }
}