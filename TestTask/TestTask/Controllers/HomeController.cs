using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using TestMakerFreeWebApp.Controllers;
using TestTask.Data;
using TestTask.Data.Models;

namespace TestTask.Controllers
{
    public class HomeController : BaseApiController
    {
        public HomeController(ApplicationDbContext context, RoleManager<IdentityRole> roleManager, UserManager<User> userManager, IConfiguration configuration) : base(context, roleManager, userManager, configuration)
        {
        }

        public async Task<IActionResult> Index()
        {
            return View(await DbContext.Users.ToListAsync());
        }
    }
}