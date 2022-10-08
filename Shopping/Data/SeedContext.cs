using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Shopping.Entites;

namespace Shopping.Data
{
    public static class SeedContext
    {
        public static async Task initalApp(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var services = scope.ServiceProvider;
            var context = services.GetRequiredService<DataContext>();

            await context!.Database.MigrateAsync();

            var userManager = services.GetRequiredService<UserManager<AppUser>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole<Guid>>>();

            if (!await roleManager.Roles.AnyAsync())
            {
                string[] roles = new string[]
                {
                    "Admin",
                    "AppUser",
                };

                foreach (var role in roles)
                {
                    await roleManager.CreateAsync(new IdentityRole<Guid> { Name = role });
                }

            
            }
        }
    }
}