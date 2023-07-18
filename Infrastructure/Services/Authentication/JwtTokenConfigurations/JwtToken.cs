using Application.Interfaces.Authentication;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Infrastructure.Services.Authentication.JwtTokenConfigurations {
    public class JwtToken : IJwtToken {

        private readonly JwtSettings _jwtSettings;

        public JwtToken(IOptions<JwtSettings> jwtOptions) {
            _jwtSettings = jwtOptions.Value;
        }

        public string GenerateToken(Guid UserId, string username, IEnumerable<string> roles) {

            // add the token claims
            var claims = new List<Claim> {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, UserId.ToString()),
                new Claim("username", username)
            };

            foreach (var role in roles) {
                claims.Add(new Claim("roles", role));
            }

            var credentials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Secret)),
                                         SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                expires: DateTime.Now.AddDays(_jwtSettings.ExpiryDays),
                claims: claims,
                signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
