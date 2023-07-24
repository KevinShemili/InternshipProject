using Application.Persistance;
using Domain.Exceptions;
using Infrastructure.Services.Common;
using Microsoft.AspNetCore.Authorization;
using System.IdentityModel.Tokens.Jwt;

namespace Infrastructure.Services.Authentication.PermissionPolicyConfigurations
{
    public class PermissionAuthorizationHandler : AuthorizationHandler<PermissionRequirement> {

        private readonly IUserRepository _userRepository;

        public PermissionAuthorizationHandler(IUserRepository userRepository) {
            _userRepository = userRepository;
        }

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement) {

            string? UserId = context.User.Claims
                               .FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Sub)?.Value;

            if (!Guid.TryParse(UserId, out Guid parsedUserId))
                throw new UnauthorizedException("Unathorized Access");

            var permissions = await _userRepository.GetPermissionsAsync(parsedUserId);

            if (permissions.Contains(requirement.Permission))
                context.Succeed(requirement);
            else
                throw new ForbiddenException("Forbidden Resource");
        }
    }
}
