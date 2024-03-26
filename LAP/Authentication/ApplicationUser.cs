using Microsoft.AspNetCore.Identity;

namespace LAP.Authentication
{
    public class ApplicationUser : IdentityUser
    {
        public String Address { get; set; }
    }
}
