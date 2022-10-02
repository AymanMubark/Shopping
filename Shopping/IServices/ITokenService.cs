using Shopping.Entites;

namespace Shopping.IServices
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}
