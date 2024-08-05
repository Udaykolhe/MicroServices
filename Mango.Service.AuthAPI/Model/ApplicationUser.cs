using Microsoft.AspNetCore.Identity;

namespace Mango.Service.AuthAPI.Model
{
    public class ApplicationUser :IdentityUser
    {
        public string? Name { get; set; }
    }
}
