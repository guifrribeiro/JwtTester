using JwtTester.Application.Models;

namespace JwtTester.Application.Contracts
{
    public interface IJwtService
    {
        JsonWebToken CreateJsonWebToken(User user);
    }
}
