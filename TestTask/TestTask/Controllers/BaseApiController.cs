using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using TestTask.Data;
using TestTask.Data.Models;

namespace TestMakerFreeWebApp.Controllers
{
    [Route("[controller]")]
    public class BaseApiController : Controller
    {
        #region Constructor

        public BaseApiController(
            ApplicationDbContext context,
            RoleManager<IdentityRole> roleManager,
            UserManager<User> userManager,
            IConfiguration configuration
            )
        {
            // Instantiate the required classes through DI
            DbContext = context;
            RoleManager = roleManager;
            UserManager = userManager;
            Configuration = configuration;

            // Instantiate a single JsonSerializerSettings object
            // that can be reused multiple times.
            JsonSettings = new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented
            };
        }

        #endregion Constructor

        #region Shared Properties

        protected ApplicationDbContext DbContext { get; private set; }
        protected RoleManager<IdentityRole> RoleManager { get; private set; }
        protected UserManager<User> UserManager { get; private set; }
        protected IConfiguration Configuration { get; private set; }
        protected JsonSerializerSettings JsonSettings { get; private set; }

        #endregion Shared Properties
    }
}