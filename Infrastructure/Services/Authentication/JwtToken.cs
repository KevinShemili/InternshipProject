using Application.Interfaces.Authentication;
using Application.Interfaces.Common;
using Domain.Exceptions;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Infrastructure.Services.Authentication
{
    public class JwtToken : IJwtToken {

        private readonly JwtSettings _jwtSettings;

        public JwtToken(IOptions<JwtSettings> jwtOptions) {
            _jwtSettings = jwtOptions.Value;
        }

        public string GenerateToken(TokenDto tokenDto) {

            var flag = true;
            if (flag)
                throw new TokenException("err");

            // add the token claims
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, tokenDto.Id.ToString()),
                new Claim("Username", tokenDto.Username)
             };

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
