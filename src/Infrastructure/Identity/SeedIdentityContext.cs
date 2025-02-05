using FokinShop.ApplicationCore.Entities;
using FokinShop.ApplicationCore.Identities;
using Microsoft.AspNetCore.Identity;

namespace FokinShop.Infrastructure.Identity
{
    public static class SeedShopUserContext
    {
        public static async Task SeedAsync(UserManager<ShopUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(AuthorizationConstants.AdminRole));
            await roleManager.CreateAsync(new IdentityRole(AuthorizationConstants.UserRole));

            var admin = new ShopUser
            {
                UserName = AuthorizationConstants.AdminEmail,
                Email = AuthorizationConstants.AdminEmail,
            };
            var user = new ShopUser
            {
                UserName = AuthorizationConstants.UserEmail,
                Email = AuthorizationConstants.UserEmail,
            };
            await userManager.CreateAsync(admin, AuthorizationConstants.AdminPassword);
            await userManager.CreateAsync(user, AuthorizationConstants.UserPassword);
            await userManager.AddToRoleAsync(admin, AuthorizationConstants.AdminRole);
            await userManager.AddToRoleAsync(user, AuthorizationConstants.UserRole);
        }
    }
}
