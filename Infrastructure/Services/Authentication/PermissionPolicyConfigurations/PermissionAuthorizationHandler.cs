using Application.Persistance;
using Domain.Exceptions;
using Infrastructure.Services.Common;
using InternshipProject.Localizations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Localization;
using System.IdentityModel.Tokens.Jwt;

namespace Infrastructure.Services.Authentication.PermissionPolicyConfigurations {
    public class PermissionAuthorizationHandler : AuthorizationHandler<PermissionRequirement> {

        private readonly IUserRepository _userRepository;
        private readonly IStringLocalizer<LocalizationResources> _localizer;

        public PermissionAuthorizationHandler(IUserRepository userRepository, IStringLocalizer<LocalizationResources> localizer) {
            _userRepository = userRepository;
            _localizer = localizer;
        }

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement) {

            string? UserId = context.User.Claims
                               .FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Sub)?.Value;

            if (!Guid.TryParse(UserId, out Guid parsedUserId))
                throw new UnauthorizedException(_localizer.GetString("UnathorizedAccess").Value);

            var permissions = await _userRepository.GetPermissionsAsync(parsedUserId);

            if (permissions.Contains(requirement.Permission))
                context.Succeed(requirement);
            else
                throw new ForbiddenException(_localizer.GetString("MissingPermission").Value);
        }
    }
}
