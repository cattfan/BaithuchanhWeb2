using Microsoft.AspNetCore.Identity;

namespace BaithuchanhWeb2.Repositories
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
