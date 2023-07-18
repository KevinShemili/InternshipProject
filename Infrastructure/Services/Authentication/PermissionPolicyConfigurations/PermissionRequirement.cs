using Microsoft.AspNetCore.Authorization;

namespace Infrastructure.Services.Authentication.PermissionPolicyConfigurations {
    public class PermissionRequirement : IAuthorizationRequirement {
        public string Permission { get; set; }

        public PermissionRequirement(string permission) {
            Permission = permission;
        }
    }
}
