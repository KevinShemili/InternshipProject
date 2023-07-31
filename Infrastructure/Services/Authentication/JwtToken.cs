using Application.Interfaces.Authentication;
using Infrastructure.Services.Common;
using InternshipProject.Localizations;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Infrastructure.Services.Authentication {
    public class JwtToken : IJwtToken {

        private readonly JwtSettings _jwtSettings;
        private readonly IStringLocalizer<LocalizationResources> _localizer;

        public JwtToken(IOptions<JwtSettings> jwtOptions, IStringLocalizer<LocalizationResources> localizer) {
            _jwtSettings = jwtOptions.Value;
            _localizer = localizer;
        }

        public string GenerateToken(Guid UserId, string username, IEnumerable<string> roles) {

            // add the token claims
            var claims = new List<Claim> {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, UserId.ToString()),
                new Claim("username", username)
            };

            foreach (var role in roles) {
                claims.Add(new Claim(ClaimTypes.Role, role));
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

        public Guid GetUserId(string accessToken) {
            var token = new JwtSecurityToken(accessToken);
            var userId = Guid.Parse(token.Claims.First(x => x.Type == "sub").Value);
            return userId;
        }

        public bool IsExpired(string accessToken) {
            var token = new JwtSecurityToken(accessToken);

            if (token.ValidTo <= DateTime.Now)
                return true;
            return false;
        }
    }
}
