using Application.UseCases.Authentication.Common;

namespace Application.Interfaces.Authentication {
    public interface IJwtToken
    {
        public string GenerateToken(TokenRequest tokenRequest);
    }
}
