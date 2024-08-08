using Mango.Service.AuthAPI.Model;

namespace Mango.Service.AuthAPI.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser,IEnumerable<string> roles);
    }
}
