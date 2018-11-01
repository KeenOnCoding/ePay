using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Data.Models;

namespace TestTask.Data
{
    public static class Seeder
    {
        #region Public Methods

        public static void Seed(ApplicationDbContext dbContext, RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            if (!dbContext.Users.Any())
                CreateUsers(dbContext, roleManager, userManager).GetAwaiter().GetResult();
        }

        #endregion Public Methods

        #region Seed Methods

        private static async Task CreateUsers(ApplicationDbContext dbContext, RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            string role_Administrator = "Administrator";
            string role_RegisteredUser = "RegisteredUser";

            if (!await roleManager.RoleExistsAsync(role_Administrator))
                await roleManager.CreateAsync(new IdentityRole(role_Administrator));
            if (!await roleManager.RoleExistsAsync(role_RegisteredUser))
                await roleManager.CreateAsync(new IdentityRole(role_RegisteredUser));

            var user_Admin = new User()
            {
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = "Admin",
                Email = "admin@example.com",
            };
            if (await userManager.FindByNameAsync(user_Admin.UserName) == null)
            {
                await userManager.CreateAsync(user_Admin, "AdminPsw0d");
                await userManager.AddToRoleAsync(user_Admin, role_RegisteredUser);
                await userManager.AddToRoleAsync(user_Admin, role_Administrator);

                user_Admin.EmailConfirmed = true;
                user_Admin.LockoutEnabled = false;
            }

#if DEBUG
            foreach (var item in LoadJson())
            {
                if (await userManager.FindByNameAsync(item.UserName) == null)
                {
                    await userManager.CreateAsync(item);
                    await userManager.AddToRoleAsync(item, role_RegisteredUser);
                    item.EmailConfirmed = true;
                    item.LockoutEnabled = false;
                }
            }
#endif
            await dbContext.SaveChangesAsync();
        }

        #endregion Seed Methods

        public static List<User> LoadJson()
        {
            using (StreamReader r = new StreamReader(@"F:\Programming\Projects\TestTask\TestTask\data.json"))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<User>>(json);
            }
        }
    }
}