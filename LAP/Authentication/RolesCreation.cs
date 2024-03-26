using Microsoft.AspNetCore.Identity;

namespace LAP.Authentication
{
    public class RolesCreation
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public RolesCreation(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }


        public async Task CreateRoleAsync(string roleName)
        {
            var roleExist = await roleManager.RoleExistsAsync(roleName);
            if (!roleExist)
            {
                var role = new IdentityRole { Name = roleName };
                await roleManager.CreateAsync(role);
            }
        }




    }
}
